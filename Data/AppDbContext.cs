using Microsoft.EntityFrameworkCore;
using ProjetoLoginAPI.Classes;

namespace ProjetoLoginAPI.Data
{
    public class AppDbContext : DbContext
    {
        DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Banco.sqlite");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
