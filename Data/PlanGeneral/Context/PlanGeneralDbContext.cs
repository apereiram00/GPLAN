using System;
using Data.Entities;
using Data.PlanGeneral.Entities;
using EntityFrameworkCore.Jet;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Data.Context
{
    public partial class PlanGeneralDbContext : DbContext
    {
        public PlanGeneralDbContext()
        {
        }

        public PlanGeneralDbContext(DbContextOptions<PlanGeneralDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured) {           
                string accessConnectionString = @"Provider=Microsoft.ACE.OLEBD.12.0;Data Source=N:\INFORMATICA\compartido\Administración Electrónica\Temp\PGM_2010_DIG;";
                optionsBuilder.UseJet(accessConnectionString);
                
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Normas_titulos>(entity =>

            {

                entity.ToTable("Normas_titulos");

                entity.HasKey(e => e.Id_titulo);

                entity.Property(e => e.Id_titulo)
                .HasColumnName("Id")
                .ValueGeneratedOnAdd();

                entity.Property(e => e.Titulo_numero)
                .HasColumnName("Titulo_numero");

                entity.Property(e => e.Titulo_denominacion)
                .HasColumnName("Titulo_denominacion");                

            });

            modelBuilder.Entity<Normas_capitulos>(entity =>

            {

                entity.ToTable("Normas_capitulos");

                entity.HasKey(e => e.Id_capitulo);

                entity.Property(e => e.Id_capitulo)
                .HasColumnName("Id")
                .ValueGeneratedOnAdd();

                entity.Property(e => e.Capitulo_titulo_pertenece)
                .HasColumnName("capitulo_titulo_pertenece");

                entity.Property(e => e.Capitulo_numero)
                .HasColumnName("capitulo_numero");

                entity.Property(e => e.Capitulo_denominacion)
              .HasColumnName("capitulo_denominacion");

            });

            modelBuilder.Entity<Normas_articulos>(entity =>
            {

                entity.ToTable("Normas_articulos");

                entity.HasKey(e => e.Id_articulo);

                entity.Property(e => e.Id_articulo)
                .HasColumnName("Id")
                .ValueGeneratedOnAdd();

                entity.Property(e => e.Titulo_articulo)
                .HasColumnName("titulo");

                entity.Property(e => e.Articulo_capitulo)
                .HasColumnName("capitulo");

                entity.Property(e => e.Seccion)
              .HasColumnName("seccion");

                entity.Property(e => e.Apartado)
                .HasColumnName("apartado");

                entity.Property(e => e.Articulo)
               .HasColumnName("articulo");

                entity.Property(e => e.Denominacion)
              .HasColumnName("denominacion");

                entity.Property(e => e.Tipo)
                .HasColumnName("tipo");

                entity.Property(e => e.Contenido)
                .HasColumnName("contenido");

                entity.Property(e => e.Vigente)
                .HasColumnName("vigente");

                entity.Property(e => e.FechaAlta)
              .HasColumnName("fecha_alta");

                entity.Property(e => e.MotivoAlta)
                .HasColumnName("motivo_alta");

                entity.Property(e => e.FechaBaja)
               .HasColumnName("fecha_baja");

                entity.Property(e => e.MotivoBaja)
              .HasColumnName("motivo_baja");

            });     
        }
    }
}
