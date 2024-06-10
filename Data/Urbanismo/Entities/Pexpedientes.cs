using System;
using System.Collections.Generic;

namespace Data.Urbanismo.Entities
{
    public partial class Pexpedientes
    {
        public short Idexp { get; set; }
        public string Tipo { get; set; }
        public short? Numexp { get; set; }
        public byte? Ejercicio { get; set; }
        public string Oficio { get; set; }
        public string Departamento { get; set; }
        public string Comision { get; set; }
        public string Objeto { get; set; }
        public string Ubifi { get; set; }
        public string Ubica { get; set; }
        public string Ubiar { get; set; }
        public string Organo { get; set; }
        public DateTime? Fechares { get; set; }
        public string Resolucion { get; set; }
        public string Observaciones { get; set; }
        public string Term { get; set; }
        public string Reab { get; set; }
        public string Ubiotro { get; set; }
        public DateTime? Feccomp { get; set; }
        public string Motcomp { get; set; }
    }
}
