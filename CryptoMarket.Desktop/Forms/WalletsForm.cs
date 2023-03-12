using System.Runtime.CompilerServices;

namespace CryptoMarket.Desktop.Forms
{
	public partial class WalletsForm : Form
	{
		static FlowLayoutPanel _walletsFlowLayotPanel;
		static Panel _walletsInfoPanel;
		static List<Wallet> _wallets;
		// 1 it`s means that wallets is empty
	    static int _walletsCount = 5; // here _walletsCount equal to the number of user wallets
		const int MaxNumWallets = 4;

		public class Wallet
		{
			public string Name { get; set; }
			public decimal Balance { get; set; }
		}

		public WalletsForm()
		{
			InitializeComponent();
			_walletsFlowLayotPanel = WalletsFlowLayoutPanel;
			_walletsInfoPanel = WalletInfoPanel;
			_wallets = new List<Wallet>();
			
			AddExistingWallets();
			if (_walletsCount == 5)AddWalletBtn.Visible = false;
		}

		private static void AddExistingWallets()
		{
			if (_walletsCount == 1)
			{
				return;
			}
			else
			{
				for(int i=1; i <= _walletsCount - 1; i++)
				{
					_walletsFlowLayotPanel.Controls.Add(CreateWallet($"Wallet {i}"));
				}
			}
		}

		private static Button CreateWallet(string walletName)
		{
			if (_walletsFlowLayotPanel.Controls.ContainsKey(walletName) && _walletsCount != 1)
			{
				MessageBox.Show("Error");
				return null;
			}
			else
			{
				Button button = new Button()
				{
					Font = new System.Drawing.Font("Segoe UI", 47.76237F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point),
					Location = new System.Drawing.Point(3, 3),
					Name = walletName,
					Size = new System.Drawing.Size(388, 329),
					Text = walletName,
				};
				Wallet wallet = new Wallet() { Name= walletName };
				_wallets.Add(wallet);
				button.Click += (sender, e) => ShowWalletInfo(wallet);
				return button;
			}
		}

		private void AddWalletBtn_Click(object sender, EventArgs e)
		{
			if(_walletsCount >= MaxNumWallets ) 
			{
				AddWalletBtn.Hide();
   			}
			string walletName = "Wallet " + _walletsCount.ToString();

		    Button button = CreateWallet(walletName);
			_walletsFlowLayotPanel.Controls.Add(button);

			button.Click += (sender, e) =>
			{
				int index = 
				int.Parse(button.Name.Replace("Wallet ", "")) - 1;
				ShowWalletInfo(_wallets[index]);
			};
			_walletsCount++;
			
		}

		private static void ShowWalletInfo(Wallet wallet)
		{
			_walletsInfoPanel.Visible = true;
			_walletsInfoPanel.Controls.Clear();
			var nameLabel = new Label
			{
				Location = new Point(10, 10),
				Text = "Name:"
			};
			_walletsInfoPanel.Controls.Add(nameLabel);

			var nameValueLabel = new Label
			{
				Location = new Point(110, 10),
				Text = wallet.Name
			};
			_walletsInfoPanel.Controls.Add(nameValueLabel);

			var balanceLabel = new Label
			{
				Location = new Point(10, 40),
				Text = "Balance:"
			};
			_walletsInfoPanel.Controls.Add(balanceLabel);

			var balanceValueLabel = new Label
			{
				Location = new Point(200, 40),
				Text = wallet.Balance.ToString()
			};
			_walletsInfoPanel.Controls.Add(balanceValueLabel);
		}
	}
}
