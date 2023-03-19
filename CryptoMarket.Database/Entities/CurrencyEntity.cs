using Newtonsoft.Json;

namespace CryptoMarket.Database.Entities
{
	public class CurrencyEntity
	{
		public int Id { get; set; }
		[JsonProperty("id")]
		public string CoinId { get; set; }
		public string Symbol { get; set; }
		public string Name { get; set; }
		public ImageEntity Image { get; set; }
		[JsonProperty("market_data")]
		public MarketEntity MarketData { get; set; }
	}
}
