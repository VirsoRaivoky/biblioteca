using Biblioteca.Shared;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {
    
        }

        public DbSet<Livro> Livros { get; set; }
        public DbSet<Aluno> Alunos { get; set; }
      
    }
}
