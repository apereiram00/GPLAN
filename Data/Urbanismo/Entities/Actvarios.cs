using System;
using System.Collections.Generic;

namespace Data.Urbanismo.Entities
{
    public partial class Actvarios
    {
        public decimal Idact { get; set; }
        public decimal Ejercicio { get; set; }
        public string Actividad { get; set; }
        public string Denominacion { get; set; }
        public string Asunto { get; set; }
        public DateTime? Fent { get; set; }
        public DateTime? Ffin { get; set; }
        public string Carpeta { get; set; }
        public string Expediente { get; set; }
        public decimal? Año { get; set; }
        public string Observaciones { get; set; }
    }
}
