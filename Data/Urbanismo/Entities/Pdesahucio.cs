using System;
using System.Collections.Generic;

namespace Data.Urbanismo.Entities
{
    public partial class Pdesahucio
    {
        public decimal Idbien { get; set; }
        public string Iden1 { get; set; }
        public string Apenom1 { get; set; }
        public string Organo { get; set; }
        public string Medidas { get; set; }
        public DateTime? Fechaac { get; set; }
        public DateTime? Fecvol { get; set; }
        public DateTime? Feclan { get; set; }
        public DateTime? Feceje { get; set; }
        public string Obs { get; set; }
        public string Tipo { get; set; }
        public string Expediente { get; set; }
        public string Ejercicio { get; set; }
    }
}
