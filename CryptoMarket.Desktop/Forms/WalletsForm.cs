namespace CryptoMarket.Desktop.Forms
{
	public partial class WalletsForm : Form
	{
		static FlowLayoutPanel _walletsFlowLayotPanel;
		int _walletsCount = 1; // Тут буде _walletsCount буде дорівнювати кількості Гаманців користувача
		const int MaxNumWallets = 4;
		public WalletsForm()
		{
			InitializeComponent();
			_walletsFlowLayotPanel = WalletsFlowLayoutPanel;


		}
		

		private void button3_Click(object sender, EventArgs e)
		{
			if(_walletsCount >= MaxNumWallets ) 
			{
				button3.Hide();
				//return;
   			}
			string walletName = "Wallet " + _walletsCount.ToString();
			if (_walletsFlowLayotPanel.Controls.ContainsKey(walletName))
			{
				return;
			}

			Button button = new Button()
			{
				Font = new System.Drawing.Font("Segoe UI", 47.76237F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point),
			    Location = new System.Drawing.Point(3, 3),
			    Name = walletName,
			    Size = new System.Drawing.Size(388, 329),
			    Text = "Wallet_" + _walletsCount.ToString(),
		   };
			_walletsFlowLayotPanel.Controls.Add(button);
			_walletsCount++;
			
		}
	}
}
