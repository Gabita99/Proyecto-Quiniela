﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Proyecto_Quiniela.Context;

#nullable disable

namespace Proyecto_Quiniela.Migrations
{
    [DbContext(typeof(ConexionSQLServer))]
    partial class ConexionSQLServerModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Proyecto_Quiniela.Models.Administrador", b =>
                {
                    b.Property<int>("idAdmin")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idAdmin"), 1L, 1);

                    b.Property<int>("idUsuario")
                        .HasColumnType("int");

                    b.HasKey("idAdmin");

                    b.ToTable("administrador");
                });

            modelBuilder.Entity("Proyecto_Quiniela.Models.Equipos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("idGrupo")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("equipos");
                });

            modelBuilder.Entity("Proyecto_Quiniela.Models.Grupos", b =>
                {
                    b.Property<int>("idGrupo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idGrupo"), 1L, 1);

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idGrupo");

                    b.ToTable("Grupos");
                });

            modelBuilder.Entity("Proyecto_Quiniela.Models.Juegos", b =>
                {
                    b.Property<int>("idJuegos")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idJuegos"), 1L, 1);

                    b.Property<DateTime>("fecha")
                        .HasColumnType("datetime2");

                    b.HasKey("idJuegos");

                    b.ToTable("Juegos");
                });

            modelBuilder.Entity("Proyecto_Quiniela.Models.Jugadores", b =>
                {
                    b.Property<int>("idJugadores")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idJugadores"), 1L, 1);

                    b.Property<int>("idUsuario")
                        .HasColumnType("int");

                    b.HasKey("idJugadores");

                    b.ToTable("Jugadores");
                });

            modelBuilder.Entity("Proyecto_Quiniela.Models.TipoPremios", b =>
                {
                    b.Property<int>("idTipo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idTipo"), 1L, 1);

                    b.Property<string>("descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idTipo");

                    b.ToTable("TipoPremios");
                });

            modelBuilder.Entity("Proyecto_Quiniela.Models.TipoResultado", b =>
                {
                    b.Property<int>("idTipo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idTipo"), 1L, 1);

                    b.Property<string>("descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idTipo");

                    b.ToTable("TipoResultado");
                });

            modelBuilder.Entity("Proyecto_Quiniela.Models.Usuarios", b =>
                {
                    b.Property<int>("Id_user")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_user"), 1L, 1);

                    b.Property<string>("Contra")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_user");

                    b.ToTable("usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
