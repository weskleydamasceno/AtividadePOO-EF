using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Atividade2EFCore.Migrations
{
    public partial class secondmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContasPoupanca_Contas_ContaId",
                table: "ContasPoupanca");

            migrationBuilder.DropColumn(
                name: "ContaI",
                table: "ContasPoupanca");

            migrationBuilder.DropColumn(
                name: "Titular",
                table: "ContasPoupanca");

            migrationBuilder.AlterColumn<int>(
                name: "ContaId",
                table: "ContasPoupanca",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ContasPoupanca_Contas_ContaId",
                table: "ContasPoupanca",
                column: "ContaId",
                principalTable: "Contas",
                principalColumn: "ContaId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContasPoupanca_Contas_ContaId",
                table: "ContasPoupanca");

            migrationBuilder.AlterColumn<int>(
                name: "ContaId",
                table: "ContasPoupanca",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "ContaI",
                table: "ContasPoupanca",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Titular",
                table: "ContasPoupanca",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ContasPoupanca_Contas_ContaId",
                table: "ContasPoupanca",
                column: "ContaId",
                principalTable: "Contas",
                principalColumn: "ContaId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
