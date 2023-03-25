using CryptoMarket.Common;
using CryptoMarket.Database.Entities;
using CryptoMarket.EntityFramework;
using CryptoMarket.EntityFramework.Repository;
using CryptoMarket.Services.CoinGreckoServices;
using CryptoMarket.Services.Response;

namespace CryptoMarket.Desktop.Forms
{
	public partial class MarketForm : Form
	{
		private static int currentPage;
		private static int totalPages;
		public static ApplicationDbContext dbcontext;
		public static IGenericRepository<CoinEntity> _coinRepository;
		public static ICryptoService _cryptoService;
		private static ResponseService<List<CoinEntity>> coins;

		public MarketForm()
		{
			dbcontext = new ApplicationDbContext();
			_coinRepository = new GenericRepository<CoinEntity>(dbcontext);
			_cryptoService = new CoinGreckoService(_coinRepository);
			coins = _cryptoService.GetCoinListFromDbAsync();
			currentPage = 0;
			totalPages = (int)Math.Ceiling((double)coins.Value.Count / MarketFormConstants.COINS_ON_PAGE);
			InitializeComponent();
			AddToFlowLayot(currenciesFlowLayoutPanel);
			CheckPaginationState();
		}
		private void UpdatePageInfo()
		{
			PageNumberInfoLab.Text = $"{currentPage + 1}/{totalPages}";
		}

		private void NextPageBtn_Click(object sender, EventArgs e)
		{
			currentPage++;
			AddToFlowLayot(currenciesFlowLayoutPanel);
			CheckPaginationState();
			PreviousPageBtn.Enabled = true;
			UpdatePageInfo();
		}

		private void PreviousPageBtn_Click(object sender, EventArgs e)
		{
			currentPage--;
			AddToFlowLayot(currenciesFlowLayoutPanel);
			CheckPaginationState();
			UpdatePageInfo();
			NextPageBtn.Enabled = true;
		}
		private void CheckPaginationState()
		{
			if (currentPage <= 0)
			{
				PreviousPageBtn.Enabled = false;
			}
			if (coins != null && currentPage == (int)Math.Ceiling((double)coins.Value.Count / MarketFormConstants.COINS_ON_PAGE) - 1)
			{
				NextPageBtn.Enabled = false;
			}
		}
		private static void groupBox_Click(object sender, EventArgs e)
		{
			GroupBox groupBox = (GroupBox)sender;
			Label secondLabel = (Label)groupBox.Controls[1];
			string coinId = secondLabel.Text;
			CoinForm coinForm = new CoinForm(coinId);
			coinForm.Show();
		}
	}
}
