using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServiTech.Migrations
{
    /// <inheritdoc />
    public partial class mudançanosatributosclasseproduto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produto_CFOPs_CfopId",
                table: "Produto");

            migrationBuilder.DropForeignKey(
                name: "FK_Produto_CSTCSOSNs_CstId",
                table: "Produto");

            migrationBuilder.DropForeignKey(
                name: "FK_Produto_Marcas_MarcaFabricanteId",
                table: "Produto");

            migrationBuilder.DropForeignKey(
                name: "FK_Produto_Ncms_NcmId",
                table: "Produto");

            migrationBuilder.DropForeignKey(
                name: "FK_Produto_OrigemMercadorias_OrigemMercadoriaId",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "UltimaEntrada",
                table: "Produto");

            migrationBuilder.RenameColumn(
                name: "UltimaSaida",
                table: "Produto",
                newName: "UltimaCompra");

            migrationBuilder.AlterColumn<int>(
                name: "SubGrupoId",
                table: "Produto",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "OrigemMercadoriaId",
                table: "Produto",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "NcmId",
                table: "Produto",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MarcaFabricanteId",
                table: "Produto",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "GrupoId",
                table: "Produto",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "FornecedorId",
                table: "Produto",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CstId",
                table: "Produto",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CfopId",
                table: "Produto",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<decimal>(
                name: "COFINS",
                table: "Produto",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Codigo",
                table: "Produto",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CodigoBarraAlternativo",
                table: "Produto",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "ICMS",
                table: "Produto",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "IPI",
                table: "Produto",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PIS",
                table: "Produto",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "QuantidadeMaxima",
                table: "Produto",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "UltimoPreco",
                table: "Produto",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddForeignKey(
                name: "FK_Produto_CFOPs_CfopId",
                table: "Produto",
                column: "CfopId",
                principalTable: "CFOPs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Produto_CSTCSOSNs_CstId",
                table: "Produto",
                column: "CstId",
                principalTable: "CSTCSOSNs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Produto_Marcas_MarcaFabricanteId",
                table: "Produto",
                column: "MarcaFabricanteId",
                principalTable: "Marcas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Produto_Ncms_NcmId",
                table: "Produto",
                column: "NcmId",
                principalTable: "Ncms",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Produto_OrigemMercadorias_OrigemMercadoriaId",
                table: "Produto",
                column: "OrigemMercadoriaId",
                principalTable: "OrigemMercadorias",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produto_CFOPs_CfopId",
                table: "Produto");

            migrationBuilder.DropForeignKey(
                name: "FK_Produto_CSTCSOSNs_CstId",
                table: "Produto");

            migrationBuilder.DropForeignKey(
                name: "FK_Produto_Marcas_MarcaFabricanteId",
                table: "Produto");

            migrationBuilder.DropForeignKey(
                name: "FK_Produto_Ncms_NcmId",
                table: "Produto");

            migrationBuilder.DropForeignKey(
                name: "FK_Produto_OrigemMercadorias_OrigemMercadoriaId",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "COFINS",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "Codigo",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "CodigoBarraAlternativo",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "ICMS",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "IPI",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "PIS",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "QuantidadeMaxima",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "UltimoPreco",
                table: "Produto");

            migrationBuilder.RenameColumn(
                name: "UltimaCompra",
                table: "Produto",
                newName: "UltimaSaida");

            migrationBuilder.AlterColumn<int>(
                name: "SubGrupoId",
                table: "Produto",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OrigemMercadoriaId",
                table: "Produto",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "NcmId",
                table: "Produto",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MarcaFabricanteId",
                table: "Produto",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "GrupoId",
                table: "Produto",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FornecedorId",
                table: "Produto",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CstId",
                table: "Produto",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CfopId",
                table: "Produto",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UltimaEntrada",
                table: "Produto",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Produto_CFOPs_CfopId",
                table: "Produto",
                column: "CfopId",
                principalTable: "CFOPs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Produto_CSTCSOSNs_CstId",
                table: "Produto",
                column: "CstId",
                principalTable: "CSTCSOSNs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Produto_Marcas_MarcaFabricanteId",
                table: "Produto",
                column: "MarcaFabricanteId",
                principalTable: "Marcas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Produto_Ncms_NcmId",
                table: "Produto",
                column: "NcmId",
                principalTable: "Ncms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Produto_OrigemMercadorias_OrigemMercadoriaId",
                table: "Produto",
                column: "OrigemMercadoriaId",
                principalTable: "OrigemMercadorias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
