using CryptoMarket.Database.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace CryptoMarket.EntityFramework.Configurations
{
	public class CurrentPriceConfiguration : IEntityTypeConfiguration<CurrentPriceEntity>
	{
		public void Configure(EntityTypeBuilder<CurrentPriceEntity> builder)
		{
			builder
				.ToTable("CurrentPrices")
				.HasKey(curprice => curprice.Id);

			builder.HasOne<MarketEntity>(curprice => curprice.Market)
				.WithOne(market => market.CurrentPrice)
				.HasForeignKey<CurrentPriceEntity>(curprice => curprice.MarketFK)
				.OnDelete(DeleteBehavior.Cascade);
		}
	}
}
