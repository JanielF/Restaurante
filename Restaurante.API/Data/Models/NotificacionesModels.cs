using System.ComponentModel.DataAnnotations;

namespace Restaurante.API.Data.Models
{
    public class NotificacionesModels
    {
        [Key]
        public int NotificacionesID { get; set; } 
        public int UsuariosID { get; set; }
        public string Mensaje { get; set; }
        public DateTime FechaEnvio { get; set; }
        public string Tipo { get; set; }
        public string Estado { get; set; }
    }
}
