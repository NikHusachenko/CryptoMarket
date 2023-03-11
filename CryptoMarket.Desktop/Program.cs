using CryptoMarket.Desktop.Forms;
using CryptoMarket.EntityFramework;

namespace CryptoMarket.Desktop
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationDbContext context = new ApplicationDbContext();
            ApplicationConfiguration.Initialize();
            //Application.Run(new LoginForm());
            //Application.Run(new ProfileForm());
            //Application.Run(new MarketForm());
            Application.Run(new WalletsForm());
        }
    }
}