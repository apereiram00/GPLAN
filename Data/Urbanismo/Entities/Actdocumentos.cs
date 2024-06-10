using System;
using System.Collections.Generic;

namespace Data.Urbanismo.Entities
{
    public partial class Actdocumentos
    {
        public short Idact { get; set; }
        public byte Ejercicio { get; set; }
        public string Asunto { get; set; }
        public DateTime? Fecha { get; set; }
        public string Ruta { get; set; }
        public string Propietario { get; set; }
    }
}
