using CryptoMarket.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CryptoMarket.EntityFramework.Configurations
{
	public class TotalVolumeConfiguration : IEntityTypeConfiguration<TotalVolumeEntity>
	{
		public void Configure(EntityTypeBuilder<TotalVolumeEntity> builder)
		{
			builder.ToTable("TotalVolumes").HasKey(vol => vol.Id);

			builder.HasOne<MarketEntity>(vol => vol.Market)
				.WithOne(market=>market.TotalVolume)
				.HasForeignKey<TotalVolumeEntity>(vol => vol.MarketFK)
				.OnDelete(DeleteBehavior.Cascade);
		}
	}
}
