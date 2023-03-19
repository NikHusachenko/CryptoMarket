using CryptoMarket.Database.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace CryptoMarket.EntityFramework.Configurations
{
	public class MarketCapConfiguration : IEntityTypeConfiguration<MarketCapEntity>
	{
		public void Configure(EntityTypeBuilder<MarketCapEntity> builder)
		{
			builder
				.ToTable("MarketCaps")
				.HasKey(cap => cap.Id);

			builder.HasOne<MarketEntity>(cap => cap.Market)
				.WithOne(market => market.MarketCap)
				.HasForeignKey<MarketCapEntity>(cap => cap.MarketFK)
				.OnDelete(DeleteBehavior.Cascade);
		}
	}
}
