using FluentValidation;
using FluentValidation.Results;

namespace CryptoMarket.Services.Response
{
    public class ValidatorService<T> where T : AbstractValidator<T>
    {
        public async Task<StateResponse> ModelState(T value)
        {
            var validate = await value.ValidateAsync(value, options =>
            {
                options.IncludeAllRuleSets();
            });

            if(validate.IsValid)
            {
                return new StateResponse()
                {
                    IsValid = true,
                };
            }
            else
            {
                return new StateResponse()
                {
                    IsValid = false,
                    Errors = validate.Errors,
                };
            }
        }
    }

    public class StateResponse
    {
        public StateResponse()
        {
            Errors = new List<ValidationFailure>();
        }

        public bool IsValid { get; set; }
        public List<ValidationFailure> Errors { get; set; }
    }
}