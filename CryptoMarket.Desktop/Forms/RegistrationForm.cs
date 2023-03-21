using CryptoMarket.Common;
using CryptoMarket.Services.Response;
using CryptoMarket.Services.UserServices;
using CryptoMarket.Services.UserServices.Models;

namespace CryptoMarket.Desktop.Forms
{
    public partial class RegistrationForm : Form
    {
        IUserService _userService;

        public RegistrationForm(IUserService userService)
        {
            _userService = userService;

            InitializeComponent();
        }

        private async void SaveRegistration_Click(object sender, EventArgs e)
        {
            ClearErrors<Label>(loginErrorLabel, emailErrorLabel, passwordErrorLabel);

            RegistrationPostViewModel vm = new RegistrationPostViewModel()
            {
                Email = EmailTextBox.Text,
                Login = LoginTextBox.Text,
                Password = PasswordTextBox.Text,
            };

            var modelState = await ValidatorService<RegistrationPostViewModel>.ModelState(vm);
            if (!modelState.IsValid)
            {
                var errors = modelState.Errors;

                if (errors.ContainsKey("Login")) ShowError<Label>(loginErrorLabel, errors["Login"]);
                if (errors.ContainsKey("Email")) ShowError<Label>(emailErrorLabel, errors["Email"]);
                if (errors.ContainsKey("Password")) ShowError<Label>(passwordErrorLabel, errors["Password"]);

                return;
            }

            var response = await _userService.Registration(vm);
            if (response.IsError)
            {
                ShowError<Label>(loginErrorLabel, response.ErrorMessage);
                return;
            }

            MessageBox.Show(SuccessMessages.REGISTRATION_SUCCESSFULY);
            this.Close();
        }

        private void ShowError<T>(T errorLabel, string errorMessage) where T : Label
        {
            errorLabel.Visible = true;
            errorLabel.Text = errorMessage;
        }

        private void ClearErrors<T>(params T[] labels) where T : Label
        {
            foreach (var label in labels)
            {
                label.Visible = false;
                label.Text = string.Empty;
            }
        }
    }
}
