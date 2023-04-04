using CryptoMarket.Database.Entities;
using CryptoMarket.Services.Response;

namespace CryptoMarket.Desktop.FormsServices.MarketServices
{
	public interface IMarketService
	{
		ResponseService<List<CoinEntity>> GetCoins(int pageNumber);
		void CheckPaginationState(int currentPage, int totalPages, Button PreviousPageBtn, Button NextPageBtn);
		void UpdatePageInfo(Label PageNumberInfoLab, int currentPage, int totalPages);
	}
}
