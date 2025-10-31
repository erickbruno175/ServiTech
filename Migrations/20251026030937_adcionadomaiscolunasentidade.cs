using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServiTech.Migrations
{
    /// <inheritdoc />
    public partial class adcionadomaiscolunasentidade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UnidadeMedida",
                table: "Produto",
                newName: "UnidadeMedidaSaida");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataValidade",
                table: "Produto",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UnidadeMedidaEntrada",
                table: "Produto",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataValidade",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "UnidadeMedidaEntrada",
                table: "Produto");

            migrationBuilder.RenameColumn(
                name: "UnidadeMedidaSaida",
                table: "Produto",
                newName: "UnidadeMedida");
        }
    }
}
