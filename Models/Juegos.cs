using System.ComponentModel.DataAnnotations;

namespace Proyecto_Quiniela.Models
{
    public class Juegos
    {
        [Key]
        public int idJuegos { get; set; }
        public DateTime fecha { get; set; }

    }
}
