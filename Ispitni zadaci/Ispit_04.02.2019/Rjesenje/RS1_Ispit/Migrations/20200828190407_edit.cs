using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace RS1_Ispit_asp.net_core.Migrations
{
    public partial class edit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OdrzanCasDetalji_Ucenik_UcenikID",
                table: "OdrzanCasDetalji");

            migrationBuilder.RenameColumn(
                name: "UcenikID",
                table: "OdrzanCasDetalji",
                newName: "OdjeljenjeStavkaID");

            migrationBuilder.RenameIndex(
                name: "IX_OdrzanCasDetalji_UcenikID",
                table: "OdrzanCasDetalji",
                newName: "IX_OdrzanCasDetalji_OdjeljenjeStavkaID");

            migrationBuilder.AddForeignKey(
                name: "FK_OdrzanCasDetalji_OdjeljenjeStavka_OdjeljenjeStavkaID",
                table: "OdrzanCasDetalji",
                column: "OdjeljenjeStavkaID",
                principalTable: "OdjeljenjeStavka",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OdrzanCasDetalji_OdjeljenjeStavka_OdjeljenjeStavkaID",
                table: "OdrzanCasDetalji");

            migrationBuilder.RenameColumn(
                name: "OdjeljenjeStavkaID",
                table: "OdrzanCasDetalji",
                newName: "UcenikID");

            migrationBuilder.RenameIndex(
                name: "IX_OdrzanCasDetalji_OdjeljenjeStavkaID",
                table: "OdrzanCasDetalji",
                newName: "IX_OdrzanCasDetalji_UcenikID");

            migrationBuilder.AddForeignKey(
                name: "FK_OdrzanCasDetalji_Ucenik_UcenikID",
                table: "OdrzanCasDetalji",
                column: "UcenikID",
                principalTable: "Ucenik",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
