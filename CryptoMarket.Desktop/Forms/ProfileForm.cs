using CryptoMarket.Database.Entities;
using Microsoft.Identity.Client;

namespace CryptoMarket.Desktop.Forms
{
	public partial class ProfileForm : Form
	{
		static List<UserEntity> userEntities; 
		static UserEntity _currentUser;
		static bool ChangePasswordWasPressed;
		//static string currentPassword; // Password of this User

		public ProfileForm(UserEntity currentUser)
		{
			InitializeComponent();

			_currentUser = currentUser;
			userEntities= new List<UserEntity>();// Here we get all Users

			//LoginTextBox.Text = Login;
			//EmailTextBox.Text = Email;
			//currentPassword = Password;

			ChangePasswordWasPressed = false;
			ChangePasswordBox.Visible = false;
			EmailErrorLabel.Visible = false;
			OldPasswordErrorLabel.Visible = false;
			NewPasswordErrorLabel.Visible = false;

			LoginTextBox.Text = _currentUser.Login;
			EmailTextBox.Text = _currentUser.Email;
		}
		private static bool CheckEnteredInfo(System.Windows.Forms.TextBox EnteredData, string NameOfProperty, Label errorLabel)
		{

			if (string.IsNullOrEmpty(EnteredData.Text))
			{
				errorLabel.Visible = true;
				errorLabel.Text = $"<- {NameOfProperty} cannot be empty";
				return false;
			}
			//else if (userEntities.Contains(EnteredData.Text))
			//{
			//	errorLabel.Visible = true;
			//	errorLabel.Text = $"<- Such {NameOfProperty} is already used";
			//	return false;
			//}
			return true;
		}

		private void SaveLabel_Click(object sender, EventArgs e)
		{

			//List<string> LoginList = new List<string>();// Here we get all Logins
			//List<string> EmailList = new List<string>();// Here we get all Emails
			//List<string> PasswordList = new List<string>();// Here we get all Passwords
		

			bool isLoginCorrect = CheckEnteredInfo(LoginTextBox, "Login", LoginErrorLabel);
			bool loginExists = userEntities.Any(user => user.Login == LoginTextBox.Text);
			if (isLoginCorrect)
			{
				if(_currentUser.Login != LoginTextBox.Text)
				{
					if (!loginExists)
					{
				        _currentUser.Login = LoginTextBox.Text;
					}
					else
					{
						LoginErrorLabel.Visible = true;
					    LoginErrorLabel.Text = $"<- Such Login is already used";
					}
				}
				//int loginIndex = LoginList.IndexOf(LoginTextBox.Text);
				//if (loginIndex >= 0)
				//{
				//	LoginList[loginIndex] = LoginTextBox.Text;
				//}
			}
			bool isEmailCorrect = CheckEnteredInfo(EmailTextBox, "Email", EmailErrorLabel);
			bool emailExists = userEntities.Any(user=> user.Email == EmailTextBox.Text);
			if (isEmailCorrect)
			{
				if(_currentUser.Email != EmailTextBox.Text)
				{
					if (!emailExists)
					{
					_currentUser.Email = EmailTextBox.Text;
					}
					else
					{
						EmailErrorLabel.Visible = true;
						EmailErrorLabel.Text = $"<- Such Email is already used";
					}
				}
				//int emailIndex = EmailList.IndexOf(EmailTextBox.Text);
				//if (emailIndex >= 0)
				//{
				//	EmailList[emailIndex] = EmailTextBox.Text;
				//}
			}
			bool isNewPasswordCorrect = false;
			if (ChangePasswordBox.Visible == true)
			{
				if (_currentUser.Password == OldPasswordTextBox.Text)
				{
					if (OldPasswordTextBox.Text != NewPasswordTextBox.Text)
					{
						isNewPasswordCorrect = CheckEnteredInfo(NewPasswordTextBox, "New Password", NewPasswordErrorLabel);
						if(isNewPasswordCorrect)
						{
							_currentUser.Password = NewPasswordTextBox.Text;
						}
						//int passwordIndex = PasswordList.IndexOf(OldPasswordTextBox.Text);
						//if (passwordIndex >= 0)
						//{
						//	PasswordList[passwordIndex] = NewPasswordTextBox.Text;
						//	MessageBox.Show("Succes");
						//	this.Close();
						//}
					}
					else
					{
						NewPasswordErrorLabel.Visible = true;
						NewPasswordErrorLabel.Text = $"<- Old password and New Password can`t be the same";
					}
				}
				else
				{
					NewPasswordErrorLabel.Visible = true;
					NewPasswordErrorLabel.Text = $"<- Old password is not correct!";
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
