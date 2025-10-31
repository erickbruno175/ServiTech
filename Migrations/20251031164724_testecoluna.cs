using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServiTech.Migrations
{
    /// <inheritdoc />
    public partial class testecoluna : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Preço",
                table: "Serviços",
                newName: "Preco");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Serviços",
                newName: "Nome");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Preco",
                table: "Serviços",
                newName: "Preço");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Serviços",
                newName: "Name");
        }
    }
}
