using AutoMapper;
using prueba.DTOs;
using prueba.Models;

namespace Prueba.Utilidades
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<ClienteDtos,Cliente>();
            CreateMap<Cliente,ClienteDtos>();


            CreateMap<DireccionDTOs,Direccion>();
            CreateMap<Direccion,DireccionDTOs>();
        }
        
    }
    
}