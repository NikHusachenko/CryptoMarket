using CryptoMarket.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CryptoMarket.EntityFramework.Configurations
{
    public class WalletConfiguration : IEntityTypeConfiguration<WalletEntity>
    {
        public void Configure(EntityTypeBuilder<WalletEntity> builder)
        {
            builder.ToTable("Wallets").HasKey(wallet => wallet.Id);

            builder.HasOne<UserEntity>(wallet => wallet.User)
                .WithMany(user => user.Wallets)
                .HasForeignKey(wallet => wallet.UserFK)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}