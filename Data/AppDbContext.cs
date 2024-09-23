using Microsoft.EntityFrameworkCore;
using ProjetoLoginAPI.Models;

namespace ProjetoLoginAPI.Data
{
    public class AppDbContext : DbContext
    {
        DbSet<Usuario> Usuarios { get; set; }
        DbSet<Livro> Livros { get; set; }
        DbSet<CategoriaLivro> CategoriaLivros { get; set; }
        DbSet<LivroCategoria> LivroCategorias { get; set; } // Tabela intermediária


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Banco.sqlite");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Define a chave primária para CategoriaLivro
            modelBuilder.Entity<CategoriaLivro>()
                .HasKey(c => c.CategoriaId);

            // Define a chave primária composta para LivroCategoria
            modelBuilder.Entity<LivroCategoria>()
                .HasKey(lc => new { lc.LivroId, lc.CategoriaId });

            // Configuração da relação entre Livro e LivroCategoria
            modelBuilder.Entity<LivroCategoria>()
                .HasOne(lc => lc.Livro)
                .WithMany(l => l.LivroCategorias)
                .HasForeignKey(lc => lc.LivroId);

            // Configuração da relação entre Categoria e LivroCategoria
            modelBuilder.Entity<LivroCategoria>()
                .HasOne(lc => lc.Categoria)
                .WithMany(c => c.LivroCategorias)
                .HasForeignKey(lc => lc.CategoriaId);
        }
    }
}
