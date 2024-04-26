using BibliotecaAPI.Entidades;
using BibliotecaAPI.Enums;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace BibliotecaAPI.Controles
{
    [ApiController]
    [Route("LivrosControle")]
    public class LivrosControle
    {
        private static readonly int[] identificadores = new[]
        {
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10
        };

        private static readonly string[] nomes = new[]
        {
            "nomes 1", "nomes 2", "nomes 3", "nomes 4", "nomes 5", "nomes 6", "nomes 7", "nomes 8", "nomes 9", "nomes 10"
        };

        private static readonly string[] autores = new[]
        {
            "autores 1", "autores 2", "autores 3", "autores 4", "autores 5", "autores 6", "autores 7", "autores 8", "autores 9", "autores 10"
        };

        private static readonly TipoGenero[] tiposGenero = new[]
        {
            TipoGenero.Romance, TipoGenero.Viagem, TipoGenero.Terror, TipoGenero.Fantasia, TipoGenero.Autoajuda, TipoGenero.Romance, TipoGenero.Viagem, TipoGenero.Terror, TipoGenero.Fantasia, TipoGenero.Autoajuda
        };

        private readonly ILogger<LivrosControle> _logger;

        public LivrosControle(ILogger<LivrosControle> logger)
        {
            _logger = logger;
        }

        [HttpGet("ConsultarTodos")]
        public IEnumerable<Livros> ConsultarTodos()
        {
            return Enumerable.Range(1, 10).Select(index => new Livros
            {
                idLivro = identificadores[Random.Shared.Next(identificadores.Length)],
                nome = nomes[Random.Shared.Next(nomes.Length)],
                autor = autores[Random.Shared.Next(autores.Length)],
                tipoGenero = tiposGenero[Random.Shared.Next(tiposGenero.Length)],
            })
            .ToArray();
        }

        [HttpGet("Consultar")]
        public Livros Consultar(int idLivro)
        {
            if (idLivro < 10 && idLivro > 1)
            {
                return Enumerable.Range(1, 10).Select(index => new Livros
                {
                    idLivro = identificadores[idLivro - 1],
                    nome = nomes[idLivro - 1],
                    autor = autores[idLivro - 1],
                    tipoGenero = tiposGenero[idLivro - 1],
                }).First();
            }
            else
            {
                return Enumerable.Range(1, 10).Select(index => new Livros
                {
                    idLivro = identificadores[5],
                    nome = nomes[5],
                    autor = autores[5],
                    tipoGenero = tiposGenero[5],
                }).First();
            }
        }

        [HttpPost("Cadastrar")]
        public HttpStatusCode Cadastrar(Livros livro)
        {
            return HttpStatusCode.OK;
        }

        [HttpPut("Editar")]
        public HttpStatusCode Editar(Livros livro)
        {
            return HttpStatusCode.OK;
        }
    }
}
