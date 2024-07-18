using System.ComponentModel.DataAnnotations;

namespace Restaurante.API.Data.Models
{
    public class MesasModels
    {
        [Key]
        public int MesasID { get; set; }
        public int Numero { get; set; }
        public int Capacidad { get; set; }
    }

}
