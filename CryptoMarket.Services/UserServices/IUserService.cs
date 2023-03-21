﻿using CryptoMarket.Services.Response;
using CryptoMarket.Services.UserServices.Models;

namespace CryptoMarket.Services.UserServices
{
    public interface IUserService
    {
        Task<ResponseService<long>> Registration(RegistrationPostViewModel vm);
        Task<ResponseService> LogIn(LoginPostViewModel vm);
    }
}