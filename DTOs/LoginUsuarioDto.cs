using System.ComponentModel.DataAnnotations;

namespace ProjetoLoginAPI.DTOs
{
    public class LoginUsuarioDto
    {
        public string Login { get; set; }
        public string Senha { get; set; }
    }
}
