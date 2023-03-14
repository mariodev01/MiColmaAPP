using System.ComponentModel.DataAnnotations;

namespace MiColmaAPP_API.Models.DTOs
{
    public class ClienteDTO
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(25)]
        public string Nombre { get; set; }
    }
}
