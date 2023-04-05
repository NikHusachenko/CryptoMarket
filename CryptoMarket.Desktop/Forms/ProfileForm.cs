using CryptoMarket.Database.Entities;
using CryptoMarket.EntityFramework.Repository;
using CryptoMarket.Services.UserServices;
using Microsoft.Identity.Client;

namespace CryptoMarket.Desktop.Forms
{
	public partial class ProfileForm : Form
	{
		static bool ChangePasswordWasPressed;
		private readonly UserEntity _currentUser;
		private static IUserService _userService;
		private static IGenericRepository<UserEntity> _userRepository;
		public ProfileForm(UserEntity currentUser, IUserService userService,IGenericRepository<UserEntity> userRepository)
		{
			InitializeComponent();
			_currentUser = currentUser;
			_userService = userService;
		    _userRepository = userRepository;
			LoginTextBox.Text = _currentUser.Login;
			EmailTextBox.Text = _currentUser.Email;
        
			ChangePasswordWasPressed = false;
			ChangePasswordBox.Visible = false;
			EmailErrorLabel.Visible = false;
			OldPasswordErrorLabel.Visible = false;
			NewPasswordErrorLabel.Visible = false;
		}

		private static bool CheckEnteredInfo(TextBox EnteredData, string NameOfProperty, List<string> existsItems, Label errorLabel)
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

		private async void SaveLabel_Click(object sender, EventArgs e)
		{
			List<UserEntity> users = await _userService.GetAllAsync();
			List<string> LoginList = new List<string>();
			List<string> EmailList = new List<string>();
			List<string> PasswordList = new List<string>();
			foreach (UserEntity user in users)
			{
				LoginList.Add(user.Login);
				EmailList.Add(user.Email);
				PasswordList.Add(user.Password);
			}

			bool isLoginCorrect = CheckEnteredInfo(LoginTextBox, "Login", LoginList, LoginErrorLabel);
			if (isLoginCorrect)
			{
				_currentUser.Login = LoginTextBox.Text;
				await _userRepository.SaveChangesAsync();
			}
			bool isEmailCorrect = CheckEnteredInfo(EmailTextBox, "Email", EmailList, EmailErrorLabel);
			if (isEmailCorrect)
			{
				_currentUser.Email = EmailTextBox.Text;
				await _userRepository.SaveChangesAsync();
			}

			bool isOldPasswordCorrect = false;
			bool isNewPasswordCorrect = false;

			if (ChangePasswordBox.Visible == true)
			{
				if (OldPasswordTextBox.Text == _currentUser.Password)
				{
					isNewPasswordCorrect = CheckEnteredInfo(NewPasswordTextBox, "New Password", PasswordList, NewPasswordErrorLabel);
					if (isNewPasswordCorrect)
					{
						_currentUser.Password = NewPasswordTextBox.Text;
						await _userRepository.SaveChangesAsync();
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
