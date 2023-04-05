using CryptoMarket.Database.Entities;
using CryptoMarket.EntityFramework.Repository;
using CryptoMarket.Services.UserServices;
using DocumentFormat.OpenXml.Presentation;

namespace CryptoMarket.Desktop.FormsServices.ProfileServices
{
	public class ProfileService : IProfileService
	{
		private readonly IGenericRepository<UserEntity> _userRepository;

		public ProfileService(IGenericRepository<UserEntity> userRepository)
		{
			_userRepository = userRepository;
		}
		public bool CheckEnteredInfo(UserEntity currentUser,TextBox EnteredData, string NameOfProperty, List<string> existsItems, Label errorLabel)
		{
			if (currentUser.Login != EnteredData.Text && currentUser.Email != EnteredData.Text)
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
				else
				{
					errorLabel.Visible = false;
					return true;
				}
			}
			else
			{
				return false;
			}
		}

		public async Task SaveChangedData(UserEntity _currentUser, GroupBox ChangePasswordBox,TextBox LoginTextBox,TextBox EmailTextBox,TextBox OldPasswordTextBox,TextBox NewPasswordTextBox,
			Label LoginErrorLabel,Label EmailErrorLabel, Label OldPasswordErrorLabel,Label NewPasswordErrorLabel,bool loginWasChanged,bool emailWasChanged)
		{
			var users = await _userRepository.GetAll();
			List<string> LoginList = new List<string>();
			List<string> EmailList = new List<string>();
			foreach (UserEntity user in users)
			{
				LoginList.Add(user.Login);
				EmailList.Add(user.Email);
			}
			if (loginWasChanged)
			{
				bool isLoginCorrect = CheckEnteredInfo(_currentUser,LoginTextBox, "Login", LoginList, LoginErrorLabel);
				if (isLoginCorrect)
				{
					_currentUser.Login = LoginTextBox.Text;
					await _userRepository.Update(_currentUser);
					MessageBox.Show("Succes");
				}
			}
			if (emailWasChanged)
			{
				bool isEmailCorrect = CheckEnteredInfo(_currentUser,EmailTextBox, "Email", EmailList, EmailErrorLabel);
				if (isEmailCorrect)
				{
					_currentUser.Email = EmailTextBox.Text;
					await _userRepository.Update(_currentUser);
					if(!loginWasChanged) MessageBox.Show("Succes");
				}
			}
			if (ChangePasswordBox.Visible == true)
			{
				if (OldPasswordTextBox.Text == _currentUser.Password)
				{
					if (!string.IsNullOrEmpty(OldPasswordTextBox.Text))
					{
						if (!string.IsNullOrEmpty(NewPasswordTextBox.Text))
						{
							_currentUser.Password = NewPasswordTextBox.Text;
							await _userRepository.Update(_currentUser);
							if (!loginWasChanged && !emailWasChanged) MessageBox.Show("Succes");
						}
						else
						{
							NewPasswordErrorLabel.Visible = true;
							NewPasswordErrorLabel.Text = $"<- New Password cannot be empty";
						}
					}
					else
					{
					    OldPasswordErrorLabel.Visible = true;
						OldPasswordErrorLabel.Text = $"<- Old Password cannot be empty";
					}
				}
				else
				{
					OldPasswordErrorLabel.Visible = true;
					OldPasswordErrorLabel.Text = $"<- Not right Password";
				}
			}
		}
	}
}
