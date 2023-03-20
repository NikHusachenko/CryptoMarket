using CryptoMarket.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CryptoMarket.EntityFramework.Configurations
{
	public class ImageConfiguration : IEntityTypeConfiguration<ImageEntity>
	{
		public void Configure(EntityTypeBuilder<ImageEntity> builder)
		{
			builder.ToTable("Images").HasKey(image => image.Id);

			builder
				.HasOne<CoinEntity>(image => image.Currency)
				.WithOne(cur => cur.Image)
				.HasForeignKey<ImageEntity>(image => image.CurrencyFK)
				.OnDelete(DeleteBehavior.Cascade);
		}
	}
}
