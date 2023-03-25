using CryptoMarket.Database.Entities;
using CryptoMarket.Services.Response;

namespace CryptoMarket.Services.CoinGreckoServices
{
    public interface ICryptoService
    {
		void Create(CoinEntity coin);
	    Task<ResponseService> CheckApiStatusAsync();
		Task<ResponseService<List<CoinEntity>>> GetCoinListAsync();
		Task<ResponseService<CoinEntity>> GetCoinByCoinIdAsync(string coinId);
	}
}