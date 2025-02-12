using Microsoft.EntityFrameworkCore;
using ProjetoLoginAPI.Models;
using ProjetoLoginAPI.Data;

namespace ProjetoLoginAPI.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context) { _context = context; }



        public void Add(User user)
        {
            _context.Add(user);
            _context.SaveChanges();
        }



        public async Task<User> getLoginAsync(string login)
        {
            return await _context.Set<User>()
                                 .FirstOrDefaultAsync(u => u.Login == login);
        }
    }
}
