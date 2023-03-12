using CryptoMarket.Services.Response;
using CryptoMarket.Services.UserServices.Models;

namespace CryptoMarket.Services.UserServices
{
    public interface IUserService
    {
        Task<ResponseService<long>> Create(RegistrationPostViewModel vm);

        Task<ResponseService> LogIn(LoginPostViewModel vm);
    }
}