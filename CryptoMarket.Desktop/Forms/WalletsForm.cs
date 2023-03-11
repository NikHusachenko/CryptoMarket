namespace CryptoMarket.Desktop.Forms
{
	public partial class WalletsForm : Form
	{
		static FlowLayoutPanel _walletsFlowLayotPanel;
	    static int _walletsCount = 5; // Тут _walletsCount буде дорівнювати кількості Гаманців користувача
		const int MaxNumWallets = 4;

		public WalletsForm()
		{
			InitializeComponent();
			_walletsFlowLayotPanel = WalletsFlowLayoutPanel;
			AddExistingWallets();
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
				return button;
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if(_walletsCount >= MaxNumWallets ) 
			{
				button3.Hide();
   			}
			string walletName = "Wallet " + _walletsCount.ToString();

		    Button button = CreateWallet(walletName);
			_walletsFlowLayotPanel.Controls.Add(button);
			_walletsCount++;
			
		}

		
	}
}
