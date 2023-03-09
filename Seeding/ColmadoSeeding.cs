using MiColmaAPP_API.Models;
using Microsoft.EntityFrameworkCore;

namespace MiColmaAPP_API.Seeding
{
    public static class ColmadoSeeding
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            var cliente1 = new Cliente() { Id = 1, Nombre = "Mario" };
            var cliente2 = new Cliente() { Id = 2, Nombre = "Biembo" };
            var cliente3 = new Cliente() { Id = 3, Nombre = "Juana" };
            var cliente4 = new Cliente() { Id = 4, Nombre = "Frank" };
            var cliente5 = new Cliente() { Id = 5, Nombre = "Pote" };

            modelBuilder.Entity<Cliente>().HasData(cliente1,cliente2,cliente3,cliente4,cliente5);

            var producto1 = new Producto() { Id = 1, Nombre = "Cerveza Presidente Peq", Precio = 135 };
            var producto2 = new Producto() { Id = 2, Nombre = "Agua Solecito ", Precio = 15 };
            var producto3 = new Producto() { Id = 3, Nombre = "Jugo Motz", Precio = 250 };
            var producto4 = new Producto() { Id = 4, Nombre = "Cerveza Presidente Normal", Precio = 175 };
            var producto5 = new Producto() { Id = 5, Nombre = "Cerveza Heineken", Precio = 140 };

            modelBuilder.Entity<Producto>().HasData(producto1,producto2,producto3,producto4,producto5);

            var orden1 = new Orden() { Id = 1,Fecha = DateTime.Now, ClienteID = 1 };
            var orden2 = new Orden() { Id = 2, Fecha = DateTime.Now, ClienteID = 1 };
            var orden3 = new Orden() { Id = 3, Fecha = DateTime.Now.AddDays(3), ClienteID = 2 };
            var orden4 = new Orden() { Id = 4, Fecha= DateTime.Now.AddDays(4), ClienteID = 3 };
            var orden5 = new Orden() { Id = 5, Fecha= DateTime.Now.AddDays(5), ClienteID= 3 };

            modelBuilder.Entity<Orden>().HasData(orden1, orden2, orden3, orden4, orden5);

            var detalle1 = new OrdenProducto() { OrdenID = 1, ProductoID = 1, Cantidad = 5, Total = 675 };
            var detalle2 = new OrdenProducto() { OrdenID = 2, ProductoID = 4, Cantidad = 9, Total = 1575 };
            var detalle3 = new OrdenProducto() { OrdenID = 3, ProductoID = 5, Cantidad = 7, Total = 980 };
            var detalle4 = new OrdenProducto() { OrdenID = 4, ProductoID = 3, Cantidad = 1, Total = 250 };
            var detalle5 = new OrdenProducto() { OrdenID = 5, ProductoID = 2, Cantidad = 3, Total = 45 };

            modelBuilder.Entity<OrdenProducto>().HasData(detalle1, detalle2, detalle3, detalle4, detalle5);
        }
    }
}
