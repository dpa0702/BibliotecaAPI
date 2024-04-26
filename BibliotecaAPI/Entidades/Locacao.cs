using BibliotecaAPI.Enums;

namespace BibliotecaAPI.Entidades
{
    public class Locacao
    {
        public int idLocacao { get; set; }
        public required int LivroId { get; set; }
        public required int clienteId { get; set; }
        public DateTime dataLocacao { get; set; }
        public DateTime dataVendimento { get; set; }
        public StatusLocacao statusLocacao { get; set; }
        public DateTime dataExclusao { get; set; }
    }
}
