using System;
using System.Collections.Generic;

namespace Data.Urbanismo.Entities
{
    public partial class Pcomprueba
    {
        public decimal Idbien { get; set; }
        public string Tipo { get; set; }
        public DateTime? Fecha { get; set; }
        public string Causa { get; set; }
    }
}
