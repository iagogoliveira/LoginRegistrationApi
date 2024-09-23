using ProjetoLoginAPI.Models;

namespace ProjetoLoginAPI.Repositories
{
    public interface IUsuarioRepository
    {
        void Adicionar(Usuario usuario);

        Task<Usuario> obterPorLoginAsync(string login);
    }
}
