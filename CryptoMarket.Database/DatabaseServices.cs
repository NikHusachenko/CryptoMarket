using CryptoMarket.Database;
using CryptoMarket.Database.Entities;
using CryptoMarket.Services.CoinGreckoServices;
using System.Linq;

namespace CryptoMarket.Services.DatabaseServices
{
    public class CoinDatabaseService
    {
        public void SaveCoins()
        {
            using (var db = new ApplicationDbContext())
            {
                var coinGreckoService = new CoinGreckoService();
                var coins = coinGreckoService.GetCoins();

                foreach (var coin in coins)
                {
                    var coinEntity = new CoinInfoEntity
                    {
                        Name = coin.Name,
                        Unit = coin.Unit,
                        Value = (float)coin.Value,
                        Type = coin.Type
                    };

                    db.Coins.Add(coinEntity);
                }

                db.SaveChanges();
            }
        }

        public IQueryable<CoinInfoEntity> GetCoins()
        {
            var db = new ApplicationDbContext();

            return db.Coins;
        }
    }
}