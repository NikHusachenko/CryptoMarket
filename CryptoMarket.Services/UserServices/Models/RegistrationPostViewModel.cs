using FluentValidation;

namespace CryptoMarket.Services.UserServices.Models
{
    public class RegistrationPostViewModel : AbstractValidator<RegistrationPostViewModel>
    {
        public RegistrationPostViewModel()
        {
            RuleFor(x => x.Login)
                .NotEmpty()
                .NotNull()
                .Length(4, 31);

            RuleFor(x => x.Email)
                .NotEmpty()
                .NotNull()
                .Length(4, 31)
                .EmailAddress();

            RuleFor(x => x.Password)
                .NotEmpty()
                .NotNull()
                .Length(4, 31);
        }

        public string Login { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}