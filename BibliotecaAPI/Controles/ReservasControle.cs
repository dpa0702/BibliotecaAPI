using BibliotecaAPI.Entidades;
using BibliotecaAPI.Enums;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace BibliotecaAPI.Controles
{
    [ApiController]
    [Route("ReservasControle")]
    public class ReservasControle
    {
        private static readonly int[] identificadores = new[]
        {
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10
        };

        private static readonly int[] identificadoresLivros = new[]
        {
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10
        };

        private static readonly int[] identificadoresCliente = new[]
        {
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10
        };

        private static readonly TipoReserva[] tipoReservas = new[]
        {
            TipoReserva.Emprestado, TipoReserva.Emprestado, TipoReserva.Emprestado, TipoReserva.Reservado, TipoReserva.Cancelado, TipoReserva.Reservado, TipoReserva.Cancelado, TipoReserva.Cancelado, TipoReserva.Reservado, TipoReserva.Emprestado
        };

        private readonly ILogger<ReservasControle> _logger;

        public ReservasControle(ILogger<ReservasControle> logger)
        {
            _logger = logger;
        }

        [HttpGet("ConsultarTodos")]
        public IEnumerable<Reservas> ConsultarTodos()
        {
            return Enumerable.Range(1, 10).Select(index => new Reservas
            {
                idReserva = identificadores[Random.Shared.Next(identificadores.Length)],
                livroId = identificadoresLivros[Random.Shared.Next(identificadoresLivros.Length)],
                clienteId = identificadoresCliente[Random.Shared.Next(identificadoresCliente.Length)],
                dataPossivelLocacao = DateTime.UtcNow,
                tipoReserva = tipoReservas[Random.Shared.Next(tipoReservas.Length)],
            })
            .ToArray();
        }

        [HttpGet("Consultar")]
        public Reservas Consultar(int idReserva)
        {
            if (idReserva < 10 && idReserva > 1)
            {
                return Enumerable.Range(1, 10).Select(index => new Reservas
                {
                    idReserva = identificadores[idReserva - 1],
                    livroId = identificadoresLivros[idReserva - 1],
                    clienteId = identificadoresCliente[idReserva - 1],
                    dataPossivelLocacao = DateTime.UtcNow,
                    tipoReserva = tipoReservas[idReserva - 1],
                }).First();
            }
            else
            {
                return Enumerable.Range(1, 10).Select(index => new Reservas
                {
                    idReserva = identificadores[5],
                    livroId = identificadoresLivros[5],
                    clienteId = identificadoresCliente[5],
                    dataPossivelLocacao = DateTime.UtcNow,
                    tipoReserva = tipoReservas[5],
                }).First();
            }
        }

        [HttpPost("Cadastrar")]
        public HttpStatusCode Cadastrar(Reservas reservas)
        {
            return HttpStatusCode.OK;
        }

        [HttpPut("Editar")]
        public HttpStatusCode Editar(Reservas reservas)
        {
            return HttpStatusCode.OK;
        }
    }
}
