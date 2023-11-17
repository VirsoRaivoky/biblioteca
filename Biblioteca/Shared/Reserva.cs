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
        public int IdLivro { get; set; }
        public string LivroNome { get; set; } = string.Empty;
        public string AlunoNome { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Turma { get; set; } = string.Empty;
        public string Situacao { get; set; } = string.Empty; 
        public DateTime DataReserva { get; set; }

    }
}
