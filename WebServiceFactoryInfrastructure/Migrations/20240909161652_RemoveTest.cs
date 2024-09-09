using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebServiceFactoryInfrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RemoveTest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Test",
                table: "TechUnits");

            migrationBuilder.DropColumn(
                name: "Test",
                table: "Regions");

            migrationBuilder.DropColumn(
                name: "Test",
                table: "HardwareTypes");

            migrationBuilder.DropColumn(
                name: "Test",
                table: "Hardwares");

            migrationBuilder.DropColumn(
                name: "Test",
                table: "Facilities");

            migrationBuilder.DropColumn(
                name: "Test",
                table: "EquipmentGroups");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Test",
                table: "TechUnits",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Test",
                table: "Regions",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Test",
                table: "HardwareTypes",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Test",
                table: "Hardwares",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Test",
                table: "Facilities",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Test",
                table: "EquipmentGroups",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
