using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarHireWebApp.Migrations
{
    public partial class model1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vehicle",
                columns: table => new
                {
                    VehicleId = table.Column<Guid>(nullable: false),
                    RegistrationMark = table.Column<string>(nullable: false),
                    VehicleType = table.Column<int>(nullable: false),
                    Make = table.Column<string>(nullable: false),
                    Model = table.Column<string>(nullable: false),
                    Size = table.Column<int>(nullable: false),
                    Seats = table.Column<int>(nullable: false),
                    HourlyCost = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicle", x => x.VehicleId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vehicle");
        }
    }
}
