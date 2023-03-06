namespace CryptoMarket.Database.Entities
{
    public class WalletEntity
    {
        public long Id { get; set; }

        public long UserFK { get; set; }
        public UserEntity User { get; set; }
    }
}