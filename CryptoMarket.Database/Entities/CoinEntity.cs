using Newtonsoft.Json;

namespace CryptoMarket.Database.Entities
{
	public class CoinEntity
	{
		public int Id { get; set; }
		[JsonProperty("id")]
		public string CoinId { get; set; }
		public string Symbol { get; set; }
    	public string Name { get; set; }
	}
}
