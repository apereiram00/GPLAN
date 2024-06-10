using System;
using System.Collections.Generic;

namespace Data.Urbanismo.Entities
{
    public partial class Parrendamiento
    {
        public decimal Idbien { get; set; }
        public string Extin { get; set; }
        public DateTime? Fecext { get; set; }
        public string Cauext { get; set; }
        public string Iden1 { get; set; }
        public string Apenom1 { get; set; }
        public string Iden2 { get; set; }
        public string Apenom2 { get; set; }
        public string Destino { get; set; }
        public string Organo { get; set; }
        public DateTime? Fechaac { get; set; }
        public string Tipdoc { get; set; }
        public DateTime? Fecdoc { get; set; }
        public string Numesc { get; set; }
        public string Noti { get; set; }
        public string Renta { get; set; }
        public DateTime? Increm { get; set; }
        public DateTime? Proxima { get; set; }
        public string Caupro { get; set; }
        public string Obs { get; set; }
        public string Tipo { get; set; }
        public string Expediente { get; set; }
        public string Ejercicio { get; set; }
    }
}
