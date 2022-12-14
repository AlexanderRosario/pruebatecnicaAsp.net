using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using prueba;
using prueba.DTOs;
using prueba.Models;

namespace prueba.Controllers
{

    
    [ApiController]
    [Route("api/clientes/{idcliente}/Direccion")]
    public  class DireccionesController : ControllerBase
    {
        private readonly ApplicationDbContext dbcontext;
        private readonly IMapper mapper ;
        public DireccionesController(ApplicationDbContext dbContext, IMapper mapper) 
        {
            this.dbcontext = dbContext;
            this.mapper = mapper;
        }



        [HttpGet]
        public async Task<ActionResult<List<DireccionDTOs>>> Get(int idcliente)
        {
            var direccion = await dbcontext.Direcciones.Where(direcciondb => direcciondb.ClienteId == idcliente).ToListAsync();
            
            return  mapper.Map<List<DireccionDTOs>>(direccion);
        }




        [HttpPost]
        public async Task<ActionResult> Post(int idcliente,CrearDireccionDTOs direccionesdtos)
        {
            var existecliente = await dbcontext.Clientes.AnyAsync(clientedb => clientedb.Id == idcliente );
            if (!existecliente)
            {
                return NotFound();
            }
            var direccion = mapper.Map<Direccion>(direccionesdtos);
            direccion.ClienteId= idcliente;
            dbcontext.Add(direccion);
            await dbcontext.SaveChangesAsync();
            return Ok();



        }

        
    }
}