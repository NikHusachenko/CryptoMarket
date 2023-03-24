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
		private static int currentPage = 0;
		public static ApplicationDbContext dbcontext = new ApplicationDbContext();
		public static IGenericRepository<CoinEntity> _coinRepository = new GenericRepository<CoinEntity>(dbcontext);
		public static ICryptoService _cryptoService = new CoinGreckoService(_coinRepository);
		private static ResponseService<List<CoinEntity>> coins;
	
		public MarketForm()
		{
			dbcontext = new ApplicationDbContext();
			_coinRepository = new GenericRepository<CoinEntity>(dbcontext);
			_cryptoService = new CoinGreckoService(_coinRepository);
			InitializeComponent();
			AddToFlowLayot(currenciesFlowLayoutPanel);
			Checker();
		}
		private void UpdatePageInfo()
		{
			PageNumberInfoLab.Text = $"{currentPage+1}/{(int)Math.Ceiling((double)coins.Value.Count / MarketFormConstants.COINS_ON_PAGE)}";
		}

		private void NextPageBtn_Click(object sender, EventArgs e)
		{
				currentPage++;
				AddToFlowLayot(currenciesFlowLayoutPanel);
                Checker();
				PreviousPageBtn.Enabled = true;
				UpdatePageInfo();
		}

		private void PreviousPageBtn_Click(object sender, EventArgs e)
		{
				currentPage--;
				AddToFlowLayot(currenciesFlowLayoutPanel);
			    Checker();
				UpdatePageInfo();
				NextPageBtn.Enabled = true;
		}
		private void Checker()
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
		public static async Task InitCoins()
		{
			coins = await _cryptoService.GetCoinListAsync();
		}
	}
}
