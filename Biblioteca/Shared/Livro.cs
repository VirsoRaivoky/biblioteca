using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Shared
{
    public class Livro
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        public string? Genre { get; set; }
        public string? Publisher { get; set; }
        public int Estoque { get; set; }
        public int Year { get; set; }
        public int Code { get; set; }
        public int ISBN { get; set; }

    }
}
