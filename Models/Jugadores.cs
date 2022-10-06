using System.ComponentModel.DataAnnotations;

namespace Proyecto_Quiniela.Models
{
    public class Jugadores
    {
        [Key]
        public int idJugadores { get; set; }
        public int idUsuario { get; set; }
    }
}
