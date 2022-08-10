using System.ComponentModel.DataAnnotations;



namespace prueba.DTOs
{
    public class ClienteDtos
    {
        
        public int Id {get;set;}

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