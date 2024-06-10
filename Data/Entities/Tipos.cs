using System;
using System.Collections.Generic;

namespace Data.Entities
{
    public partial class Tipos
    {
        public Tipos()
        {
            Valores = new HashSet<Valores>();
        }

        public decimal Tiposid { get; set; }
        public string CodigoTipo { get; set; }
        public string NombreTipo { get; set; }
        public string DescripcionTipo { get; set; }
        public DateTime FechaAlta { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaBaja { get; set; }
        public string MotivoBaja { get; set; }
        public DateTime? FechaUltimaModif { get; set; }
        public string UsuarioUltimaModif { get; set; }
        public string Uuid { get; set; }

        public virtual ICollection<Valores> Valores { get; set; }
    }
}
