using CryptoMarket.Common;
using CryptoMarket.Database.Entities;
using CryptoMarket.EntityFramework.Repository;
using Newtonsoft.Json;

namespace CryptoMarket.Services.CoinListServices
{
	public class CoinListService : ICoinListService
	{
		private readonly IGenericRepository<CoinEntity> _coinListRepository;

		public CoinListService(IGenericRepository<CoinEntity> coinListRepository)
		{
			_coinListRepository = coinListRepository;
		}

		public void Create(CoinEntity coin)
		{
			_coinListRepository.Create(coin);
		}

		public async Task<List<CoinEntity>> GetCoinsAsync()
		{
			try
			{
				var client = new HttpClient();
				var message = await client.GetAsync($"{CoinGrecko.COIN_LIST}");
				message.EnsureSuccessStatusCode();
				var context = await message.Content.ReadAsStringAsync();
				var coinList = JsonConvert.DeserializeObject<List<CoinEntity>>(context);
				return coinList;
			}
			catch (Exception ex)
			{
				return null;
			}
		}
	}
}
