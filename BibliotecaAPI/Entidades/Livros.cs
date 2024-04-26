using BibliotecaAPI.Enums;

namespace BibliotecaAPI.Entidades
{
    public class Livros
    {
        public int idLivro { get; set; }
        public required string nome { get; set; }
        public required string autor { get; set;}
        public required TipoGenero tipoGenero { get; set;}
    }
}
