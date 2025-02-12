using Microsoft.EntityFrameworkCore;
using ProjetoLoginAPI.Models;

namespace ProjetoLoginAPI.Data
{
    public class AppDbContext : DbContext
    {
        DbSet<User> Users { get; set; }
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=master;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
