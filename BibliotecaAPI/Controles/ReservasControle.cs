using BibliotecaAPI.Entidades;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace BibliotecaAPI.Controles
{
    [ApiController]
    [Route("ReservasControle")]
    public class ReservasControle
    {
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
