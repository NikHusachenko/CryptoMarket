using CryptoMarket;
using CryptoMarket.Services.CoinGreckoServices;

namespace CryptoMarket.Database.Entities
{
    public class CoinInfoEntity
    {
        public string Name { get;  set; }

        public string Unit { get; set; }
        public double Value { get; set; }
        public string Type { get; set; }
    }
}