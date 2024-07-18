using System.ComponentModel.DataAnnotations;

namespace Restaurante.API.Data.Models
{
    public class MenusModels
    {
        [Key]
        public int MenuIdD{ get; set; }
        public string Nombre { get; set; }
        public string  Descripcion { get; set; }
        public decimal Precio { get; set; }

    }
}
