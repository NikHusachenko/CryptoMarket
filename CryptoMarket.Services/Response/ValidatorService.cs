using FluentValidation;

namespace CryptoMarket.Services.Response
{
    public class ValidatorService<T> where T : AbstractValidator<T>
    {
        public static async Task<StateResponse> ModelState(T value)
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
                Dictionary<string, string> errors = new Dictionary<string, string>();
                foreach(var error in  validate.Errors)
                {
                    if(!errors.ContainsKey(error.PropertyName))
                    {
                        errors.Add(error.PropertyName, error.ErrorMessage);
                    }
                }

                return new StateResponse()
                {
                    IsValid = false,
                    Errors = errors,
                };
            }
        }
    }

    public class StateResponse
    {
        public StateResponse()
        {
            Errors = new Dictionary<string, string>();
        }

        public bool IsValid { get; set; }
        public Dictionary<string, string> Errors { get; set; }
    }
}