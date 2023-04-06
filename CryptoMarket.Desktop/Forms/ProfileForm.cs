using CryptoMarket.Database.Entities;
using CryptoMarket.Desktop.FormsServices.ProfileServices;
using CryptoMarket.EntityFramework.Repository;
using CryptoMarket.Services.UserServices;
using Microsoft.Identity.Client;

namespace CryptoMarket.Desktop.Forms
{
	public partial class ProfileForm : Form
	{
		static bool changePasswordWasPressed;
		static bool loginWasPressed;
		static bool emailWasPressed;
		private readonly UserEntity _currentUser;
		private static IProfileService _profileService;
		private static IGenericRepository<UserEntity> _userRepository;
		public ProfileForm(UserEntity currentUser, IGenericRepository<UserEntity> userRepository)
		{
			InitializeComponent();
			_currentUser = currentUser;
		    _userRepository = userRepository;
			_profileService = new ProfileService(_userRepository);
			LoginTextBox.Text = _currentUser.Login;
			EmailTextBox.Text = _currentUser.Email;

			loginWasPressed = false;
			emailWasPressed = false;
			changePasswordWasPressed = false;
			ChangePasswordBox.Visible = false;
			EmailErrorLabel.Visible = false;
			OldPasswordErrorLabel.Visible = false;
			NewPasswordErrorLabel.Visible = false;
		}
		private async void SaveLabel_Click(object sender, EventArgs e)
		{
			await _profileService.SaveChangedData(_currentUser,ChangePasswordBox,LoginTextBox,EmailTextBox,OldPasswordTextBox,NewPasswordTextBox,
				LoginErrorLabel,EmailErrorLabel,OldPasswordErrorLabel,NewPasswordErrorLabel,
				loginWasPressed,emailWasPressed);
		}

		private void CancelLabel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void ChangePasswordLabel_Click(object sender, EventArgs e)
		{
			if (changePasswordWasPressed == false)
			{
				changePasswordWasPressed = true;
				ChangePasswordBox.Visible = true;
			}
			else
			{
				changePasswordWasPressed= false;
				ChangePasswordBox.Visible = false;
				OldPasswordErrorLabel.Visible = false;
			}

		}
		private void LoginTextBox_TextChanged(object sender, EventArgs e)
		{
			loginWasPressed= true;
			LoginErrorLabel.Visible = false;
		}

		private void EmailTextBox_TextChanged(object sender, EventArgs e)
		{
			emailWasPressed= true;
			EmailErrorLabel.Visible = false;
		}
	}
}
