namespace ProjetoLoginAPI.Models
{
    public class CategoriaLivro
    {
        public int CategoriaId { get; set; } // Chave primária
        public string Nome { get; set; }

        // Relacionamento com LivroCategoria
        public ICollection<LivroCategoria> LivroCategorias { get; set; } = new List<LivroCategoria>();
    }
}
