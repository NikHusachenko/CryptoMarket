using CryptoMarket.Database.Entities;
using CryptoMarket.EntityFramework;
using CryptoMarket.EntityFramework.Repository;
using CryptoMarket.Services.CoinGreckoServices;
using CryptoMarket.Services.Response;

namespace CryptoMarket.Desktop.Forms
{
	public partial class MarketForm : Form
	{
		private const int coinsPerPage = 150;
		private static int currentPage = 0;
		private static ResponseService<List<CoinEntity>> coins;
		public static async Task InitCoins()
		{
			coins = await _cryptoService.GetCoinListAsync();
		}
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
			PageNumberInfoLab.Text = $"{currentPage+1}/{(int)Math.Ceiling((double)coins.Value.Count / coinsPerPage)}";
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

			if (coins != null && currentPage >= (int)Math.Ceiling((double)coins.Value.Count / coinsPerPage))
			{
				NextPageBtn.Enabled = false;
			}
		}
		//public async static void AddCoinsToForm()
		//{
		//	int a = 0;
		//	ResponseService<List<CoinEntity>> coins = await _cryptoService.GetCoinListAsync();
		//	for (int i = 0; i < 650; i++)
		//	{
		//		Label NameText = new Label()
		//		{
		//			AutoSize = true,
		//			Location = new System.Drawing.Point(7, 32),
		//			Name = "label1",
		//			Size = new System.Drawing.Size(43, 17),
		//			TabIndex = 0,
		//			Text = "Name",
		//		};
		//		Label AgeText = new Label()
		//		{
		//			AutoSize = true,
		//			Location = new System.Drawing.Point(7, 61),
		//			Name = "label4",
		//			Size = new System.Drawing.Size(31, 17),
		//			TabIndex = 2,
		//			Text = a.ToString(),
		//		};

		//		GroupBox groupBox = new GroupBox()
		//		{

		//			Location = new Point(3, 3),
		//			Size = new System.Drawing.Size(320, 200),
		//			Margin = new Padding(5, 5, 5, 5),
		//			Name = "groupBox",
		//			Text = coins.Value[i].CoinId, //"groupBox",
		//			Controls = {  NameText, AgeText }
		//		};
		//		a++;
		//		_infoFlowLayotPanel.Controls.Add(groupBox);
		//	}

		//}
	}
}
