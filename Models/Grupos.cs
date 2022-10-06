using System.ComponentModel.DataAnnotations;

namespace Proyecto_Quiniela.Models
{
    public class Grupos
    {
        [Key]
        public int idGrupo { get; set; }
        public string? nombre { get; set; }
    }
}
