using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoLoginAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddLivrosECategorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoriaLivros",
                columns: table => new
                {
                    CategoriaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriaLivros", x => x.CategoriaId);
                });

            migrationBuilder.CreateTable(
                name: "Livros",
                columns: table => new
                {
                    LivroId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Titulo = table.Column<string>(type: "TEXT", nullable: false),
                    Autor = table.Column<string>(type: "TEXT", nullable: false),
                    Isbn = table.Column<string>(type: "TEXT", nullable: false),
                    Editora = table.Column<string>(type: "TEXT", nullable: false),
                    AnoPublicacao = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Edicao = table.Column<int>(type: "INTEGER", nullable: false),
                    NumeroPaginas = table.Column<int>(type: "INTEGER", nullable: false),
                    NumeroExemplares = table.Column<int>(type: "INTEGER", nullable: false),
                    DataAquisicao = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Livros", x => x.LivroId);
                });

            migrationBuilder.CreateTable(
                name: "LivroCategorias",
                columns: table => new
                {
                    LivroId = table.Column<int>(type: "INTEGER", nullable: false),
                    CategoriaId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LivroCategorias", x => new { x.LivroId, x.CategoriaId });
                    table.ForeignKey(
                        name: "FK_LivroCategorias_CategoriaLivros_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "CategoriaLivros",
                        principalColumn: "CategoriaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LivroCategorias_Livros_LivroId",
                        column: x => x.LivroId,
                        principalTable: "Livros",
                        principalColumn: "LivroId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LivroCategorias_CategoriaId",
                table: "LivroCategorias",
                column: "CategoriaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LivroCategorias");

            migrationBuilder.DropTable(
                name: "CategoriaLivros");

            migrationBuilder.DropTable(
                name: "Livros");
        }
    }
}
