using CryptoMarket.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CryptoMarket.EntityFramework.Configurations
{
	public class PingConfiguration : IEntityTypeConfiguration<PingEntity>
	{
		public void Configure(EntityTypeBuilder<PingEntity> builder)
		{
			builder.ToTable("Pings").HasKey(ping => ping.Id);
		}
	}
}
