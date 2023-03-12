namespace CryptoMarket.Desktop.Forms
{
	public partial class RegistrationForm : Form
	{

		public RegistrationForm()
		{
			InitializeComponent();


		}

		private void SaveRegistration_Click(object sender, EventArgs e)
		{
			List<string> LoginList = new List<string>();// Here we get all Logins
			List<string> EmailList = new List<string>();// Here we get all Emails
			List<string> PasswordList = new List<string>();// Here we get all Passwords

			// Add existing data
			LoginList.Add("1");
			EmailList.Add("1");

			bool isLoginCorrect = CheckEnteredInfo(LoginTextBox, "Login", LoginList, LoginErrorLabel);
            if (isLoginCorrect)
			{
				LoginList.Add(LoginTextBox.Text);
			}

			bool isEmailCorrect = CheckEnteredInfo(EmailTextBox, "Email", EmailList, PasswordErrorLabel);
			if(isEmailCorrect)
			{
				EmailList.Add(EmailTextBox.Text);
			}
            
			if(string.IsNullOrEmpty())
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
	}
}
