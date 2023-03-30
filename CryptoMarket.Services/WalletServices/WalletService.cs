using CryptoMarket.Common;
using CryptoMarket.Database.Entities;
using CryptoMarket.EntityFramework.Repository;
using CryptoMarket.Services.Response;

namespace CryptoMarket.Services.WalletServices
{
    public class WalletService : IWalletService
    {
        private readonly IGenericRepository<WalletEntity> _walletRepository;

        public WalletService(IGenericRepository<WalletEntity> walletRepository)
        {
            _walletRepository = walletRepository;
        }

        public async Task<ResponseService<long>> Create(long userFK)
        {
            WalletEntity dbRecord = new WalletEntity()
            {
                UserFK = userFK,
            };

            var result = await _walletRepository.Create(dbRecord);
            if(result == string.Empty)
            {
                return ResponseService<long>.Ok(dbRecord.Id);
            }
            else
            {
                return ResponseService<long>.Error(result);
            }
        }
    }
}