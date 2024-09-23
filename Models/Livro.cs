namespace ProjetoLoginAPI.Models
{
    public class Livro
    {
        public int LivroId { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Isbn { get; set; }
        public string Editora { get; set; }
        public DateTime AnoPublicacao { get; set; }
        public int Edicao { get; set; }
        public int NumeroPaginas { get; set; }
        public int NumeroExemplares { get; set; }
        public DateTime DataAquisicao { get; set; }

        public ICollection<LivroCategoria> LivroCategorias { get; set; } = new List<LivroCategoria>();
    }
}
