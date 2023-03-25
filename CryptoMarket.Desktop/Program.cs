using CryptoMarket.Database.Entities;
using CryptoMarket.Desktop.Forms;
using CryptoMarket.EntityFramework;
using CryptoMarket.EntityFramework.Repository;
using CryptoMarket.Services.UserServices;
using CryptoMarket.Services.WalletServices;

namespace CryptoMarket.Desktop
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationDbContext context = new ApplicationDbContext();

            IGenericRepository<WalletEntity> walletRepository = new GenericRepository<WalletEntity>(context);
            IGenericRepository<UserEntity> userRepository = new GenericRepository<UserEntity>(context);

            IWalletService walletService = new WalletService(walletRepository);
            IUserService userService = new UserService(userRepository, walletService);

            ApplicationConfiguration.Initialize();
            //  Application.Run(new LoginForm(userService));
            Application.Run(new MarketForm());
        }
    }
}