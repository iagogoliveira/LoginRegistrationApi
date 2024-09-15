using System.Security.Cryptography;

namespace ProjetoLoginAPI.Services
{
    public class CriptografiaSenha
    {
        public static string GerarHashSenha(string password)
        {
            // Cria o salt aleatório (16 bytes)
            byte[] salt = RandomNumberGenerator.GetBytes(16);

            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000, HashAlgorithmName.SHA256))
            {
                // Gera 32 bytes para o hash da senha
                byte[] hash = pbkdf2.GetBytes(32);
                // Combina o salt e o hash em um único array
                byte[] hashBytes = new byte[48]; 

                Array.Copy(salt, 0, hashBytes, 0, 16);
                Array.Copy(hash, 0, hashBytes, 16, 32);


                // Retorna o hash e o salt como uma string Base64
                return Convert.ToBase64String(hashBytes);
            }
        }
        public static bool SenhaValida(string password, string storedHash)
        {
            // Extrai o array de bytes do hash armazenado
            byte[] hashBytes = Convert.FromBase64String(storedHash);

            // Extrai o salt dos primeiros 16 bytes
            byte[] salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);

            // Usa o salt para gerar o hash da senha informada
            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000, HashAlgorithmName.SHA256))
            {
                byte[] hash = pbkdf2.GetBytes(32);

                // Compara o hash gerado com o hash armazenado
                for (int i = 0; i < 32; i++)
                {
                    if (hashBytes[i + 16] != hash[i])
                    {
                        return false;
                    }
                }

                return true;
            }
        }





    }
}
