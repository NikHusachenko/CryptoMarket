namespace CryptoMarket.Database.Entities
{
	public class Low24HEntity
	{
		public int Id { get; set; }
		public double? Usd { get; set; }
		public int MarketFK { get; set; }
		public MarketEntity Market { get; set; }
	}
}
