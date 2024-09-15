using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoLoginAPI.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarDetalhesUsuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Usuarios",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Login",
                table: "Usuarios",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Senha",
                table: "Usuarios",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Login",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Senha",
                table: "Usuarios");
        }
    }
}
