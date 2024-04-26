using BibliotecaAPI.Entidades;
using BibliotecaAPI.Enums;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace BibliotecaAPI.Controles
{
    [ApiController]
    [Route("ClientesControle")]
    public class ClientesControle
    {
        private static readonly int[] identificadores = new[]
        {
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10
        };

        private static readonly string[] nomes = new[]
        {
            "nomes 1", "nomes 2", "nomes 3", "nomes 4", "nomes 5", "nomes 6", "nomes 7", "nomes 8", "nomes 9", "nomes 10"
        };

        private static readonly string[] telefones = new[]
        {
            "nomes 1", "nomes 2", "nomes 3", "nomes 4", "nomes 5", "nomes 6", "nomes 7", "nomes 8", "nomes 9", "nomes 10"
        };

        private static readonly string[] emails = new[]
        {
            "nomes 1", "nomes 2", "nomes 3", "nomes 4", "nomes 5", "nomes 6", "nomes 7", "nomes 8", "nomes 9", "nomes 10"
        };

        private static readonly string[] enderecos = new[]
        {
            "nomes 1", "nomes 2", "nomes 3", "nomes 4", "nomes 5", "nomes 6", "nomes 7", "nomes 8", "nomes 9", "nomes 10"
        };

        private static readonly TipoDocumento[] tiposDocumento = new[]
        {
            TipoDocumento.RG, TipoDocumento.CNH, TipoDocumento.CPF, TipoDocumento.PASSAPORTE, TipoDocumento.CNH, TipoDocumento.RG, TipoDocumento.CPF, TipoDocumento.PASSAPORTE, TipoDocumento.CPF, TipoDocumento.RG
        };

        private readonly ILogger<ClientesControle> _logger;

        public ClientesControle(ILogger<ClientesControle> logger)
        {
            _logger = logger;
        }

        [HttpGet("ConsultarTodos")]
        public IEnumerable<Clientes> ConsultarTodos()
        {
            return Enumerable.Range(1, 10).Select(index => new Clientes
            {
                idCliente = identificadores[Random.Shared.Next(identificadores.Length)],
                nome = nomes[Random.Shared.Next(nomes.Length)],
                telefone = telefones[Random.Shared.Next(telefones.Length)],
                email = telefones[Random.Shared.Next(emails.Length)],
                endereco = telefones[Random.Shared.Next(enderecos.Length)],
                tipoDocumento = tiposDocumento[Random.Shared.Next(tiposDocumento.Length)],
            })
            .ToArray();
        }

        [HttpGet("Consultar")]
        public Clientes Consultar(int idCliente)
        {
            if (idCliente < 10 && idCliente > 1)
            {
                return Enumerable.Range(1, 10).Select(index => new Clientes
                {
                    idCliente = identificadores[idCliente - 1],
                    nome = nomes[idCliente - 1],
                    telefone = telefones[idCliente - 1],
                    email = emails[idCliente - 1],
                    endereco = enderecos[idCliente - 1],
                    tipoDocumento = tiposDocumento[idCliente - 1],
                }).First();
            }
            else
            {
                return Enumerable.Range(1, 10).Select(index => new Clientes
                {
                    idCliente = identificadores[5],
                    nome = nomes[5],
                    telefone = telefones[5],
                    email = emails[5],
                    endereco = enderecos[5],
                    tipoDocumento = tiposDocumento[5],
                }).First();
            }
        }

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
