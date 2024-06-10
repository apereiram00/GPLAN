using System;
using System.Collections.Generic;

namespace Data.Urbanismo.Entities
{
    public partial class Pdocumentose
    {
        public short Idexp { get; set; }
        public string Asunto { get; set; }
        public DateTime Fecha { get; set; }
        public string Ruta { get; set; }
    }
}
