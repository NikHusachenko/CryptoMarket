using CryptoMarket.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CryptoMarket.EntityFramework.Configurations
{
	public class MarketConfiguration : IEntityTypeConfiguration<MarketEntity>
	{
		public void Configure(EntityTypeBuilder<MarketEntity> builder)
		{
			builder
				.ToTable("Markets")
				.HasKey(market => market.Id);

			builder
				.HasOne<CurrencyEntity>(market => market.Currency)
				.WithOne(cur => cur.MarketData)
				.HasForeignKey<MarketEntity>(market => market.CurrencyFK)
				.OnDelete(DeleteBehavior.Cascade);
		}
	}
}
