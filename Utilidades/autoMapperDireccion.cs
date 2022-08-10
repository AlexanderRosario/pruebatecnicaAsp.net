using AutoMapper;
using prueba.DTOs;
using prueba.Models;

namespace Prueba.Utilidades
{
    public class AutoMapperdireccion : Profile
    {
        public AutoMapperdireccion()
        {
            CreateMap<DireccionesDTOs,Direccion>();
        }
        
    }
    
}