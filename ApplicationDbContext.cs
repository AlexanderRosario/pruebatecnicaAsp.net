using Microsoft.EntityFrameworkCore;
using prueba.Models;

namespace prueba
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        
        {
            
        }

        public DbSet<Cliente> Clientes {get; set;}
        public DbSet<Direccion> Direcciones {get;set;}
    }
    
}