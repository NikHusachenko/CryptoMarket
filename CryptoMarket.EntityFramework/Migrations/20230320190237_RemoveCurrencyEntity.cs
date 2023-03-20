using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CryptoMarket.EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class RemoveCurrencyEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Currencyies_CurrencyFK",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Markets_Currencyies_CurrencyFK",
                table: "Markets");

            migrationBuilder.DropTable(
                name: "Currencyies");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Coins_CurrencyFK",
                table: "Images",
                column: "CurrencyFK",
                principalTable: "Coins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Markets_Coins_CurrencyFK",
                table: "Markets",
                column: "CurrencyFK",
                principalTable: "Coins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Coins_CurrencyFK",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Markets_Coins_CurrencyFK",
                table: "Markets");

            migrationBuilder.CreateTable(
                name: "Currencyies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CoinId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Symbol = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencyies", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Currencyies_CurrencyFK",
                table: "Images",
                column: "CurrencyFK",
                principalTable: "Currencyies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Markets_Currencyies_CurrencyFK",
                table: "Markets",
                column: "CurrencyFK",
                principalTable: "Currencyies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
