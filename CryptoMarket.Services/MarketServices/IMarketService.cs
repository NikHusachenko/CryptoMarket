using CryptoMarket.Database.Entities;
using CryptoMarket.Services.Response;

namespace CryptoMarket.Services.MarketServices
{
	public interface IMarketService
	{
		ResponseService<List<CoinEntity>> GetCoins(int pageNumber);
	}
}
