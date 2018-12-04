using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cycle",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    System = table.Column<int>(nullable: false),
                    Lot = table.Column<int>(nullable: false),
                    Semeado = table.Column<DateTime>(nullable: false),
                    Banca = table.Column<DateTime>(nullable: false),
                    FiftyMm = table.Column<DateTime>(nullable: false),
                    SeventyFiveMm = table.Column<DateTime>(nullable: false),
                    Colhido = table.Column<DateTime>(nullable: false),
                    Entregue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cycle", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pesticide",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    System = table.Column<int>(nullable: false),
                    Lot = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Hour = table.Column<DateTime>(nullable: false),
                    CommercialName = table.Column<string>(nullable: true),
                    PesticideType = table.Column<string>(nullable: true),
                    ActivePrinciple = table.Column<string>(nullable: true),
                    DoseL = table.Column<string>(nullable: true),
                    Lack = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pesticide", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Planting",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    System = table.Column<int>(nullable: false),
                    Lot = table.Column<int>(nullable: false),
                    SeedBrand = table.Column<int>(nullable: false),
                    SeedType = table.Column<int>(nullable: false),
                    SeedVariety = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planting", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Sytem = table.Column<int>(nullable: false),
                    Lot = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WashingPipe",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    System = table.Column<int>(nullable: false),
                    Lot = table.Column<int>(nullable: false),
                    DayHour = table.Column<DateTime>(nullable: false),
                    Mode = table.Column<int>(nullable: false),
                    UsedProds = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WashingPipe", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WaterChange",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    System = table.Column<int>(nullable: false),
                    Lot = table.Column<int>(nullable: false),
                    DayHour = table.Column<DateTime>(nullable: false),
                    Receita = table.Column<decimal>(nullable: false),
                    AdditiveType = table.Column<int>(nullable: false),
                    AdditiveDose = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WaterChange", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WaterControl",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    System = table.Column<int>(nullable: false),
                    Lot = table.Column<int>(nullable: false),
                    DayHour = table.Column<DateTime>(nullable: false),
                    CDE = table.Column<decimal>(nullable: false),
                    PH = table.Column<decimal>(nullable: false),
                    CelsiusDegree = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WaterControl", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cycle");

            migrationBuilder.DropTable(
                name: "Pesticide");

            migrationBuilder.DropTable(
                name: "Planting");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "WashingPipe");

            migrationBuilder.DropTable(
                name: "WaterChange");

            migrationBuilder.DropTable(
                name: "WaterControl");
        }
    }
}
