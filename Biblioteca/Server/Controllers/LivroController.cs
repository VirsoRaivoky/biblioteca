using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Biblioteca.Shared;

namespace Biblioteca.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivroController : ControllerBase
    {
        public async Task<ActionResult<List<Livro>>> GetAllLivros()
        {
            var list = new List<Livro>
            {
                new Livro{ Id = 1, Title = "Memo", Author = "M", Code = 15481, Genre = "R", ISBN = 158486, Publisher = "Editora", Year = 1900 } 
            };
            return Ok(list);
        }
    }
}
