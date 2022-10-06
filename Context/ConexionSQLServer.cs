using Microsoft.EntityFrameworkCore;
using Proyecto_Quiniela.Models;

namespace Proyecto_Quiniela.Context
{
    public class ConexionSQLServer:DbContext
    {
        public ConexionSQLServer(DbContextOptions<ConexionSQLServer> options): base(options){}

        public DbSet<Usuarios> usuarios { get; set; }
        //public DbSet<TipoResultado> tipos { get; set; }
        public DbSet<Equipos> equipos { get; set; }

        public DbSet<Administrador> administrador { get; set; }

        public DbSet<Proyecto_Quiniela.Models.TipoPremios> TipoPremios { get; set; }

        public DbSet<Proyecto_Quiniela.Models.TipoResultado> TipoResultado { get; set; }

        public DbSet<Proyecto_Quiniela.Models.Juegos> Juegos { get; set; }

        public DbSet<Proyecto_Quiniela.Models.Jugadores> Jugadores { get; set; }

        public DbSet<Proyecto_Quiniela.Models.Grupos> Grupos { get; set; }

        //public DbSet<Juegos> juegos { get; set; }
    }
}
