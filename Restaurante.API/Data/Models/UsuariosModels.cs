using System.ComponentModel.DataAnnotations;

namespace Restaurante.API.Data.Models
{
    public class UsuariosModels
    {
        [Key]
        public int UsuariosID { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Contraseña { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
