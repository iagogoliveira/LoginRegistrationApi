namespace ProjetoLoginAPI.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get;  set; }
        public bool Ativo { get;  set; }
        public string Login { get; set; }
        public string Email { get;  set; }
        public string Senha { get;  set; }

        public Usuario(string nome, string login, string senha, string email) 
        {
            Nome= nome;
            Ativo= true;
            Login = login;
            Email = email;
            Senha= senha;
        }

    }
}
