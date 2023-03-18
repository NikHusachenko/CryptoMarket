using CryptoMarket.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CryptoMarket.EntityFramework.Configurations
{
	public class CoinConfiguration : IEntityTypeConfiguration<CoinEntity>
	{
		public void Configure(EntityTypeBuilder<CoinEntity> builder)
		{
			builder.ToTable("Coins").HasKey(c => c.Id);
		}
	}
}
