using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SWApiCaller.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Films",
                columns: table => new
                {
                    Url = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Episode_id = table.Column<int>(nullable: false),
                    Opening_crawl = table.Column<string>(nullable: true),
                    Director = table.Column<string>(nullable: true),
                    Producer = table.Column<string>(nullable: true),
                    Release_date = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    Edited = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Films", x => x.Url);
                });

            migrationBuilder.CreateTable(
                name: "people",
                columns: table => new
                {
                    Url = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Height = table.Column<string>(nullable: true),
                    Mass = table.Column<string>(nullable: true),
                    Hair_color = table.Column<string>(nullable: true),
                    Skin_color = table.Column<string>(nullable: true),
                    Eye_color = table.Column<string>(nullable: true),
                    Birth_year = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    Homeworld = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    Edited = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_people", x => x.Url);
                });

            migrationBuilder.CreateTable(
                name: "vehicles",
                columns: table => new
                {
                    Url = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    Manufacturer = table.Column<string>(nullable: true),
                    Cost_in_credits = table.Column<string>(nullable: true),
                    Length = table.Column<string>(nullable: true),
                    Max_atmosphering_speed = table.Column<string>(nullable: true),
                    Crew = table.Column<string>(nullable: true),
                    Passengers = table.Column<string>(nullable: true),
                    Cargo_capacity = table.Column<string>(nullable: true),
                    Consumables = table.Column<string>(nullable: true),
                    Vehicle_class = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    Edited = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vehicles", x => x.Url);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Films");

            migrationBuilder.DropTable(
                name: "people");

            migrationBuilder.DropTable(
                name: "vehicles");
        }
    }
}
