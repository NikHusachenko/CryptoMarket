using CryptoMarket.Common;
using CryptoMarket.Database.Entities;
using CryptoMarket.EntityFramework.Repository;
using CryptoMarket.Services.Response;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace CryptoMarket.Services.CoinGreckoServices
{
	public class CoinGreckoService : ICryptoService
	{
		private readonly IGenericRepository<CoinEntity> _coinListRepository;
		private readonly HttpClient _httpClient;

		public CoinGreckoService(IGenericRepository<CoinEntity> coinListRepository)
		{
			_coinListRepository = coinListRepository;
			_httpClient = new HttpClient();
		}

		public async Task<ResponseService> Create(CoinEntity coin)
		{
			CoinEntity dbRecord = await _coinListRepository.GetBy(c => c.CoinId == coin.CoinId);
			if (dbRecord != null)
			{
				return ResponseService.Error(Errors.COINT_EXISTS_ERROR);
			}

			var result = await _coinListRepository.Create(coin);

			if (result == string.Empty)
			{
				return ResponseService.Ok();
			}
			else
			{
				return ResponseService.Error(result);
			}
		}

		private async Task<ResponseService<string>> GetHttpContent(string url)
		{
			var message = await _httpClient.GetAsync(url);
			message.EnsureSuccessStatusCode();
			
			if (!message.IsSuccessStatusCode)
			{
				return ResponseService<string>.Error($"{Errors.ERROR_STATUS_CODE} {message.StatusCode}");
			}

			return ResponseService<string>.Ok(await message.Content.ReadAsStringAsync());
		}

		public async Task<ResponseService> CheckApiStatusAsync()
		{
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(CoinGrecko.PING);
                response.EnsureSuccessStatusCode();
                return ResponseService.Ok();
            }
            catch (HttpRequestException)
            {
                return ResponseService.Error(Errors.SERVER_DOWN);
            }
        }

		public async Task<ResponseService<List<CoinEntity>>> GetCoinListAsync()
		{
			var response = await GetHttpContent($"{CoinGrecko.COIN_LIST}");
			if (response.IsError)
			{
				return ResponseService<List<CoinEntity>>.Error(response.ErrorMessage);
			}

            var list = JsonConvert.DeserializeObject<List<CoinEntity>>(response.Value);
			return ResponseService<List<CoinEntity>>.Ok(list);
        }

		public async Task<ResponseService<CoinEntity>> GetCoinByCoinIdAsync(string coinId)
		{
			var response = await GetHttpContent($"{CoinGrecko.COINS}/{coinId}");
			if (response.IsError)
			{
				return ResponseService<CoinEntity>.Error(response.ErrorMessage);
			}

            var currency = JsonConvert.DeserializeObject<CoinEntity>(response.Value);
			return ResponseService<CoinEntity>.Ok(currency);
        }

        public async Task<ResponseService> UpdateData()
		{
			var pingResult = await CheckApiStatusAsync();
			if (pingResult.IsError)
			{
				return ResponseService.Error(pingResult.ErrorMessage);
			}

			var response = await GetHttpContent($"{CoinGrecko.COIN_LIST}");
			if (response.IsError)
			{
				return ResponseService.Error(response.ErrorMessage);
			}

            var coins = JsonConvert.DeserializeObject<List<CoinEntity>>(response.Value);
			foreach (CoinEntity coin in coins)
			{
				var result = await Create(coin);
				if (result.IsError)
				{
					return ResponseService.Error(result.ErrorMessage);
				}
			}

			return ResponseService.Ok();
        }

        public async Task<bool> CoinsIsExists()
        {
			return await _coinListRepository.Table.AnyAsync();
        }

        public async Task<List<CoinEntity>> GetCoinListAsync(int page)
        {
			var query = _coinListRepository.Table
				.Skip(CalcSkip(page))
				.Take(MarketFormConstants.COINS_ON_PAGE);

			return await query.ToListAsync();
        }

		private int CalcSkip(int pageNumber)
		{
			return (pageNumber - 1) * MarketFormConstants.COINS_ON_PAGE;
        }
		public async Task<int> GetNumberOfCoins()
		{
			return _coinListRepository.Table.Count();
		}
		public async Task UpdateDatabaseOrDefaultAsync()
		{
			var coinsFromApi = await GetCoinListAsync();
			var coinsFromDb = await _coinListRepository.Table
				.ToListAsync();

			if(coinsFromApi.Value.Count() != coinsFromDb.Count())
			{
				foreach (CoinEntity coin in coinsFromDb) await _coinListRepository.Delete(coin);

				foreach (CoinEntity coin in coinsFromApi.Value) await Create(coin);
			}
		}
    }
}