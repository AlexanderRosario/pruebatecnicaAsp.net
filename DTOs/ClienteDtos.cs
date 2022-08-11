

namespace prueba.DTOs
{
    public class ClienteDtos
    {
        
        public int Id {get;set;}

        public string Nombre {get;set;}

        public string Apellido {get;set;}
 
        public DateTime Fecha_de_Nacimiento {get;set;}

        public string telefono {get;set;}
        
        public List<DireccionDTOs> Ubicaccion {get;set;}
        




        
        
    }
}