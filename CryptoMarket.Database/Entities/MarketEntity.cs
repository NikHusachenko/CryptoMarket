using Newtonsoft.Json;

namespace CryptoMarket.Database.Entities
{
	public class MarketEntity
	{
		public int Id { get; set; }
		[JsonProperty("price_change_percentage_24h")]
		public double? PriceChangePercentage { get; set; }

		[JsonProperty("market_cap_rank")]
		public int? MarketCapRank { get; set; }

		[JsonProperty("total_volume")]
		public TotalVolumeEntity TotalVolume { get; set; }

		[JsonProperty("market_cap")]
		public MarketCapEntity MarketCap { get; set; }

		[JsonProperty("current_price")]
		public CurrentPriceEntity CurrentPrice { get; set; }

		[JsonProperty("high_24h")]
		public Hight24HEntity Hight24H { get; set; }

		[JsonProperty("low_24h")]
		public Low24HEntity Low24H { get; set; }

		public int CurrencyFK { get; set; }
		public CoinEntity Currency { get; set; }
	}
}
