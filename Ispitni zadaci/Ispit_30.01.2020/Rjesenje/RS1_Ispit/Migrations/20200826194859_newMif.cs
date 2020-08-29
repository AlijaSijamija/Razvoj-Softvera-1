using Microsoft.EntityFrameworkCore.Migrations;

namespace RS1_Ispit_asp.net_core.Migrations
{
    public partial class newMif : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TakmicenjeUcesnik_Odjeljenje_OdjeljenjeID",
                table: "TakmicenjeUcesnik");

            migrationBuilder.DropForeignKey(
                name: "FK_TakmicenjeUcesnik_Ucenik_UcenikID",
                table: "TakmicenjeUcesnik");

            migrationBuilder.DropIndex(
                name: "IX_TakmicenjeUcesnik_OdjeljenjeID",
                table: "TakmicenjeUcesnik");

            migrationBuilder.DropIndex(
                name: "IX_TakmicenjeUcesnik_UcenikID",
                table: "TakmicenjeUcesnik");

            migrationBuilder.DropColumn(
                name: "OdjeljenjeID",
                table: "TakmicenjeUcesnik");

            migrationBuilder.DropColumn(
                name: "UcenikID",
                table: "TakmicenjeUcesnik");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OdjeljenjeID",
                table: "TakmicenjeUcesnik",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UcenikID",
                table: "TakmicenjeUcesnik",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TakmicenjeUcesnik_OdjeljenjeID",
                table: "TakmicenjeUcesnik",
                column: "OdjeljenjeID");

            migrationBuilder.CreateIndex(
                name: "IX_TakmicenjeUcesnik_UcenikID",
                table: "TakmicenjeUcesnik",
                column: "UcenikID");

            migrationBuilder.AddForeignKey(
                name: "FK_TakmicenjeUcesnik_Odjeljenje_OdjeljenjeID",
                table: "TakmicenjeUcesnik",
                column: "OdjeljenjeID",
                principalTable: "Odjeljenje",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TakmicenjeUcesnik_Ucenik_UcenikID",
                table: "TakmicenjeUcesnik",
                column: "UcenikID",
                principalTable: "Ucenik",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
