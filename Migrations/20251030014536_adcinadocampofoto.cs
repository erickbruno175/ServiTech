using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServiTech.Migrations
{
    /// <inheritdoc />
    public partial class adcinadocampofoto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "FotoProduto",
                table: "Produto",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FotoProduto",
                table: "Produto");
        }
    }
}
