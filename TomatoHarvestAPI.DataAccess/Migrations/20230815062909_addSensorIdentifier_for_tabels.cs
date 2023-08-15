using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TomatoHarvestAPI.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addSensorIdentifier_for_tabels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SoilMoistureSensorIdentifier",
                table: "TbSoilMoistureSensorDatas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LdrSensorIdentifier",
                table: "TbLdrSensorDatas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Dh22SensorIdentifier",
                table: "TbDh22SensorDatas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SoilMoistureSensorIdentifier",
                table: "TbSoilMoistureSensorDatas");

            migrationBuilder.DropColumn(
                name: "LdrSensorIdentifier",
                table: "TbLdrSensorDatas");

            migrationBuilder.DropColumn(
                name: "Dh22SensorIdentifier",
                table: "TbDh22SensorDatas");
        }
    }
}
