using CryptoMarket.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CryptoMarket.EntityFramework.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.ToTable("Users").HasKey(user => user.Id);

            builder.Property(user => user.Login).HasMaxLength(32).IsRequired(true);
            builder.Property(user => user.Email).HasMaxLength(32).IsRequired(true);
            builder.Property(user => user.Password).HasMaxLength(32).IsRequired(true);
        }
    }
}