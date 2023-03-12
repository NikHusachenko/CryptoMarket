using Microsoft.Identity.Client;

namespace CryptoMarket.Desktop.Forms
{
	public partial class ProfileForm : Form
	{
		static bool ChangePasswordWasPressed;
		static string currentPassword; // Password of this User

		public ProfileForm(string Login, string Email, string Password)
		{
			InitializeComponent();

			LoginTextBox.Text = Login;
			EmailTextBox.Text = Email;
			currentPassword = Password;

			ChangePasswordWasPressed = false;
			ChangePasswordBox.Visible = false;
			EmailErrorLabel.Visible = false;
			OldPasswordErrorLabel.Visible = false;
			NewPasswordErrorLabel.Visible = false;
		}

		private static bool CheckEnteredInfo(System.Windows.Forms.TextBox EnteredData, string NameOfProperty, List<string> existsItems, Label errorLabel)
		{
			if (string.IsNullOrEmpty(EnteredData.Text))
			{
				errorLabel.Visible = true;
				errorLabel.Text = $"<- {NameOfProperty} cannot be empty";
				return false;
			}
			else if (existsItems.Contains(EnteredData.Text))
			{
				errorLabel.Visible = true;
				errorLabel.Text = $"<- Such {NameOfProperty} is already used";
				return false;
			}
			return true;
		}

		private void SaveLabel_Click(object sender, EventArgs e)
		{

			List<string> LoginList = new List<string>();// Here we get all Logins
			List<string> EmailList = new List<string>();// Here we get all Emails
			List<string> PasswordList = new List<string>();// Here we get all Passwords

			// Add existing data
			LoginList.Add("1");
			EmailList.Add("1");
			PasswordList.Add("1");

			bool isLoginCorrect = CheckEnteredInfo(LoginTextBox, "Login", LoginList, LoginErrorLabel);
			if (isLoginCorrect)
			{
				int loginIndex = LoginList.IndexOf(LoginTextBox.Text);
				if (loginIndex >= 0)
				{
					LoginList[loginIndex] = LoginTextBox.Text;
				}
			}
			bool isEmailCorrect = CheckEnteredInfo(EmailTextBox, "Email", EmailList, EmailErrorLabel);
			if (isEmailCorrect)
			{
				int emailIndex = EmailList.IndexOf(EmailTextBox.Text);
				if (emailIndex >= 0)
				{
					EmailList[emailIndex] = EmailTextBox.Text;
				}
			}

			bool isOldPasswordCorrect = false;
			bool isNewPasswordCorrect = false;

			if (ChangePasswordBox.Visible == true)
			{
				//isOldPasswordCorrect = CheckEnteredInfo(OldPasswordTextBox, "Old Password", PasswordList, OldPasswordErrorLabel);
				if (OldPasswordTextBox.Text == currentPassword)
				{
					isNewPasswordCorrect = CheckEnteredInfo(NewPasswordTextBox, "New Password", PasswordList, NewPasswordErrorLabel);
					int passwordIndex = PasswordList.IndexOf(OldPasswordTextBox.Text);
					if (passwordIndex >= 0)
					{
						PasswordList[passwordIndex] = NewPasswordTextBox.Text;
						MessageBox.Show("Succes");
						this.Close();
					}
				}
			}
		}

		private void CancelLabel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void ChangePasswordLabel_Click(object sender, EventArgs e)
		{
			if (ChangePasswordWasPressed == false)
			{
				ChangePasswordWasPressed = true;
				ChangePasswordBox.Visible = true;
			}
			else
			{
				ChangePasswordWasPressed= false;
				ChangePasswordBox.Visible = false;
				OldPasswordErrorLabel.Visible = false;
			}

		}
		private void LoginTextBox_TextChanged(object sender, EventArgs e)
		{
			LoginErrorLabel.Visible = false;
		}

		private void EmailTextBox_TextChanged(object sender, EventArgs e)
		{
			EmailErrorLabel.Visible = false;
		}
	}
}
