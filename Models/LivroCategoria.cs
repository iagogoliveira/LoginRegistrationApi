namespace ProjetoLoginAPI.Models
{
    public class LivroCategoria
    {
        public int LivroId { get; set; }
        public Livro Livro { get; set; }

        public int CategoriaId { get; set; }
        public CategoriaLivro Categoria { get; set; }
    }
}
