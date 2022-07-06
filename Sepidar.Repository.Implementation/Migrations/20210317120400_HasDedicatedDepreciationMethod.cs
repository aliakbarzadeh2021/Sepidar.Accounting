using Microsoft.EntityFrameworkCore.Migrations;

namespace Sepidar.Repository.Implementation.Migrations
{
    public partial class HasDedicatedDepreciationMethod : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "HasDedicatedDepreciationMethod",
                table: "Assets",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HasDedicatedDepreciationMethod",
                table: "Assets");
        }
    }
}
