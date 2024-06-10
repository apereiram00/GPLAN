using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Data.Urbanismo.Entities
{
    public partial class UrbanismoDbContext : DbContext
    {
        public UrbanismoDbContext()
        {
        }

        public UrbanismoDbContext(DbContextOptions<UrbanismoDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Actdocumentos> Actdocumentos { get; set; }
        public virtual DbSet<Acterrazas> Acterrazas { get; set; }
        public virtual DbSet<Actertotal> Actertotal { get; set; }
        public virtual DbSet<Actividades> Actividades { get; set; }
        public virtual DbSet<Acttecnicos> Acttecnicos { get; set; }
        public virtual DbSet<Actvarios> Actvarios { get; set; }
        public virtual DbSet<Dismsg> Dismsg { get; set; }
        public virtual DbSet<Displu> Displu { get; set; }
        public virtual DbSet<Disvarios> Disvarios { get; set; }
        public virtual DbSet<Ineventos> Ineventos { get; set; }
        public virtual DbSet<Invehiculos> Invehiculos { get; set; }
        public virtual DbSet<Licobramenor> Licobramenor { get; set; }
        public virtual DbSet<Pactuabien> Pactuabien { get; set; }
        public virtual DbSet<Pactuaciones> Pactuaciones { get; set; }
        public virtual DbSet<Parrendamiento> Parrendamiento { get; set; }
        public virtual DbSet<Pattipbien> Pattipbien { get; set; }
        public virtual DbSet<Pbiendest> Pbiendest { get; set; }
        public virtual DbSet<Pbienes> Pbienes { get; set; }
        public virtual DbSet<Pbieniden> Pbieniden { get; set; }
        public virtual DbSet<Pcesiong> Pcesiong { get; set; }
        public virtual DbSet<Pcesiono> Pcesiono { get; set; }
        public virtual DbSet<Pcesionp> Pcesionp { get; set; }
        public virtual DbSet<Pcomprueba> Pcomprueba { get; set; }
        public virtual DbSet<Pconcesion> Pconcesion { get; set; }
        public virtual DbSet<Pdemaniales> Pdemaniales { get; set; }
        public virtual DbSet<Pdepartamento> Pdepartamento { get; set; }
        public virtual DbSet<Pderechosu> Pderechosu { get; set; }
        public virtual DbSet<Pdesahucio> Pdesahucio { get; set; }
        public virtual DbSet<Pdocumentosb> Pdocumentosb { get; set; }
        public virtual DbSet<Pdocumentosd> Pdocumentosd { get; set; }
        public virtual DbSet<Pdocumentose> Pdocumentose { get; set; }
        public virtual DbSet<Penajenacion> Penajenacion { get; set; }
        public virtual DbSet<Pexpedientes> Pexpedientes { get; set; }
        public virtual DbSet<Pexpropiacion> Pexpropiacion { get; set; }
        public virtual DbSet<Ppermuta> Ppermuta { get; set; }
        public virtual DbSet<Precuperacion> Precuperacion { get; set; }
        public virtual DbSet<Psegregacion> Psegregacion { get; set; }
        public virtual DbSet<Ptipoe> Ptipoe { get; set; }
        public virtual DbSet<Uracciones> Uracciones { get; set; }
        public virtual DbSet<Uractuacion> Uractuacion { get; set; }
        public virtual DbSet<Urafecciones> Urafecciones { get; set; }
        public virtual DbSet<Uragrulue> Uragrulue { get; set; }
        public virtual DbSet<Urareasplan> Urareasplan { get; set; }
        public virtual DbSet<Urcontenido> Urcontenido { get; set; }
        public virtual DbSet<Urdotaciones> Urdotaciones { get; set; }
        public virtual DbSet<Urelementos> Urelementos { get; set; }
        public virtual DbSet<Urexpedientes> Urexpedientes { get; set; }
        public virtual DbSet<Urexpedientes3> Urexpedientes3 { get; set; }
        public virtual DbSet<Urlue> Urlue { get; set; }
        public virtual DbSet<Urperfiles> Urperfiles { get; set; }
        public virtual DbSet<Urreparto> Urreparto { get; set; }
        public virtual DbSet<Urseccion> Urseccion { get; set; }
        public virtual DbSet<Urtecnicos> Urtecnicos { get; set; }
        public virtual DbSet<Urtipoexpediente> Urtipoexpediente { get; set; }
        public virtual DbSet<Urusonurbano> Urusonurbano { get; set; }
        public virtual DbSet<Urusospe> Urusospe { get; set; }
        public virtual DbSet<Urusourbano> Urusourbano { get; set; }
        public virtual DbSet<Urzonas> Urzonas { get; set; }

        // Unable to generate entity type for table 'URBANISMO.LICACTUACIONES'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.INVEHIMP'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.LICDOCUMENTOS'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.LICEXPREL'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.LICINFORMES'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.LICOMCAL'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.LICPERFILES'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.OBSERVACIONES'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.PARRENDAMIENTOH'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.PATINFORMES'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.PATTECNICOS'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.PBIENLIS'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.PCALLES'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.PCALLESDEM'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.PCATASEG'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.PCATASTRAL'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.ACTVARLIS'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.DISACTUACIONES'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.DISCATASTRAL'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.DISDOCUMENTOS'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.DISEXPREL'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.DISINTERESADOS'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.DISLISPLAZOS'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.DISMSGCAL'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.DISMSGPRIN'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.DISPE'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.DISPERFILES'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.DISPLAZOS'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.INAUTORIZACIONES'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.INCALENDARIO'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.INCONSUMOS'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.INCOSTES'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.INEVIMP'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.ININFEVE'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.ININFORMES'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.INKILOMETRAJE'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.INPERFILES'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.INPETICIONES'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.INPROCEDENCIA'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.INTECNICOS'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.ACTCALLES'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.ACTCALLEST'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.ACTCALLESV'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.ACTDOCTER'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.ACTINFORMES'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.ACTINTERESADOSV'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.ACTLISTER'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.ACTLISTOTAL'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.ACTOLVIDADOS'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.ACTOLVIDADOST'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.ACTPERFILES'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.ACTILIS'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.ACTINFTER'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.ACTINTERESADOS'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.URCONREG'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.ACTINTETER'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.PEXPREL'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.PEXPRELD'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.PINCILIS'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.PINTERESADOS'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.PNATURALEZA'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.PRELBIEN'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.URCALLES'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.URCATASTRAL'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.URINTERESADOS'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.URINTERESADOS3'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.URLISTADOS'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.URLOCAPE'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.URLOCAUR'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.URMANZANAS'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.URUSOSPETA'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.URUSOSUR'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.PCESIONGH'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.PCESIONOH'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.PCESIONPH'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.PCONCESIONH'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.PDEMLIS'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.PDERECHOSUH'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.PERFILESA'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.PERFILESP'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.URDOCUMENTOS'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.UREXPREL'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.URINFACT'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.URINFDIS'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.URINFLIC'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.URINFORMES'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.URINFPAT'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.PEXPIMP'. Please see the warning messages.
        // Unable to generate entity type for table 'URBANISMO.ACTDOCVAR'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseOracle("Data Source=(DESCRIPTION =(ADDRESS=(PROTOCOL=TCP)(HOST= oraclescan)(PORT=1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME = AYTOCC)(FAILOVER_MODE =(TYPE = SELECT)(METHOD = BASIC)(RETRIES = 180)(DELAY = 5))));User Id=MAKO;Password=MAmu,20.;Data Source=(DESCRIPTION =(ADDRESS=(PROTOCOL=TCP)(HOST= oraclescan)(PORT=1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME = AYTOCC)(FAILOVER_MODE =(TYPE = SELECT)(METHOD = BASIC)(RETRIES = 180)(DELAY = 5))));User Id=URBANISMO;Password=URmo,02.;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:DefaultSchema", "URBANISMO");

            modelBuilder.Entity<Actdocumentos>(entity =>
            {
                entity.HasKey(e => new { e.Idact, e.Ejercicio, e.Ruta });

                entity.ToTable("ACTDOCUMENTOS");

                entity.HasIndex(e => new { e.Idact, e.Ejercicio, e.Ruta })
                    .HasName("ACTDOCUMENTOS_PK")
                    .IsUnique();

                entity.Property(e => e.Idact).HasColumnName("IDACT");

                entity.Property(e => e.Ejercicio)
                    .HasColumnName("EJERCICIO")
                    .HasColumnType("NUMBER(4)");

                entity.Property(e => e.Ruta)
                    .HasColumnName("RUTA")
                    .HasColumnType("VARCHAR2(300)");

                entity.Property(e => e.Asunto)
                    .HasColumnName("ASUNTO")
                    .HasColumnType("VARCHAR2(100)");

                entity.Property(e => e.Fecha)
                    .HasColumnName("FECHA")
                    .HasColumnType("DATE");

                entity.Property(e => e.Propietario)
                    .HasColumnName("PROPIETARIO")
                    .HasColumnType("VARCHAR2(1)");
            });

            modelBuilder.Entity<Acterrazas>(entity =>
            {
                entity.HasKey(e => new { e.Idact, e.Ejercicio });

                entity.ToTable("ACTERRAZAS");

                entity.HasIndex(e => new { e.Idact, e.Ejercicio })
                    .HasName("PRIMTER")
                    .IsUnique();

                entity.Property(e => e.Idact)
                    .HasColumnName("IDACT")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Ejercicio)
                    .HasColumnName("EJERCICIO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Actividad)
                    .HasColumnName("ACTIVIDAD")
                    .HasColumnType("VARCHAR2(100)");

                entity.Property(e => e.Año)
                    .HasColumnName("AÑO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Caducada)
                    .HasColumnName("CADUCADA")
                    .HasColumnType("VARCHAR2(300)");

                entity.Property(e => e.Carpeta)
                    .HasColumnName("CARPETA")
                    .HasColumnType("VARCHAR2(8)");

                entity.Property(e => e.Denegada)
                    .HasColumnName("DENEGADA")
                    .HasColumnType("VARCHAR2(300)");

                entity.Property(e => e.Denominacion)
                    .HasColumnName("DENOMINACION")
                    .HasColumnType("VARCHAR2(70)");

                entity.Property(e => e.Ejerbar)
                    .HasColumnName("EJERBAR")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Expediente)
                    .HasColumnName("EXPEDIENTE")
                    .HasColumnType("VARCHAR2(8)");

                entity.Property(e => e.Fcadu)
                    .HasColumnName("FCADU")
                    .HasColumnType("DATE");

                entity.Property(e => e.Fden)
                    .HasColumnName("FDEN")
                    .HasColumnType("DATE");

                entity.Property(e => e.Fent)
                    .HasColumnName("FENT")
                    .HasColumnType("DATE");

                entity.Property(e => e.Ffin)
                    .HasColumnName("FFIN")
                    .HasColumnType("DATE");

                entity.Property(e => e.Fin)
                    .HasColumnName("FIN")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.Fpagado)
                    .HasColumnName("FPAGADO")
                    .HasColumnType("DATE");

                entity.Property(e => e.Fres)
                    .HasColumnName("FRES")
                    .HasColumnType("DATE");

                entity.Property(e => e.Idbar)
                    .HasColumnName("IDBAR")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Importe)
                    .HasColumnName("IMPORTE")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Licb)
                    .HasColumnName("LICB")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Licencia)
                    .HasColumnName("LICENCIA")
                    .HasColumnType("VARCHAR2(300)");

                entity.Property(e => e.Numlic)
                    .HasColumnName("NUMLIC")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Observaciones)
                    .HasColumnName("OBSERVACIONES")
                    .HasColumnType("VARCHAR2(2000)");

                entity.Property(e => e.Pagado)
                    .HasColumnName("PAGADO")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.Refcat)
                    .HasColumnName("REFCAT")
                    .HasColumnType("VARCHAR2(20)");

                entity.Property(e => e.Tcomunica)
                    .HasColumnName("TCOMUNICA")
                    .HasColumnType("VARCHAR2(70)");

                entity.Property(e => e.Tituact)
                    .HasColumnName("TITUACT")
                    .HasColumnType("VARCHAR2(100)");

                entity.Property(e => e.Velador)
                    .HasColumnName("VELADOR")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Veladora)
                    .HasColumnName("VELADORA")
                    .HasColumnType("NUMBER");
            });

            modelBuilder.Entity<Actertotal>(entity =>
            {
                entity.HasKey(e => new { e.Idact, e.Ejercicio });

                entity.ToTable("ACTERTOTAL");

                entity.HasIndex(e => new { e.Idact, e.Ejercicio })
                    .HasName("ACTERTOTAL_PK")
                    .IsUnique();

                entity.Property(e => e.Idact)
                    .HasColumnName("IDACT")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Ejercicio)
                    .HasColumnName("EJERCICIO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Actividad)
                    .HasColumnName("ACTIVIDAD")
                    .HasColumnType("VARCHAR2(100)");

                entity.Property(e => e.Apenom1)
                    .HasColumnName("APENOM1")
                    .HasColumnType("VARCHAR2(100)");

                entity.Property(e => e.Apenom2)
                    .HasColumnName("APENOM2")
                    .HasColumnType("VARCHAR2(100)");

                entity.Property(e => e.Año)
                    .HasColumnName("AÑO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Carpeta)
                    .HasColumnName("CARPETA")
                    .HasColumnType("VARCHAR2(8)");

                entity.Property(e => e.Denominacion)
                    .HasColumnName("DENOMINACION")
                    .HasColumnType("VARCHAR2(70)");

                entity.Property(e => e.DomLargo1)
                    .HasColumnName("DOM_LARGO1")
                    .HasColumnType("VARCHAR2(120)");

                entity.Property(e => e.DomLargo2)
                    .HasColumnName("DOM_LARGO2")
                    .HasColumnType("VARCHAR2(120)");

                entity.Property(e => e.Ejerbar)
                    .HasColumnName("EJERBAR")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Expediente)
                    .HasColumnName("EXPEDIENTE")
                    .HasColumnType("VARCHAR2(8)");

                entity.Property(e => e.Fcadu)
                    .HasColumnName("FCADU")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Fden)
                    .HasColumnName("FDEN")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Fecha1)
                    .HasColumnName("FECHA1")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Fecha2)
                    .HasColumnName("FECHA2")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Fecha3)
                    .HasColumnName("FECHA3")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Fent)
                    .HasColumnName("FENT")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Ffin)
                    .HasColumnName("FFIN")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Fin)
                    .HasColumnName("FIN")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.Fpagado)
                    .HasColumnName("FPAGADO")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Fres)
                    .HasColumnName("FRES")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Idbar)
                    .HasColumnName("IDBAR")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Importe)
                    .HasColumnName("IMPORTE")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Licb)
                    .HasColumnName("LICB")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Nif1)
                    .HasColumnName("NIF1")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Nif2)
                    .HasColumnName("NIF2")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Numlic)
                    .HasColumnName("NUMLIC")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Pagado)
                    .HasColumnName("PAGADO")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.Refcat)
                    .HasColumnName("REFCAT")
                    .HasColumnType("VARCHAR2(20)");

                entity.Property(e => e.Rep1)
                    .HasColumnName("REP1")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.Rep2)
                    .HasColumnName("REP2")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.Resultado1)
                    .HasColumnName("RESULTADO1")
                    .HasColumnType("VARCHAR2(20)");

                entity.Property(e => e.Resultado2)
                    .HasColumnName("RESULTADO2")
                    .HasColumnType("VARCHAR2(20)");

                entity.Property(e => e.Resultado3)
                    .HasColumnName("RESULTADO3")
                    .HasColumnType("VARCHAR2(20)");

                entity.Property(e => e.Tcomunica)
                    .HasColumnName("TCOMUNICA")
                    .HasColumnType("VARCHAR2(70)");

                entity.Property(e => e.Tecnico1)
                    .HasColumnName("TECNICO1")
                    .HasColumnType("VARCHAR2(150)");

                entity.Property(e => e.Tecnico2)
                    .HasColumnName("TECNICO2")
                    .HasColumnType("VARCHAR2(150)");

                entity.Property(e => e.Tecnico3)
                    .HasColumnName("TECNICO3")
                    .HasColumnType("VARCHAR2(150)");

                entity.Property(e => e.Tipo1)
                    .HasColumnName("TIPO1")
                    .HasColumnType("VARCHAR2(15)");

                entity.Property(e => e.Tipo2)
                    .HasColumnName("TIPO2")
                    .HasColumnType("VARCHAR2(15)");

                entity.Property(e => e.Tipo3)
                    .HasColumnName("TIPO3")
                    .HasColumnType("VARCHAR2(15)");

                entity.Property(e => e.Tituact)
                    .HasColumnName("TITUACT")
                    .HasColumnType("VARCHAR2(100)");

                entity.Property(e => e.Velador)
                    .HasColumnName("VELADOR")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Veladora)
                    .HasColumnName("VELADORA")
                    .HasColumnType("NUMBER");
            });

            modelBuilder.Entity<Actividades>(entity =>
            {
                entity.HasKey(e => new { e.Ejercicio, e.Idact });

                entity.ToTable("ACTIVIDADES");

                entity.HasIndex(e => new { e.Ejercicio, e.Idact })
                    .HasName("PRIMACTI")
                    .IsUnique();

                entity.Property(e => e.Ejercicio)
                    .HasColumnName("EJERCICIO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Idact)
                    .HasColumnName("IDACT")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Actividad)
                    .HasColumnName("ACTIVIDAD")
                    .HasColumnType("VARCHAR2(100)");

                entity.Property(e => e.Año)
                    .HasColumnName("AÑO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Caducada)
                    .HasColumnName("CADUCADA")
                    .HasColumnType("VARCHAR2(300)");

                entity.Property(e => e.Carpeta)
                    .HasColumnName("CARPETA")
                    .HasColumnType("VARCHAR2(8)");

                entity.Property(e => e.Climatiza)
                    .HasColumnName("CLIMATIZA")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.Definitiva)
                    .HasColumnName("DEFINITIVA")
                    .HasColumnType("VARCHAR2(300)");

                entity.Property(e => e.Denegada)
                    .HasColumnName("DENEGADA")
                    .HasColumnType("VARCHAR2(300)");

                entity.Property(e => e.Denominacion)
                    .HasColumnName("DENOMINACION")
                    .HasColumnType("VARCHAR2(70)");

                entity.Property(e => e.Denuncia)
                    .HasColumnName("DENUNCIA")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.Expediente)
                    .HasColumnName("EXPEDIENTE")
                    .HasColumnType("VARCHAR2(8)");

                entity.Property(e => e.Fcadu)
                    .HasColumnName("FCADU")
                    .HasColumnType("DATE");

                entity.Property(e => e.Fdef)
                    .HasColumnName("FDEF")
                    .HasColumnType("DATE");

                entity.Property(e => e.Fden)
                    .HasColumnName("FDEN")
                    .HasColumnType("DATE");

                entity.Property(e => e.Fent)
                    .HasColumnName("FENT")
                    .HasColumnType("DATE");

                entity.Property(e => e.Ffin)
                    .HasColumnName("FFIN")
                    .HasColumnType("DATE");

                entity.Property(e => e.Fin)
                    .HasColumnName("FIN")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.Fres)
                    .HasColumnName("FRES")
                    .HasColumnType("DATE");

                entity.Property(e => e.Licencia)
                    .HasColumnName("LICENCIA")
                    .HasColumnType("VARCHAR2(300)");

                entity.Property(e => e.Musica)
                    .HasColumnName("MUSICA")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.Numlic)
                    .HasColumnName("NUMLIC")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Observaciones)
                    .HasColumnName("OBSERVACIONES")
                    .HasColumnType("VARCHAR2(2000)");

                entity.Property(e => e.Ramimp)
                    .HasColumnName("RAMIMP")
                    .HasColumnType("VARCHAR2(50)");

                entity.Property(e => e.Refcat)
                    .HasColumnName("REFCAT")
                    .HasColumnType("VARCHAR2(20)");

                entity.Property(e => e.Tcomunica)
                    .HasColumnName("TCOMUNICA")
                    .HasColumnType("VARCHAR2(70)");

                entity.Property(e => e.Terraza)
                    .HasColumnName("TERRAZA")
                    .HasColumnType("VARCHAR2(1)");
            });

            modelBuilder.Entity<Acttecnicos>(entity =>
            {
                entity.HasKey(e => e.Abreviatura);

                entity.ToTable("ACTTECNICOS");

                entity.HasIndex(e => e.Abreviatura)
                    .HasName("PRIMTEC")
                    .IsUnique();

                entity.Property(e => e.Abreviatura)
                    .HasColumnName("ABREVIATURA")
                    .HasColumnType("VARCHAR2(2)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Apenom)
                    .HasColumnName("APENOM")
                    .HasColumnType("VARCHAR2(50)");

                entity.Property(e => e.Puesto)
                    .HasColumnName("PUESTO")
                    .HasColumnType("VARCHAR2(70)");
            });

            modelBuilder.Entity<Actvarios>(entity =>
            {
                entity.HasKey(e => new { e.Ejercicio, e.Idact });

                entity.ToTable("ACTVARIOS");

                entity.HasIndex(e => new { e.Ejercicio, e.Idact })
                    .HasName("PRIMVARIOS")
                    .IsUnique();

                entity.Property(e => e.Ejercicio)
                    .HasColumnName("EJERCICIO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Idact)
                    .HasColumnName("IDACT")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Actividad)
                    .HasColumnName("ACTIVIDAD")
                    .HasColumnType("VARCHAR2(100)");

                entity.Property(e => e.Asunto)
                    .HasColumnName("ASUNTO")
                    .HasColumnType("VARCHAR2(200)");

                entity.Property(e => e.Año)
                    .HasColumnName("AÑO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Carpeta)
                    .HasColumnName("CARPETA")
                    .HasColumnType("VARCHAR2(8)");

                entity.Property(e => e.Denominacion)
                    .HasColumnName("DENOMINACION")
                    .HasColumnType("VARCHAR2(70)");

                entity.Property(e => e.Expediente)
                    .HasColumnName("EXPEDIENTE")
                    .HasColumnType("VARCHAR2(8)");

                entity.Property(e => e.Fent)
                    .HasColumnName("FENT")
                    .HasColumnType("DATE");

                entity.Property(e => e.Ffin)
                    .HasColumnName("FFIN")
                    .HasColumnType("DATE");

                entity.Property(e => e.Observaciones)
                    .HasColumnName("OBSERVACIONES")
                    .HasColumnType("VARCHAR2(1000)");
            });

            modelBuilder.Entity<Dismsg>(entity =>
            {
                entity.HasKey(e => e.Idexp);

                entity.ToTable("DISMSG");

                entity.HasIndex(e => e.Idexp)
                    .HasName("DISMSG_PK")
                    .IsUnique();

                entity.Property(e => e.Idexp)
                    .HasColumnName("IDEXP")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Antigua)
                    .HasColumnName("ANTIGUA")
                    .HasColumnType("VARCHAR2(20)");

                entity.Property(e => e.Caracter)
                    .HasColumnName("CARACTER")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Codplano)
                    .HasColumnName("CODPLANO")
                    .HasColumnType("VARCHAR2(15)");

                entity.Property(e => e.Codtabla)
                    .HasColumnName("CODTABLA")
                    .HasColumnType("VARCHAR2(15)");

                entity.Property(e => e.Departamento)
                    .HasColumnName("DEPARTAMENTO")
                    .HasColumnType("VARCHAR2(70)");

                entity.Property(e => e.Docin)
                    .HasColumnName("DOCIN")
                    .HasColumnType("VARCHAR2(200)");

                entity.Property(e => e.Ejercicio)
                    .HasColumnName("EJERCICIO")
                    .HasColumnType("VARCHAR2(4)");

                entity.Property(e => e.Fecrg)
                    .HasColumnName("FECRG")
                    .HasColumnType("DATE");

                entity.Property(e => e.Fecrp)
                    .HasColumnName("FECRP")
                    .HasColumnType("DATE");

                entity.Property(e => e.Fecterm)
                    .HasColumnName("FECTERM")
                    .HasColumnType("DATE");

                entity.Property(e => e.Inicio)
                    .HasColumnName("INICIO")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.Licencia)
                    .HasColumnName("LICENCIA")
                    .HasColumnType("VARCHAR2(150)");

                entity.Property(e => e.Liqren)
                    .HasColumnName("LIQREN")
                    .HasColumnType("VARCHAR2(60)");

                entity.Property(e => e.Motivo)
                    .HasColumnName("MOTIVO")
                    .HasColumnType("VARCHAR2(100)");

                entity.Property(e => e.Mslink)
                    .HasColumnName("MSLINK")
                    .HasColumnType("VARCHAR2(15)");

                entity.Property(e => e.Nexp)
                    .HasColumnName("NEXP")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Numrg)
                    .HasColumnName("NUMRG")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Numrp)
                    .HasColumnName("NUMRP")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Objeto)
                    .HasColumnName("OBJETO")
                    .HasColumnType("VARCHAR2(200)");

                entity.Property(e => e.Obs)
                    .HasColumnName("OBS")
                    .HasColumnType("VARCHAR2(1000)");

                entity.Property(e => e.Projud)
                    .HasColumnName("PROJUD")
                    .HasColumnType("VARCHAR2(60)");

                entity.Property(e => e.Seccion)
                    .HasColumnName("SECCION")
                    .HasColumnType("VARCHAR2(50)");

                entity.Property(e => e.Tipo)
                    .HasColumnName("TIPO")
                    .HasColumnType("VARCHAR2(3)");

                entity.Property(e => e.Tipobj)
                    .HasColumnName("TIPOBJ")
                    .HasColumnType("VARCHAR2(50)");
            });

            modelBuilder.Entity<Displu>(entity =>
            {
                entity.HasKey(e => e.Idexp);

                entity.ToTable("DISPLU");

                entity.HasIndex(e => e.Idexp)
                    .HasName("DISPLU_PK")
                    .IsUnique();

                entity.Property(e => e.Idexp)
                    .HasColumnName("IDEXP")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Actividades)
                    .HasColumnName("ACTIVIDADES")
                    .HasColumnType("VARCHAR2(150)");

                entity.Property(e => e.Antigua)
                    .HasColumnName("ANTIGUA")
                    .HasColumnType("VARCHAR2(20)");

                entity.Property(e => e.Cautelar)
                    .HasColumnName("CAUTELAR")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.Codplano)
                    .HasColumnName("CODPLANO")
                    .HasColumnType("VARCHAR2(15)");

                entity.Property(e => e.Codtabla)
                    .HasColumnName("CODTABLA")
                    .HasColumnType("VARCHAR2(15)");

                entity.Property(e => e.Departamento)
                    .HasColumnName("DEPARTAMENTO")
                    .HasColumnType("VARCHAR2(70)");

                entity.Property(e => e.Docin)
                    .HasColumnName("DOCIN")
                    .HasColumnType("VARCHAR2(200)");

                entity.Property(e => e.Ejercicio)
                    .HasColumnName("EJERCICIO")
                    .HasColumnType("VARCHAR2(4)");

                entity.Property(e => e.Fecrg)
                    .HasColumnName("FECRG")
                    .HasColumnType("DATE");

                entity.Property(e => e.Fecrp)
                    .HasColumnName("FECRP")
                    .HasColumnType("DATE");

                entity.Property(e => e.Fecterm)
                    .HasColumnName("FECTERM")
                    .HasColumnType("DATE");

                entity.Property(e => e.Finco)
                    .HasColumnName("FINCO")
                    .HasColumnType("DATE");

                entity.Property(e => e.Inicio)
                    .HasColumnName("INICIO")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.Licencia)
                    .HasColumnName("LICENCIA")
                    .HasColumnType("VARCHAR2(150)");

                entity.Property(e => e.Liqren)
                    .HasColumnName("LIQREN")
                    .HasColumnType("VARCHAR2(60)");

                entity.Property(e => e.Motivo)
                    .HasColumnName("MOTIVO")
                    .HasColumnType("VARCHAR2(100)");

                entity.Property(e => e.Mslink)
                    .HasColumnName("MSLINK")
                    .HasColumnType("VARCHAR2(15)");

                entity.Property(e => e.Nexp)
                    .HasColumnName("NEXP")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Numrg)
                    .HasColumnName("NUMRG")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Numrp)
                    .HasColumnName("NUMRP")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Objeto)
                    .HasColumnName("OBJETO")
                    .HasColumnType("VARCHAR2(200)");

                entity.Property(e => e.Obs)
                    .HasColumnName("OBS")
                    .HasColumnType("VARCHAR2(1000)");

                entity.Property(e => e.Projud)
                    .HasColumnName("PROJUD")
                    .HasColumnType("VARCHAR2(60)");

                entity.Property(e => e.Seccion)
                    .HasColumnName("SECCION")
                    .HasColumnType("VARCHAR2(50)");

                entity.Property(e => e.Tipo)
                    .HasColumnName("TIPO")
                    .HasColumnType("VARCHAR2(3)");

                entity.Property(e => e.Tipobj)
                    .HasColumnName("TIPOBJ")
                    .HasColumnType("VARCHAR2(50)");

                entity.Property(e => e.Tipoin)
                    .HasColumnName("TIPOIN")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.Tipopro)
                    .HasColumnName("TIPOPRO")
                    .HasColumnType("VARCHAR2(30)");
            });

            modelBuilder.Entity<Disvarios>(entity =>
            {
                entity.HasKey(e => e.Idexp);

                entity.ToTable("DISVARIOS");

                entity.HasIndex(e => e.Idexp)
                    .HasName("DISVARIOS_PK")
                    .IsUnique();

                entity.Property(e => e.Idexp)
                    .HasColumnName("IDEXP")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Antigua)
                    .HasColumnName("ANTIGUA")
                    .HasColumnType("VARCHAR2(20)");

                entity.Property(e => e.Codplano)
                    .HasColumnName("CODPLANO")
                    .HasColumnType("VARCHAR2(15)");

                entity.Property(e => e.Codtabla)
                    .HasColumnName("CODTABLA")
                    .HasColumnType("VARCHAR2(15)");

                entity.Property(e => e.Departamento)
                    .HasColumnName("DEPARTAMENTO")
                    .HasColumnType("VARCHAR2(70)");

                entity.Property(e => e.Docin)
                    .HasColumnName("DOCIN")
                    .HasColumnType("VARCHAR2(200)");

                entity.Property(e => e.Ejercicio)
                    .HasColumnName("EJERCICIO")
                    .HasColumnType("VARCHAR2(4)");

                entity.Property(e => e.Fecrg)
                    .HasColumnName("FECRG")
                    .HasColumnType("DATE");

                entity.Property(e => e.Fecrp)
                    .HasColumnName("FECRP")
                    .HasColumnType("DATE");

                entity.Property(e => e.Fecterm)
                    .HasColumnName("FECTERM")
                    .HasColumnType("DATE");

                entity.Property(e => e.Inicio)
                    .HasColumnName("INICIO")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.Licencia)
                    .HasColumnName("LICENCIA")
                    .HasColumnType("VARCHAR2(150)");

                entity.Property(e => e.Liqren)
                    .HasColumnName("LIQREN")
                    .HasColumnType("VARCHAR2(60)");

                entity.Property(e => e.Motivo)
                    .HasColumnName("MOTIVO")
                    .HasColumnType("VARCHAR2(100)");

                entity.Property(e => e.Mslink)
                    .HasColumnName("MSLINK")
                    .HasColumnType("VARCHAR2(15)");

                entity.Property(e => e.Nexp)
                    .HasColumnName("NEXP")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Numrg)
                    .HasColumnName("NUMRG")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Numrp)
                    .HasColumnName("NUMRP")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Objeto)
                    .HasColumnName("OBJETO")
                    .HasColumnType("VARCHAR2(200)");

                entity.Property(e => e.Obs)
                    .HasColumnName("OBS")
                    .HasColumnType("VARCHAR2(1000)");

                entity.Property(e => e.Seccion)
                    .HasColumnName("SECCION")
                    .HasColumnType("VARCHAR2(50)");

                entity.Property(e => e.Tipo)
                    .HasColumnName("TIPO")
                    .HasColumnType("VARCHAR2(3)");

                entity.Property(e => e.Tipobj)
                    .HasColumnName("TIPOBJ")
                    .HasColumnType("VARCHAR2(50)");
            });

            modelBuilder.Entity<Ineventos>(entity =>
            {
                entity.HasKey(e => e.Iden);

                entity.ToTable("INEVENTOS");

                entity.HasIndex(e => e.Iden)
                    .HasName("PRIMEVEN")
                    .IsUnique();

                entity.Property(e => e.Iden)
                    .HasColumnName("IDEN")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Dnipet)
                    .HasColumnName("DNIPET")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Dnirep)
                    .HasColumnName("DNIREP")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Docapro)
                    .HasColumnName("DOCAPRO")
                    .HasColumnType("VARCHAR2(300)");

                entity.Property(e => e.Evento)
                    .HasColumnName("EVENTO")
                    .HasColumnType("VARCHAR2(200)");

                entity.Property(e => e.Expediente)
                    .HasColumnName("EXPEDIENTE")
                    .HasColumnType("VARCHAR2(40)");

                entity.Property(e => e.Fecapro)
                    .HasColumnName("FECAPRO")
                    .HasColumnType("DATE");

                entity.Property(e => e.Fecfin)
                    .HasColumnName("FECFIN")
                    .HasColumnType("DATE");

                entity.Property(e => e.Fecini)
                    .HasColumnName("FECINI")
                    .HasColumnType("DATE");

                entity.Property(e => e.Fecpet)
                    .HasColumnName("FECPET")
                    .HasColumnType("DATE");

                entity.Property(e => e.Nompet)
                    .HasColumnName("NOMPET")
                    .HasColumnType("VARCHAR2(70)");

                entity.Property(e => e.Nomrep)
                    .HasColumnName("NOMREP")
                    .HasColumnType("VARCHAR2(70)");

                entity.Property(e => e.Observaciones)
                    .HasColumnName("OBSERVACIONES")
                    .HasColumnType("VARCHAR2(2000)");

                entity.Property(e => e.Organo)
                    .HasColumnName("ORGANO")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.Otro)
                    .HasColumnName("OTRO")
                    .HasColumnType("VARCHAR2(50)");

                entity.Property(e => e.Peticion)
                    .HasColumnName("PETICION")
                    .HasColumnType("VARCHAR2(400)");

                entity.Property(e => e.Procedencia)
                    .HasColumnName("PROCEDENCIA")
                    .HasColumnType("VARCHAR2(80)");

                entity.Property(e => e.Reseven)
                    .HasColumnName("RESEVEN")
                    .HasColumnType("VARCHAR2(20)");

                entity.Property(e => e.Ubicacion)
                    .HasColumnName("UBICACION")
                    .HasColumnType("VARCHAR2(200)");
            });

            modelBuilder.Entity<Invehiculos>(entity =>
            {
                entity.HasKey(e => e.Matricula);

                entity.ToTable("INVEHICULOS");

                entity.HasIndex(e => e.Matricula)
                    .HasName("INPRIMVEHI")
                    .IsUnique();

                entity.Property(e => e.Matricula)
                    .HasColumnName("MATRICULA")
                    .HasColumnType("VARCHAR2(12)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Anoi)
                    .HasColumnName("ANOI")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Baja)
                    .HasColumnName("BAJA")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.Documentacion)
                    .HasColumnName("DOCUMENTACION")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.Fechabaj)
                    .HasColumnName("FECHABAJ")
                    .HasColumnType("DATE");

                entity.Property(e => e.Fechadoc)
                    .HasColumnName("FECHADOC")
                    .HasColumnType("DATE");

                entity.Property(e => e.Fechaitv)
                    .HasColumnName("FECHAITV")
                    .HasColumnType("DATE");

                entity.Property(e => e.Fechamat)
                    .HasColumnName("FECHAMAT")
                    .HasColumnType("DATE");

                entity.Property(e => e.Fechase)
                    .HasColumnName("FECHASE")
                    .HasColumnType("DATE");

                entity.Property(e => e.Forma)
                    .HasColumnName("FORMA")
                    .HasColumnType("VARCHAR2(50)");

                entity.Property(e => e.Marca)
                    .HasColumnName("MARCA")
                    .HasColumnType("VARCHAR2(50)");

                entity.Property(e => e.Modelo)
                    .HasColumnName("MODELO")
                    .HasColumnType("VARCHAR2(50)");

                entity.Property(e => e.Observaciones)
                    .HasColumnName("OBSERVACIONES")
                    .HasColumnType("VARCHAR2(500)");

                entity.Property(e => e.Seccion)
                    .HasColumnName("SECCION")
                    .HasColumnType("VARCHAR2(30)");

                entity.Property(e => e.Seguro)
                    .HasColumnName("SEGURO")
                    .HasColumnType("VARCHAR2(50)");

                entity.Property(e => e.Servicio)
                    .HasColumnName("SERVICIO")
                    .HasColumnType("VARCHAR2(30)");

                entity.Property(e => e.Tarjeta)
                    .HasColumnName("TARJETA")
                    .HasColumnType("VARCHAR2(30)");

                entity.Property(e => e.Tipo)
                    .HasColumnName("TIPO")
                    .HasColumnType("VARCHAR2(50)");
            });

            modelBuilder.Entity<Licobramenor>(entity =>
            {
                entity.HasKey(e => e.Idexp);

                entity.ToTable("LICOBRAMENOR");

                entity.HasIndex(e => e.Idexp)
                    .HasName("LICOBRAMENOR_PK")
                    .IsUnique();

                entity.Property(e => e.Idexp)
                    .HasColumnName("IDEXP")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Apenom)
                    .HasColumnName("APENOM")
                    .HasColumnType("VARCHAR2(150)");

                entity.Property(e => e.Calicata)
                    .HasColumnName("CALICATA")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Cif)
                    .HasColumnName("CIF")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Codplano)
                    .HasColumnName("CODPLANO")
                    .HasColumnType("VARCHAR2(15)");

                entity.Property(e => e.Codtabla)
                    .HasColumnName("CODTABLA")
                    .HasColumnType("VARCHAR2(15)");

                entity.Property(e => e.Direccione)
                    .HasColumnName("DIRECCIONE")
                    .HasColumnType("VARCHAR2(100)");

                entity.Property(e => e.Direccions)
                    .HasColumnName("DIRECCIONS")
                    .HasColumnType("VARCHAR2(100)");

                entity.Property(e => e.Ejercicio)
                    .HasColumnName("EJERCICIO")
                    .HasColumnType("VARCHAR2(4)");

                entity.Property(e => e.Feccon)
                    .HasColumnName("FECCON")
                    .HasColumnType("DATE");

                entity.Property(e => e.Fecent)
                    .HasColumnName("FECENT")
                    .HasColumnType("DATE");

                entity.Property(e => e.Fecrg)
                    .HasColumnName("FECRG")
                    .HasColumnType("DATE");

                entity.Property(e => e.Inex)
                    .HasColumnName("INEX")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.Maile)
                    .HasColumnName("MAILE")
                    .HasColumnType("VARCHAR2(100)");

                entity.Property(e => e.Mails)
                    .HasColumnName("MAILS")
                    .HasColumnType("VARCHAR2(100)");

                entity.Property(e => e.Mslink)
                    .HasColumnName("MSLINK")
                    .HasColumnType("VARCHAR2(15)");

                entity.Property(e => e.Nexp)
                    .HasColumnName("NEXP")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Nif)
                    .HasColumnName("NIF")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Numrg)
                    .HasColumnName("NUMRG")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Objeto)
                    .HasColumnName("OBJETO")
                    .HasColumnType("VARCHAR2(200)");

                entity.Property(e => e.Obs)
                    .HasColumnName("OBS")
                    .HasColumnType("VARCHAR2(1000)");

                entity.Property(e => e.Permiso)
                    .HasColumnName("PERMISO")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Presupuesto)
                    .HasColumnName("PRESUPUESTO")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Razon)
                    .HasColumnName("RAZON")
                    .HasColumnType("VARCHAR2(150)");

                entity.Property(e => e.Refcat)
                    .HasColumnName("REFCAT")
                    .HasColumnType("VARCHAR2(20)");

                entity.Property(e => e.Rep)
                    .HasColumnName("REP")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.Seccion)
                    .HasColumnName("SECCION")
                    .HasColumnType("VARCHAR2(50)");

                entity.Property(e => e.Tfne)
                    .HasColumnName("TFNE")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Tfns)
                    .HasColumnName("TFNS")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Tipo)
                    .HasColumnName("TIPO")
                    .HasColumnType("VARCHAR2(3)");
            });

            modelBuilder.Entity<Pactuabien>(entity =>
            {
                entity.HasKey(e => new { e.Idbien, e.Fecha, e.Actuacion });

                entity.ToTable("PACTUABIEN");

                entity.HasIndex(e => new { e.Idbien, e.Fecha, e.Actuacion })
                    .HasName("PRIMACTUAB")
                    .IsUnique();

                entity.Property(e => e.Idbien)
                    .HasColumnName("IDBIEN")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Fecha)
                    .HasColumnName("FECHA")
                    .HasColumnType("DATE");

                entity.Property(e => e.Actuacion)
                    .HasColumnName("ACTUACION")
                    .HasColumnType("VARCHAR2(70)");

                entity.Property(e => e.Ultima)
                    .HasColumnName("ULTIMA")
                    .HasColumnType("VARCHAR2(1)");
            });

            modelBuilder.Entity<Pactuaciones>(entity =>
            {
                entity.HasKey(e => new { e.Fecha, e.Descripcion, e.Idexp });

                entity.ToTable("PACTUACIONES");

                entity.HasIndex(e => new { e.Fecha, e.Descripcion, e.Idexp })
                    .HasName("PRIMACTEXP")
                    .IsUnique();

                entity.Property(e => e.Fecha)
                    .HasColumnName("FECHA")
                    .HasColumnType("DATE");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasColumnType("VARCHAR2(2500)");

                entity.Property(e => e.Idexp).HasColumnName("IDEXP");

                entity.Property(e => e.Registro)
                    .HasColumnName("REGISTRO")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Ultima)
                    .HasColumnName("ULTIMA")
                    .HasColumnType("VARCHAR2(1)");
            });

            modelBuilder.Entity<Parrendamiento>(entity =>
            {
                entity.HasKey(e => e.Idbien);

                entity.ToTable("PARRENDAMIENTO");

                entity.HasIndex(e => e.Idbien)
                    .HasName("PRIMARREN")
                    .IsUnique();

                entity.Property(e => e.Idbien)
                    .HasColumnName("IDBIEN")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Apenom1)
                    .HasColumnName("APENOM1")
                    .HasColumnType("VARCHAR2(70)");

                entity.Property(e => e.Apenom2)
                    .HasColumnName("APENOM2")
                    .HasColumnType("VARCHAR2(70)");

                entity.Property(e => e.Cauext)
                    .HasColumnName("CAUEXT")
                    .HasColumnType("VARCHAR2(100)");

                entity.Property(e => e.Caupro)
                    .HasColumnName("CAUPRO")
                    .HasColumnType("VARCHAR2(60)");

                entity.Property(e => e.Destino)
                    .HasColumnName("DESTINO")
                    .HasColumnType("VARCHAR2(200)");

                entity.Property(e => e.Ejercicio)
                    .HasColumnName("EJERCICIO")
                    .HasColumnType("VARCHAR2(4)");

                entity.Property(e => e.Expediente)
                    .HasColumnName("EXPEDIENTE")
                    .HasColumnType("VARCHAR2(8)");

                entity.Property(e => e.Extin)
                    .HasColumnName("EXTIN")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.Fecdoc)
                    .HasColumnName("FECDOC")
                    .HasColumnType("DATE");

                entity.Property(e => e.Fecext)
                    .HasColumnName("FECEXT")
                    .HasColumnType("DATE");

                entity.Property(e => e.Fechaac)
                    .HasColumnName("FECHAAC")
                    .HasColumnType("DATE");

                entity.Property(e => e.Iden1)
                    .HasColumnName("IDEN1")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Iden2)
                    .HasColumnName("IDEN2")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Increm)
                    .HasColumnName("INCREM")
                    .HasColumnType("DATE");

                entity.Property(e => e.Noti)
                    .HasColumnName("NOTI")
                    .HasColumnType("VARCHAR2(70)");

                entity.Property(e => e.Numesc)
                    .HasColumnName("NUMESC")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Obs)
                    .HasColumnName("OBS")
                    .HasColumnType("VARCHAR2(1000)");

                entity.Property(e => e.Organo)
                    .HasColumnName("ORGANO")
                    .HasColumnType("VARCHAR2(30)");

                entity.Property(e => e.Proxima)
                    .HasColumnName("PROXIMA")
                    .HasColumnType("DATE");

                entity.Property(e => e.Renta)
                    .HasColumnName("RENTA")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Tipdoc)
                    .HasColumnName("TIPDOC")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.Tipo)
                    .HasColumnName("TIPO")
                    .HasColumnType("VARCHAR2(40)");
            });

            modelBuilder.Entity<Pattipbien>(entity =>
            {
                entity.HasKey(e => e.Descripcion);

                entity.ToTable("PATTIPBIEN");

                entity.HasIndex(e => e.Descripcion)
                    .HasName("PRIMTBIEN")
                    .IsUnique();

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasColumnType("VARCHAR2(70)")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<Pbiendest>(entity =>
            {
                entity.HasKey(e => new { e.Tipo, e.Idbien });

                entity.ToTable("PBIENDEST");

                entity.HasIndex(e => new { e.Tipo, e.Idbien })
                    .HasName("PRIMDEST")
                    .IsUnique();

                entity.Property(e => e.Tipo)
                    .HasColumnName("TIPO")
                    .HasColumnType("VARCHAR2(50)");

                entity.Property(e => e.Idbien)
                    .HasColumnName("IDBIEN")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Destino)
                    .HasColumnName("DESTINO")
                    .HasColumnType("VARCHAR2(200)");

                entity.Property(e => e.Extinguido)
                    .HasColumnName("EXTINGUIDO")
                    .HasColumnType("VARCHAR2(1)");
            });

            modelBuilder.Entity<Pbienes>(entity =>
            {
                entity.HasKey(e => e.Idbien);

                entity.ToTable("PBIENES");

                entity.HasIndex(e => e.Idbien)
                    .HasName("PRIMBIEN")
                    .IsUnique();

                entity.Property(e => e.Idbien)
                    .HasColumnName("IDBIEN")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Acausa)
                    .HasColumnName("ACAUSA")
                    .HasColumnType("VARCHAR2(50)");

                entity.Property(e => e.Aexp1)
                    .HasColumnName("AEXP1")
                    .HasColumnType("VARCHAR2(30)");

                entity.Property(e => e.Aexp2)
                    .HasColumnName("AEXP2")
                    .HasColumnType("VARCHAR2(4)");

                entity.Property(e => e.Aexp3)
                    .HasColumnName("AEXP3")
                    .HasColumnType("VARCHAR2(4)");

                entity.Property(e => e.Aorg)
                    .HasColumnName("AORG")
                    .HasColumnType("VARCHAR2(25)");

                entity.Property(e => e.Bcausa)
                    .HasColumnName("BCAUSA")
                    .HasColumnType("VARCHAR2(50)");

                entity.Property(e => e.Bexp1)
                    .HasColumnName("BEXP1")
                    .HasColumnType("VARCHAR2(30)");

                entity.Property(e => e.Bexp2)
                    .HasColumnName("BEXP2")
                    .HasColumnType("VARCHAR2(4)");

                entity.Property(e => e.Bexp3)
                    .HasColumnName("BEXP3")
                    .HasColumnType("VARCHAR2(4)");

                entity.Property(e => e.Borg)
                    .HasColumnName("BORG")
                    .HasColumnType("VARCHAR2(25)");

                entity.Property(e => e.Clase)
                    .HasColumnName("CLASE")
                    .HasColumnType("VARCHAR2(25)");

                entity.Property(e => e.Concepto)
                    .HasColumnName("CONCEPTO")
                    .HasColumnType("VARCHAR2(80)");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasColumnType("VARCHAR2(70)");

                entity.Property(e => e.Ejercicio)
                    .HasColumnName("EJERCICIO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Expediente)
                    .HasColumnName("EXPEDIENTE")
                    .HasColumnType("VARCHAR2(8)");

                entity.Property(e => e.Falta)
                    .HasColumnName("FALTA")
                    .HasColumnType("DATE");

                entity.Property(e => e.Fbaja)
                    .HasColumnName("FBAJA")
                    .HasColumnType("DATE");

                entity.Property(e => e.Fechac)
                    .HasColumnName("FECHAC")
                    .HasColumnType("DATE");

                entity.Property(e => e.Fechae)
                    .HasColumnName("FECHAE")
                    .HasColumnType("DATE");

                entity.Property(e => e.Fechain)
                    .HasColumnName("FECHAIN")
                    .HasColumnType("DATE");

                entity.Property(e => e.Fechao)
                    .HasColumnName("FECHAO")
                    .HasColumnType("DATE");

                entity.Property(e => e.Fechaoc)
                    .HasColumnName("FECHAOC")
                    .HasColumnType("DATE");

                entity.Property(e => e.Finca)
                    .HasColumnName("FINCA")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Folio)
                    .HasColumnName("FOLIO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Identificador)
                    .HasColumnName("IDENTIFICADOR")
                    .HasColumnType("VARCHAR2(7)");

                entity.Property(e => e.Inscripcion)
                    .HasColumnName("INSCRIPCION")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Inventariada)
                    .HasColumnName("INVENTARIADA")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.Libre)
                    .HasColumnName("LIBRE")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.Libro)
                    .HasColumnName("LIBRO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Line)
                    .HasColumnName("LINE")
                    .HasColumnType("VARCHAR2(40)");

                entity.Property(e => e.Linn)
                    .HasColumnName("LINN")
                    .HasColumnType("VARCHAR2(40)");

                entity.Property(e => e.Lino)
                    .HasColumnName("LINO")
                    .HasColumnType("VARCHAR2(40)");

                entity.Property(e => e.Lins)
                    .HasColumnName("LINS")
                    .HasColumnType("VARCHAR2(40)");

                entity.Property(e => e.Mslink)
                    .HasColumnName("MSLINK")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Naturaleza)
                    .HasColumnName("NATURALEZA")
                    .HasColumnType("VARCHAR2(40)");

                entity.Property(e => e.Notario)
                    .HasColumnName("NOTARIO")
                    .HasColumnType("VARCHAR2(80)");

                entity.Property(e => e.Nume)
                    .HasColumnName("NUME")
                    .HasColumnType("VARCHAR2(15)");

                entity.Property(e => e.Numinv)
                    .HasColumnName("NUMINV")
                    .HasColumnType("VARCHAR2(15)");

                entity.Property(e => e.Numinva)
                    .HasColumnName("NUMINVA")
                    .HasColumnType("VARCHAR2(15)");

                entity.Property(e => e.Observaciones)
                    .HasColumnName("OBSERVACIONES")
                    .HasColumnType("VARCHAR2(1550)");

                entity.Property(e => e.Organo)
                    .HasColumnName("ORGANO")
                    .HasColumnType("VARCHAR2(25)");

                entity.Property(e => e.Scon)
                    .HasColumnName("SCON")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Sdep)
                    .HasColumnName("SDEP")
                    .HasColumnType("VARCHAR2(50)");

                entity.Property(e => e.Slib)
                    .HasColumnName("SLIB")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Splan)
                    .HasColumnName("SPLAN")
                    .HasColumnType("VARCHAR2(12)");

                entity.Property(e => e.Sreal)
                    .HasColumnName("SREAL")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Stit)
                    .HasColumnName("STIT")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Tipo)
                    .HasColumnName("TIPO")
                    .HasColumnType("VARCHAR2(40)");

                entity.Property(e => e.Titulo)
                    .HasColumnName("TITULO")
                    .HasColumnType("VARCHAR2(50)");

                entity.Property(e => e.Tomo)
                    .HasColumnName("TOMO")
                    .HasColumnType("NUMBER");
            });

            modelBuilder.Entity<Pbieniden>(entity =>
            {
                entity.HasKey(e => new { e.Apenom, e.Tipo, e.Idbien });

                entity.ToTable("PBIENIDEN");

                entity.HasIndex(e => new { e.Apenom, e.Tipo, e.Idbien })
                    .HasName("PRIMIDEN")
                    .IsUnique();

                entity.Property(e => e.Apenom)
                    .HasColumnName("APENOM")
                    .HasColumnType("VARCHAR2(100)");

                entity.Property(e => e.Tipo)
                    .HasColumnName("TIPO")
                    .HasColumnType("VARCHAR2(50)");

                entity.Property(e => e.Idbien)
                    .HasColumnName("IDBIEN")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Nif)
                    .HasColumnName("NIF")
                    .HasColumnType("VARCHAR2(10)");
            });

            modelBuilder.Entity<Pcesiong>(entity =>
            {
                entity.HasKey(e => e.Idbien);

                entity.ToTable("PCESIONG");

                entity.HasIndex(e => e.Idbien)
                    .HasName("PRINCESIONGR")
                    .IsUnique();

                entity.Property(e => e.Idbien)
                    .HasColumnName("IDBIEN")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Apenom1)
                    .HasColumnName("APENOM1")
                    .HasColumnType("VARCHAR2(70)");

                entity.Property(e => e.Apenom2)
                    .HasColumnName("APENOM2")
                    .HasColumnType("VARCHAR2(70)");

                entity.Property(e => e.Cauext)
                    .HasColumnName("CAUEXT")
                    .HasColumnType("VARCHAR2(100)");

                entity.Property(e => e.Caupro)
                    .HasColumnName("CAUPRO")
                    .HasColumnType("VARCHAR2(60)");

                entity.Property(e => e.Destino)
                    .HasColumnName("DESTINO")
                    .HasColumnType("VARCHAR2(200)");

                entity.Property(e => e.Ejercicio)
                    .HasColumnName("EJERCICIO")
                    .HasColumnType("VARCHAR2(4)");

                entity.Property(e => e.Expediente)
                    .HasColumnName("EXPEDIENTE")
                    .HasColumnType("VARCHAR2(8)");

                entity.Property(e => e.Extin)
                    .HasColumnName("EXTIN")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.Fecdoc)
                    .HasColumnName("FECDOC")
                    .HasColumnType("DATE");

                entity.Property(e => e.Fecext)
                    .HasColumnName("FECEXT")
                    .HasColumnType("DATE");

                entity.Property(e => e.Fechaac)
                    .HasColumnName("FECHAAC")
                    .HasColumnType("DATE");

                entity.Property(e => e.Iden1)
                    .HasColumnName("IDEN1")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Iden2)
                    .HasColumnName("IDEN2")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Noti)
                    .HasColumnName("NOTI")
                    .HasColumnType("VARCHAR2(70)");

                entity.Property(e => e.Numesc)
                    .HasColumnName("NUMESC")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Obs)
                    .HasColumnName("OBS")
                    .HasColumnType("VARCHAR2(1000)");

                entity.Property(e => e.Organo)
                    .HasColumnName("ORGANO")
                    .HasColumnType("VARCHAR2(30)");

                entity.Property(e => e.Plazovi)
                    .HasColumnName("PLAZOVI")
                    .HasColumnType("DATE");

                entity.Property(e => e.Proxima)
                    .HasColumnName("PROXIMA")
                    .HasColumnType("DATE");

                entity.Property(e => e.Tipdoc)
                    .HasColumnName("TIPDOC")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.Tipo)
                    .HasColumnName("TIPO")
                    .HasColumnType("VARCHAR2(40)");
            });

            modelBuilder.Entity<Pcesiono>(entity =>
            {
                entity.HasKey(e => e.Idbien);

                entity.ToTable("PCESIONO");

                entity.HasIndex(e => e.Idbien)
                    .HasName("CESIONOPRIM")
                    .IsUnique();

                entity.Property(e => e.Idbien)
                    .HasColumnName("IDBIEN")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Apenom1)
                    .HasColumnName("APENOM1")
                    .HasColumnType("VARCHAR2(70)");

                entity.Property(e => e.Apenom2)
                    .HasColumnName("APENOM2")
                    .HasColumnType("VARCHAR2(70)");

                entity.Property(e => e.Cauext)
                    .HasColumnName("CAUEXT")
                    .HasColumnType("VARCHAR2(100)");

                entity.Property(e => e.Caupro)
                    .HasColumnName("CAUPRO")
                    .HasColumnType("VARCHAR2(60)");

                entity.Property(e => e.Destino)
                    .HasColumnName("DESTINO")
                    .HasColumnType("VARCHAR2(200)");

                entity.Property(e => e.Ejercicio)
                    .HasColumnName("EJERCICIO")
                    .HasColumnType("VARCHAR2(4)");

                entity.Property(e => e.Expediente)
                    .HasColumnName("EXPEDIENTE")
                    .HasColumnType("VARCHAR2(8)");

                entity.Property(e => e.Extin)
                    .HasColumnName("EXTIN")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.Fecdoc)
                    .HasColumnName("FECDOC")
                    .HasColumnType("DATE");

                entity.Property(e => e.Fecext)
                    .HasColumnName("FECEXT")
                    .HasColumnType("DATE");

                entity.Property(e => e.Fechaac)
                    .HasColumnName("FECHAAC")
                    .HasColumnType("DATE");

                entity.Property(e => e.Iden1)
                    .HasColumnName("IDEN1")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Iden2)
                    .HasColumnName("IDEN2")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Increm)
                    .HasColumnName("INCREM")
                    .HasColumnType("DATE");

                entity.Property(e => e.Noti)
                    .HasColumnName("NOTI")
                    .HasColumnType("VARCHAR2(70)");

                entity.Property(e => e.Numesc)
                    .HasColumnName("NUMESC")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Obs)
                    .HasColumnName("OBS")
                    .HasColumnType("VARCHAR2(1000)");

                entity.Property(e => e.Organo)
                    .HasColumnName("ORGANO")
                    .HasColumnType("VARCHAR2(30)");

                entity.Property(e => e.Proxima)
                    .HasColumnName("PROXIMA")
                    .HasColumnType("DATE");

                entity.Property(e => e.Renta)
                    .HasColumnName("RENTA")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Tipdoc)
                    .HasColumnName("TIPDOC")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.Tipo)
                    .HasColumnName("TIPO")
                    .HasColumnType("VARCHAR2(40)");
            });

            modelBuilder.Entity<Pcesionp>(entity =>
            {
                entity.HasKey(e => e.Idbien);

                entity.ToTable("PCESIONP");

                entity.HasIndex(e => e.Idbien)
                    .HasName("PRINCESIONP")
                    .IsUnique();

                entity.Property(e => e.Idbien)
                    .HasColumnName("IDBIEN")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Apenom1)
                    .HasColumnName("APENOM1")
                    .HasColumnType("VARCHAR2(70)");

                entity.Property(e => e.Apenom2)
                    .HasColumnName("APENOM2")
                    .HasColumnType("VARCHAR2(70)");

                entity.Property(e => e.Cauext)
                    .HasColumnName("CAUEXT")
                    .HasColumnType("VARCHAR2(100)");

                entity.Property(e => e.Caupro)
                    .HasColumnName("CAUPRO")
                    .HasColumnType("VARCHAR2(60)");

                entity.Property(e => e.Destino)
                    .HasColumnName("DESTINO")
                    .HasColumnType("VARCHAR2(200)");

                entity.Property(e => e.Ejercicio)
                    .HasColumnName("EJERCICIO")
                    .HasColumnType("VARCHAR2(4)");

                entity.Property(e => e.Expediente)
                    .HasColumnName("EXPEDIENTE")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Extin)
                    .HasColumnName("EXTIN")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.Fecdoc)
                    .HasColumnName("FECDOC")
                    .HasColumnType("DATE");

                entity.Property(e => e.Fecext)
                    .HasColumnName("FECEXT")
                    .HasColumnType("DATE");

                entity.Property(e => e.Fechaac)
                    .HasColumnName("FECHAAC")
                    .HasColumnType("DATE");

                entity.Property(e => e.Iden1)
                    .HasColumnName("IDEN1")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Iden2)
                    .HasColumnName("IDEN2")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Noti)
                    .HasColumnName("NOTI")
                    .HasColumnType("VARCHAR2(70)");

                entity.Property(e => e.Numesc)
                    .HasColumnName("NUMESC")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Obs)
                    .HasColumnName("OBS")
                    .HasColumnType("VARCHAR2(1000)");

                entity.Property(e => e.Organo)
                    .HasColumnName("ORGANO")
                    .HasColumnType("VARCHAR2(30)");

                entity.Property(e => e.Plazocon)
                    .HasColumnName("PLAZOCON")
                    .HasColumnType("DATE");

                entity.Property(e => e.Plazoman)
                    .HasColumnName("PLAZOMAN")
                    .HasColumnType("DATE");

                entity.Property(e => e.Plazovi)
                    .HasColumnName("PLAZOVI")
                    .HasColumnType("DATE");

                entity.Property(e => e.Proxima)
                    .HasColumnName("PROXIMA")
                    .HasColumnType("DATE");

                entity.Property(e => e.Tipdoc)
                    .HasColumnName("TIPDOC")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.Tipo)
                    .HasColumnName("TIPO")
                    .HasColumnType("VARCHAR2(40)");
            });

            modelBuilder.Entity<Pcomprueba>(entity =>
            {
                entity.HasKey(e => new { e.Idbien, e.Tipo });

                entity.ToTable("PCOMPRUEBA");

                entity.HasIndex(e => new { e.Idbien, e.Tipo })
                    .HasName("PRINCOMP")
                    .IsUnique();

                entity.Property(e => e.Idbien)
                    .HasColumnName("IDBIEN")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Tipo)
                    .HasColumnName("TIPO")
                    .HasColumnType("VARCHAR2(50)");

                entity.Property(e => e.Causa)
                    .HasColumnName("CAUSA")
                    .HasColumnType("VARCHAR2(100)");

                entity.Property(e => e.Fecha)
                    .HasColumnName("FECHA")
                    .HasColumnType("DATE");
            });

            modelBuilder.Entity<Pconcesion>(entity =>
            {
                entity.HasKey(e => e.Idbien);

                entity.ToTable("PCONCESION");

                entity.HasIndex(e => e.Idbien)
                    .HasName("PRIMCONCE")
                    .IsUnique();

                entity.Property(e => e.Idbien)
                    .HasColumnName("IDBIEN")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Apenom1)
                    .HasColumnName("APENOM1")
                    .HasColumnType("VARCHAR2(70)");

                entity.Property(e => e.Apenom2)
                    .HasColumnName("APENOM2")
                    .HasColumnType("VARCHAR2(70)");

                entity.Property(e => e.Canon)
                    .HasColumnName("CANON")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Cauext)
                    .HasColumnName("CAUEXT")
                    .HasColumnType("VARCHAR2(100)");

                entity.Property(e => e.Caupro)
                    .HasColumnName("CAUPRO")
                    .HasColumnType("VARCHAR2(60)");

                entity.Property(e => e.Destino)
                    .HasColumnName("DESTINO")
                    .HasColumnType("VARCHAR2(200)");

                entity.Property(e => e.Ejercicio)
                    .HasColumnName("EJERCICIO")
                    .HasColumnType("VARCHAR2(4)");

                entity.Property(e => e.Expediente)
                    .HasColumnName("EXPEDIENTE")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Extin)
                    .HasColumnName("EXTIN")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.Fecdoc)
                    .HasColumnName("FECDOC")
                    .HasColumnType("DATE");

                entity.Property(e => e.Fecext)
                    .HasColumnName("FECEXT")
                    .HasColumnType("DATE");

                entity.Property(e => e.Fechaac)
                    .HasColumnName("FECHAAC")
                    .HasColumnType("DATE");

                entity.Property(e => e.Iden1)
                    .HasColumnName("IDEN1")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Iden2)
                    .HasColumnName("IDEN2")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Noti)
                    .HasColumnName("NOTI")
                    .HasColumnType("VARCHAR2(70)");

                entity.Property(e => e.Numesc)
                    .HasColumnName("NUMESC")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Obs)
                    .HasColumnName("OBS")
                    .HasColumnType("VARCHAR2(1000)");

                entity.Property(e => e.Organo)
                    .HasColumnName("ORGANO")
                    .HasColumnType("VARCHAR2(30)");

                entity.Property(e => e.Proxima)
                    .HasColumnName("PROXIMA")
                    .HasColumnType("DATE");

                entity.Property(e => e.Tipdoc)
                    .HasColumnName("TIPDOC")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.Tipo)
                    .HasColumnName("TIPO")
                    .HasColumnType("VARCHAR2(40)");
            });

            modelBuilder.Entity<Pdemaniales>(entity =>
            {
                entity.HasKey(e => e.Idbien);

                entity.ToTable("PDEMANIALES");

                entity.HasIndex(e => e.Idbien)
                    .HasName("PRIMDEMA")
                    .IsUnique();

                entity.Property(e => e.Idbien)
                    .HasColumnName("IDBIEN")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Apenom)
                    .HasColumnName("APENOM")
                    .HasColumnType("VARCHAR2(100)");

                entity.Property(e => e.Cauext)
                    .HasColumnName("CAUEXT")
                    .HasColumnType("VARCHAR2(100)");

                entity.Property(e => e.Caupro)
                    .HasColumnName("CAUPRO")
                    .HasColumnType("VARCHAR2(60)");

                entity.Property(e => e.Clase)
                    .HasColumnName("CLASE")
                    .HasColumnType("VARCHAR2(70)");

                entity.Property(e => e.Codigo)
                    .HasColumnName("CODIGO")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasColumnType("VARCHAR2(200)");

                entity.Property(e => e.Destino)
                    .HasColumnName("DESTINO")
                    .HasColumnType("VARCHAR2(200)");

                entity.Property(e => e.Extin)
                    .HasColumnName("EXTIN")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.Fecdoc)
                    .HasColumnName("FECDOC")
                    .HasColumnType("DATE");

                entity.Property(e => e.Fecext)
                    .HasColumnName("FECEXT")
                    .HasColumnType("DATE");

                entity.Property(e => e.Fechaac)
                    .HasColumnName("FECHAAC")
                    .HasColumnType("DATE");

                entity.Property(e => e.Naturaleza)
                    .HasColumnName("NATURALEZA")
                    .HasColumnType("VARCHAR2(40)");

                entity.Property(e => e.Nif)
                    .HasColumnName("NIF")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Noti)
                    .HasColumnName("NOTI")
                    .HasColumnType("VARCHAR2(70)");

                entity.Property(e => e.Numesc)
                    .HasColumnName("NUMESC")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Obs)
                    .HasColumnName("OBS")
                    .HasColumnType("VARCHAR2(1000)");

                entity.Property(e => e.Organo)
                    .HasColumnName("ORGANO")
                    .HasColumnType("VARCHAR2(30)");

                entity.Property(e => e.Proxima)
                    .HasColumnName("PROXIMA")
                    .HasColumnType("DATE");

                entity.Property(e => e.Superficie)
                    .HasColumnName("SUPERFICIE")
                    .HasColumnType("VARCHAR2(20)");

                entity.Property(e => e.Tipdoc)
                    .HasColumnName("TIPDOC")
                    .HasColumnType("VARCHAR2(1)");
            });

            modelBuilder.Entity<Pdepartamento>(entity =>
            {
                entity.HasKey(e => e.Denominacion);

                entity.ToTable("PDEPARTAMENTO");

                entity.HasIndex(e => e.Denominacion)
                    .HasName("PRIMDEP")
                    .IsUnique();

                entity.Property(e => e.Denominacion)
                    .HasColumnName("DENOMINACION")
                    .HasColumnType("VARCHAR2(70)")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<Pderechosu>(entity =>
            {
                entity.HasKey(e => e.Idbien);

                entity.ToTable("PDERECHOSU");

                entity.HasIndex(e => e.Idbien)
                    .HasName("PRIMDESHU")
                    .IsUnique();

                entity.Property(e => e.Idbien)
                    .HasColumnName("IDBIEN")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Apenom1)
                    .HasColumnName("APENOM1")
                    .HasColumnType("VARCHAR2(70)");

                entity.Property(e => e.Apenom2)
                    .HasColumnName("APENOM2")
                    .HasColumnType("VARCHAR2(70)");

                entity.Property(e => e.Cauext)
                    .HasColumnName("CAUEXT")
                    .HasColumnType("VARCHAR2(100)");

                entity.Property(e => e.Caupro)
                    .HasColumnName("CAUPRO")
                    .HasColumnType("VARCHAR2(60)");

                entity.Property(e => e.Construccion)
                    .HasColumnName("CONSTRUCCION")
                    .HasColumnType("DATE");

                entity.Property(e => e.Destino)
                    .HasColumnName("DESTINO")
                    .HasColumnType("VARCHAR2(200)");

                entity.Property(e => e.Ejercicio)
                    .HasColumnName("EJERCICIO")
                    .HasColumnType("VARCHAR2(4)");

                entity.Property(e => e.Expediente)
                    .HasColumnName("EXPEDIENTE")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Extin)
                    .HasColumnName("EXTIN")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.Fecdoc)
                    .HasColumnName("FECDOC")
                    .HasColumnType("DATE");

                entity.Property(e => e.Fecext)
                    .HasColumnName("FECEXT")
                    .HasColumnType("DATE");

                entity.Property(e => e.Fechaac)
                    .HasColumnName("FECHAAC")
                    .HasColumnType("DATE");

                entity.Property(e => e.Gratis)
                    .HasColumnName("GRATIS")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.Iden1)
                    .HasColumnName("IDEN1")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Iden2)
                    .HasColumnName("IDEN2")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Increm)
                    .HasColumnName("INCREM")
                    .HasColumnType("DATE");

                entity.Property(e => e.Noti)
                    .HasColumnName("NOTI")
                    .HasColumnType("VARCHAR2(70)");

                entity.Property(e => e.Numesc)
                    .HasColumnName("NUMESC")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Obs)
                    .HasColumnName("OBS")
                    .HasColumnType("VARCHAR2(1000)");

                entity.Property(e => e.Organo)
                    .HasColumnName("ORGANO")
                    .HasColumnType("VARCHAR2(30)");

                entity.Property(e => e.Proxima)
                    .HasColumnName("PROXIMA")
                    .HasColumnType("DATE");

                entity.Property(e => e.Renta)
                    .HasColumnName("RENTA")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Reversion)
                    .HasColumnName("REVERSION")
                    .HasColumnType("DATE");

                entity.Property(e => e.Tipdoc)
                    .HasColumnName("TIPDOC")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.Tipo)
                    .HasColumnName("TIPO")
                    .HasColumnType("VARCHAR2(40)");
            });

            modelBuilder.Entity<Pdesahucio>(entity =>
            {
                entity.HasKey(e => e.Idbien);

                entity.ToTable("PDESAHUCIO");

                entity.HasIndex(e => e.Idbien)
                    .HasName("PRIMDESAH")
                    .IsUnique();

                entity.Property(e => e.Idbien)
                    .HasColumnName("IDBIEN")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Apenom1)
                    .HasColumnName("APENOM1")
                    .HasColumnType("VARCHAR2(70)");

                entity.Property(e => e.Ejercicio)
                    .HasColumnName("EJERCICIO")
                    .HasColumnType("VARCHAR2(4)");

                entity.Property(e => e.Expediente)
                    .HasColumnName("EXPEDIENTE")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Feceje)
                    .HasColumnName("FECEJE")
                    .HasColumnType("DATE");

                entity.Property(e => e.Fechaac)
                    .HasColumnName("FECHAAC")
                    .HasColumnType("DATE");

                entity.Property(e => e.Feclan)
                    .HasColumnName("FECLAN")
                    .HasColumnType("DATE");

                entity.Property(e => e.Fecvol)
                    .HasColumnName("FECVOL")
                    .HasColumnType("DATE");

                entity.Property(e => e.Iden1)
                    .HasColumnName("IDEN1")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Medidas)
                    .HasColumnName("MEDIDAS")
                    .HasColumnType("VARCHAR2(50)");

                entity.Property(e => e.Obs)
                    .HasColumnName("OBS")
                    .HasColumnType("VARCHAR2(1000)");

                entity.Property(e => e.Organo)
                    .HasColumnName("ORGANO")
                    .HasColumnType("VARCHAR2(30)");

                entity.Property(e => e.Tipo)
                    .HasColumnName("TIPO")
                    .HasColumnType("VARCHAR2(40)");
            });

            modelBuilder.Entity<Pdocumentosb>(entity =>
            {
                entity.HasKey(e => new { e.Fecha, e.Asunto, e.Idexp });

                entity.ToTable("PDOCUMENTOSB");

                entity.HasIndex(e => new { e.Fecha, e.Asunto, e.Idexp })
                    .HasName("PRIMDOCB")
                    .IsUnique();

                entity.Property(e => e.Fecha)
                    .HasColumnName("FECHA")
                    .HasColumnType("DATE");

                entity.Property(e => e.Asunto)
                    .HasColumnName("ASUNTO")
                    .HasColumnType("VARCHAR2(100)");

                entity.Property(e => e.Idexp).HasColumnName("IDEXP");

                entity.Property(e => e.Ruta)
                    .HasColumnName("RUTA")
                    .HasColumnType("VARCHAR2(300)");
            });

            modelBuilder.Entity<Pdocumentosd>(entity =>
            {
                entity.HasKey(e => new { e.Idexp, e.Fecha, e.Asunto });

                entity.ToTable("PDOCUMENTOSD");

                entity.HasIndex(e => new { e.Idexp, e.Fecha, e.Asunto })
                    .HasName("PDOCD")
                    .IsUnique();

                entity.Property(e => e.Idexp).HasColumnName("IDEXP");

                entity.Property(e => e.Fecha)
                    .HasColumnName("FECHA")
                    .HasColumnType("DATE");

                entity.Property(e => e.Asunto)
                    .HasColumnName("ASUNTO")
                    .HasColumnType("VARCHAR2(100)");

                entity.Property(e => e.Ruta)
                    .HasColumnName("RUTA")
                    .HasColumnType("VARCHAR2(300)");
            });

            modelBuilder.Entity<Pdocumentose>(entity =>
            {
                entity.HasKey(e => new { e.Idexp, e.Asunto, e.Fecha });

                entity.ToTable("PDOCUMENTOSE");

                entity.HasIndex(e => new { e.Idexp, e.Asunto, e.Fecha })
                    .HasName("PDOCE")
                    .IsUnique();

                entity.Property(e => e.Idexp).HasColumnName("IDEXP");

                entity.Property(e => e.Asunto)
                    .HasColumnName("ASUNTO")
                    .HasColumnType("VARCHAR2(100)");

                entity.Property(e => e.Fecha)
                    .HasColumnName("FECHA")
                    .HasColumnType("DATE");

                entity.Property(e => e.Ruta)
                    .HasColumnName("RUTA")
                    .HasColumnType("VARCHAR2(300)");
            });

            modelBuilder.Entity<Penajenacion>(entity =>
            {
                entity.HasKey(e => e.Idbien);

                entity.ToTable("PENAJENACION");

                entity.HasIndex(e => e.Idbien)
                    .HasName("PRIMENA")
                    .IsUnique();

                entity.Property(e => e.Idbien)
                    .HasColumnName("IDBIEN")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Apenom1)
                    .HasColumnName("APENOM1")
                    .HasColumnType("VARCHAR2(70)");

                entity.Property(e => e.Apenom2)
                    .HasColumnName("APENOM2")
                    .HasColumnType("VARCHAR2(70)");

                entity.Property(e => e.Caupro)
                    .HasColumnName("CAUPRO")
                    .HasColumnType("VARCHAR2(60)");

                entity.Property(e => e.Destino)
                    .HasColumnName("DESTINO")
                    .HasColumnType("VARCHAR2(200)");

                entity.Property(e => e.Ejercicio)
                    .HasColumnName("EJERCICIO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Expediente)
                    .HasColumnName("EXPEDIENTE")
                    .HasColumnType("VARCHAR2(8)");

                entity.Property(e => e.Fecdoc)
                    .HasColumnName("FECDOC")
                    .HasColumnType("DATE");

                entity.Property(e => e.Fechaac)
                    .HasColumnName("FECHAAC")
                    .HasColumnType("DATE");

                entity.Property(e => e.Fecpag)
                    .HasColumnName("FECPAG")
                    .HasColumnType("DATE");

                entity.Property(e => e.Iden1)
                    .HasColumnName("IDEN1")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Iden2)
                    .HasColumnName("IDEN2")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Noti)
                    .HasColumnName("NOTI")
                    .HasColumnType("VARCHAR2(70)");

                entity.Property(e => e.Numesc)
                    .HasColumnName("NUMESC")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Obs)
                    .HasColumnName("OBS")
                    .HasColumnType("VARCHAR2(1000)");

                entity.Property(e => e.Organo)
                    .HasColumnName("ORGANO")
                    .HasColumnType("VARCHAR2(30)");

                entity.Property(e => e.Precio)
                    .HasColumnName("PRECIO")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Procem)
                    .HasColumnName("PROCEM")
                    .HasColumnType("VARCHAR2(40)");

                entity.Property(e => e.Proxima)
                    .HasColumnName("PROXIMA")
                    .HasColumnType("DATE");

                entity.Property(e => e.Tipdoc)
                    .HasColumnName("TIPDOC")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.Tipo)
                    .HasColumnName("TIPO")
                    .HasColumnType("VARCHAR2(40)");
            });

            modelBuilder.Entity<Pexpedientes>(entity =>
            {
                entity.HasKey(e => e.Idexp);

                entity.ToTable("PEXPEDIENTES");

                entity.HasIndex(e => e.Idexp)
                    .HasName("PRINCIPAL_EXPE")
                    .IsUnique();

                entity.Property(e => e.Idexp)
                    .HasColumnName("IDEXP")
                    .ValueGeneratedNever();

                entity.Property(e => e.Comision)
                    .HasColumnName("COMISION")
                    .HasColumnType("VARCHAR2(40)");

                entity.Property(e => e.Departamento)
                    .HasColumnName("DEPARTAMENTO")
                    .HasColumnType("VARCHAR2(40)");

                entity.Property(e => e.Ejercicio)
                    .HasColumnName("EJERCICIO")
                    .HasColumnType("NUMBER(4)");

                entity.Property(e => e.Feccomp)
                    .HasColumnName("FECCOMP")
                    .HasColumnType("DATE");

                entity.Property(e => e.Fechares)
                    .HasColumnName("FECHARES")
                    .HasColumnType("DATE");

                entity.Property(e => e.Motcomp)
                    .HasColumnName("MOTCOMP")
                    .HasColumnType("VARCHAR2(60)");

                entity.Property(e => e.Numexp).HasColumnName("NUMEXP");

                entity.Property(e => e.Objeto)
                    .HasColumnName("OBJETO")
                    .HasColumnType("VARCHAR2(250)");

                entity.Property(e => e.Observaciones)
                    .HasColumnName("OBSERVACIONES")
                    .HasColumnType("VARCHAR2(1700)");

                entity.Property(e => e.Oficio)
                    .HasColumnName("OFICIO")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.Organo)
                    .HasColumnName("ORGANO")
                    .HasColumnType("VARCHAR2(40)");

                entity.Property(e => e.Reab)
                    .HasColumnName("REAB")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.Resolucion)
                    .HasColumnName("RESOLUCION")
                    .HasColumnType("VARCHAR2(1000)");

                entity.Property(e => e.Term)
                    .HasColumnName("TERM")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.Tipo)
                    .HasColumnName("TIPO")
                    .HasColumnType("VARCHAR2(40)");

                entity.Property(e => e.Ubiar)
                    .HasColumnName("UBIAR")
                    .HasColumnType("VARCHAR2(15)");

                entity.Property(e => e.Ubica)
                    .HasColumnName("UBICA")
                    .HasColumnType("VARCHAR2(15)");

                entity.Property(e => e.Ubifi)
                    .HasColumnName("UBIFI")
                    .HasColumnType("VARCHAR2(15)");

                entity.Property(e => e.Ubiotro)
                    .HasColumnName("UBIOTRO")
                    .HasColumnType("VARCHAR2(15)");
            });

            modelBuilder.Entity<Pexpropiacion>(entity =>
            {
                entity.HasKey(e => e.Idbien);

                entity.ToTable("PEXPROPIACION");

                entity.HasIndex(e => e.Idbien)
                    .HasName("PRIMEXP")
                    .IsUnique();

                entity.Property(e => e.Idbien)
                    .HasColumnName("IDBIEN")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Apenom1)
                    .HasColumnName("APENOM1")
                    .HasColumnType("VARCHAR2(70)");

                entity.Property(e => e.Apenom2)
                    .HasColumnName("APENOM2")
                    .HasColumnType("VARCHAR2(70)");

                entity.Property(e => e.Destino)
                    .HasColumnName("DESTINO")
                    .HasColumnType("VARCHAR2(200)");

                entity.Property(e => e.Dupi)
                    .HasColumnName("DUPI")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Ejercicio)
                    .HasColumnName("EJERCICIO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Expediente)
                    .HasColumnName("EXPEDIENTE")
                    .HasColumnType("VARCHAR2(8)");

                entity.Property(e => e.Fdecla)
                    .HasColumnName("FDECLA")
                    .HasColumnType("DATE");

                entity.Property(e => e.Fechaac)
                    .HasColumnName("FECHAAC")
                    .HasColumnType("DATE");

                entity.Property(e => e.Finca)
                    .HasColumnName("FINCA")
                    .HasColumnType("VARCHAR2(100)");

                entity.Property(e => e.Focu)
                    .HasColumnName("FOCU")
                    .HasColumnType("DATE");

                entity.Property(e => e.Fpago)
                    .HasColumnName("FPAGO")
                    .HasColumnType("DATE");

                entity.Property(e => e.Fprevia)
                    .HasColumnName("FPREVIA")
                    .HasColumnType("DATE");

                entity.Property(e => e.Furge)
                    .HasColumnName("FURGE")
                    .HasColumnType("DATE");

                entity.Property(e => e.Iden1)
                    .HasColumnName("IDEN1")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Iden2)
                    .HasColumnName("IDEN2")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Obs)
                    .HasColumnName("OBS")
                    .HasColumnType("VARCHAR2(1000)");

                entity.Property(e => e.Organo)
                    .HasColumnName("ORGANO")
                    .HasColumnType("VARCHAR2(30)");

                entity.Property(e => e.Super)
                    .HasColumnName("SUPER")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Tipo)
                    .HasColumnName("TIPO")
                    .HasColumnType("VARCHAR2(40)");

                entity.Property(e => e.Urge)
                    .HasColumnName("URGE")
                    .HasColumnType("VARCHAR2(1)");
            });

            modelBuilder.Entity<Ppermuta>(entity =>
            {
                entity.HasKey(e => e.Idbien);

                entity.ToTable("PPERMUTA");

                entity.HasIndex(e => e.Idbien)
                    .HasName("PRIMPER")
                    .IsUnique();

                entity.Property(e => e.Idbien)
                    .HasColumnName("IDBIEN")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Apenom1)
                    .HasColumnName("APENOM1")
                    .HasColumnType("VARCHAR2(70)");

                entity.Property(e => e.Caupro)
                    .HasColumnName("CAUPRO")
                    .HasColumnType("VARCHAR2(60)");

                entity.Property(e => e.Destino)
                    .HasColumnName("DESTINO")
                    .HasColumnType("VARCHAR2(100)");

                entity.Property(e => e.Destinoa)
                    .HasColumnName("DESTINOA")
                    .HasColumnType("VARCHAR2(100)");

                entity.Property(e => e.Destinot)
                    .HasColumnName("DESTINOT")
                    .HasColumnType("VARCHAR2(100)");

                entity.Property(e => e.Ejercicio)
                    .HasColumnName("EJERCICIO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Expediente)
                    .HasColumnName("EXPEDIENTE")
                    .HasColumnType("VARCHAR2(8)");

                entity.Property(e => e.Fecdoc)
                    .HasColumnName("FECDOC")
                    .HasColumnType("DATE");

                entity.Property(e => e.Fechaac)
                    .HasColumnName("FECHAAC")
                    .HasColumnType("DATE");

                entity.Property(e => e.Fentrega)
                    .HasColumnName("FENTREGA")
                    .HasColumnType("DATE");

                entity.Property(e => e.Iden1)
                    .HasColumnName("IDEN1")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Noti)
                    .HasColumnName("NOTI")
                    .HasColumnType("VARCHAR2(70)");

                entity.Property(e => e.Numesc)
                    .HasColumnName("NUMESC")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Obs)
                    .HasColumnName("OBS")
                    .HasColumnType("VARCHAR2(1000)");

                entity.Property(e => e.Organo)
                    .HasColumnName("ORGANO")
                    .HasColumnType("VARCHAR2(30)");

                entity.Property(e => e.Proxima)
                    .HasColumnName("PROXIMA")
                    .HasColumnType("DATE");

                entity.Property(e => e.Tipdoc)
                    .HasColumnName("TIPDOC")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.Tipo)
                    .HasColumnName("TIPO")
                    .HasColumnType("VARCHAR2(40)");

                entity.Property(e => e.Valor)
                    .HasColumnName("VALOR")
                    .HasColumnType("VARCHAR2(10)");
            });

            modelBuilder.Entity<Precuperacion>(entity =>
            {
                entity.HasKey(e => e.Idbien);

                entity.ToTable("PRECUPERACION");

                entity.HasIndex(e => e.Idbien)
                    .HasName("PRINREC")
                    .IsUnique();

                entity.Property(e => e.Idbien)
                    .HasColumnName("IDBIEN")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Apenom1)
                    .HasColumnName("APENOM1")
                    .HasColumnType("VARCHAR2(70)");

                entity.Property(e => e.Ejercicio)
                    .HasColumnName("EJERCICIO")
                    .HasColumnType("VARCHAR2(4)");

                entity.Property(e => e.Expediente)
                    .HasColumnName("EXPEDIENTE")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Fechaac)
                    .HasColumnName("FECHAAC")
                    .HasColumnType("DATE");

                entity.Property(e => e.Fecrec)
                    .HasColumnName("FECREC")
                    .HasColumnType("DATE");

                entity.Property(e => e.Fecsub)
                    .HasColumnName("FECSUB")
                    .HasColumnType("DATE");

                entity.Property(e => e.Fecvol)
                    .HasColumnName("FECVOL")
                    .HasColumnType("DATE");

                entity.Property(e => e.Iden1)
                    .HasColumnName("IDEN1")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Obs)
                    .HasColumnName("OBS")
                    .HasColumnType("VARCHAR2(1000)");

                entity.Property(e => e.Organo)
                    .HasColumnName("ORGANO")
                    .HasColumnType("VARCHAR2(30)");

                entity.Property(e => e.Procem)
                    .HasColumnName("PROCEM")
                    .HasColumnType("VARCHAR2(50)");

                entity.Property(e => e.Tipo)
                    .HasColumnName("TIPO")
                    .HasColumnType("VARCHAR2(40)");
            });

            modelBuilder.Entity<Psegregacion>(entity =>
            {
                entity.HasKey(e => e.Idbien);

                entity.ToTable("PSEGREGACION");

                entity.HasIndex(e => e.Idbien)
                    .HasName("PRIMSEG")
                    .IsUnique();

                entity.Property(e => e.Idbien)
                    .HasColumnName("IDBIEN")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Apenom1)
                    .HasColumnName("APENOM1")
                    .HasColumnType("VARCHAR2(70)");

                entity.Property(e => e.Destino)
                    .HasColumnName("DESTINO")
                    .HasColumnType("VARCHAR2(200)");

                entity.Property(e => e.Destino2)
                    .HasColumnName("DESTINO2")
                    .HasColumnType("VARCHAR2(100)");

                entity.Property(e => e.Ejercicio)
                    .HasColumnName("EJERCICIO")
                    .HasColumnType("VARCHAR2(4)");

                entity.Property(e => e.Expediente)
                    .HasColumnName("EXPEDIENTE")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Fecdoc)
                    .HasColumnName("FECDOC")
                    .HasColumnType("DATE");

                entity.Property(e => e.Fechaac)
                    .HasColumnName("FECHAAC")
                    .HasColumnType("DATE");

                entity.Property(e => e.Iden1)
                    .HasColumnName("IDEN1")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Inicial)
                    .HasColumnName("INICIAL")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Noti)
                    .HasColumnName("NOTI")
                    .HasColumnType("VARCHAR2(70)");

                entity.Property(e => e.Numesc)
                    .HasColumnName("NUMESC")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Obs)
                    .HasColumnName("OBS")
                    .HasColumnType("VARCHAR2(1000)");

                entity.Property(e => e.Organo)
                    .HasColumnName("ORGANO")
                    .HasColumnType("VARCHAR2(30)");

                entity.Property(e => e.Resultante)
                    .HasColumnName("RESULTANTE")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Tipdoc)
                    .HasColumnName("TIPDOC")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.Tipo)
                    .HasColumnName("TIPO")
                    .HasColumnType("VARCHAR2(40)");
            });

            modelBuilder.Entity<Ptipoe>(entity =>
            {
                entity.HasKey(e => e.Tipoexp);

                entity.ToTable("PTIPOE");

                entity.HasIndex(e => e.Tipoexp)
                    .HasName("PRIMTIPOE")
                    .IsUnique();

                entity.Property(e => e.Tipoexp)
                    .HasColumnName("TIPOEXP")
                    .HasColumnType("VARCHAR2(40)")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<Uracciones>(entity =>
            {
                entity.HasKey(e => new { e.Identificacion, e.Clasificacion });

                entity.ToTable("URACCIONES");

                entity.HasIndex(e => new { e.Identificacion, e.Clasificacion })
                    .HasName("SYS_C003143624")
                    .IsUnique();

                entity.Property(e => e.Identificacion)
                    .HasColumnName("IDENTIFICACION")
                    .HasColumnType("VARCHAR2(15)");

                entity.Property(e => e.Clasificacion)
                    .HasColumnName("CLASIFICACION")
                    .HasColumnType("VARCHAR2(5)");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasColumnType("VARCHAR2(100)");
            });

            modelBuilder.Entity<Uractuacion>(entity =>
            {
                entity.HasKey(e => new { e.Identificacion, e.Clasificacion });

                entity.ToTable("URACTUACION");

                entity.HasIndex(e => new { e.Identificacion, e.Clasificacion })
                    .HasName("SYS_C003143625")
                    .IsUnique();

                entity.Property(e => e.Identificacion)
                    .HasColumnName("IDENTIFICACION")
                    .HasColumnType("VARCHAR2(15)");

                entity.Property(e => e.Clasificacion)
                    .HasColumnName("CLASIFICACION")
                    .HasColumnType("VARCHAR2(5)");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasColumnType("VARCHAR2(100)");
            });

            modelBuilder.Entity<Urafecciones>(entity =>
            {
                entity.HasKey(e => new { e.Clave, e.Tipo });

                entity.ToTable("URAFECCIONES");

                entity.HasIndex(e => new { e.Clave, e.Tipo })
                    .HasName("PRIMAFEC")
                    .IsUnique();

                entity.Property(e => e.Clave)
                    .HasColumnName("CLAVE")
                    .HasColumnType("VARCHAR2(3)");

                entity.Property(e => e.Tipo)
                    .HasColumnName("TIPO")
                    .HasColumnType("VARCHAR2(30)");

                entity.Property(e => e.Art)
                    .HasColumnName("ART")
                    .HasColumnType("VARCHAR2(20)");

                entity.Property(e => e.Des1)
                    .HasColumnName("DES1")
                    .HasColumnType("VARCHAR2(100)");

                entity.Property(e => e.Des2)
                    .HasColumnName("DES2")
                    .HasColumnType("VARCHAR2(20)");

                entity.Property(e => e.Des3)
                    .HasColumnName("DES3")
                    .HasColumnType("VARCHAR2(100)");

                entity.Property(e => e.Suelo1)
                    .HasColumnName("SUELO1")
                    .HasColumnType("VARCHAR2(5)");

                entity.Property(e => e.Suelo2)
                    .HasColumnName("SUELO2")
                    .HasColumnType("VARCHAR2(5)");
            });

            modelBuilder.Entity<Uragrulue>(entity =>
            {
                entity.HasKey(e => new { e.Seccion, e.Grupo });

                entity.ToTable("URAGRULUE");

                entity.HasIndex(e => new { e.Seccion, e.Grupo })
                    .HasName("URAGRULUE_PK")
                    .IsUnique();

                entity.Property(e => e.Seccion)
                    .HasColumnName("SECCION")
                    .HasColumnType("VARCHAR2(3)");

                entity.Property(e => e.Grupo)
                    .HasColumnName("GRUPO")
                    .HasColumnType("VARCHAR2(70)");
            });

            modelBuilder.Entity<Urareasplan>(entity =>
            {
                entity.HasKey(e => new { e.Codigo, e.Clasificacion });

                entity.ToTable("URAREASPLAN");

                entity.HasIndex(e => new { e.Codigo, e.Clasificacion })
                    .HasName("PRIMAREAS")
                    .IsUnique();

                entity.Property(e => e.Codigo)
                    .HasColumnName("CODIGO")
                    .HasColumnType("VARCHAR2(12)");

                entity.Property(e => e.Clasificacion)
                    .HasColumnName("CLASIFICACION")
                    .HasColumnType("VARCHAR2(6)");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasColumnType("VARCHAR2(80)");
            });

            modelBuilder.Entity<Urcontenido>(entity =>
            {
                entity.HasKey(e => e.Identi);

                entity.ToTable("URCONTENIDO");

                entity.HasIndex(e => e.Identi)
                    .HasName("URCONTENIDO_PK")
                    .IsUnique();

                entity.Property(e => e.Identi)
                    .HasColumnName("IDENTI")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Agrupa)
                    .HasColumnName("AGRUPA")
                    .HasColumnType("VARCHAR2(100)");

                entity.Property(e => e.Codplano)
                    .HasColumnName("CODPLANO")
                    .HasColumnType("VARCHAR2(15)");

                entity.Property(e => e.Codtabla)
                    .HasColumnName("CODTABLA")
                    .HasColumnType("VARCHAR2(15)");

                entity.Property(e => e.Fsig)
                    .HasColumnName("FSIG")
                    .HasColumnType("DATE");

                entity.Property(e => e.Mslink)
                    .HasColumnName("MSLINK")
                    .HasColumnType("VARCHAR2(15)");

                entity.Property(e => e.Obs)
                    .HasColumnName("OBS")
                    .HasColumnType("VARCHAR2(1000)");

                entity.Property(e => e.Obsd)
                    .HasColumnName("OBSD")
                    .HasColumnType("VARCHAR2(300)");

                entity.Property(e => e.Obsp)
                    .HasColumnName("OBSP")
                    .HasColumnType("VARCHAR2(300)");

                entity.Property(e => e.Obssig)
                    .HasColumnName("OBSSIG")
                    .HasColumnType("VARCHAR2(150)");

                entity.Property(e => e.Tema)
                    .HasColumnName("TEMA")
                    .HasColumnType("VARCHAR2(100)");
            });

            modelBuilder.Entity<Urdotaciones>(entity =>
            {
                entity.HasKey(e => new { e.Identificador, e.Clas1, e.Clas2, e.Vinarea });

                entity.ToTable("URDOTACIONES");

                entity.HasIndex(e => new { e.Identificador, e.Clas1, e.Clas2, e.Vinarea })
                    .HasName("URDOTACIONES_PK")
                    .IsUnique();

                entity.Property(e => e.Identificador)
                    .HasColumnName("IDENTIFICADOR")
                    .HasColumnType("VARCHAR2(15)");

                entity.Property(e => e.Clas1)
                    .HasColumnName("CLAS1")
                    .HasColumnType("VARCHAR2(5)");

                entity.Property(e => e.Clas2)
                    .HasColumnName("CLAS2")
                    .HasColumnType("VARCHAR2(5)");

                entity.Property(e => e.Vinarea)
                    .HasColumnName("VINAREA")
                    .HasColumnType("VARCHAR2(15)");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasColumnType("VARCHAR2(100)");
            });

            modelBuilder.Entity<Urelementos>(entity =>
            {
                entity.HasKey(e => new { e.Numero, e.Clasificacion });

                entity.ToTable("URELEMENTOS");

                entity.HasIndex(e => new { e.Numero, e.Clasificacion })
                    .HasName("SYS_C003143631")
                    .IsUnique();

                entity.Property(e => e.Numero)
                    .HasColumnName("NUMERO")
                    .HasColumnType("VARCHAR2(8)");

                entity.Property(e => e.Clasificacion)
                    .HasColumnName("CLASIFICACION")
                    .HasColumnType("VARCHAR2(5)");

                entity.Property(e => e.Proteccion)
                    .HasColumnName("PROTECCION")
                    .HasColumnType("VARCHAR2(25)");

                entity.Property(e => e.Rc)
                    .HasColumnName("RC")
                    .HasColumnType("VARCHAR2(25)");

                entity.Property(e => e.Situacion)
                    .HasColumnName("SITUACION")
                    .HasColumnType("VARCHAR2(100)");
            });

            modelBuilder.Entity<Urexpedientes>(entity =>
            {
                entity.ToTable("UREXPEDIENTES");

                entity.HasIndex(e => e.Id)
                    .HasName("UREXPEDIENTES2_PK")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Apenom)
                    .HasColumnName("APENOM")
                    .HasColumnType("VARCHAR2(100)");

                entity.Property(e => e.Asig2)
                    .HasColumnName("ASIG2")
                    .HasColumnType("VARCHAR2(5)");

                entity.Property(e => e.Asig3)
                    .HasColumnName("ASIG3")
                    .HasColumnType("VARCHAR2(5)");

                entity.Property(e => e.Asig4)
                    .HasColumnName("ASIG4")
                    .HasColumnType("VARCHAR2(5)");

                entity.Property(e => e.Asig5)
                    .HasColumnName("ASIG5")
                    .HasColumnType("VARCHAR2(5)");

                entity.Property(e => e.Asignado)
                    .HasColumnName("ASIGNADO")
                    .HasColumnType("VARCHAR2(5)");

                entity.Property(e => e.Asunto)
                    .HasColumnName("ASUNTO")
                    .HasColumnType("VARCHAR2(150)");

                entity.Property(e => e.Cif)
                    .HasColumnName("CIF")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Dir)
                    .HasColumnName("DIR")
                    .HasColumnType("VARCHAR2(150)");

                entity.Property(e => e.Ejercicio)
                    .HasColumnName("EJERCICIO")
                    .HasColumnType("VARCHAR2(4)");

                entity.Property(e => e.Expediente)
                    .HasColumnName("EXPEDIENTE")
                    .HasColumnType("VARCHAR2(50)");

                entity.Property(e => e.ExpedienteMytao)
                    .HasColumnName("EXPEDIENTE_MYTAO")
                    .HasColumnType("VARCHAR2(500)");

                entity.Property(e => e.Fecentrada)
                    .HasColumnName("FECENTRADA")
                    .HasColumnType("DATE");

                entity.Property(e => e.Hasig2)
                    .HasColumnName("HASIG2")
                    .HasColumnType("VARCHAR2(5)");

                entity.Property(e => e.Hasig3)
                    .HasColumnName("HASIG3")
                    .HasColumnType("VARCHAR2(5)");

                entity.Property(e => e.Hasig4)
                    .HasColumnName("HASIG4")
                    .HasColumnType("VARCHAR2(5)");

                entity.Property(e => e.Hasig5)
                    .HasColumnName("HASIG5")
                    .HasColumnType("VARCHAR2(5)");

                entity.Property(e => e.Hasignado)
                    .HasColumnName("HASIGNADO")
                    .HasColumnType("VARCHAR2(5)");

                entity.Property(e => e.Nexp)
                    .HasColumnName("NEXP")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Obsad)
                    .HasColumnName("OBSAD")
                    .HasColumnType("VARCHAR2(350)");

                entity.Property(e => e.Orden)
                    .HasColumnName("ORDEN")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Pd)
                    .HasColumnName("PD")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.Planeamiento)
                    .HasColumnName("PLANEAMIENTO")
                    .HasColumnType("VARCHAR2(30)");

                entity.Property(e => e.Seccion)
                    .HasColumnName("SECCION")
                    .HasColumnType("VARCHAR2(50)");
            });

            modelBuilder.Entity<Urexpedientes3>(entity =>
            {
                entity.ToTable("UREXPEDIENTES3");

                entity.HasIndex(e => e.Id)
                    .HasName("UREXPEDIENTES_PK")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Apenom)
                    .HasColumnName("APENOM")
                    .HasColumnType("VARCHAR2(100)");

                entity.Property(e => e.Asig2)
                    .HasColumnName("ASIG2")
                    .HasColumnType("VARCHAR2(5)");

                entity.Property(e => e.Asig3)
                    .HasColumnName("ASIG3")
                    .HasColumnType("VARCHAR2(5)");

                entity.Property(e => e.Asig4)
                    .HasColumnName("ASIG4")
                    .HasColumnType("VARCHAR2(5)");

                entity.Property(e => e.Asig5)
                    .HasColumnName("ASIG5")
                    .HasColumnType("VARCHAR2(5)");

                entity.Property(e => e.Asignado)
                    .HasColumnName("ASIGNADO")
                    .HasColumnType("VARCHAR2(5)");

                entity.Property(e => e.Asunto)
                    .HasColumnName("ASUNTO")
                    .HasColumnType("VARCHAR2(150)");

                entity.Property(e => e.Cif)
                    .HasColumnName("CIF")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Dir)
                    .HasColumnName("DIR")
                    .HasColumnType("VARCHAR2(150)");

                entity.Property(e => e.Ejercicio)
                    .HasColumnName("EJERCICIO")
                    .HasColumnType("VARCHAR2(4)");

                entity.Property(e => e.Expediente)
                    .HasColumnName("EXPEDIENTE")
                    .HasColumnType("VARCHAR2(50)");

                entity.Property(e => e.Fecentrada)
                    .HasColumnName("FECENTRADA")
                    .HasColumnType("DATE");

                entity.Property(e => e.Hasig2)
                    .HasColumnName("HASIG2")
                    .HasColumnType("VARCHAR2(5)");

                entity.Property(e => e.Hasig3)
                    .HasColumnName("HASIG3")
                    .HasColumnType("VARCHAR2(5)");

                entity.Property(e => e.Hasig4)
                    .HasColumnName("HASIG4")
                    .HasColumnType("VARCHAR2(5)");

                entity.Property(e => e.Hasig5)
                    .HasColumnName("HASIG5")
                    .HasColumnType("VARCHAR2(5)");

                entity.Property(e => e.Hasignado)
                    .HasColumnName("HASIGNADO")
                    .HasColumnType("VARCHAR2(5)");

                entity.Property(e => e.Nexp)
                    .HasColumnName("NEXP")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Obsad)
                    .HasColumnName("OBSAD")
                    .HasColumnType("VARCHAR2(250)");

                entity.Property(e => e.Orden)
                    .HasColumnName("ORDEN")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Pd)
                    .HasColumnName("PD")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.Planeamiento)
                    .HasColumnName("PLANEAMIENTO")
                    .HasColumnType("VARCHAR2(30)");

                entity.Property(e => e.Seccion)
                    .HasColumnName("SECCION")
                    .HasColumnType("VARCHAR2(50)");
            });

            modelBuilder.Entity<Urlue>(entity =>
            {
                entity.HasKey(e => new { e.Seccion, e.Tipo });

                entity.ToTable("URLUE");

                entity.HasIndex(e => new { e.Seccion, e.Tipo })
                    .HasName("PRIMLUE")
                    .IsUnique();

                entity.Property(e => e.Seccion)
                    .HasColumnName("SECCION")
                    .HasColumnType("VARCHAR2(50)");

                entity.Property(e => e.Tipo)
                    .HasColumnName("TIPO")
                    .HasColumnType("VARCHAR2(80)");
            });

            modelBuilder.Entity<Urperfiles>(entity =>
            {
                entity.HasKey(e => new { e.Codigo, e.Usuario });

                entity.ToTable("URPERFILES");

                entity.HasIndex(e => new { e.Codigo, e.Usuario })
                    .HasName("URPERFILES_PK")
                    .IsUnique();

                entity.Property(e => e.Codigo).HasColumnName("CODIGO");

                entity.Property(e => e.Usuario)
                    .HasColumnName("USUARIO")
                    .HasColumnType("VARCHAR2(20)");

                entity.Property(e => e.Contraseña)
                    .HasColumnName("CONTRASEÑA")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Correo)
                    .HasColumnName("CORREO")
                    .HasColumnType("VARCHAR2(70)");

                entity.Property(e => e.Estado)
                    .HasColumnName("ESTADO")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.Nombre)
                    .HasColumnName("NOMBRE")
                    .HasColumnType("VARCHAR2(70)");

                entity.Property(e => e.Perfil)
                    .HasColumnName("PERFIL")
                    .HasColumnType("VARCHAR2(2)");
            });

            modelBuilder.Entity<Urreparto>(entity =>
            {
                entity.HasKey(e => new { e.Identificacion, e.Clasificacion });

                entity.ToTable("URREPARTO");

                entity.HasIndex(e => new { e.Identificacion, e.Clasificacion })
                    .HasName("URREPARTO_PK")
                    .IsUnique();

                entity.Property(e => e.Identificacion)
                    .HasColumnName("IDENTIFICACION")
                    .HasColumnType("VARCHAR2(15)");

                entity.Property(e => e.Clasificacion)
                    .HasColumnName("CLASIFICACION")
                    .HasColumnType("VARCHAR2(5)");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasColumnType("VARCHAR2(100)");
            });

            modelBuilder.Entity<Urseccion>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.ToTable("URSECCION");

                entity.HasIndex(e => e.Codigo)
                    .HasName("PRIMSEC")
                    .IsUnique();

                entity.Property(e => e.Codigo)
                    .HasColumnName("CODIGO")
                    .HasColumnType("VARCHAR2(3)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasColumnType("VARCHAR2(50)");
            });

            modelBuilder.Entity<Urtecnicos>(entity =>
            {
                entity.HasKey(e => new { e.Abreviatura, e.Apenom });

                entity.ToTable("URTECNICOS");

                entity.HasIndex(e => new { e.Abreviatura, e.Apenom })
                    .HasName("URTECNICOS_PK")
                    .IsUnique();

                entity.Property(e => e.Abreviatura)
                    .HasColumnName("ABREVIATURA")
                    .HasColumnType("VARCHAR2(2)");

                entity.Property(e => e.Apenom)
                    .HasColumnName("APENOM")
                    .HasColumnType("VARCHAR2(50)");

                entity.Property(e => e.Estado)
                    .HasColumnName("ESTADO")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.Puesto)
                    .HasColumnName("PUESTO")
                    .HasColumnType("VARCHAR2(70)");
            });

            modelBuilder.Entity<Urtipoexpediente>(entity =>
            {
                entity.HasKey(e => new { e.Seccion, e.Tipo });

                entity.ToTable("URTIPOEXPEDIENTE");

                entity.HasIndex(e => new { e.Seccion, e.Tipo })
                    .HasName("PRIMTE")
                    .IsUnique();

                entity.Property(e => e.Seccion)
                    .HasColumnName("SECCION")
                    .HasColumnType("VARCHAR2(3)");

                entity.Property(e => e.Tipo)
                    .HasColumnName("TIPO")
                    .HasColumnType("VARCHAR2(3)");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasColumnType("VARCHAR2(40)");
            });

            modelBuilder.Entity<Urusonurbano>(entity =>
            {
                entity.HasKey(e => new { e.Global, e.Clase, e.Subclase });

                entity.ToTable("URUSONURBANO");

                entity.HasIndex(e => new { e.Global, e.Clase, e.Subclase })
                    .HasName("URUSONURBANO_PK")
                    .IsUnique();

                entity.Property(e => e.Global)
                    .HasColumnName("GLOBAL")
                    .HasColumnType("VARCHAR2(80)");

                entity.Property(e => e.Clase)
                    .HasColumnName("CLASE")
                    .HasColumnType("VARCHAR2(220)");

                entity.Property(e => e.Subclase)
                    .HasColumnName("SUBCLASE")
                    .HasColumnType("VARCHAR2(180)");
            });

            modelBuilder.Entity<Urusospe>(entity =>
            {
                entity.HasKey(e => new { e.Uso, e.Tipos, e.Categoria });

                entity.ToTable("URUSOSPE");

                entity.HasIndex(e => new { e.Uso, e.Tipos, e.Categoria })
                    .HasName("URUSOSPE_PK")
                    .IsUnique();

                entity.Property(e => e.Uso)
                    .HasColumnName("USO")
                    .HasColumnType("VARCHAR2(40)");

                entity.Property(e => e.Tipos)
                    .HasColumnName("TIPOS")
                    .HasColumnType("VARCHAR2(70)");

                entity.Property(e => e.Categoria)
                    .HasColumnName("CATEGORIA")
                    .HasColumnType("VARCHAR2(100)");
            });

            modelBuilder.Entity<Urusourbano>(entity =>
            {
                entity.HasKey(e => new { e.Global, e.Clase, e.Subclase, e.Categorias, e.Grupo, e.Clases2, e.Situaciones });

                entity.ToTable("URUSOURBANO");

                entity.HasIndex(e => new { e.Global, e.Clase, e.Subclase, e.Categorias, e.Grupo, e.Clases2, e.Situaciones })
                    .HasName("URUSOURBANO_PK")
                    .IsUnique();

                entity.Property(e => e.Global)
                    .HasColumnName("GLOBAL")
                    .HasColumnType("VARCHAR2(15)");

                entity.Property(e => e.Clase)
                    .HasColumnName("CLASE")
                    .HasColumnType("VARCHAR2(60)");

                entity.Property(e => e.Subclase)
                    .HasColumnName("SUBCLASE")
                    .HasColumnType("VARCHAR2(60)");

                entity.Property(e => e.Categorias)
                    .HasColumnName("CATEGORIAS")
                    .HasColumnType("VARCHAR2(120)");

                entity.Property(e => e.Grupo)
                    .HasColumnName("GRUPO")
                    .HasColumnType("VARCHAR2(15)");

                entity.Property(e => e.Clases2)
                    .HasColumnName("CLASES2")
                    .HasColumnType("VARCHAR2(25)");

                entity.Property(e => e.Situaciones)
                    .HasColumnName("SITUACIONES")
                    .HasColumnType("VARCHAR2(120)");
            });

            modelBuilder.Entity<Urzonas>(entity =>
            {
                entity.HasKey(e => new { e.Identificador, e.Clas1, e.Clas2, e.Vinarea });

                entity.ToTable("URZONAS");

                entity.HasIndex(e => new { e.Identificador, e.Clas1, e.Clas2, e.Vinarea })
                    .HasName("URZONAS_PK")
                    .IsUnique();

                entity.Property(e => e.Identificador)
                    .HasColumnName("IDENTIFICADOR")
                    .HasColumnType("VARCHAR2(15)");

                entity.Property(e => e.Clas1)
                    .HasColumnName("CLAS1")
                    .HasColumnType("VARCHAR2(5)");

                entity.Property(e => e.Clas2)
                    .HasColumnName("CLAS2")
                    .HasColumnType("VARCHAR2(5)");

                entity.Property(e => e.Vinarea)
                    .HasColumnName("VINAREA")
                    .HasColumnType("VARCHAR2(15)");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasColumnType("VARCHAR2(100)");
            });
        }
    }
}
