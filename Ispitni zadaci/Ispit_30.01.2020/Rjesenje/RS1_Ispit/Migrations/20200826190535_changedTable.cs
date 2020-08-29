using Microsoft.EntityFrameworkCore.Migrations;

namespace RS1_Ispit_asp.net_core.Migrations
{
    public partial class changedTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Takmicenje_Odjeljenje_OdjeljenjeID",
                table: "Takmicenje");

            migrationBuilder.DropIndex(
                name: "IX_Takmicenje_OdjeljenjeID",
                table: "Takmicenje");

            migrationBuilder.RenameColumn(
                name: "OdjeljenjeID",
                table: "Takmicenje",
                newName: "Razred");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Razred",
                table: "Takmicenje",
                newName: "OdjeljenjeID");

            migrationBuilder.CreateIndex(
                name: "IX_Takmicenje_OdjeljenjeID",
                table: "Takmicenje",
                column: "OdjeljenjeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Takmicenje_Odjeljenje_OdjeljenjeID",
                table: "Takmicenje",
                column: "OdjeljenjeID",
                principalTable: "Odjeljenje",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
