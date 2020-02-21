using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NWEE.MyAirport.EF.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bagages",
                columns: table => new
                {
                    BagageID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VolID = table.Column<int>(nullable: false),
                    CodeIada = table.Column<string>(nullable: true),
                    DateCreation = table.Column<DateTime>(nullable: false),
                    Classe = table.Column<string>(nullable: true),
                    Prioritaire = table.Column<bool>(nullable: false),
                    STA = table.Column<string>(nullable: false),
                    SSUR = table.Column<string>(nullable: true),
                    Destination = table.Column<string>(nullable: true),
                    Escale = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bagages", x => x.BagageID);
                });

            migrationBuilder.CreateTable(
                name: "Vols",
                columns: table => new
                {
                    VolID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CIE = table.Column<string>(nullable: true),
                    JEX = table.Column<short>(nullable: false),
                    DHC = table.Column<DateTime>(nullable: false),
                    PKG = table.Column<string>(nullable: true),
                    IMM = table.Column<string>(nullable: true),
                    PAX = table.Column<short>(nullable: false),
                    DES = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vols", x => x.VolID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bagages");

            migrationBuilder.DropTable(
                name: "Vols");
        }
    }
}
