using AutoMapper;
using MiColmaAPP_API.Models;
using MiColmaAPP_API.Models.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MiColmaAPP_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper mapper;

        public ProductoController(ApplicationDbContext context,IMapper mapper)
        {
            _context = context;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<ProductoDTO>>> get()
        {
            var productos = await _context.Productos.ToListAsync();

            return mapper.Map<List<ProductoDTO>>(productos);
        }

        [HttpGet("nombre")]
        public async Task<ActionResult<ProductoDTO>> GetNombre(string nombre)
        {
            var producto = await _context.Productos.FirstOrDefaultAsync(p=>p.Nombre.Contains(nombre));

            if(producto == null)
            {
                return NotFound("no se encuentra ese producto");
            }

            return mapper.Map<ProductoDTO>(producto);
        }
        [HttpPost]
        public async Task<ActionResult> Post(ProductoCreateDTO producto)
        {
            var product = mapper.Map<Producto>(producto);

            await _context.AddAsync(product);
            await _context.SaveChangesAsync();
            return Ok("se agrego");
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Actualizar(ProductoCreateDTO producto,int id)
        {
            var product = await _context.Productos.FirstOrDefaultAsync(p=> p.Id == id);

            if (product == null)
            {
                return NotFound("no existe ese producto");
            }

            product = mapper.Map(producto, product);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Borrar(int id)
        {
            var producto = await _context.Productos.FirstOrDefaultAsync(p=>p.Id == id);

            if (producto == null)
            {
                return NotFound();
            }

            _context.Remove(producto);
            await _context.SaveChangesAsync();
            return NoContent();
        }

    }
}
