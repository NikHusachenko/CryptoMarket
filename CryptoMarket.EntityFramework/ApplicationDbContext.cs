using CryptoMarket.Common;
using CryptoMarket.Database.Entities;
using CryptoMarket.EntityFramework.Configurations;
using Microsoft.EntityFrameworkCore;

namespace CryptoMarket.EntityFramework
{
	public class ApplicationDbContext : DbContext
	{
		public DbSet<UserEntity> Users { get; set; }
		public DbSet<WalletEntity> Wallets { get; set; }
		public DbSet<CoinEntity> Coins { get; set; }
		public DbSet<ImageEntity> Images { get; set; }
		public DbSet<MarketEntity> Markets { get; set; }
		public DbSet<TotalVolumeEntity> TotalVolumes { get; set; }
		public DbSet<MarketCapEntity> MarketCaps { get; set; }
		public DbSet<Low24HEntity> Low24Hs { get; set; }
		public DbSet<Hight24HEntity> Hight24Hs { get; set; }
		public DbSet<CurrentPriceEntity> CurrentPrices { get; set; }
		public ApplicationDbContext()
		{
			Database.Migrate();
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(DbConfiguration.DEFAULT_CONNECTION);
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new UserConfiguration());
			modelBuilder.ApplyConfiguration(new WalletConfiguration());
			modelBuilder.ApplyConfiguration(new CoinConfiguration());
			modelBuilder.ApplyConfiguration(new ImageConfiguration());
			modelBuilder.ApplyConfiguration(new MarketConfiguration());
			modelBuilder.ApplyConfiguration(new TotalVolumeConfiguration());
			modelBuilder.ApplyConfiguration(new MarketCapConfiguration());
			modelBuilder.ApplyConfiguration(new Low24HConfiguration());
			modelBuilder.ApplyConfiguration(new Hight24HConfiguration());
			modelBuilder.ApplyConfiguration(new CurrentPriceConfiguration());
		}
	}
}