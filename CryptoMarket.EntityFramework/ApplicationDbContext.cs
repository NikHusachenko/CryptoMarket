using CryptoMarket.Common;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace CryptoMarket.EntityFramework
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
            Database.Migrate();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Constants.DEFAULT_CONNECTION);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}