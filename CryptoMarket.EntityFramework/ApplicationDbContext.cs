using CryptoMarket.Common;
using CryptoMarket.Database.Entities;
using CryptoMarket.EntityFramework.Configurations;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace CryptoMarket.EntityFramework
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<WalletEntity> Wallets { get; set; }
        public DbSet<CoinInfoEntity> Coins { get; set; }

        public ApplicationDbContext()
        {
            Database.Migrate();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(DbConfiguration.DEFAULT_CONNECTION);
            //optionsBuilder.UseSqlServer(DbConfiguration.DEFAULT_CONNECTION);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new WalletConfiguration());
            modelBuilder.ApplyConfiguration(new CoinInfoConfiguration());
        }
    }
}