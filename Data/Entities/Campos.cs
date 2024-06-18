using System;
using System.Collections.Generic;

namespace Data.Entities
{
    public partial class Campos
    {
        public Campos()
        {
          //CamposOrigen = new HashSet<Origen>();
        }

        public decimal Camposid { get; set; }
        public string CampoPlantilla { get; set; }
        public string CampoExterno { get; set; }
        public decimal PlantillaId { get; set; }
        public decimal TipoCampoId { get; set; }
        public DateTime FechaAlta { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaBaja { get; set; }
        public string MotivoBaja { get; set; }
        public DateTime? FechaUltimaModif { get; set; }
        public string UsuarioUltimaModif { get; set; }
        public string Uuid { get; set; }
        public decimal Origen_Id { get; set; }


        public virtual Origen Origen { get; set; }
        public virtual Valores TipoCampo { get; set; }
       //public virtual ICollection<Origen> CamposOrigen { get; set; }



    }
}
