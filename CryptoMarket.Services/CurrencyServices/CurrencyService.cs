using CryptoMarket.Database.Entities;
using CryptoMarket.EntityFramework.Repository;
using Newtonsoft.Json;

namespace CryptoMarket.Services.CurrencyServices
{
	public class CurrencyService : ICurrencyService
	{
		private readonly IGenericRepository<CurrencyEntity> _currencyRepository;

		public CurrencyService(IGenericRepository<CurrencyEntity> currencyRepository)
		{
			_currencyRepository = currencyRepository;
		}
	
		public void Create(CurrencyEntity currency)
		{
			_currencyRepository.Create(currency);
		}

		public async Task<CurrencyEntity> GetCurrencyByCurrencyIdAsync(string coinId)
		{
			try
			{
				var client = new HttpClient();
				var message = await client.GetAsync($"https://api.coingecko.com/api/v3/coins/{coinId}");
				message.EnsureSuccessStatusCode();
				var context = await message.Content.ReadAsStringAsync();
				var currency = JsonConvert.DeserializeObject<CurrencyEntity>(context);
				return currency;
			}
			catch (Exception ex)
			{
				return null;
			}
		}
	}
}
