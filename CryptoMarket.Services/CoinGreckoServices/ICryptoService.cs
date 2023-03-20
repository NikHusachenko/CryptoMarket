using CryptoMarket.Database.Entities;
using CryptoMarket.Services.Response;

namespace CryptoMarket.Services.CoinGreckoServices
{
    public interface ICryptoService
    {
		void Create(CoinEntity coin);
		void Create(CurrencyEntity currency);
	    Task<ResponseService> CheckApiStatusAsync();
		Task<ResponseService<List<CoinEntity>>> GetCoinListAsync();
		Task<ResponseService<CurrencyEntity>> GetCurrencyByCoinIdAsync(string coinId);
	}
}