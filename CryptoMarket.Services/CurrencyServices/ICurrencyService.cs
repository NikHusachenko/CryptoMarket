using CryptoMarket.Database.Entities;

namespace CryptoMarket.Services.CurrencyServices
{
	public interface ICurrencyService
	{
		void Create(CurrencyEntity currency);
		Task<CurrencyEntity> GetCurrencyByCurrencyIdAsync(string coinId);
	}
}

