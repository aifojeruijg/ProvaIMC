using API_IMC.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Imc> Imcs { get; set; }
        
    }
}