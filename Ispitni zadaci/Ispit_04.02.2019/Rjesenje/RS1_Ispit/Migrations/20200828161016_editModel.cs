using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace RS1_Ispit_asp.net_core.Migrations
{
    public partial class editModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ucenik_OdrzanCasDetalji_OdrzanCasDetaljiID",
                table: "Ucenik");

            migrationBuilder.DropIndex(
                name: "IX_Ucenik_OdrzanCasDetaljiID",
                table: "Ucenik");

            migrationBuilder.DropColumn(
                name: "OdrzanCasDetaljiID",
                table: "Ucenik");

            migrationBuilder.AddColumn<int>(
                name: "UcenikID",
                table: "OdrzanCasDetalji",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_OdrzanCasDetalji_UcenikID",
                table: "OdrzanCasDetalji",
                column: "UcenikID");

            migrationBuilder.AddForeignKey(
                name: "FK_OdrzanCasDetalji_Ucenik_UcenikID",
                table: "OdrzanCasDetalji",
                column: "UcenikID",
                principalTable: "Ucenik",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OdrzanCasDetalji_Ucenik_UcenikID",
                table: "OdrzanCasDetalji");

            migrationBuilder.DropIndex(
                name: "IX_OdrzanCasDetalji_UcenikID",
                table: "OdrzanCasDetalji");

            migrationBuilder.DropColumn(
                name: "UcenikID",
                table: "OdrzanCasDetalji");

            migrationBuilder.AddColumn<int>(
                name: "OdrzanCasDetaljiID",
                table: "Ucenik",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ucenik_OdrzanCasDetaljiID",
                table: "Ucenik",
                column: "OdrzanCasDetaljiID");

            migrationBuilder.AddForeignKey(
                name: "FK_Ucenik_OdrzanCasDetalji_OdrzanCasDetaljiID",
                table: "Ucenik",
                column: "OdrzanCasDetaljiID",
                principalTable: "OdrzanCasDetalji",
                principalColumn: "OdrzanCasDetaljiID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
