using CryptoMarket.Services.Response;
using CryptoMarket.Services.UserServices;
using CryptoMarket.Services.UserServices.Models;

namespace CryptoMarket.Desktop.Forms
{
    public partial class LoginForm : Form
    {
        private readonly IUserService _userService;

        public LoginForm(IUserService userService)
        {
            _userService = userService;

            InitializeComponent();
        }

        private void SignUpLabel_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.FormClosed += (object? sender, FormClosedEventArgs e) =>
            {
                this.Show();
            };

            this.Hide();
            registrationForm.ShowDialog();
        }

        private async void SignInLabel_Click(object sender, EventArgs e)
        {
            LoginPostViewModel vm = new LoginPostViewModel()
            {
                Login = LoginTextBox.Text,
                Password = PasswordTextBox.Text,
            };

            var validationResult = await ValidatorService<LoginPostViewModel>.ModelState(vm);
            if(validationResult.IsValid)
            {
                // ...
            }
            else
            {
                var error = validationResult.Errors;
                string passwordErrorMessage = error[0].ErrorMessage;
            }
        }
    }
}