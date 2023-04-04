using CryptoMarket.Common;
using CryptoMarket.Database.Entities;
using CryptoMarket.Desktop.FormsServices;
using CryptoMarket.EntityFramework;
using CryptoMarket.EntityFramework.Repository;
using CryptoMarket.Services.CoinGreckoServices;

namespace CryptoMarket.Desktop.Forms
{
	public partial class MarketForm : Form
	{
		private static int currentPage;
		private static int totalPages;
		private static ApplicationDbContext dbcontext;
		private static IGenericRepository<CoinEntity> _coinRepository;
		private static ICryptoService _cryptoService;
		private static IMarketService _marketService;

		public MarketForm(ICryptoService cryptoService)
		{
			dbcontext = new ApplicationDbContext();
			_coinRepository = new GenericRepository<CoinEntity>(dbcontext);
			_cryptoService = cryptoService;
			totalPages = (int)Math.Ceiling((double)11143 / MarketFormConstants.COINS_ON_PAGE);

			//   _cryptoService = new CoinGreckoService(_coinRepository);
			InitializeComponent();
			_marketService = new MarketService(cryptoService, _coinRepository);
			//   await _cryptoService.UpdateData();
			currentPage = 0;

			AddToFlowLayot(_marketService.GetCoins(currentPage), currenciesFlowLayoutPanel);
			UpdatePageInfo();
			_marketService.CheckPaginationState(currentPage, totalPages, PreviousPageBtn, NextPageBtn);
		}
		private void UpdatePageInfo()
		{
			PageNumberInfoLab.Text = $"{currentPage + 1}/{totalPages}";
		}

		private void NextPageBtn_Click(object sender, EventArgs e)
		{
			currentPage++;
			_marketService.CheckPaginationState(currentPage, totalPages, PreviousPageBtn, NextPageBtn);
			AddToFlowLayot(_marketService.GetCoins(currentPage), currenciesFlowLayoutPanel);
			PreviousPageBtn.Enabled = true;
			UpdatePageInfo();
		}

		private void PreviousPageBtn_Click(object sender, EventArgs e)
		{
			currentPage--;
			AddToFlowLayot(_marketService.GetCoins(currentPage), currenciesFlowLayoutPanel);
			_marketService.CheckPaginationState(currentPage,totalPages,PreviousPageBtn,NextPageBtn);
			UpdatePageInfo();
			NextPageBtn.Enabled = true;
		}
		//private void CheckPaginationState()
		//{
		//	if (currentPage <= 0)
		//	{
		//		PreviousPageBtn.Enabled = false;
		//	}
		//	if (currentPage == totalPages - 1)
		//	{
		//		NextPageBtn.Enabled = false;
		//	}
		//}
		private static void groupBox_Click(object sender, EventArgs e)
		{
			GroupBox groupBox = (GroupBox)sender;
			Label secondLabel = (Label)groupBox.Controls[1];
			string coinId = secondLabel.Text;
			CoinForm coinForm = new CoinForm(coinId);
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
