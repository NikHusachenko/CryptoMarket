using CryptoMarket.Database.Entities;
using CryptoMarket.EntityFramework;
using CryptoMarket.EntityFramework.Repository;
using CryptoMarket.Services.CoinGreckoServices;
using CryptoMarket.Services.Response;
using System.Net;

namespace CryptoMarket.Desktop.Forms
{
	public partial class CoinForm : Form
	{
		public static ResponseService<CoinEntity> currentCoin;
		public static ApplicationDbContext dbcontext;
		public static IGenericRepository<CoinEntity> _coinRepository;
		public static ICryptoService _cryptoService;
		public CoinForm(string Id)
		{
			InitializeComponent();
			dbcontext = new ApplicationDbContext();
			_coinRepository = new GenericRepository<CoinEntity>(dbcontext);
			_cryptoService = new CoinGreckoService(_coinRepository);

			FillData(Id);
		}
		public async Task InitCoin(string coinId)
		{
			currentCoin = await _cryptoService.GetCoinByCoinIdAsync(coinId);
		}
		public async void FillData(string coinId)
		{
			await InitCoin(coinId);
			if (currentCoin != null) 
			{
				DisplayImage(currentCoin.Value.Image.Large);
			}
			SymbolLabel.Text = currentCoin.Value.Symbol;
			CoinIDLabel.Text = currentCoin.Value.CoinId;
			NameLabel.Text = currentCoin.Value.Name;
			PriceChangePercentageLabel.Text = 
				(currentCoin.Value.MarketData.PriceChangePercentage == null) ? "No info" :  currentCoin.Value.MarketData.PriceChangePercentage.ToString();
			MarketCapRankLabel.Text =
				(currentCoin.Value.MarketData.MarketCapRank == null) ? "No info" : currentCoin.Value.MarketData.MarketCapRank.ToString();
			TotalVolumeLabel.Text =
				(currentCoin.Value.MarketData.TotalVolume.Usd == null) ? "No info" : currentCoin.Value.MarketData.TotalVolume.Usd.ToString();
			MarketCapLabel.Text = 
				(currentCoin.Value.MarketData.MarketCap.Usd == null) ? "No info" : currentCoin.Value.MarketData.MarketCap.Usd.ToString();
			CurrentPriceLabel.Text =
				(currentCoin.Value.MarketData.CurrentPrice.Usd == null) ? "No info" : currentCoin.Value.MarketData.CurrentPrice.Usd.ToString();
			High24HLabel.Text =
				(currentCoin.Value.MarketData.Hight24H.Usd == null) ? "No info" : currentCoin.Value.MarketData.Hight24H.Usd.ToString();
			Low24HLabel.Text =
				(currentCoin.Value.MarketData.Low24H.Usd == null) ? "No info" : currentCoin.Value.MarketData.Low24H.Usd.ToString();
		}
		private void DisplayImage(string imageUrl)
		{
			try
			{
				using (WebClient webClient = new WebClient())
				{
					byte[] data = webClient.DownloadData(imageUrl);
					using (MemoryStream memoryStream = new MemoryStream(data))
					{
						Image image = Image.FromStream(memoryStream);
						CoinLogoPictureBox.Image = image;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message}");
			}
		}

	}
}
