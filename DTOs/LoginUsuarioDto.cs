using System.ComponentModel.DataAnnotations;

namespace ProjetoLoginAPI.DTOs
{
    public class LoginUsuarioDto
    {
        [Required(ErrorMessage = "O Login é obrigatório.")]
        public string Login { get; set; }
        [Required(ErrorMessage = "A senha é obrigatória.")]
        public string Senha { get; set; }
    }
}
