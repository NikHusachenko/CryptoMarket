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

			FillCoinDataAndDisplay(Id);
		}
		private async Task InitCoin(string coinId)
		{
			currentCoin = await _cryptoService.GetCoinByCoinIdAsync(coinId);
		}
		private async void FillCoinDataAndDisplay(string coinId)
		{
			await InitCoin(coinId);
			if (currentCoin.Value == null)
			{
				Thread.Sleep(110000);
				currentCoin = await _cryptoService.GetCoinByCoinIdAsync(coinId);
			}

			DisplayImage(currentCoin.Value.Image.Large);
			SymbolLabel.Text = currentCoin.Value.Symbol;
			CoinIDLabel.Text = currentCoin.Value.CoinId;
			NameLabel.Text = currentCoin.Value.Name;
			PriceChangePercentageLabel.Text = FormatValueOrDefault(currentCoin.Value.MarketData.PriceChangePercentage);
			MarketCapRankLabel.Text = FormatValueOrDefault(currentCoin.Value.MarketData.MarketCapRank);
			TotalVolumeLabel.Text = FormatValueOrDefault(currentCoin.Value.MarketData.TotalVolume.Usd);
			MarketCapLabel.Text = FormatValueOrDefault(currentCoin.Value.MarketData.MarketCap.Usd);
			CurrentPriceLabel.Text = FormatValueOrDefault(currentCoin.Value.MarketData.CurrentPrice.Usd);
			High24HLabel.Text =FormatValueOrDefault(currentCoin.Value.MarketData.Hight24H.Usd);
			Low24HLabel.Text = FormatValueOrDefault(currentCoin.Value.MarketData.Low24H.Usd);
		}
		private string FormatValueOrDefault(double? value)
		{
			if (value == null) return "No info";
			return value.ToString();
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
