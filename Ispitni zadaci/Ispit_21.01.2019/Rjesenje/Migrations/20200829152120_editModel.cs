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
                name: "FK_MaturskiIspit_Predmet_PredmetIDId",
                table: "MaturskiIspit");

            migrationBuilder.DropIndex(
                name: "IX_MaturskiIspit_PredmetIDId",
                table: "MaturskiIspit");

            migrationBuilder.DropColumn(
                name: "PredmetIDId",
                table: "MaturskiIspit");

            migrationBuilder.AddColumn<int>(
                name: "PredmetID",
                table: "MaturskiIspit",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_MaturskiIspit_PredmetID",
                table: "MaturskiIspit",
                column: "PredmetID");

            migrationBuilder.AddForeignKey(
                name: "FK_MaturskiIspit_Predmet_PredmetID",
                table: "MaturskiIspit",
                column: "PredmetID",
                principalTable: "Predmet",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MaturskiIspit_Predmet_PredmetID",
                table: "MaturskiIspit");

            migrationBuilder.DropIndex(
                name: "IX_MaturskiIspit_PredmetID",
                table: "MaturskiIspit");

            migrationBuilder.DropColumn(
                name: "PredmetID",
                table: "MaturskiIspit");

            migrationBuilder.AddColumn<int>(
                name: "PredmetIDId",
                table: "MaturskiIspit",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MaturskiIspit_PredmetIDId",
                table: "MaturskiIspit",
                column: "PredmetIDId");

            migrationBuilder.AddForeignKey(
                name: "FK_MaturskiIspit_Predmet_PredmetIDId",
                table: "MaturskiIspit",
                column: "PredmetIDId",
                principalTable: "Predmet",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
