using System;
using System.Collections.Generic;

namespace Data.Urbanismo.Entities
{
    public partial class Pactuabien
    {
        public decimal Idbien { get; set; }
        public string Actuacion { get; set; }
        public DateTime Fecha { get; set; }
        public string Ultima { get; set; }
    }
}
