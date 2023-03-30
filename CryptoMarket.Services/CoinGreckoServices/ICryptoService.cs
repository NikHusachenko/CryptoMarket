using CryptoMarket.Database.Entities;
using CryptoMarket.Services.Response;

namespace CryptoMarket.Services.CoinGreckoServices
{
    public interface ICryptoService
    {
		Task<ResponseService> Create(CoinEntity coin);
	    Task<ResponseService> CheckApiStatusAsync();
		Task<ResponseService<List<CoinEntity>>> GetCoinListAsync();
		Task<List<CoinEntity>> GetCoinListAsync(int page);
		Task<ResponseService<CoinEntity>> GetCoinByCoinIdAsync(string coinId);
		Task<ResponseService> UpdateData();
		Task<bool> CoinsIsExists();
	}
}