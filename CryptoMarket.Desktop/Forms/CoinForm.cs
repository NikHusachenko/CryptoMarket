using CryptoMarket.Database.Entities;
using CryptoMarket.EntityFramework.Repository;
using CryptoMarket.EntityFramework;
using CryptoMarket.Services.CoinGreckoServices;
using CryptoMarket.Services.Response;
using System.Net;
using System.Windows.Forms;

namespace CryptoMarket.Desktop.Forms
{
	public partial class CoinForm : Form
	{
		private static string coinId;
		public static ResponseService<CoinEntity>? currentCoin;
		public static ApplicationDbContext dbcontext;
		public static IGenericRepository<CoinEntity> _coinRepository;
		public static ICryptoService _cryptoService;
		public CoinForm(string Id)
		{
			InitializeComponent();
			coinId = Id;
			dbcontext = new ApplicationDbContext();
			_coinRepository = new GenericRepository<CoinEntity>(dbcontext);
			_cryptoService = new CoinGreckoService(_coinRepository);
			
			FillData();

			
		}
		public async Task InitCoin()
		{
			currentCoin = await _cryptoService.GetCoinByCoinIdAsync(coinId);
		}
		public async void FillData()
		{
			if (currentCoin == null)
			{
				await InitCoin();
			}

			if(currentCoin != null) 
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
