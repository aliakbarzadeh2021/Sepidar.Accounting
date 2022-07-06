using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sepidar.Repository.Implementation.Migrations
{
    public partial class AcquisitionChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OperationDate",
                table: "Assets");

            migrationBuilder.DropColumn(
                name: "AccumulatedDepreciation",
                table: "AssetAcquisitions");

            migrationBuilder.AddColumn<DateTime>(
                name: "OperationDate",
                table: "AssetAcquisitions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OperationDate",
                table: "AssetAcquisitions");

            migrationBuilder.AddColumn<DateTime>(
                name: "OperationDate",
                table: "Assets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<double>(
                name: "AccumulatedDepreciation",
                table: "AssetAcquisitions",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
