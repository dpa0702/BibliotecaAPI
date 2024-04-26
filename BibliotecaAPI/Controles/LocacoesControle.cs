using BibliotecaAPI.Entidades;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace BibliotecaAPI.Controles
{
    [ApiController]
    [Route("LocacoesControle")]
    public class LocacoesControle
    {
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
