using System;
using System.Collections.Generic;

namespace Data.Entities
{
    public partial class Plantillas
    {
        public Plantillas()
        {
            Campos = new HashSet<Campos>();
        }

        public decimal Plantillasid { get; set; }
        public string Nombre { get; set; }
        public string RutaPlantilla { get; set; }
        public decimal SeguridadId { get; set; }
        public decimal EstadoId { get; set; }       
        public DateTime FechaAlta { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaBaja { get; set; }
        public string MotivoBaja { get; set; }
        public DateTime? FechaUltimaModif { get; set; }
        public string UsuarioUltimaModif { get; set; }
        public string Uuid { get; set; }
        public decimal OrigenId { get; set; }

        public virtual Origen Origen { get; set; }
        public virtual Valores Estado { get; set; }
        public virtual Valores Seguridad { get; set; }
        public virtual ICollection<Campos> Campos { get; set; }
    }
}
