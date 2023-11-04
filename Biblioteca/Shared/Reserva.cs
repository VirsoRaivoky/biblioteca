using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Shared
{
    public class Reserva
    {
        public int Id { get; set; }
        public int AlunoId { get; set; }
        public int LivroId { get; set; }
        public DateTime DataReserva { get; set; }
    }
}
