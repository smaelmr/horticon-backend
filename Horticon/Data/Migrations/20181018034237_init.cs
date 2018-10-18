using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Planting",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    System = table.Column<int>(nullable: false),
                    Lot = table.Column<int>(nullable: false),
                    SeedBrand = table.Column<int>(nullable: false),
                    SeedType = table.Column<int>(nullable: false),
                    SeedName = table.Column<int>(nullable: false)
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Planting");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
