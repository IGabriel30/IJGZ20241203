using Microsoft.EntityFrameworkCore;

namespace IJGZ20241203.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Proveedor> Proveedors { get; set; }

        public DbSet<DireccionProveedor> Direcciones { get; set; }

    }
}
