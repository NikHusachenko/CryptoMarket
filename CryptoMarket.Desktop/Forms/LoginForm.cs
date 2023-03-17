using CryptoMarket.Database.Entities;
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

            var response = await _userService.LogIn(vm);
            if(response.IsError)
            {

            }
        }
    }
}