using CryptoMarket.Database.Entities;
using CryptoMarket.Desktop.FormsServices.ProfileServices;
using CryptoMarket.EntityFramework.Repository;
using CryptoMarket.Services.UserServices;
using Microsoft.Identity.Client;

namespace CryptoMarket.Desktop.Forms
{
	public partial class ProfileForm : Form
	{
		static bool ChangePasswordWasPressed;
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
        
			ChangePasswordWasPressed = false;
			ChangePasswordBox.Visible = false;
			EmailErrorLabel.Visible = false;
			OldPasswordErrorLabel.Visible = false;
			NewPasswordErrorLabel.Visible = false;
		}
		private async void SaveLabel_Click(object sender, EventArgs e)
		{
			await _profileService.SaveChangedData(_currentUser,ChangePasswordBox,LoginTextBox,EmailTextBox,OldPasswordTextBox,NewPasswordTextBox,LoginErrorLabel,EmailErrorLabel);
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
