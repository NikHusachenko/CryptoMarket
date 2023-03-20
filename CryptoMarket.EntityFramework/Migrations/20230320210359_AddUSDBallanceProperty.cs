using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CryptoMarket.EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class AddUSDBallanceProperty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "USDBallance",
                table: "Users",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "USDBallance",
                table: "Users");
        }
    }
}
