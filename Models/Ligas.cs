namespace Proyecto_Quiniela.Models
{
    public class Ligas
    {
        public int idLiga { get; set; }
        public string? nombre { get; set; }
        public int idAdmin { get; set; }
        public DateTime? fechaInicio { get; set; }
        public DateTime? fechaCierre { get; set; }
        public int idEquipo { get; set; }
        public int idJugador { get; set; }
        public int idResultado { get; set; }

    }
}
