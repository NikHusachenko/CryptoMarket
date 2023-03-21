using CryptoMarket.Database.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace CryptoMarket.EntityFramework.Configurations
{
	public class Hight24HConfiguration : IEntityTypeConfiguration<Hight24HEntity>
	{
		public void Configure(EntityTypeBuilder<Hight24HEntity> builder)
		{
			builder
				.ToTable("Hight24Hs")
				.HasKey(high => high.Id);

			builder.HasOne<MarketEntity>(high => high.Market)
				.WithOne(market => market.Hight24H)
				.HasForeignKey<Hight24HEntity>(high => high.MarketFK)
				.OnDelete(DeleteBehavior.Cascade);
		}
	}
}
