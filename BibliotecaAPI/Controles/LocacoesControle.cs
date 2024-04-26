using BibliotecaAPI.Entidades;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace BibliotecaAPI.Controles
{
    [ApiController]
    [Route("LocacoesControle")]
    public class LocacoesControle
    {
        private static readonly int[] identificadores = new[]
        {
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10
        };

        private readonly ILogger<LocacoesControle> _logger;

        public LocacoesControle(ILogger<LocacoesControle> logger)
        {
            _logger = logger;
        }

        [HttpPost("Cadastrar")]
        public HttpStatusCode Cadastrar(Locacao locacao)
        {
            return HttpStatusCode.OK;
        }

        [HttpPut("Editar")]
        public HttpStatusCode Editar(Locacao locacao)
        {
            return HttpStatusCode.OK;
        }
    }
}
