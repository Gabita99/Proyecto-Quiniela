using System.ComponentModel.DataAnnotations;

namespace Proyecto_Quiniela.Models
{
    public class Administrador
    {
        [Key]
        public int idAdmin { get; set; }
        public int idUsuario { get; set; }
        
    }
}
