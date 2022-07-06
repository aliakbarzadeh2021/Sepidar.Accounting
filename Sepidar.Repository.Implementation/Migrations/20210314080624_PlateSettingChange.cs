using Microsoft.EntityFrameworkCore.Migrations;

namespace Sepidar.Repository.Implementation.Migrations
{
    public partial class PlateSettingChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MethodId",
                table: "PlateSettings",
                newName: "PlateSettingMethod");

            migrationBuilder.AlterColumn<int>(
                name: "Fixpart",
                table: "PlateSettings",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PlateSettingMethod",
                table: "PlateSettings",
                newName: "MethodId");

            migrationBuilder.AlterColumn<string>(
                name: "Fixpart",
                table: "PlateSettings",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
