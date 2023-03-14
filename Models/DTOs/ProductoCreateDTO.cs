using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace MiColmaAPP_API.Models.DTOs
{
    public class ProductoCreateDTO
    {
        [Required]
        [MaxLength(35)]
        public string Nombre { get; set; }
        [Required]
        [Precision(precision: 6, scale: 2)]
        public decimal Precio { get; set; }
    }
}
