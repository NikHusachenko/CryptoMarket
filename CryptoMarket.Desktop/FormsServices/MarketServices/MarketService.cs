using CryptoMarket.Common;
using CryptoMarket.Database.Entities;
using CryptoMarket.EntityFramework.Repository;
using CryptoMarket.Services.Response;
namespace CryptoMarket.Desktop.FormsServices.MarketServices
{
	public class MarketService : IMarketService
	{
		IGenericRepository<CoinEntity> _coinRepository;
		static int FIRST_COIN_ID = 28234;
		public MarketService(IGenericRepository<CoinEntity> coinRepository)
		{
			_coinRepository = coinRepository;
		}
		public ResponseService<List<CoinEntity>> GetCoins(int pageNumber)
		{
			int startIndex = pageNumber * MarketFormConstants.COINS_ON_PAGE + FIRST_COIN_ID;
			int endIndex = startIndex + MarketFormConstants.COINS_ON_PAGE - 1;
			var query = _coinRepository.Table
						.Where(c => c.Id >= startIndex && c.Id <= endIndex)
						.OrderBy(c => c.Id)
						.ToList();
			ResponseService<List<CoinEntity>> response = new ResponseService<List<CoinEntity>>();
			response.Value = query;
			return response;
		}
		public void CheckPaginationState(int currentPage, int totalPages, Button PreviousPageBtn, Button NextPageBtn)
		{
			if (currentPage <= 0)
			{
				PreviousPageBtn.Enabled = false;
			}
			if (currentPage == totalPages)
			{
				NextPageBtn.Enabled = false;
			}
		}
		public void UpdatePageInfo(Label PageNumberInfoLab, int currentPage, int totalPages)
		{
			PageNumberInfoLab.Text = $"{currentPage}/{totalPages}";
		}
		public void ChangeNavigationBattonEnabled(Button Previous, Button Next, bool enable)
		{
			Previous.Enabled = enable;
			Next.Enabled = enable;
		}
	}
}
