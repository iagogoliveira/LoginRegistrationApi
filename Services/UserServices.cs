using ProjetoLoginAPI.Models;
using ProjetoLoginAPI.Repositories;

namespace ProjetoLoginAPI.Services
{
    public class UserServices
    {
        private readonly IUserRepository _userRepository;

        public UserServices(IUserRepository usuarioRepository)
        {
            _userRepository = usuarioRepository;
        }

        public void CreateUser(User user)
        {
            user.Password = PasswordCriptografy.GeneratePasswordHash(user.Password);

            _userRepository.Add(user);
        }

        public bool AuthenticateUser(string userLogin, string userPassword)
        {
            var user = _userRepository.getLoginAsync(userLogin);

            if (user.Result != null && PasswordCriptografy.ValidPassword(userPassword, user.Result.Password))
            {
                return true;
            }

            return false;
        } 

    }
}
