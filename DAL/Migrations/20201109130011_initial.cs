using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "MusteriSistemi");

            migrationBuilder.CreateTable(
                name: "Admin",
                schema: "MusteriSistemi",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Username = table.Column<string>(maxLength: 32, nullable: false),
                    Password = table.Column<string>(maxLength: 32, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TBL_Musteri",
                schema: "MusteriSistemi",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    NameSurname = table.Column<string>(maxLength: 150, nullable: false),
                    Email = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_Musteri", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admin",
                schema: "MusteriSistemi");

            migrationBuilder.DropTable(
                name: "TBL_Musteri",
                schema: "MusteriSistemi");
        }
    }
}
