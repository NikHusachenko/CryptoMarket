using CryptoMarket.Database.Enums;

namespace CryptoMarket.Database.Entities
{
    public class UserEntity
    {
        public long Id { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public UserType Type { get; set; }
    }
}