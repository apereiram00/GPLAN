using System;
using System.Collections.Generic;

namespace Data.Entities
{
    public partial class Valores
    {
        public Valores()
        {
            Campos = new HashSet<Campos>();
            // PlantillasDepartamento = new HashSet<Plantillas>();
            PlantillasEstado = new HashSet<Plantillas>();
            PlantillasSeguridad = new HashSet<Plantillas>();
        }

        public decimal Valoresid { get; set; }
        public string CodigoValor { get; set; }
        public string NombreValor { get; set; }
        public string DescripcionValor { get; set; }
        public decimal TiposId { get; set; }
        public DateTime FechaAlta { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaBaja { get; set; }
        public string MotivoBaja { get; set; }
        public DateTime? FechaUltimaModif { get; set; }
        public string UsuarioUltimaModif { get; set; }
        public string Uuid { get; set; }

        public virtual Tipos Tipos { get; set; }
        public virtual ICollection<Campos> Campos { get; set; }
        // public virtual ICollection<Plantillas> PlantillasDepartamento { get; set; }
        public virtual ICollection<Plantillas> PlantillasEstado { get; set; }
        public virtual ICollection<Plantillas> PlantillasSeguridad { get; set; }
    }
}
