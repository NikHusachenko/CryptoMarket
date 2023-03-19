using CryptoMarket.Database.Entities;

namespace CryptoMarket.Services.CoinListServices
{
	public interface ICoinListService
	{
		void Create(CoinEntity coin);
		Task<List<CoinEntity>> GetCoinsAsync();
	}
}
