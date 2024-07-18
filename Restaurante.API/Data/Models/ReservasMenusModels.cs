using System.ComponentModel.DataAnnotations;

namespace Restaurante.API.Data.Models
{
    public class ReservasMenusModels
    {
        [Key]
        public int ReservaID { get; set; }
        public int MenuID { get; set; }
       
    }
}
