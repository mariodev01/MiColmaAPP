using Microsoft.EntityFrameworkCore;

namespace MiColmaAPP_API.Models
{
    public class OrdenProducto
    {
        public int OrdenID { get; set; }
        public int ProductoID { get; set; }
        public int Cantidad { get; set; }
        [Precision(precision:8,scale:2)]
        public decimal Total { get; set; }
        public virtual Orden Orden { get; set; }
        public virtual Producto Producto { get; set; }
    }
}
