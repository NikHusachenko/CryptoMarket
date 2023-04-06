using CryptoMarket.Common;
using CryptoMarket.Database.Entities;
using CryptoMarket.Database.Enums;
using CryptoMarket.EntityFramework.Repository;
using CryptoMarket.Services.Response;
using CryptoMarket.Services.UserServices.Models;
using CryptoMarket.Services.WalletServices;
using Microsoft.EntityFrameworkCore;

namespace CryptoMarket.Services.UserServices
{
    public class UserService : IUserService
    {
        private readonly IGenericRepository<UserEntity> _userRepository;
        private readonly IWalletService _walletService;

        public UserService(IGenericRepository<UserEntity> userRepository,
            IWalletService walletService)
        {
            _userRepository = userRepository;
            _walletService = walletService;
        }

        public async Task<ResponseService<long>> Registration(RegistrationPostViewModel vm)
        {
            UserEntity dbRecord = await _userRepository
                .GetBy(user => user.Email ==  vm.Email || 
                    user.Login == vm.Login);

            if(dbRecord != null)
            {
                return ResponseService<long>.Error(Errors.USER_IS_EXISTING_ERROR);
            }

            dbRecord = new UserEntity()
            {
                CreatedOn = DateTime.Now,
                Email = vm.Email,
                IsBlocked = false,
                Login = vm.Login,
                Password = vm.Password,
                Type = UserType.User,
            };

            var result = await _userRepository.Create(dbRecord);
            if(result != string.Empty)
            {
                return ResponseService<long>.Error(result);
            }

            var createResult = await _walletService.Create(dbRecord.Id);
            if(createResult.IsError)
            {
                return ResponseService<long>.Error(createResult.ErrorMessage);
            }

            return ResponseService<long>.Ok(dbRecord.Id);
        }

        public async Task<ResponseService> LogIn(LoginPostViewModel vm)
        {
            UserEntity dbRecord = await _userRepository
                .GetBy(user => user.Login == vm.Login &&
                    user.Password == vm.Password);

            if(dbRecord == null)
            {
                return ResponseService.Error(Errors.USER_NOT_FOUND_ERROR);
            }

            dbRecord.IsOnline = true;
            var result = await _userRepository.Update(dbRecord);
            if (result == string.Empty)
            {
                return ResponseService.Ok();
            }
            else
            {
                return ResponseService.Error(result);
            }
        }
		public async Task<UserEntity> GetByLoginAndPasswordAsync(string login, string password)
		{
			UserEntity dbRecord = await _userRepository.Table
				.Include(user => user.Wallets)
				.Where(user => user.Login == login && user.Password == password)
				.FirstOrDefaultAsync();
			if (dbRecord == null)
			{
				return null;
			}
			return dbRecord;
		}
		public async Task<List<UserEntity>> GetAllAsync()
		{
			List<UserEntity> dbRecord = await _userRepository.Table
				.Include(user => user.Wallets)
				.ToListAsync();
			if (dbRecord == null)
			{
				return null;
			}
			return dbRecord;
		}
	}
}