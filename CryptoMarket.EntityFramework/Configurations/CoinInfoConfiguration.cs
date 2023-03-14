using CryptoMarket.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CryptoMarket.EntityFramework.Configurations
{
    public class CoinInfoConfiguration : IEntityTypeConfiguration<CoinInfoEntity>
    {
        public void Configure(EntityTypeBuilder<CoinInfoEntity> builder)
        {
            builder.ToTable("Coins").HasKey(coin => coin.Unit);

            builder.Property(coin => coin.Name).IsRequired(true);
            builder.Property(coin => coin.Value).IsRequired(true);
            builder.Property(coin => coin.Type).IsRequired(true);
        }
    }
}