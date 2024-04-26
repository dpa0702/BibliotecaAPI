using BibliotecaAPI.Entidades;
using BibliotecaAPI.Enums;
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

        private static readonly int[] identificadoresLivros = new[]
        {
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10
        };

        private static readonly int[] identificadoresCliente = new[]
        {
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10
        };

        private static readonly StatusLocacao[] statusLocacaos = new[]
        {
            StatusLocacao.Disponivel, StatusLocacao.Emprestado, StatusLocacao.Disponivel, StatusLocacao.Disponivel, StatusLocacao.Disponivel, StatusLocacao.Excluido, StatusLocacao.Disponivel, StatusLocacao.Emprestado, StatusLocacao.Disponivel, StatusLocacao.Excluido
        };

        private readonly ILogger<LocacoesControle> _logger;

        public LocacoesControle(ILogger<LocacoesControle> logger)
        {
            _logger = logger;
        }

        [HttpGet("ConsultarTodos")]
        public IEnumerable<Locacao> ConsultarTodos()
        {
            return Enumerable.Range(1, 10).Select(index => new Locacao
            {
                idLocacao = identificadores[Random.Shared.Next(identificadores.Length)],
                livroId = identificadoresLivros[Random.Shared.Next(identificadoresLivros.Length)],
                clienteId = identificadoresCliente[Random.Shared.Next(identificadoresCliente.Length)],
                dataLocacao = DateTime.UtcNow,
                dataVendimento = DateTime.UtcNow,
                statusLocacao = statusLocacaos[Random.Shared.Next(statusLocacaos.Length)],
            })
            .ToArray();
        }

        [HttpGet("Consultar")]
        public Locacao Consultar(int idLocacao)
        {
            if (idLocacao < 10 && idLocacao > 1)
            {
                return Enumerable.Range(1, 10).Select(index => new Locacao
                {
                    idLocacao = identificadores[idLocacao - 1],
                    livroId = identificadoresLivros[idLocacao - 1],
                    clienteId = identificadoresCliente[idLocacao - 1],
                    dataLocacao = DateTime.UtcNow,
                    dataVendimento = DateTime.UtcNow,
                    statusLocacao = statusLocacaos[idLocacao - 1],
                    dataExclusao = DateTime.UtcNow,
                }).First();
            }
            else
            {
                return Enumerable.Range(1, 10).Select(index => new Locacao
                {
                    idLocacao = identificadores[5],
                    livroId = identificadoresLivros[5],
                    clienteId = identificadoresCliente[5],
                    dataLocacao = DateTime.UtcNow,
                    dataVendimento = DateTime.UtcNow,
                    statusLocacao = statusLocacaos[5],
                    dataExclusao = DateTime.UtcNow,
                }).First();
            }
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
