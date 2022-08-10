using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace prueba.Models
{
    public class Cliente
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

        public List<Direccion> Ubicaccion {get;set;}


        [DefaultValue(true)]
        public bool Estado {get;set;} = true;


        
    }


}