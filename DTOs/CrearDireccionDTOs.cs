using System.ComponentModel.DataAnnotations;

namespace prueba.DTOs
{
    public class CrearDireccionDTOs
    {
        [Required(ErrorMessage = "La direccion es requerida")]
        [StringLength(maximumLength:255,MinimumLength =3)]
        public string Ubicacion {get;set;}
        // public int Id_Cliente {get;set;}
        
    }
    
}