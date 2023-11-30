using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Loja_Classe_Abstrata.Migrations
{
    /// <inheritdoc />
    public partial class dois : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Produtos",
                newName: "Cor");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Cor",
                table: "Produtos",
                newName: "Nome");
        }
    }
}
