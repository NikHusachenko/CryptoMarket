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
        public DbSet<PingEntity> Pings { get; set; }
        public DbSet<CoinEntity> Coins { get; set; }
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
            modelBuilder.ApplyConfiguration(new PingConfiguration());
            modelBuilder.ApplyConfiguration(new CoinConfiguration());
        }
    }
}