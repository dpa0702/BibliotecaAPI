using BibliotecaAPI.Entidades;
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

        private readonly ILogger<ReservasControle> _logger;

        public ReservasControle(ILogger<ReservasControle> logger)
        {
            _logger = logger;
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
