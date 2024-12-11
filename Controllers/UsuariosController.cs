using Microsoft.AspNetCore.Mvc;
using ProjetoLoginAPI.Models;
using ProjetoLoginAPI.DTOs;
using ProjetoLoginAPI.Services;
namespace ProjetoLoginAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuariosController : ControllerBase
    {

        private readonly UsuarioServices _usuarioServices;
        public UsuariosController(UsuarioServices usuarioServices)
        {
            _usuarioServices = usuarioServices;
        }

        [HttpPost("Cadastro")]
        public IActionResult CadastrarUsuario([FromBody] CriarUsuarioDto usuarioDto)
        {

            if(usuarioDto == null)
            {
                return BadRequest("Usuário não pode ser nulo.");
            }


            var usuario = new Usuario(usuarioDto.Nome, usuarioDto.Login, usuarioDto.Senha, usuarioDto.Email);

            try
            {
                _usuarioServices.RegistrarUsuario(usuario);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return BadRequest(ex.Message);
            }


            return Ok();

        }

        [HttpPost("Login")]
        public IActionResult LoginUsuario([FromBody] LoginUsuarioDto loginDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            bool sucessoLogin = _usuarioServices.AutenticarUsuario(loginDto.Login, loginDto.Senha);

            if (sucessoLogin)
            {
                return Ok(new { message = "Login bem sucedido."});
            }
            else
            {
                return Unauthorized(new { message = "Credenciais inválidas."});
            }
        }
    }
}
