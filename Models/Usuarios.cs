using System.ComponentModel.DataAnnotations;

namespace Proyecto_Quiniela.Models
{
    public class Usuarios
    {
        [Key]
        public int Id_user { get; set; }
        public string? Nombre { get; set; }

        public string? Email { get; set; }

        public string? Contra { get; set; }

        public string? Estatus { get; set; }   

    }
}
