using Credi_Gestion.Models;
using Microsoft.EntityFrameworkCore;

namespace Credi_Gestion.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> Options) : base(Options)
        {

        }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Prestamo> Prestamo { get; set; }
        public DbSet<Pagos> Pagos { get; set; }
    }
}
