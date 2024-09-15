using Microsoft.EntityFrameworkCore;
using ProjetoLoginAPI.Classes;
using ProjetoLoginAPI.Data;

namespace ProjetoLoginAPI.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly AppDbContext _context;

        public UsuarioRepository(AppDbContext context) { _context = context; }



        public void Adicionar(Usuario usuario)
        {
            _context.Add(usuario);
            _context.SaveChanges();
        }



        public async Task<Usuario> obterPorLoginAsync(string login)
        {
            return await _context.Set<Usuario>()
                                 .FirstOrDefaultAsync(u => u.Login == login);
        }
    }
}
