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
			_marketService = new MarketService(_coinRepository);
			_coinRepository = coinRepository;
			_cryptoService = cryptoService;
			currentPage = 1;
			InitializeComponent();
		}
		private async void NextPageBtn_Click(object sender, EventArgs e)
		{
			currentPage++;
			_marketService.CheckPaginationState(currentPage, totalPages, PreviousPageBtn, NextPageBtn);
			List<CoinEntity> coinList = await _cryptoService.GetCoinListAsync(currentPage);
			AddToFlowLayot(coinList, currenciesFlowLayoutPanel);
			PreviousPageBtn.Enabled = true;
			_marketService.UpdatePageInfo(PageNumberInfo, currentPage, totalPages);
		}

		private async void PreviousPageBtn_Click(object sender, EventArgs e)
		{
			currentPage--;
			List<CoinEntity> coinList = await _cryptoService.GetCoinListAsync(currentPage);
			AddToFlowLayot(coinList, currenciesFlowLayoutPanel);
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
			
			await _cryptoService.UpdateDatabaseOrDefaultAsync();
			MessageBox.Show("Test");
			List<CoinEntity> coinList = await _cryptoService.GetCoinListAsync(currentPage);
			AddToFlowLayot(coinList, currenciesFlowLayoutPanel);
			totalPages = (int)Math.Ceiling((double)await _cryptoService.GetNumberOfCoins() / MarketFormConstants.COINS_ON_PAGE);
			_marketService.UpdatePageInfo(PageNumberInfo, currentPage, totalPages);
			_marketService.CheckPaginationState(currentPage, totalPages, PreviousPageBtn, NextPageBtn);
			var result = await _cryptoService.CoinsIsExists();
			if (!result)
			{
				await _cryptoService.UpdateData();
			}
		}
	}
}
