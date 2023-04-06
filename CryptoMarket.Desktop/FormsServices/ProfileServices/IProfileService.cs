using CryptoMarket.Database.Entities;

namespace CryptoMarket.Desktop.FormsServices.ProfileServices
{
	public interface IProfileService
	{
		bool CheckEnteredInfo(UserEntity currentUser, TextBox EnteredData, string NameOfProperty, List<string> existsItems, Label errorLabel);
		Task SaveChangedData(UserEntity _currentUser, GroupBox ChangePasswordBox, TextBox LoginTextBox, TextBox EmailTextBox, TextBox OldPasswordTextBox, TextBox NewPasswordTextBox,
			Label LoginErrorLabel, Label EmailErrorLabel, Label OldPasswordErrorLabel, Label NewPasswordErrorLabel, bool loginWasChanged, bool emailWasChanged);
	}
}
