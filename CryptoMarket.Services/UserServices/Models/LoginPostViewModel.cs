using FluentValidation;

namespace CryptoMarket.Services.UserServices.Models
{
    public class LoginPostViewModel
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }

    public class LoginPostValidator : AbstractValidator<LoginPostViewModel>
    {
        public LoginPostValidator()
        {
            RuleFor(x => x.Password)
                .NotEmpty()
                .NotNull()
                .MaximumLength(32);

            RuleFor(x => x.Login)
                .NotEmpty()
                .NotNull()
                .MaximumLength(32);
        }
    }
}