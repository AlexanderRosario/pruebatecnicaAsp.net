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
            CreateMap<DireccionesDTOs,Direccion>();
            CreateMap<Cliente,ClienteDtos>();
        }
        
    }
    
}