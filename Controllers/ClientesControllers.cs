using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using prueba.Models;
using prueba.DTOs;

namespace prueba.Controllers
{
    [ApiController]
    [Route("api/cliente")]
    public class ClientesController : ControllerBase
    {
        private readonly ApplicationDbContext dbcontext;
        private readonly Mapper mapper;

        public ClientesController(ApplicationDbContext dbcontext, Mapper mapper)
        {
            this.dbcontext = dbcontext;
            this.mapper = mapper;
        }
        [HttpGet]
        public async Task<List<Cliente>> Get( )
        {
            return await dbcontext.Clientes.ToListAsync();
        }


        [HttpPost]
        public async Task<ActionResult> Post(ClienteDtos clientedtos)
        {
            var existecliente = await dbcontext.Clientes.AnyAsync(x => x.Nombre == clientedtos.Nombre);
            if (existecliente)
            {
                return BadRequest($"Ya existe un Cliente con el nombre {clientedtos.Nombre}");
            }
            var cliente = mapper.Map<Cliente>(clientedtos);
            dbcontext.Add(cliente);
            await dbcontext.SaveChangesAsync();
            return Ok();


        }



        [HttpDelete("{id:int}")] // api/autores/2
        public async Task<ActionResult> Delete(int id)
        {
            var existe = await dbcontext.Clientes.AnyAsync(cliente => cliente.Id == id);

            if (!existe)
            {
                return NotFound();
            }

            dbcontext.Remove(new Cliente() { Id = id });
            await dbcontext.SaveChangesAsync();
            return Ok();
        }
        
    }
    
}