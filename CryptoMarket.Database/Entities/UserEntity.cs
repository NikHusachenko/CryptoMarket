using CryptoMarket.Database.Enums;

namespace CryptoMarket.Database.Entities
{
    public class UserEntity
    {
        public long Id { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsBlocked { get; set; }
        public bool IsOnline { get; set; }
        public double USDBallance { get; set; }
        public UserType Type { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? BlockedOn { get; set; }
        public DateTime? DeletedOn { get; set; }
        public ICollection<WalletEntity> Wallets { get; set; }
    }
}