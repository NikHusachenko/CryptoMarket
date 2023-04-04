using CryptoMarket.Common;
using CryptoMarket.Database.Entities;
using CryptoMarket.EntityFramework.Repository;
using CryptoMarket.Services.CoinGreckoServices;
using CryptoMarket.Services.Response;

namespace CryptoMarket.Services.MarketServices
{
	public class MarketService : IMarketService
	{
		private readonly ICryptoService _cryptoService;
		IGenericRepository<CoinEntity> _coinRepository;
		static int FIRST_COIN_ID = 28234;
		public MarketService(ICryptoService cryptoService, IGenericRepository<CoinEntity> coinRepository)
		{
			_cryptoService = cryptoService;
			_coinRepository = coinRepository;
		}
		public ResponseService<List<CoinEntity>> GetCoins(int pageNumber)
		{
			int startIndex = (pageNumber) * MarketFormConstants.COINS_ON_PAGE + FIRST_COIN_ID;
			int endIndex = startIndex + MarketFormConstants.COINS_ON_PAGE - 1;
			var query = _coinRepository.Table
						.Where(c => c.Id >= startIndex && c.Id <= endIndex)
						.OrderBy(c => c.Id)
						.ToList();
			ResponseService<List<CoinEntity>> response = new ResponseService<List<CoinEntity>>();
			response.Value = query;
			return response;
		}
	}
}
