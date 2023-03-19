using CryptoMarket.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CryptoMarket.EntityFramework.Configurations
{
	public class CurrencyConfiguration : IEntityTypeConfiguration<CurrencyEntity>
	{
		public void Configure(EntityTypeBuilder<CurrencyEntity> builder)
		{
			builder.ToTable("Currencyies").HasKey(cur => cur.Id);
		}
	}
}
