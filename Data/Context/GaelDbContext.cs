using System;
using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Data.Context
{
    public partial class GaelDbContext : DbContext
    {
        public GaelDbContext()
        {
        }

        public GaelDbContext(DbContextOptions<GaelDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Campos> Campos { get; set; }
        public virtual DbSet<Plantillas> Plantillas { get; set; }
        public virtual DbSet<Tipos> Tipos { get; set; }
        public virtual DbSet<Valores> Valores { get; set; }
        public virtual DbSet<Origen> Origen { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseOracle("Data Source=(DESCRIPTION =(ADDRESS=(PROTOCOL=TCP)(HOST= oraclescan)(PORT=1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME = AYTOCC)(FAILOVER_MODE =(TYPE = SELECT)(METHOD = BASIC)(RETRIES = 180)(DELAY = 5))));User Id=MAKO;Password=MAmu,20.;Data Source=(DESCRIPTION =(ADDRESS=(PROTOCOL=TCP)(HOST= oraclescan)(PORT=1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME = AYTOCC)(FAILOVER_MODE =(TYPE = SELECT)(METHOD = BASIC)(RETRIES = 180)(DELAY = 5))));User Id=GAEL;Password=ELga,0221.;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:DefaultSchema", "GAEL");

            modelBuilder.Entity<Origen>(entity =>
            {
                entity.ToTable("ORIGEN");

                entity.HasIndex(e => e.Origenid)
                    .HasName("ORIGEN_PK")
                    .IsUnique();

                entity.Property(e => e.Origenid)
                    .HasColumnName("ORIGENID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Nombre)
                    .HasColumnName("NOMBRE")
                    .HasColumnType("VARCHAR2(50)");

                entity.Property(e => e.OrigenSrc)
                    .HasColumnName("ORIGENSRC")
                    .HasColumnType("VARCHAR2(1000)");

                entity.Property(e => e.FechaAlta)
                   .HasColumnName("FECHA_ALTA")
                   .HasColumnType("DATE");

                entity.Property(e => e.UsuarioCreacion)
                   .HasColumnName("USUARIO_CREACION")
                   .HasColumnType("VARCHAR2(100)");

                entity.Property(e => e.FechaBaja)
                   .HasColumnName("FECHA_BAJA")
                   .HasColumnType("DATE");

                entity.Property(e => e.MotivoBaja)
                   .HasColumnName("MOTIVO_BAJA")
                   .HasColumnType("VARCHAR2(1000)");

                entity.Property(e => e.FechaUltimaModif)
                   .HasColumnName("FECHA_ULTIMA_MODIF")
                   .HasColumnType("DATE");

                entity.Property(e => e.UsuarioUltimaModif)
                   .HasColumnName("USUARIO_ULTIMA_MODIF")
                   .HasColumnType("VARCHAR2(100)");

                entity.Property(e => e.Uuid)
                   .IsRequired()
                   .HasColumnName("UUID")
                   .HasColumnType("VARCHAR2(50)")
                   .HasDefaultValueSql("sys_guid() ");
            });

            modelBuilder.Entity<Campos>(entity =>
            {
                entity.ToTable("CAMPOS");

                entity.HasIndex(e => e.Camposid)
                    .HasName("SYS_C003617018")
                    .IsUnique();

                entity.Property(e => e.Camposid)
                    .HasColumnName("CAMPOSID")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("\"GAEL\".\"SECUENCIA_CAMPOS\".\"NEXTVAL\"");

                entity.Property(e => e.CampoExterno)
                    .HasColumnName("CAMPO_EXTERNO")
                    .HasColumnType("VARCHAR2(200)");

                entity.Property(e => e.CampoPlantilla)
                    .HasColumnName("CAMPO_PLANTILLA")
                    .HasColumnType("VARCHAR2(200)");

                entity.Property(e => e.FechaAlta)
                    .HasColumnName("FECHA_ALTA")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("SYSDATE ");

                entity.Property(e => e.FechaBaja)
                    .HasColumnName("FECHA_BAJA")
                    .HasColumnType("DATE");

                entity.Property(e => e.FechaUltimaModif)
                    .HasColumnName("FECHA_ULTIMA_MODIF")
                    .HasColumnType("DATE");

                entity.Property(e => e.MotivoBaja)
                    .HasColumnName("MOTIVO_BAJA")
                    .HasColumnType("VARCHAR2(1000)");

                entity.Property(e => e.PlantillaId)
                    .HasColumnName("PLANTILLA_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.TipoCampoId)
                    .HasColumnName("TIPO_CAMPO_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.UsuarioCreacion)
                    .IsRequired()
                    .HasColumnName("USUARIO_CREACION")
                    .HasColumnType("VARCHAR2(100)")
                    .HasDefaultValueSql("'system' ");

                entity.Property(e => e.UsuarioUltimaModif)
                    .HasColumnName("USUARIO_ULTIMA_MODIF")
                    .HasColumnType("VARCHAR2(100)");

                entity.Property(e => e.Uuid)
                    .IsRequired()
                    .HasColumnName("UUID")
                    .HasColumnType("VARCHAR2(50)")
                    .HasDefaultValueSql("sys_guid() ");

                entity.HasOne(d => d.Plantilla)
                    .WithMany(p => p.Campos)
                    .HasForeignKey(d => d.PlantillaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C003617020");

                entity.HasOne(d => d.TipoCampo)
                    .WithMany(p => p.Campos)
                    .HasForeignKey(d => d.TipoCampoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C003617019");
            });

            modelBuilder.Entity<Plantillas>(entity =>
            {
                entity.ToTable("PLANTILLAS");

                entity.HasIndex(e => e.Plantillasid)
                    .HasName("SYS_C003617009")
                    .IsUnique();

                entity.Property(e => e.Plantillasid)
                    .HasColumnName("PLANTILLASID")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("\"GAEL\".\"SECUENCIA_PLANTILLAS\".\"NEXTVAL\"");


                entity.Property(e => e.OrigenId)
                    .HasColumnName("ORIGEN_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.EstadoId)
                    .HasColumnName("ESTADO_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.FechaAlta)
                    .HasColumnName("FECHA_ALTA")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("SYSDATE ");

                entity.Property(e => e.FechaBaja)
                    .HasColumnName("FECHA_BAJA")
                    .HasColumnType("DATE");

                entity.Property(e => e.FechaUltimaModif)
                    .HasColumnName("FECHA_ULTIMA_MODIF")
                    .HasColumnType("DATE");

                entity.Property(e => e.MotivoBaja)
                    .HasColumnName("MOTIVO_BAJA")
                    .HasColumnType("VARCHAR2(1000)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("NOMBRE")
                    .HasColumnType("VARCHAR2(200)");

                entity.Property(e => e.RutaPlantilla)
                    .IsRequired()
                    .HasColumnName("RUTA_PLANTILLA")
                    .HasColumnType("VARCHAR2(1000)");

                entity.Property(e => e.SeguridadId)
                    .HasColumnName("SEGURIDAD_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.UsuarioCreacion)
                    .IsRequired()
                    .HasColumnName("USUARIO_CREACION")
                    .HasColumnType("VARCHAR2(100)")
                    .HasDefaultValueSql("'system' ");

                entity.Property(e => e.UsuarioUltimaModif)
                    .HasColumnName("USUARIO_ULTIMA_MODIF")
                    .HasColumnType("VARCHAR2(100)");

                entity.Property(e => e.Uuid)
                    .IsRequired()
                    .HasColumnName("UUID")
                    .HasColumnType("VARCHAR2(50)")
                    .HasDefaultValueSql("sys_guid() ");

                entity.HasOne(d => d.Estado)
                    .WithMany(p => p.PlantillasEstado)
                    .HasForeignKey(d => d.EstadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C003617012");

                entity.HasOne(d => d.Seguridad)
                    .WithMany(p => p.PlantillasSeguridad)
                    .HasForeignKey(d => d.SeguridadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C003617010");

                entity.HasOne(d => d.Origen)
                    .WithMany(p => p.PlantillasOrigenes)
                    .HasForeignKey(d => d.OrigenId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ORIGEN_FK");
            });

            modelBuilder.Entity<Tipos>(entity =>
            {
                entity.ToTable("TIPOS");

                entity.HasIndex(e => e.CodigoTipo)
                    .HasName("SYS_C003615804")
                    .IsUnique();

                entity.HasIndex(e => e.Tiposid)
                    .HasName("SYS_C003615803")
                    .IsUnique();

                entity.Property(e => e.Tiposid)
                    .HasColumnName("TIPOSID")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("\"GAEL\".\"SECUENCIA_TIPOS\".\"NEXTVAL\"");

                entity.Property(e => e.CodigoTipo)
                    .IsRequired()
                    .HasColumnName("CODIGO_TIPO")
                    .HasColumnType("VARCHAR2(5)");

                entity.Property(e => e.DescripcionTipo)
                    .HasColumnName("DESCRIPCION_TIPO")
                    .HasColumnType("VARCHAR2(100)");

                entity.Property(e => e.FechaAlta)
                    .HasColumnName("FECHA_ALTA")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("SYSDATE ");

                entity.Property(e => e.FechaBaja)
                    .HasColumnName("FECHA_BAJA")
                    .HasColumnType("DATE");

                entity.Property(e => e.FechaUltimaModif)
                    .HasColumnName("FECHA_ULTIMA_MODIF")
                    .HasColumnType("DATE");

                entity.Property(e => e.MotivoBaja)
                    .HasColumnName("MOTIVO_BAJA")
                    .HasColumnType("VARCHAR2(1000)");

                entity.Property(e => e.NombreTipo)
                    .HasColumnName("NOMBRE_TIPO")
                    .HasColumnType("VARCHAR2(50)");

                entity.Property(e => e.UsuarioCreacion)
                    .IsRequired()
                    .HasColumnName("USUARIO_CREACION")
                    .HasColumnType("VARCHAR2(100)")
                    .HasDefaultValueSql("'system' ");

                entity.Property(e => e.UsuarioUltimaModif)
                    .HasColumnName("USUARIO_ULTIMA_MODIF")
                    .HasColumnType("VARCHAR2(100)");

                entity.Property(e => e.Uuid)
                    .IsRequired()
                    .HasColumnName("UUID")
                    .HasColumnType("VARCHAR2(50)")
                    .HasDefaultValueSql("sys_guid() ");
            });

            modelBuilder.Entity<Valores>(entity =>
            {
                entity.ToTable("VALORES");

                entity.HasIndex(e => e.CodigoValor)
                    .HasName("SYS_C003615811")
                    .IsUnique();

                entity.HasIndex(e => e.Valoresid)
                    .HasName("SYS_C003615810")
                    .IsUnique();

                entity.Property(e => e.Valoresid)
                    .HasColumnName("VALORESID")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("\"GAEL\".\"SECUENCIA_VALORES\".\"NEXTVAL\"");

                entity.Property(e => e.CodigoValor)
                    .IsRequired()
                    .HasColumnName("CODIGO_VALOR")
                    .HasColumnType("VARCHAR2(5)");

                entity.Property(e => e.DescripcionValor)
                    .HasColumnName("DESCRIPCION_VALOR")
                    .HasColumnType("VARCHAR2(100)");

                entity.Property(e => e.FechaAlta)
                    .HasColumnName("FECHA_ALTA")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("SYSDATE ");

                entity.Property(e => e.FechaBaja)
                    .HasColumnName("FECHA_BAJA")
                    .HasColumnType("DATE");

                entity.Property(e => e.FechaUltimaModif)
                    .HasColumnName("FECHA_ULTIMA_MODIF")
                    .HasColumnType("DATE");

                entity.Property(e => e.MotivoBaja)
                    .HasColumnName("MOTIVO_BAJA")
                    .HasColumnType("VARCHAR2(1000)");

                entity.Property(e => e.NombreValor)
                    .HasColumnName("NOMBRE_VALOR")
                    .HasColumnType("VARCHAR2(50)");

                entity.Property(e => e.TiposId)
                    .HasColumnName("TIPOS_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.UsuarioCreacion)
                    .IsRequired()
                    .HasColumnName("USUARIO_CREACION")
                    .HasColumnType("VARCHAR2(100)")
                    .HasDefaultValueSql("'system' ");

                entity.Property(e => e.UsuarioUltimaModif)
                    .HasColumnName("USUARIO_ULTIMA_MODIF")
                    .HasColumnType("VARCHAR2(100)");

                entity.Property(e => e.Uuid)
                    .IsRequired()
                    .HasColumnName("UUID")
                    .HasColumnType("VARCHAR2(50)")
                    .HasDefaultValueSql("sys_guid() ");

                entity.HasOne(d => d.Tipos)
                    .WithMany(p => p.Valores)
                    .HasForeignKey(d => d.TiposId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C003615812");
            });

            modelBuilder.HasSequence("SECUENCIA_CAMPOS");

            modelBuilder.HasSequence("SECUENCIA_PLANTILLAS");

            modelBuilder.HasSequence("SECUENCIA_TIPOS");

            modelBuilder.HasSequence("SECUENCIA_VALORES");

            modelBuilder.Entity<Valores>().HasQueryFilter(entity => entity.FechaBaja == null);
            modelBuilder.Entity<Tipos>().HasQueryFilter(entity => entity.FechaBaja == null);
            modelBuilder.Entity<Plantillas>().HasQueryFilter(entity => entity.FechaBaja == null);
            modelBuilder.Entity<Campos>().HasQueryFilter(entity => entity.FechaBaja == null);
        }
    }
}
