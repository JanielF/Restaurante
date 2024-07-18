using System.ComponentModel.DataAnnotations;

namespace Restaurante.API.Data.Models
{
    public class PagosModels
    {
        [Key]
        public int PagoID { get; set; }
        public int ReservaID { get; set; }
        public decimal Monto { get; set; }
        public DateTime FechaPago { get; set; }
        public string Metodo { get; set; }
        public string Estado { get; set; }
    }
}
