using ProjetoLoginAPI.Classes;
using ProjetoLoginAPI.Repositories;

namespace ProjetoLoginAPI.Services
{
    public class UsuarioServices
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioServices(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public void RegistrarUsuario(Usuario usuario)
        {
            usuario.Senha = CriptografiaSenha.GerarHashSenha(usuario.Senha);

            _usuarioRepository.Adicionar(usuario);
        }

        public bool AutenticarUsuario(string loginUsuario, string senhaUsuario)
        {
            var usuario = _usuarioRepository.obterPorLoginAsync(loginUsuario);

            if (usuario.Result != null && CriptografiaSenha.SenhaValida(senhaUsuario, usuario.Result.Senha))
            {
                return true;
            }

            return false;
        } 

    }
}
