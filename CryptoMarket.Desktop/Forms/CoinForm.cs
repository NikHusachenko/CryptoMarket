using CryptoMarket.Database.Entities;
using CryptoMarket.EntityFramework;
using CryptoMarket.EntityFramework.Repository;
using CryptoMarket.Services.CoinGreckoServices;
using CryptoMarket.Services.Response;
using DocumentFormat.OpenXml.Office2010.Excel;
using System.Net;

namespace CryptoMarket.Desktop.Forms
{
	public partial class CoinForm : Form
	{
		public static ResponseService<CoinEntity> currentCoin;
		public static ApplicationDbContext dbcontext;
		public static IGenericRepository<CoinEntity> _coinRepository;
		public static ICryptoService _cryptoService;
		public readonly string currentCoinId;
		public CoinForm(string Id)
		{
			currentCoinId= Id;
			dbcontext = new ApplicationDbContext();
			_coinRepository = new GenericRepository<CoinEntity>(dbcontext);
			_cryptoService = new CoinGreckoService(_coinRepository);
			InitializeComponent();
		}
		private string FormatValueOrDefault(double? value)
		{
			if (value == null) return "No info";
			return value.ToString();
		}
		private async void CoinForm_Load(object sender, EventArgs e)
		{
			await FillCoinDataAndDisplay(currentCoinId);
		}
	}
}
