using BibliotecaAPI.Enums;

namespace BibliotecaAPI.Entidades
{
    public class Clientes
    {
        public int idCliente { get; set; }
        public required string nome { get; set; }
        public required string telefone { get; set; }
        public required string email { get; set; }
        public required string endereco { get; set; }
        public required TipoDocumento documentoIdentificacao { get; set; }
    }
}
