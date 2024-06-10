using System;
using System.Collections.Generic;

namespace Data.Urbanismo.Entities
{
    public partial class Urcontenido
    {
        public decimal Identi { get; set; }
        public string Mslink { get; set; }
        public string Agrupa { get; set; }
        public string Tema { get; set; }
        public string Obs { get; set; }
        public string Obsp { get; set; }
        public string Obsd { get; set; }
        public DateTime? Fsig { get; set; }
        public string Obssig { get; set; }
        public string Codtabla { get; set; }
        public string Codplano { get; set; }
    }
}
