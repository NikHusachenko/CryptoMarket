using CryptoMarket.Database.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace CryptoMarket.EntityFramework.Configurations
{
	public class Low24HConfiguration : IEntityTypeConfiguration<Low24HEntity>
	{
		public void Configure(EntityTypeBuilder<Low24HEntity> builder)
		{
			builder
				.ToTable("Low24Hs")
				.HasKey(low => low.Id);

			builder.HasOne<MarketEntity>(low => low.Market)
				.WithOne(market => market.Low24H)
				.HasForeignKey<Low24HEntity>(low => low.MarketFK)
				.OnDelete(DeleteBehavior.Cascade);
		}
	}
}
