using System;
using System.Collections.Generic;

namespace Data.Urbanismo.Entities
{
    public partial class Pactuaciones
    {
        public short Idexp { get; set; }
        public string Descripcion { get; set; }
        public string Registro { get; set; }
        public DateTime Fecha { get; set; }
        public string Ultima { get; set; }
    }
}
