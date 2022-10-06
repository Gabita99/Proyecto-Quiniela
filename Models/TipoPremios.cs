using System.ComponentModel.DataAnnotations;

namespace Proyecto_Quiniela.Models
{
    public class TipoPremios
    {
        [Key]
        public int idTipo { get; set; }
        public string? descripcion { get; set; }
    }
}
