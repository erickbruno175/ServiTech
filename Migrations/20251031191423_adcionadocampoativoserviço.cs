using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServiTech.Migrations
{
    /// <inheritdoc />
    public partial class adcionadocampoativoserviço : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "Serviços",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "Serviços");
        }
    }
}
