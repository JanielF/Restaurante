using System.ComponentModel.DataAnnotations;

namespace Restaurante.API.Data.Models
{
    public class ReservasModels
    {
        [Key]
        public int ReservaID { get; set; }
        public int UsuariosID { get; set; }
        public int MesaID { get; set; }
        public DateTime Fecha {  get; set; }
        public int NumeroPersonas { get; set; }
        public int Estado { get; set; }
        public string Comentarios { get; set; }

    }
}
