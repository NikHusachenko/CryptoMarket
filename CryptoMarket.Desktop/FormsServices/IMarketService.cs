using CryptoMarket.Common;
using CryptoMarket.Database.Entities;
using CryptoMarket.Services.Response;

namespace CryptoMarket.Desktop.FormsServices
{
	public interface IMarketService
	{
		ResponseService<List<CoinEntity>> GetCoins(int pageNumber);
		void CheckPaginationState(int currentPage, int totalPages, Button PreviousPageBtn, Button NextPageBtn);
	}
}
