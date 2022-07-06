using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sepidar.Repository.Implementation.Migrations
{
    public partial class BusinessId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "BusinessId",
                table: "SubGroups",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "BusinessId",
                table: "SubGroupPropertiess",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "BusinessId",
                table: "SubGroupDepreciationMethods",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "BusinessId",
                table: "PlateSettings",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "BusinessId",
                table: "GroupSettings",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "BusinessId",
                table: "Groups",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "BusinessId",
                table: "ExpensesAfterAcquisitions",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "BusinessId",
                table: "DepreciationRuless",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "BusinessId",
                table: "DepreciationCalculates",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "BusinessId",
                table: "DeploymentLocations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "BusinessId",
                table: "BuyFactors",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "BusinessId",
                table: "AssetTransferees",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "BusinessId",
                table: "AssetSells",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "BusinessId",
                table: "Assets",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "BusinessId",
                table: "AssetRemoveAndScrappings",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "BusinessId",
                table: "AssetPropertiess",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "BusinessId",
                table: "AssetOperations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "BusinessId",
                table: "AssetInsurances",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "BusinessId",
                table: "AssetGuarantees",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "BusinessId",
                table: "AssetDepreciationMethods",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "BusinessId",
                table: "AssetDeploymentLocations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "BusinessId",
                table: "AssetAcquisitions",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BusinessId",
                table: "SubGroups");

            migrationBuilder.DropColumn(
                name: "BusinessId",
                table: "SubGroupPropertiess");

            migrationBuilder.DropColumn(
                name: "BusinessId",
                table: "SubGroupDepreciationMethods");

            migrationBuilder.DropColumn(
                name: "BusinessId",
                table: "PlateSettings");

            migrationBuilder.DropColumn(
                name: "BusinessId",
                table: "GroupSettings");

            migrationBuilder.DropColumn(
                name: "BusinessId",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "BusinessId",
                table: "ExpensesAfterAcquisitions");

            migrationBuilder.DropColumn(
                name: "BusinessId",
                table: "DepreciationRuless");

            migrationBuilder.DropColumn(
                name: "BusinessId",
                table: "DepreciationCalculates");

            migrationBuilder.DropColumn(
                name: "BusinessId",
                table: "DeploymentLocations");

            migrationBuilder.DropColumn(
                name: "BusinessId",
                table: "BuyFactors");

            migrationBuilder.DropColumn(
                name: "BusinessId",
                table: "AssetTransferees");

            migrationBuilder.DropColumn(
                name: "BusinessId",
                table: "AssetSells");

            migrationBuilder.DropColumn(
                name: "BusinessId",
                table: "Assets");

            migrationBuilder.DropColumn(
                name: "BusinessId",
                table: "AssetRemoveAndScrappings");

            migrationBuilder.DropColumn(
                name: "BusinessId",
                table: "AssetPropertiess");

            migrationBuilder.DropColumn(
                name: "BusinessId",
                table: "AssetOperations");

            migrationBuilder.DropColumn(
                name: "BusinessId",
                table: "AssetInsurances");

            migrationBuilder.DropColumn(
                name: "BusinessId",
                table: "AssetGuarantees");

            migrationBuilder.DropColumn(
                name: "BusinessId",
                table: "AssetDepreciationMethods");

            migrationBuilder.DropColumn(
                name: "BusinessId",
                table: "AssetDeploymentLocations");

            migrationBuilder.DropColumn(
                name: "BusinessId",
                table: "AssetAcquisitions");
        }
    }
}
