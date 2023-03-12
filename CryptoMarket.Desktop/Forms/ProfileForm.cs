namespace CryptoMarket.Desktop.Forms
{
	public partial class ProfileForm : Form
	{
		static bool ChangePasswordWasPressed = false;
		public ProfileForm()
		{
			InitializeComponent();
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
			bool isLoginCorrect = false;
			bool isEmailCorrect = false;
			bool isOldPasswordCorrect = false;
			bool isNewPasswordCorrect = false;

			List<string> LoginList = new List<string>();// Here we get all Logins
			List<string> EmailList = new List<string>();// Here we get all Emails
			List<string> PasswordList = new List<string>();// Here we get all Passwords
			LoginList.Add("1");
			EmailList.Add("1");
			PasswordList.Add("1");
			CheckEnteredInfo(LoginTextBox, "Login", LoginList, LoginErrorLabel);
			CheckEnteredInfo(EmailTextBox, "Email", EmailList, EmailErrorLabel);
			if(ChangePasswordBox.Visible == true)
			CheckEnteredInfo(OldPasswordTextBox, "Old Password", PasswordList, OldPasswordErrorLabel);
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
