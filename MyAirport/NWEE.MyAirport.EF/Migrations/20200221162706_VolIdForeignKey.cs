using Microsoft.EntityFrameworkCore.Migrations;

namespace NWEE.MyAirport.EF.Migrations
{
    public partial class VolIdForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Bagages_VolID",
                table: "Bagages",
                column: "VolID");

            migrationBuilder.AddForeignKey(
                name: "FK_Bagages_Vols_VolID",
                table: "Bagages",
                column: "VolID",
                principalTable: "Vols",
                principalColumn: "VolID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bagages_Vols_VolID",
                table: "Bagages");

            migrationBuilder.DropIndex(
                name: "IX_Bagages_VolID",
                table: "Bagages");
        }
    }
}
