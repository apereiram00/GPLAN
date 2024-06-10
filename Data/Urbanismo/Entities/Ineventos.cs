using System;
using System.Collections.Generic;

namespace Data.Urbanismo.Entities
{
    public partial class Ineventos
    {
        public decimal Iden { get; set; }
        public DateTime? Fecpet { get; set; }
        public DateTime? Fecini { get; set; }
        public DateTime? Fecfin { get; set; }
        public string Dnipet { get; set; }
        public string Nompet { get; set; }
        public string Dnirep { get; set; }
        public string Nomrep { get; set; }
        public string Expediente { get; set; }
        public string Procedencia { get; set; }
        public string Evento { get; set; }
        public string Peticion { get; set; }
        public string Ubicacion { get; set; }
        public string Organo { get; set; }
        public string Otro { get; set; }
        public string Docapro { get; set; }
        public DateTime? Fecapro { get; set; }
        public string Observaciones { get; set; }
        public string Reseven { get; set; }
    }
}
