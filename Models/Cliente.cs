using System.ComponentModel.DataAnnotations;

namespace MiColmaAPP_API.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(25)]
        public string Nombre { get; set; }
        public virtual ICollection<Orden> Ordenes { get; set; }
    }
}
