using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BNASNWEE.MyAirport.EF.Migrations
{
    public partial class nathproj : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vols",
                columns: table => new
                {
                    VolId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cie = table.Column<string>(nullable: true),
                    Lig = table.Column<string>(nullable: true),
                    Jex = table.Column<short>(nullable: false),
                    Dhc = table.Column<DateTime>(nullable: false),
                    Pkg = table.Column<string>(nullable: true),
                    Imm = table.Column<string>(nullable: true),
                    Pax = table.Column<short>(nullable: false),
                    Des = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vols", x => x.VolId);
                });

            migrationBuilder.CreateTable(
                name: "Bagages",
                columns: table => new
                {
                    BagageID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VolID = table.Column<int>(nullable: false),
                    CodeIata = table.Column<string>(nullable: true),
                    DateCreation = table.Column<DateTime>(nullable: false),
                    Classe = table.Column<string>(nullable: true),
                    Prioritaire = table.Column<bool>(nullable: false),
                    Sta = table.Column<string>(nullable: false),
                    Ssur = table.Column<string>(nullable: true),
                    Destination = table.Column<string>(nullable: true),
                    Escale = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bagages", x => x.BagageID);
                    table.ForeignKey(
                        name: "FK_Bagages_Vols_VolID",
                        column: x => x.VolID,
                        principalTable: "Vols",
                        principalColumn: "VolId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bagages_VolID",
                table: "Bagages",
                column: "VolID");
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
