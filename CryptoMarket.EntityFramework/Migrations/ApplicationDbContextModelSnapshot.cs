﻿// <auto-generated />
using System;
using CryptoMarket.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CryptoMarket.EntityFramework.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CryptoMarket.Database.Entities.CoinEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CoinId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Symbol")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Coins", (string)null);
                });

            modelBuilder.Entity("CryptoMarket.Database.Entities.CurrencyEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CoinId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Symbol")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Currencyies", (string)null);
                });

            modelBuilder.Entity("CryptoMarket.Database.Entities.CurrentPriceEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("MarketFK")
                        .HasColumnType("int");

                    b.Property<double>("Usd")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("MarketFK")
                        .IsUnique();

                    b.ToTable("CurrentPrices", (string)null);
                });

            modelBuilder.Entity("CryptoMarket.Database.Entities.Hight24HEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("MarketFK")
                        .HasColumnType("int");

                    b.Property<double>("Usd")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("MarketFK")
                        .IsUnique();

                    b.ToTable("Hight24Hs", (string)null);
                });

            modelBuilder.Entity("CryptoMarket.Database.Entities.ImageEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CurrencyFK")
                        .HasColumnType("int");

                    b.Property<string>("Large")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Small")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Thumb")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CurrencyFK")
                        .IsUnique();

                    b.ToTable("Images", (string)null);
                });

            modelBuilder.Entity("CryptoMarket.Database.Entities.Low24HEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("MarketFK")
                        .HasColumnType("int");

                    b.Property<double>("Usd")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("MarketFK")
                        .IsUnique();

                    b.ToTable("Low24Hs", (string)null);
                });

            modelBuilder.Entity("CryptoMarket.Database.Entities.MarketCapEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("MarketFK")
                        .HasColumnType("int");

                    b.Property<double>("Usd")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("MarketFK")
                        .IsUnique();

                    b.ToTable("MarketCaps", (string)null);
                });

            modelBuilder.Entity("CryptoMarket.Database.Entities.MarketEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CurrencyFK")
                        .HasColumnType("int");

                    b.Property<int>("MarketCapRank")
                        .HasColumnType("int");

                    b.Property<double>("PriceChangePercentage")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CurrencyFK")
                        .IsUnique();

                    b.ToTable("Markets", (string)null);
                });

            modelBuilder.Entity("CryptoMarket.Database.Entities.PingEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("GeckoState")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Pings", (string)null);
                });

            modelBuilder.Entity("CryptoMarket.Database.Entities.TotalVolumeEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("MarketFK")
                        .HasColumnType("int");

                    b.Property<double>("Usd")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("MarketFK")
                        .IsUnique();

                    b.ToTable("TotalVolumes", (string)null);
                });

            modelBuilder.Entity("CryptoMarket.Database.Entities.UserEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime?>("BlockedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<bool>("IsBlocked")
                        .HasColumnType("bit");

                    b.Property<bool>("IsOnline")
                        .HasColumnType("bit");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("CryptoMarket.Database.Entities.WalletEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("UserFK")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UserFK");

                    b.ToTable("Wallets", (string)null);
                });

            modelBuilder.Entity("CryptoMarket.Database.Entities.CurrentPriceEntity", b =>
                {
                    b.HasOne("CryptoMarket.Database.Entities.MarketEntity", "Market")
                        .WithOne("CurrentPrice")
                        .HasForeignKey("CryptoMarket.Database.Entities.CurrentPriceEntity", "MarketFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Market");
                });

            modelBuilder.Entity("CryptoMarket.Database.Entities.Hight24HEntity", b =>
                {
                    b.HasOne("CryptoMarket.Database.Entities.MarketEntity", "Market")
                        .WithOne("Hight24H")
                        .HasForeignKey("CryptoMarket.Database.Entities.Hight24HEntity", "MarketFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Market");
                });

            modelBuilder.Entity("CryptoMarket.Database.Entities.ImageEntity", b =>
                {
                    b.HasOne("CryptoMarket.Database.Entities.CurrencyEntity", "Currency")
                        .WithOne("Image")
                        .HasForeignKey("CryptoMarket.Database.Entities.ImageEntity", "CurrencyFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Currency");
                });

            modelBuilder.Entity("CryptoMarket.Database.Entities.Low24HEntity", b =>
                {
                    b.HasOne("CryptoMarket.Database.Entities.MarketEntity", "Market")
                        .WithOne("Low24H")
                        .HasForeignKey("CryptoMarket.Database.Entities.Low24HEntity", "MarketFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Market");
                });

            modelBuilder.Entity("CryptoMarket.Database.Entities.MarketCapEntity", b =>
                {
                    b.HasOne("CryptoMarket.Database.Entities.MarketEntity", "Market")
                        .WithOne("MarketCap")
                        .HasForeignKey("CryptoMarket.Database.Entities.MarketCapEntity", "MarketFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Market");
                });

            modelBuilder.Entity("CryptoMarket.Database.Entities.MarketEntity", b =>
                {
                    b.HasOne("CryptoMarket.Database.Entities.CurrencyEntity", "Currency")
                        .WithOne("MarketData")
                        .HasForeignKey("CryptoMarket.Database.Entities.MarketEntity", "CurrencyFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Currency");
                });

            modelBuilder.Entity("CryptoMarket.Database.Entities.TotalVolumeEntity", b =>
                {
                    b.HasOne("CryptoMarket.Database.Entities.MarketEntity", "Market")
                        .WithOne("TotalVolume")
                        .HasForeignKey("CryptoMarket.Database.Entities.TotalVolumeEntity", "MarketFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Market");
                });

            modelBuilder.Entity("CryptoMarket.Database.Entities.WalletEntity", b =>
                {
                    b.HasOne("CryptoMarket.Database.Entities.UserEntity", "User")
                        .WithMany("Wallets")
                        .HasForeignKey("UserFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("CryptoMarket.Database.Entities.CurrencyEntity", b =>
                {
                    b.Navigation("Image")
                        .IsRequired();

                    b.Navigation("MarketData")
                        .IsRequired();
                });

            modelBuilder.Entity("CryptoMarket.Database.Entities.MarketEntity", b =>
                {
                    b.Navigation("CurrentPrice")
                        .IsRequired();

                    b.Navigation("Hight24H")
                        .IsRequired();

                    b.Navigation("Low24H")
                        .IsRequired();

                    b.Navigation("MarketCap")
                        .IsRequired();

                    b.Navigation("TotalVolume")
                        .IsRequired();
                });

            modelBuilder.Entity("CryptoMarket.Database.Entities.UserEntity", b =>
                {
                    b.Navigation("Wallets");
                });
#pragma warning restore 612, 618
        }
    }
}
