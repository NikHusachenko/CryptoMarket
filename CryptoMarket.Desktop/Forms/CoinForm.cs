using CryptoMarket.Desktop.FormsServices.CoinServices;
using CryptoMarket.Services.CoinGreckoServices;

namespace CryptoMarket.Desktop.Forms
{
	public partial class CoinForm : Form
	{
		public static ICryptoService _cryptoService;
		public static ICoinService _coinService;
		public readonly string currentCoinId;
		public CoinForm(ICryptoService cryptoService, string Id)
		{
			currentCoinId = Id;
			_cryptoService = cryptoService;
			_coinService = new CoinService();
			InitializeComponent();
		}
		private async void CoinForm_Load(object sender, EventArgs e)
		{
			await FillCoinDataAndDisplay(currentCoinId);
		}
	}
}
