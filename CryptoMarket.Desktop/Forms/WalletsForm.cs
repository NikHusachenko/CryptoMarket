using CryptoMarket.Database.Entities;
using System.Runtime.CompilerServices;

namespace CryptoMarket.Desktop.Forms
{
	public partial class WalletsForm : Form
	{
		static UserEntity _currentUser;
		static FlowLayoutPanel _walletsFlowLayotPanel;
		static Panel _walletsInfoPanel;
		static int _walletsCount; // here _walletsCount equal to the number of user wallets. 1 it`s means that wallets is empty
		const int MaxNumWallets = 5;

		//public class Wallet
		//{
		//	public string Name { get; set; }
		//	public decimal Balance { get; set; }
		//}

		public WalletsForm(UserEntity currentUser)
		{
			InitializeComponent();

			_currentUser = currentUser;
			_walletsFlowLayotPanel = WalletsFlowLayoutPanel;
			_walletsCount = _currentUser.Wallets.Count+ 1;
			_walletsInfoPanel = WalletInfoPanel;
			
			AddExistingWallets();
			if (_walletsCount == MaxNumWallets) AddWalletBtn.Visible = false;
		}

		private static void AddExistingWallets()
		{
			if(_currentUser.Wallets.Count == null)
			{
				return;
			}
			else
			{
				for(int i=1; i<= _currentUser.Wallets.Count; i++)
				{
					Button button = new Button()
					{
						Font = new System.Drawing.Font("Segoe UI", 47.76237F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point),
						Location = new System.Drawing.Point(3, 3),
						Name = "Wallet",
						Size = new System.Drawing.Size(388, 329),
						Text = $"Wallet {i}",
					};
					WalletEntity wallet = new WalletEntity() { Id = i };
				
					_walletsFlowLayotPanel.Controls.Add(button);

					button.Click += (sender, e) =>
					{
						_walletsInfoPanel.Visible = true;
						_walletsInfoPanel.Controls.Clear();
						var nameLabel = new Label
						{
							Location = new Point(10, 10),
							Text = $"Wallet User Id : {wallet.Id}",
							AutoSize = true,

						};
						_walletsInfoPanel.Controls.Add(nameLabel);
					};

				
				}
			}
		}

		private static (Button,WalletEntity) CreateWallet(string walletName)
		{
			if (_walletsFlowLayotPanel.Controls.ContainsKey(walletName) && _walletsCount != 1)
			{
				MessageBox.Show("Error");
				return (null,null);
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
				WalletEntity wallet = new WalletEntity() { Id = _walletsCount};
				_currentUser.Wallets.Add(wallet);
				button.Click += (sender, e) => ShowWalletInfo(wallet);
				return (button,wallet);
			}
		}

		private void AddWalletBtn_Click(object sender, EventArgs e)
		{
			if(_walletsCount + 1 == MaxNumWallets ) 
			{
				AddWalletBtn.Hide();
   			}
			string walletName = "Wallet " + _walletsCount.ToString();

		    (Button button,WalletEntity wallet) = CreateWallet(walletName);
			_walletsFlowLayotPanel.Controls.Add(button);

			button.Click += (sender, e) =>
			{
				ShowWalletInfo(wallet);
			};
			_walletsCount++;
			
		}

		private static void ShowWalletInfo(WalletEntity wallet)
		{
			_walletsInfoPanel.Visible = true;
			_walletsInfoPanel.Controls.Clear();
			var nameLabel = new Label
			{
				Location = new Point(10, 10),
				Text = $"Wallet User Id : {wallet.Id}",
				AutoSize = true,
				
			};
			_walletsInfoPanel.Controls.Add(nameLabel);
			
		}
	}
}
