using CryptoMarket.Database.Entities;
using CryptoMarket.EntityFramework.Repository;
using CryptoMarket.Services.CoinGreckoServices;
using CryptoMarket.Services.Response;
using CryptoMarket.Services.UserServices;
using CryptoMarket.Services.UserServices.Models;

namespace CryptoMarket.Desktop.Forms
{
    public partial class LoginForm : Form
    {
        private readonly IUserService _userService;
        private readonly ICryptoService _cryptoService;
		private readonly IGenericRepository<CoinEntity> _coinRepository;
        private readonly IGenericRepository<UserEntity> _userRepository;
		public LoginForm(IUserService userService, ICryptoService cryptoService, IGenericRepository<CoinEntity> coinRepository,IGenericRepository<UserEntity> userRepository)
        {
            _userService = userService;
            _userRepository = userRepository;
            _cryptoService = cryptoService;
            _coinRepository = coinRepository;
            InitializeComponent();
        }

        private void SignUpLabel_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm(_userService);
            registrationForm.FormClosed += (object? sender, FormClosedEventArgs e) =>
            {
                this.Show();
            };

            this.Hide();
            registrationForm.ShowDialog();
        }

        private async void LoginButton_Click(object sender, EventArgs e)
        {
            ClearErrors<Label>(passwordErrorLabel, loginErrorLabel);

            LoginPostViewModel vm = new LoginPostViewModel()
            {
                Login = LoginTextBox.Text,
                Password = PasswordTextBox.Text,
            };

            var validationResult = await ValidatorService<LoginPostViewModel>.ModelState(vm);
            if (validationResult.IsValid)
            {
                var response = await _userService.LogIn(vm);
                if (response.IsError)
                {

                    return;
                }
                UserEntity currentUser = await _userService.GetByLoginAndPasswordAsync(LoginTextBox.Text, PasswordTextBox.Text);
				MarketForm marketForm = new MarketForm(currentUser,_cryptoService,_userService,_coinRepository,_userRepository);
                marketForm.FormClosed += (object? sender, FormClosedEventArgs e) =>
                {
                    Environment.Exit(0);
                };
                this.Hide();
                marketForm.ShowDialog();
            }
            else
            {
                var errors = validationResult.Errors;

                if (errors.ContainsKey("Password")) ShowError<Label>(passwordErrorLabel, errors["Password"]);
                if (errors.ContainsKey("Login")) ShowError<Label>(loginErrorLabel, errors["Login"]);
            }
        }

        private void ShowError<T>(T label, string errorMessage) where T : Label
        {
            label.Visible = true;
            label.Text = errorMessage;
        }

        private void ClearErrors<T>(params Label[] labels)
        {
            foreach (var label in labels)
            {
                label.Visible = false;
                label.Text = string.Empty;
            }
        }
	}
}