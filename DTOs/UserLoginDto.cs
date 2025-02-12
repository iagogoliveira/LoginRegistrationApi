using System.ComponentModel.DataAnnotations;

namespace ProjetoLoginAPI.DTOs
{
    public class UserLoginDto
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
