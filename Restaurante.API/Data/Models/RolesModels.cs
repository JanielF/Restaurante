using System.ComponentModel.DataAnnotations;

namespace Restaurante.API.Data.Models
{
    public class RolesModels
    {
        [Key]
        public int RolID { get; set; }
        public string Nombre { get; set; }
    }
}
