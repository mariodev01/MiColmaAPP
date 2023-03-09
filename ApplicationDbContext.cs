using MiColmaAPP_API.Models;
using MiColmaAPP_API.Seeding;
using Microsoft.EntityFrameworkCore;

namespace MiColmaAPP_API
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<OrdenProducto>().HasKey(p => new { p.OrdenID, p.ProductoID });
            ColmadoSeeding.Seed(builder);
        }

        DbSet<Cliente> Clientes { get; set; }
        DbSet<Producto> Productos { get; set; }
        DbSet<Orden> Ordenes { get; set; }
        DbSet<OrdenProducto> OrdenProducto { get; set; }
    }
}
