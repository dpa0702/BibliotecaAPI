using BibliotecaAPI.Entidades;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace BibliotecaAPI.Controles
{
    [ApiController]
    [Route("ClientesControle")]
    public class ClientesControle
    {
        [HttpPost("Cadastrar")]
        public HttpStatusCode Cadastrar(Clientes clientes)
        {
            return HttpStatusCode.OK;
        }

        [HttpPut("Editar")]
        public HttpStatusCode Editar(Clientes clientes)
        {
            return HttpStatusCode.OK;
        }
    }
}
