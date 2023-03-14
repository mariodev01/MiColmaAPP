using AutoMapper;
using MiColmaAPP_API.Models;
using MiColmaAPP_API.Models.DTOs;

namespace MiColmaAPP_API
{
    public class MappingConfig: Profile
    {
        public MappingConfig()
        { 
            //Producto
            CreateMap<Producto,ProductoDTO>().ReverseMap();
            CreateMap<Producto,ProductoCreateDTO>().ReverseMap();

            //Cliente
            CreateMap<Cliente,ClienteDTO>().ReverseMap();
            CreateMap<Cliente,ClienteCreateDTO>().ReverseMap();
        }
    }
}
