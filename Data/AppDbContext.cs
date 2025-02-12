using Microsoft.EntityFrameworkCore;
using ProjetoLoginAPI.Models;

namespace ProjetoLoginAPI.Data
{
    public class AppDbContext : DbContext
    {
        DbSet<User> Users { get; set; }
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=urlShortener;Trusted_Connection=True;TrustServerCertificate=True;",
                            options => options.MigrationsHistoryTable("__MigrationsHistory_LoginRegister"));

            base.OnConfiguring(optionsBuilder);
        }
    }
}
