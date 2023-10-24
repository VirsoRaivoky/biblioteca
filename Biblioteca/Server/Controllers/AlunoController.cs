using Biblioteca.Server.Data;
using Biblioteca.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private readonly DataContext _context;

        public AlunoController(DataContext context)
        {
            _context = context;
        }

        public async Task<ActionResult<List<Aluno>>> GetAllAlunos()
        {
            var list = await _context.Alunos.ToListAsync();

            return Ok(list);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<Aluno>>> GetAlunos(int id)
        {
            var dbAluno = await _context.Alunos.FindAsync(id);
            if (dbAluno == null)
            {
                return NotFound("Esse Aluno não existe!");
            }

            return Ok(dbAluno);
        }

        [HttpPost]
        public async Task<ActionResult<List<Aluno>>> CreateAluno(Aluno Aluno)
        {
            _context.Alunos.Add(Aluno);
            await _context.SaveChangesAsync();

            return await GetAllAlunos();
        }

        [HttpPut("{id}")]

        public async Task<ActionResult<List<Aluno>>> UpdateAluno(int id, Aluno Aluno)
        {
            var dbAluno = await _context.Alunos.FindAsync(id);

            if (dbAluno == null)
            {
                return NotFound("Esse Aluno não existe!");
            }

            dbAluno.Name = Aluno.Name;
            dbAluno.Email = Aluno.Email;
            dbAluno.Telefone = Aluno.Telefone;
            dbAluno.Serie = Aluno.Serie;
            dbAluno.Turma = Aluno.Turma;

            await _context.SaveChangesAsync();

            return await GetAllAlunos();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Aluno>>> DeleteAluno(int id)
        {
            var dbAluno = await _context.Alunos.FindAsync(id);

            if (dbAluno == null)
            {
                return NotFound("Esse Aluno não existe!");
            }

            _context.Alunos.Remove(dbAluno);
            await _context.SaveChangesAsync();

            return await GetAllAlunos();
        }
    }
}
