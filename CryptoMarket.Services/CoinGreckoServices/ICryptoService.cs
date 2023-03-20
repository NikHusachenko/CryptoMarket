using CryptoMarket.Database.Entities;
using CryptoMarket.Services.Response;

namespace CryptoMarket.Services.CoinGreckoServices
{
    public interface ICryptoService
    {
		void Create(CoinEntity coin);
		void Create(CoinEntity currency);
	    Task<ResponseService> CheckApiStatusAsync();
		Task<ResponseService<List<CoinEntity>>> GetCoinListAsync();
		Task<ResponseService<CoinEntity>> GetCurrencyByCoinIdAsync(string coinId);
	}
}