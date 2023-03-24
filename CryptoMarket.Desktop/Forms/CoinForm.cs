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
				DisplayImage(currentCoin.Value.Image.Large);

			SymbolLabel.Text = currentCoin.Value.Symbol;
			CoinIDLabel.Text = currentCoin.Value.CoinId;
			NameLabel.Text = currentCoin.Value.Name;
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
