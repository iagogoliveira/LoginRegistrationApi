using ProjetoLoginAPI.Models;

namespace ProjetoLoginAPI.Repositories
{
    public interface IUserRepository
    {
        void Add(User user);

        Task<User> getLoginAsync(string login);
    }
}
