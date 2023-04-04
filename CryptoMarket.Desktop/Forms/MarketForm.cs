using CryptoMarket.Common;
using CryptoMarket.Database.Entities;
using CryptoMarket.Desktop.FormsServices.MarketServices;
using CryptoMarket.EntityFramework.Repository;
using CryptoMarket.Services.CoinGreckoServices;

namespace CryptoMarket.Desktop.Forms
{
    public partial class MarketForm : Form
	{
		private static int currentPage;
		private static int totalPages;
		private static IGenericRepository<CoinEntity> _coinRepository;
		private static ICryptoService _cryptoService;
		private static IMarketService _marketService;

		public MarketForm(ICryptoService cryptoService, IGenericRepository<CoinEntity> coinRepository)
		{
			_coinRepository = coinRepository;
			_cryptoService = cryptoService;
			_marketService = new MarketService(_coinRepository);
			totalPages = (int)Math.Ceiling((double)11143 / MarketFormConstants.COINS_ON_PAGE);/////////////////////////////////////////////
			currentPage = 0;
			InitializeComponent();

			AddToFlowLayot(_marketService.GetCoins(currentPage), currenciesFlowLayoutPanel);
			_marketService.UpdatePageInfo(PageNumberInfo, currentPage, totalPages);
			_marketService.CheckPaginationState(currentPage, totalPages, PreviousPageBtn, NextPageBtn);
		}
		private void NextPageBtn_Click(object sender, EventArgs e)
		{
			currentPage++;
			_marketService.CheckPaginationState(currentPage, totalPages, PreviousPageBtn, NextPageBtn);
			AddToFlowLayot(_marketService.GetCoins(currentPage), currenciesFlowLayoutPanel);
			PreviousPageBtn.Enabled = true;
			_marketService.UpdatePageInfo(PageNumberInfo, currentPage, totalPages);
		}

		private void PreviousPageBtn_Click(object sender, EventArgs e)
		{
			currentPage--;
			AddToFlowLayot(_marketService.GetCoins(currentPage), currenciesFlowLayoutPanel);
			_marketService.CheckPaginationState(currentPage, totalPages, PreviousPageBtn, NextPageBtn);
			_marketService.UpdatePageInfo(PageNumberInfo, currentPage, totalPages);
			NextPageBtn.Enabled = true;
		}
		private static void groupBox_Click(object sender, EventArgs e)
		{
			GroupBox groupBox = (GroupBox)sender;
			Label secondLabel = (Label)groupBox.Controls[1];
			string coinId = secondLabel.Text;
			CoinForm coinForm = new CoinForm(_cryptoService,coinId);
			coinForm.Show();

		}
		private async void MarketForm_Load(object sender, EventArgs e)
		{
			var result = await _cryptoService.CoinsIsExists();
			if (!result)
			{
				await _cryptoService.UpdateData();
			}
		}
	}
}
