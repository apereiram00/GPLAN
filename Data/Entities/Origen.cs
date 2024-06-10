using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public partial class Origen
    {
        public Origen()
        {
            PlantillasOrigenes = new HashSet<Plantillas>();
        }
        public decimal Origenid { get; set; }
        public string Nombre { get; set; }
        public decimal OrigenSrc { get; set; }
        public DateTime FechaAlta { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaBaja { get; set; }
        public string MotivoBaja { get; set; }
        public DateTime FechaUltimaModif { get; set; }
        public string UsuarioUltimaModif { get; set; }
        public string Uuid { get; set; }
        public virtual ICollection<Plantillas> PlantillasOrigenes { get; set; }


    }
}
