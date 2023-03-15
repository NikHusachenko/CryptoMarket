using CryptoMarket.Database.Entities;

namespace CryptoMarket.Desktop.Forms
{
	public partial class RegistrationForm : Form
	{
		static List<UserEntity> _allUsers;
		public RegistrationForm()
		{
			InitializeComponent();
			_allUsers = new List<UserEntity>();
			_allUsers.Add(new UserEntity { Login = "Oleg", Password = "1" });

		}

		private void SaveRegistration_Click(object sender, EventArgs e)
		{
			bool isLoginDone = false;
			bool isPasswordDone = false;
			bool isEmailDone = false;
			//List<string> LoginList = new List<string>();// Here we get all Logins
			//List<string> EmailList = new List<string>();// Here we get all Emails
			//List<string> PasswordList = new List<string>();// Here we get all Passwords

			// Add existing data
			//LoginList.Add("1");
			//EmailList.Add("1");

			bool isLoginCorrect = CheckEnteredInfo(LoginTextBox, "Login", LoginErrorLabel);
            if (isLoginCorrect)
			{
				bool containLogin = _allUsers.Any(u => u.Login == LoginTextBox.Text);
			    if(!containLogin)
				{
					isLoginDone= true;
				}
				else
				{
					LoginErrorLabel.Visible = true;
			    	LoginErrorLabel.Text = $"<- Such Login is already used";
				}
				//LoginList.Add(LoginTextBox.Text);
			}
			bool isEmailCorrect = CheckEnteredInfo(EmailTextBox, "Email", EmailErrorLabel);
			if(isEmailCorrect)
			{
				bool containEmail = _allUsers.Any(u=>u.Email== EmailTextBox.Text);
				if (!containEmail)
				{
					isEmailDone= true;
				}
				else
				{
					EmailErrorLabel.Visible = true;
					EmailErrorLabel.Text = $"<- Such Email is already used";
				}
			}

			bool isPasswordCorrect = !string.IsNullOrEmpty(PasswordTextBox.Text);
			if (isPasswordCorrect)
			{
				isPasswordDone= true;
			}
			else 
			{
				PasswordErrorLabel.Visible = true;
				PasswordErrorLabel.Text = $"<- Password cannot be empty";
			}
			if (isLoginDone && isEmailDone && isPasswordDone)
			{
				MessageBox.Show("Succesfully added");
				this.Close();
			}
		}

		private static bool CheckEnteredInfo(System.Windows.Forms.TextBox EnteredData, string NameOfProperty, Label errorLabel)
		{
			if (string.IsNullOrEmpty(EnteredData.Text))
			{
				errorLabel.Visible = true;
				errorLabel.Text = $"<- {NameOfProperty} cannot be empty";
				return false;
			}
			//else if (existsItems.Contains(EnteredData.Text))
			//{
			//	errorLabel.Visible = true;
			//	errorLabel.Text = $"<- Such {NameOfProperty} is already used";
			//	return false;
			//}
			return true;
		}

		private void LoginTextBox_TextChanged(object sender, EventArgs e)
		{
			LoginErrorLabel.Visible = false;
		}

		private void EmailTextBox_TextChanged(object sender, EventArgs e)
		{
			EmailErrorLabel.Visible = false;
		}

		private void PasswordTextBox_TextChanged(object sender, EventArgs e)
		{
			PasswordErrorLabel.Visible=false;
		}
	}
}
