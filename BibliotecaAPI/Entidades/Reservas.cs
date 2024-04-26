using BibliotecaAPI.Enums;

namespace BibliotecaAPI.Entidades
{
    public class Reservas
    {
        public int idReserva { get; set; }
        public required int LivroId { get; set; }
        public required int clienteId { get; set; }
        public DateTime dataPossivelLocacao { get; set; }
        public TipoReserva tipoReserva { get; set; }
    }
}
