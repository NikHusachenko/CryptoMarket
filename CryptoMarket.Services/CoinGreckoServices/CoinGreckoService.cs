using CryptoMarket.Common;
using CryptoMarket.Database.Entities;
using CryptoMarket.EntityFramework.Repository;
using CryptoMarket.Services.Response;
using Newtonsoft.Json;

namespace CryptoMarket.Services.CoinGreckoServices
{
	public class CoinGreckoService : ICryptoService
	{
		private readonly IGenericRepository<CoinEntity> _coinListRepository;

		public CoinGreckoService(IGenericRepository<CoinEntity> coinListRepository)
		{
			_coinListRepository = coinListRepository;
		}

		public void Create(CoinEntity coin)
		{
			_coinListRepository.Create(coin);
		}

		public async Task<ResponseService> CheckApiStatusAsync()
		{
			using (var client = new HttpClient())
			{
				try
				{
					HttpResponseMessage response = await client.GetAsync(CoinGrecko.PING);
					response.EnsureSuccessStatusCode();
					return ResponseService.Ok();
				}
				catch (HttpRequestException)
				{
					return ResponseService.Error(Errors.SERVER_DOWN);
				}
			}
		}

		public async Task<ResponseService<List<CoinEntity>>> GetCoinListAsync()
		{
			try
			{
				var client = new HttpClient();
				var message = await client.GetAsync($"{CoinGrecko.COIN_LIST}");
				message.EnsureSuccessStatusCode();
				var context = await message.Content.ReadAsStringAsync();
				var coinList = JsonConvert.DeserializeObject<List<CoinEntity>>(context);
				return ResponseService<List<CoinEntity>>.Ok(coinList);
			}
			catch(Exception ex)
			{
				return ResponseService<List<CoinEntity>>.Error(ex.Message);
			}
		}

		public async Task<ResponseService<CoinEntity>> GetCoinByCoinIdAsync(string coinId)
		{
			try
			{
				var client = new HttpClient();
				var message = await client.GetAsync($"{CoinGrecko.COINS}{coinId}");
				message.EnsureSuccessStatusCode();
				var context = await message.Content.ReadAsStringAsync();
				var currency = JsonConvert.DeserializeObject<CoinEntity>(context);
				return ResponseService<CoinEntity>.Ok(currency);
			}
			catch (Exception ex)
			{
				return ResponseService<CoinEntity>.Error(ex.Message);
			}
		}
		public ResponseService<List<CoinEntity>> GetCoinListFromDbAsync()
		{
			ResponseService<List<CoinEntity>> dbRecord = new ResponseService<List<CoinEntity>>();
			dbRecord.Value = _coinListRepository.Table.ToList();
			if (dbRecord == null)
			{
				return null;
			}
			return dbRecord;
		}
		
	}
}