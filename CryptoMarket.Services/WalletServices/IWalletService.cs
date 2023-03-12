using CryptoMarket.Database.Entities;
using CryptoMarket.Services.Response;

namespace CryptoMarket.Services.WalletServices
{
    public interface IWalletService
    {
        Task<ResponseService<long>> Create(long userFK);
    }
}