using Newtonsoft.Json;
namespace CryptoMarket.Database.Entities
{
	public class PingEntity
	{
		public int Id { get; set; }

		[JsonProperty("gecko_says")]
		public string GeckoState { get; set; }
	}
}
