using AutoMapper;
using prueba.DTOs;
using prueba.Models;

namespace Prueba.Utilidades
{
    public class AutoMapperClient : Profile
    {
        public AutoMapperClient()
        {
            CreateMap<ClienteDtos,Cliente>();
            CreateMap<DireccionesDTOs , Direccion>();
        }
        
    }
    
}