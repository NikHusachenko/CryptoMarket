using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CryptoMarket.EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class AddCurrencyEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Currencyies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CoinId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Symbol = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencyies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Thumb = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Small = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Large = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CurrencyFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Images_Currencyies_CurrencyFK",
                        column: x => x.CurrencyFK,
                        principalTable: "Currencyies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Markets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PriceChangePercentage = table.Column<double>(type: "float", nullable: false),
                    MarketCapRank = table.Column<int>(type: "int", nullable: false),
                    CurrencyFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Markets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Markets_Currencyies_CurrencyFK",
                        column: x => x.CurrencyFK,
                        principalTable: "Currencyies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CurrentPrices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Usd = table.Column<double>(type: "float", nullable: false),
                    MarketFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrentPrices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CurrentPrices_Markets_MarketFK",
                        column: x => x.MarketFK,
                        principalTable: "Markets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Hight24Hs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Usd = table.Column<double>(type: "float", nullable: false),
                    MarketFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hight24Hs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hight24Hs_Markets_MarketFK",
                        column: x => x.MarketFK,
                        principalTable: "Markets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Low24Hs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Usd = table.Column<double>(type: "float", nullable: false),
                    MarketFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Low24Hs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Low24Hs_Markets_MarketFK",
                        column: x => x.MarketFK,
                        principalTable: "Markets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MarketCaps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Usd = table.Column<double>(type: "float", nullable: false),
                    MarketFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarketCaps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MarketCaps_Markets_MarketFK",
                        column: x => x.MarketFK,
                        principalTable: "Markets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TotalVolumes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Usd = table.Column<double>(type: "float", nullable: false),
                    MarketFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TotalVolumes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TotalVolumes_Markets_MarketFK",
                        column: x => x.MarketFK,
                        principalTable: "Markets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CurrentPrices_MarketFK",
                table: "CurrentPrices",
                column: "MarketFK",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Hight24Hs_MarketFK",
                table: "Hight24Hs",
                column: "MarketFK",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Images_CurrencyFK",
                table: "Images",
                column: "CurrencyFK",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Low24Hs_MarketFK",
                table: "Low24Hs",
                column: "MarketFK",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MarketCaps_MarketFK",
                table: "MarketCaps",
                column: "MarketFK",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Markets_CurrencyFK",
                table: "Markets",
                column: "CurrencyFK",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TotalVolumes_MarketFK",
                table: "TotalVolumes",
                column: "MarketFK",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CurrentPrices");

            migrationBuilder.DropTable(
                name: "Hight24Hs");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Low24Hs");

            migrationBuilder.DropTable(
                name: "MarketCaps");

            migrationBuilder.DropTable(
                name: "TotalVolumes");

            migrationBuilder.DropTable(
                name: "Markets");

            migrationBuilder.DropTable(
                name: "Currencyies");
        }
    }
}
