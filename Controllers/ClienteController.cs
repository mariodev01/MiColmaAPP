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
    public class ClienteController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper mapper;

        public ClienteController(ApplicationDbContext context,IMapper mapper)
        {
            _context = context;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<ClienteDTO>>> GetAll()
        {
            var cliente = await _context.Clientes.ToListAsync();
            return mapper.Map<List<ClienteDTO>>(cliente);
        }
        [HttpGet("nombre")]
        public async Task<ActionResult<ClienteDTO>> Get(string nombre) 
        {
            var cliente = await _context.Clientes.FirstOrDefaultAsync(c=>c.Nombre.Contains(nombre));
            if(cliente == null)
            {
                return NotFound();
            }
            return mapper.Map<ClienteDTO>(cliente);
        }

        [HttpGet("clienteCuenta/{id:int}")]
        public async Task<ActionResult> ClienteCuenta(int id)
        {
            var clienteCuenta = await _context.Clientes
                .Include(cu=>cu.Ordenes)
                    .ThenInclude(cd=>cd.OrdenProducto)
                .FirstOrDefaultAsync(c=>c.Id== id);

            if(clienteCuenta== null)
            {
                return NotFound();
            }

            return Ok(clienteCuenta);
        }

        [HttpPost]
        public async Task<ActionResult> Post(ClienteCreateDTO cliente)
        {
            var existe = await _context.Clientes.AnyAsync(c => c.Nombre == cliente.Nombre);
            if (existe == true)
            {
                return BadRequest("ya existe un cliente con ese nombre");
            }
            var client = mapper.Map<Cliente>(cliente);

            await _context.AddAsync(client);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        [HttpPut("{id:int}")]
        public async Task<ActionResult> Actualizar(ClienteCreateDTO clienteCreate,int id)
        {
            var cliente = await _context.Clientes.FirstOrDefaultAsync(c=>c.Id== id);

            if (cliente == null)
            {
                return NotFound("el cliente no existe");
            }

            cliente = mapper.Map(clienteCreate, cliente);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var existe = await _context.Clientes.FirstOrDefaultAsync(c => c.Id == id);

            if (existe == null)
            {
                return NotFound("no existe ese cliente");
            }

            _context.Remove(existe);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        /*solo tienes que bregar lo de agregar con data existente y nueva
         y lo de actualizar y borrar*/
    }
}
