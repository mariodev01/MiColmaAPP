using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace MiColmaAPP_API.Models
{
    public class Producto
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(35)]
        public string Nombre { get; set; }
        [Required]
        [Precision(precision:6,scale:2)]
        public decimal Precio { get; set; }
        public virtual ICollection<OrdenProducto> OrdenProductos { get; set; }
    }
}
