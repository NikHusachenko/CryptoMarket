using CryptoMarket.Database.Entities;

namespace CryptoMarket.Desktop.Forms
{
	public partial class ProfileForm : Form
	{
		static List<UserEntity> userEntities;
		static UserEntity _currentUser;
		static bool ChangePasswordButtonWasPressed;
		static bool ChangePasswordAttemptWasMade;
		static bool ChangeLoginAttempWasMade;
		static bool ChangeEmailAttempWasMade;

		public ProfileForm(UserEntity currentUser)
		{
			InitializeComponent();
			_currentUser = currentUser;// Here we get current User
			userEntities = new List<UserEntity>();// Here we get all Users

			ChangePasswordButtonWasPressed = false;
			ChangePasswordAttemptWasMade = false;
			ChangeLoginAttempWasMade = false;
			ChangeEmailAttempWasMade = false;

			ChangePasswordBox.Visible = false;
		
			CancelBtn.Select();
			LoadTextBoxData();
		}

		private void LoadTextBoxData()
		{
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
			return true;
		}

		private void SaveLabel_Click(object sender, EventArgs e)
		{
			bool isLoginDone = false;
			bool isEmailDone = false;
			bool isPasswordDone = false;
			if (ChangeLoginAttempWasMade)
			{
				bool isLoginCorrect = CheckEnteredInfo(LoginTextBox, "Login", LoginErrorLabel);
				bool loginExists = userEntities.Any(user => user.Login == LoginTextBox.Text);
				if (isLoginCorrect)
				{
					if (_currentUser.Login != LoginTextBox.Text)
					{
						if (!loginExists)
						{
							_currentUser.Login = LoginTextBox.Text;
							isLoginDone = true;
						}
						else
						{
							LoginErrorLabel.Visible = true;
							LoginErrorLabel.Text = $"<- Such Login is already used";
						}
					}
					else
					{
						isLoginDone = true;
					}
				}
			}
			if (ChangeEmailAttempWasMade)
			{
				bool isEmailCorrect = CheckEnteredInfo(EmailTextBox, "Email", EmailErrorLabel);
				bool emailExists = userEntities.Any(user => user.Email == EmailTextBox.Text);
				if (isEmailCorrect)
				{
					if (_currentUser.Email != EmailTextBox.Text)
					{
						if (!emailExists)
						{
							_currentUser.Email = EmailTextBox.Text;
							isEmailDone = true;
						}
						else
						{
							EmailErrorLabel.Visible = true;
							EmailErrorLabel.Text = $"<- Such Email is already used";
						}
					}
					else
					{
						isEmailDone = true;
					}
				}
			}
			bool isNewPasswordCorrect = false;
			if (ChangePasswordBox.Visible == true)
			{
				if (ChangePasswordAttemptWasMade)
				{
					if (_currentUser.Password == OldPasswordTextBox.Text)
					{
						if (OldPasswordTextBox.Text != NewPasswordTextBox.Text)
						{
							isNewPasswordCorrect = CheckEnteredInfo(NewPasswordTextBox, "New Password", NewPasswordErrorLabel);
							if (isNewPasswordCorrect)
							{
								_currentUser.Password = NewPasswordTextBox.Text;
								isPasswordDone = true;
							}
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
			else
			{
				isPasswordDone = true;
			}
			if (isLoginDone && isEmailDone && isPasswordDone)
			{
                  LoadTextBoxData();
				  MessageBox.Show("Succesfuly Updated");	
			}
			else MessageBox.Show("Finish all edits");
		}

		private void CancelLabel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void ChangePasswordLabel_Click(object sender, EventArgs e)
		{
			if (ChangePasswordButtonWasPressed == false)
			{
				ChangePasswordButtonWasPressed = true;
				ChangePasswordBox.Visible = true;
			}
			else
			{
				ChangePasswordButtonWasPressed = false;
				ChangePasswordBox.Visible = false;
				OldPasswordErrorLabel.Visible = false;
			}

		}
		private void LoginTextBox_TextChanged(object sender, EventArgs e)
		{
			ChangeLoginAttempWasMade = true;
			LoginErrorLabel.Visible = false;

		}

		private void EmailTextBox_TextChanged(object sender, EventArgs e)
		{
			ChangeEmailAttempWasMade = true;
			EmailErrorLabel.Visible = false;
		}

		private void OldPasswordTextBox_TextChanged(object sender, EventArgs e)
		{
			ChangePasswordAttemptWasMade = true;
		}

		private void NewPasswordTextBox_TextChanged(object sender, EventArgs e)
		{
			ChangePasswordAttemptWasMade = true;
		}
	}
}
