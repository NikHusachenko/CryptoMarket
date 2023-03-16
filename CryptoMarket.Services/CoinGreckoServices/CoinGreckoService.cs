using Newtonsoft.Json;
using System.Net;

namespace CryptoMarket.Services.CoinGreckoServices
{
    public class CoinProps
    {
        public string Name { get; set; }
        public string Unit { get; set; }
        public double Value { get; set; }
        public string Type { get; set; }
    }
    public class Exchange
    {
        public Dictionary<string, CoinProps> Rates { get; set; }
    }

    public class Coin
    {
        public string Name { get; set; }
        public string Unit { get; set; }
        public double Value { get; set; }
        public string Type { get; set; }
    }
    public class CoinGreckoService
    {
        public List<Coin> GetCoins()
        {
            string url = "https://api.coingecko.com/api/v3/exchange_rates";

            using (var client = new WebClient())
            {
                string response = client.DownloadString(url);
                Exchange exchangeRate = JsonConvert.DeserializeObject<Exchange>(response);

                List<Coin> coins = exchangeRate.Rates.Select(rate => new Coin
                {
                    Name = rate.Value.Name,
                    Unit = rate.Value.Unit,
                    Value = rate.Value.Value,
                    Type = rate.Value.Type
                }).ToList();

                return coins;
            }
        }

    }
}