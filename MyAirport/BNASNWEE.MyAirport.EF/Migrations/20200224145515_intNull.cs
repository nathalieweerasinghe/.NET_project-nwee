using Microsoft.EntityFrameworkCore.Migrations;

namespace BNASNWEE.MyAirport.EF.Migrations
{
    public partial class intNull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bagages_Vols_VolID",
                table: "Bagages");

            migrationBuilder.RenameColumn(
                name: "VolID",
                table: "Bagages",
                newName: "VolId");

            migrationBuilder.RenameColumn(
                name: "BagageID",
                table: "Bagages",
                newName: "BagageId");

            migrationBuilder.RenameIndex(
                name: "IX_Bagages_VolID",
                table: "Bagages",
                newName: "IX_Bagages_VolId");

            migrationBuilder.AlterColumn<int>(
                name: "VolId",
                table: "Bagages",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Bagages_Vols_VolId",
                table: "Bagages",
                column: "VolId",
                principalTable: "Vols",
                principalColumn: "VolId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bagages_Vols_VolId",
                table: "Bagages");

            migrationBuilder.RenameColumn(
                name: "VolId",
                table: "Bagages",
                newName: "VolID");

            migrationBuilder.RenameColumn(
                name: "BagageId",
                table: "Bagages",
                newName: "BagageID");

            migrationBuilder.RenameIndex(
                name: "IX_Bagages_VolId",
                table: "Bagages",
                newName: "IX_Bagages_VolID");

            migrationBuilder.AlterColumn<int>(
                name: "VolID",
                table: "Bagages",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Bagages_Vols_VolID",
                table: "Bagages",
                column: "VolID",
                principalTable: "Vols",
                principalColumn: "VolId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
