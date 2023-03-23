using CryptoMarket.Database.Entities;
using CryptoMarket.EntityFramework;
using CryptoMarket.EntityFramework.Repository;
using CryptoMarket.Services.CoinGreckoServices;
using CryptoMarket.Services.Response;

namespace CryptoMarket.Desktop.Forms
{
	public partial class MarketForm : Form
	{
		//public static FlowLayoutPanel _infoFlowLayotPanel;
		//static ApplicationDbContext dbcontext;
		//static IGenericRepository<CoinEntity> _entityRepository;
		//static ICryptoService _cryptoService;
		public MarketForm()
		{
			InitializeComponent();
			//_infoFlowLayotPanel = currenciesFlowLayoutPanel;
			//dbcontext = new ApplicationDbContext();
			//_entityRepository = new GenericRepository<CoinEntity>(dbcontext);
			//_cryptoService = new CoinGreckoService(_entityRepository);
			//AddCoinsToForm();
			AddToFlowLayot(currenciesFlowLayoutPanel);
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
