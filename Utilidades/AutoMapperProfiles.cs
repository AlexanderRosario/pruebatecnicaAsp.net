using AutoMapper;
using prueba.DTOs;
using prueba.Models;

namespace Prueba.Utilidades
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<CrearClienteDtos,Cliente>();
            // CreateMap<ClienteDtos,Cliente>();
            CreateMap<Cliente,ClienteDtos>();


            CreateMap<CrearDireccionDTOs,Direccion>();
            CreateMap<Direccion,DireccionDTOs>();
        }
        
    }
    
}