using CryptoMarket.Database.Entities;
namespace CryptoMarket.Desktop.Forms
{
    public partial class LoginForm : Form
    {
		static List<UserEntity> userEntities;//here I will get all Users
        public LoginForm()
        {
            InitializeComponent();
			userEntities= new List<UserEntity>();
        }
		private void SignUpLabel_Click(object sender, EventArgs e)
		{
			RegistrationForm registrationForm = new RegistrationForm();
			registrationForm.Show();
			registrationForm.FormClosed += ShowThisForm;
			this.Hide();
		}

		private void SignInLabel_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(LoginTextBox.Text))
			{
				if (!string.IsNullOrEmpty(PasswordTextBox.Text))
				{
					UserEntity userEntity = new UserEntity() // add random User for checking functionality
					{ 
						Login = "Oleg",
					    Email = "olegredko@gmail.com", 
						CreatedOn = DateTime.Now,
						Password = "1", IsBlocked = true 
					};
					userEntities.Add(userEntity);
					foreach (UserEntity user in userEntities)
					{
						if (LoginTextBox.Text == user.Login)
						{
							if(user.IsBlocked == false)
							{
                                if (PasswordTextBox.Text == user.Password)
								{
									MarketForm market = new MarketForm(user);
									market.Show();
									market.FormClosed += CloseThisForm;
									this.Hide();
									break;
								}
								else
								{
								PasswordErrorLabel.Visible = true;
								PasswordErrorLabel.Text = "Password is not correct";
								}
							}
							else
							{
								LoginErrorLabel.Visible = true;
								LoginErrorLabel.Text = $"<- This User were blocked";	
							}	
						}
						else
						{
							LoginErrorLabel.Visible = true;
							LoginErrorLabel.Text = $"<- Login is not correct";
						}
					}
				}
				else
				{
					PasswordErrorLabel.Visible = true;
					PasswordErrorLabel.Text = $"<- Password cannot be empty";
				}
			}
			else
			{
				LoginErrorLabel.Visible = true;
				LoginErrorLabel.Text = $"<- Login cannot be empty";
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

		private void LoginTextBox_TextChanged(object sender, EventArgs e)
		{
			LoginErrorLabel.Visible = false;
		}

		private void PasswordTextBox_TextChanged(object sender, EventArgs e)
		{
			PasswordErrorLabel.Visible = false;
		}
	}
}