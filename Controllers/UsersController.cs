using Microsoft.AspNetCore.Mvc;
using ProjetoLoginAPI.Models;
using ProjetoLoginAPI.DTOs;
using ProjetoLoginAPI.Services;
namespace ProjetoLoginAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {

        private readonly UserServices _userServices;
        public UsersController(UserServices userServices)
        {
            _userServices = userServices;
        }

        [HttpPost("CreateUser")]
        public IActionResult CreateUser([FromBody] CreateUserDto userDto)
        {

            if(userDto == null)
            {
                return BadRequest("User cannot be null.");
            }


            var user = new User(userDto.Name, userDto.Login, userDto.Password, userDto.Email);

            try
            {
                _userServices.CreateUser(user);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return BadRequest(ex.Message);
            }


            return Ok();

        }

        [HttpPost("Login")]
        public IActionResult UserLogin([FromBody] UserLoginDto loginDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            bool sucessoLogin = _userServices.AuthenticateUser(loginDto.Login, loginDto.Password);

            if (sucessoLogin)
            {
                return Ok(new { message = "Successful Login." });
            }
            else
            {
                return Unauthorized(new { message = "Invalid Credentials."});
            }
        }
    }
}
