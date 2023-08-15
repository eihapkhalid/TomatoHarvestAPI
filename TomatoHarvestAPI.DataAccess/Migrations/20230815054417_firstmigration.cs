using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TomatoHarvestAPI.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class firstmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TbDh22SensorDatas",
                columns: table => new
                {
                    Dh22SensorDataId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Temperature = table.Column<double>(type: "float", nullable: false),
                    Humidity = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbDh22SensorDatas", x => x.Dh22SensorDataId);
                });

            migrationBuilder.CreateTable(
                name: "TbLdrSensorDatas",
                columns: table => new
                {
                    LdrSensorDataId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LightIntensity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbLdrSensorDatas", x => x.LdrSensorDataId);
                });

            migrationBuilder.CreateTable(
                name: "TbSoilMoistureSensorDatas",
                columns: table => new
                {
                    SoilMoistureSensorDataId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SoilMoistureLevel = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbSoilMoistureSensorDatas", x => x.SoilMoistureSensorDataId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TbDh22SensorDatas");

            migrationBuilder.DropTable(
                name: "TbLdrSensorDatas");

            migrationBuilder.DropTable(
                name: "TbSoilMoistureSensorDatas");
        }
    }
}
