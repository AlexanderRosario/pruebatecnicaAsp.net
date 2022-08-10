using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using prueba.Models;

namespace prueba.DTOs
{
    public class CrearClienteDtos
    {

        [Required]
        [StringLength(maximumLength:100,MinimumLength =3)]
        public string Nombre {get;set;}

        [Required]
        [StringLength(maximumLength:100,MinimumLength =3)]
        public string Apellido {get;set;}
 
        [DataType(DataType.Date)]
        public DateTime Fecha_de_Nacimiento {get;set;}

        [Required]
        public string telefono {get;set;}
        
    }
    
}