using Biblioteca.Server.Data;
using Biblioteca.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservaController : ControllerBase
    {
        private readonly DataContext _context;

        public ReservaController(DataContext context)
        {
            _context = context;
        }
        public async Task<ActionResult<List<Reserva>>> GetAllReservas()
        {
            var list = await _context.Reserva.ToListAsync();

            return Ok(list);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<Aluno>>> GetReservas(int id)
        {
            var dbReserva = await _context.Reserva.FindAsync(id);
            if (dbReserva == null)
            {
                return NotFound("Essa Reserva não existe!");
            }

            return Ok(dbReserva);
        }

        [HttpPost]
        public async Task<ActionResult<List<Reserva>>> CreateReserva(Reserva reserva)
        {
            _context.Reserva.Add(reserva);
            await _context.SaveChangesAsync();

            return await GetAllReservas();
        }
    }
}
