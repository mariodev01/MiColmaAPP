using System.ComponentModel.DataAnnotations;

namespace MiColmaAPP_API.Models.DTOs
{
    public class ClienteCreateDTO
    {
        [Required]
        [MaxLength(25)]
        public string Nombre { get; set; }
    }
}
