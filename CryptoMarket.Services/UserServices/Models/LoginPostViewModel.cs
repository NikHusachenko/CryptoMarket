using FluentValidation;

namespace CryptoMarket.Services.UserServices.Models
{
    public class LoginPostViewModel : AbstractValidator<LoginPostViewModel>
    {
        public LoginPostViewModel()
        {
            RuleFor(x => x.Password)
                .NotEmpty()
                .NotNull()
                .MinimumLength(4)
                .MaximumLength(32);

            RuleFor(x => x.Login)
                .NotEmpty()
                .NotNull()
                .MinimumLength(4)
                .MaximumLength(32);
        }

        public string Login { get; set; }
        public string Password { get; set; }
    }
}