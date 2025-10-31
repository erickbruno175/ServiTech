using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServiTech.Migrations
{
    /// <inheritdoc />
    public partial class teste : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FotoProduto",
                table: "Produto");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Produto",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "Codigo",
                table: "Produto",
                newName: "CodigoProdutpBalanca");

            migrationBuilder.AlterColumn<int>(
                name: "Tamanho",
                table: "Produto",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<bool>(
                name: "PermitidoDesconto",
                table: "Produto",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CodigoInterno",
                table: "Produto",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<bool>(
                name: "Ativo",
                table: "Produto",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Produto",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "CodigoProdutpBalanca",
                table: "Produto",
                newName: "Codigo");

            migrationBuilder.AlterColumn<string>(
                name: "Tamanho",
                table: "Produto",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "PermitidoDesconto",
                table: "Produto",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "CodigoInterno",
                table: "Produto",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "Ativo",
                table: "Produto",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddColumn<byte[]>(
                name: "FotoProduto",
                table: "Produto",
                type: "varbinary(max)",
                nullable: true);
        }
    }
}
