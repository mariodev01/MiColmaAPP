using System.ComponentModel.DataAnnotations.Schema;

namespace MiColmaAPP_API.Models
{
    public class Orden
    {
        public int Id { get; set; }
        [Column(TypeName ="date")]
        public DateTime? Fecha { get; set; }
        public int ClienteID { get; set; }
        [ForeignKey(nameof(ClienteID))]
        public virtual Cliente Cliente { get; set; }
        public virtual ICollection<OrdenProducto> OrdenProducto { get; set; }
    }
}
