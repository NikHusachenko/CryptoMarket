namespace CryptoMarket.Desktop.Forms
{
	public partial class LoginForm : Form
	{

		public LoginForm()
		{
			InitializeComponent();
		}

		private void SignUpLabel_Click(object sender, EventArgs e)
		{
			ProfileForm profileForm = new ProfileForm();
			profileForm.Show();
			profileForm.FormClosed += ShowThisForm;
			this.Hide();
		}

		private void SignInLabel_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(LoginTextBox.Text))
			{
				if (!string.IsNullOrEmpty(PasswordTextBox.Text))
				{
					List<string> logins = new List<string>();// Here we get all Logins
					List<string> passwords = new List<string>();// Here we get all Passwords
					logins.Add("1");
					passwords.Add("1");

					foreach (string log in logins)
					{
						if (LoginTextBox.Text == log)
						{
							foreach (string pas in passwords)
							{
								if (PasswordTextBox.Text == pas)
								{
									MarketForm market = new MarketForm();
									market.Show();
									market.FormClosed += CloseThisForm;
									this.Hide();
									break;
								}
								else
								{
									MessageBox.Show("Password is not correct");
								}
							}
						}
						else
						{
							MessageBox.Show("Login is not correct");
						}
					}
				}
				else
				{
					MessageBox.Show("Password cannot be empty!");
				}
			}
			else
			{
				MessageBox.Show("Login cannot be empty!");
			}
		}
		private void ShowThisForm(object sender, FormClosedEventArgs e)
		{
			this.Show();
		}
		private void CloseThisForm(object sender, FormClosedEventArgs e)
		{
			this.Close();
		}
	}
}
