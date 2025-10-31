using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServiTech.Migrations
{
    /// <inheritdoc />
    public partial class adcionadomaisumacolunas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CodigoProdutpBalanca",
                table: "Produto",
                newName: "CodigoBalanca");

            migrationBuilder.RenameColumn(
                name: "CodigoBarra",
                table: "Produto",
                newName: "CodigoBarraEAN");

            migrationBuilder.RenameIndex(
                name: "IX_Produto_CodigoBarra",
                table: "Produto",
                newName: "IX_Produto_CodigoBarraEAN");

            migrationBuilder.AddColumn<bool>(
                name: "ProdutoBalanca",
                table: "Produto",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProdutoBalanca",
                table: "Produto");

            migrationBuilder.RenameColumn(
                name: "CodigoBarraEAN",
                table: "Produto",
                newName: "CodigoBarra");

            migrationBuilder.RenameColumn(
                name: "CodigoBalanca",
                table: "Produto",
                newName: "CodigoProdutpBalanca");

            migrationBuilder.RenameIndex(
                name: "IX_Produto_CodigoBarraEAN",
                table: "Produto",
                newName: "IX_Produto_CodigoBarra");
        }
    }
}
