using Microsoft.EntityFrameworkCore.Migrations;

namespace Sepidar.Repository.Implementation.Migrations
{
    public partial class DepreciationCalculate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "FinalPrice",
                table: "DepreciationCalculates",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "NetValue",
                table: "DepreciationCalculates",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "RemoveAndScrapping",
                table: "AssetRemoveAndScrappings",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FinalPrice",
                table: "DepreciationCalculates");

            migrationBuilder.DropColumn(
                name: "NetValue",
                table: "DepreciationCalculates");

            migrationBuilder.DropColumn(
                name: "RemoveAndScrapping",
                table: "AssetRemoveAndScrappings");
        }
    }
}
