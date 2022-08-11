using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace prueba.Models
{
    public class Direccion
    {
        public int Id {get;set;}

        [Required(ErrorMessage = "La direccion es requerida")]
        [StringLength(maximumLength:255,MinimumLength =3)]
        public string Ubicacion {get;set;}


        // [Required(ErrorMessage = "Debe enviar el Id del cliente")]
        public int ClienteId {get;set;}
        // public List<Cliente> Cliente {get;set;}
        public Cliente Cliente {get;set;}
        
        [DefaultValue(true)]
        public bool Estado {get;set;} = true;

        
    }


}