
using Microsoft.AspNetCore.Mvc;
using Biblioteca.Shared;
using Biblioteca.Server.Data;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivroController : ControllerBase
    {
        private readonly DataContext _context;

        public LivroController(DataContext context)
        {
            _context = context;
        }

        public async Task<ActionResult<List<Livro>>> GetAllLivros()
        {
            var list = await _context.Livros.ToListAsync();
            
            return Ok(list);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<Livro>>> GetLivros(int id)
        {
            var dbLivro = await _context.Livros.FindAsync(id);
            if (dbLivro == null)
            {
                return NotFound("Esse livro não existe!");
            }

            return Ok(dbLivro);
        }

        [HttpPost]
        public async Task<ActionResult<List<Livro>>> CreateLivro(Livro livro)
        {
            _context.Livros.Add(livro);
            await _context.SaveChangesAsync();

            return await GetAllLivros();
        }

        [HttpPut("{id}")]

        public async Task<ActionResult<List<Livro>>> UpdateLivro(int id, Livro livro)
        {
            var dbLivro = await _context.Livros.FindAsync(id);

            if (dbLivro == null)
            {
                return NotFound("Esse livro não existe!");
            }

            dbLivro.Title = livro.Title;
            dbLivro.Author = livro.Author;
            dbLivro.Genre = livro.Genre;
            dbLivro.Publisher = livro.Publisher;
            dbLivro.Year = livro.Year;
            dbLivro.Code = livro.Code;
            dbLivro.ISBN = livro.ISBN;
            dbLivro.Estoque = livro.Estoque;

            await _context.SaveChangesAsync();

            return await GetAllLivros();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Livro>>> DeleteLivro(int id)
        {
            var dbLivro = await _context.Livros.FindAsync(id);

            if (dbLivro == null)
            {
                return NotFound("Esse livro não existe!");
            }

            _context.Livros.Remove(dbLivro);
            await _context.SaveChangesAsync();

            return await GetAllLivros();
        }
    }
}
