using System;
using System.Collections.Generic;

namespace Data.Urbanismo.Entities
{
    public partial class Actividades
    {
        public decimal Idact { get; set; }
        public decimal Ejercicio { get; set; }
        public string Actividad { get; set; }
        public string Denominacion { get; set; }
        public string Tcomunica { get; set; }
        public string Denuncia { get; set; }
        public string Musica { get; set; }
        public string Climatiza { get; set; }
        public string Ramimp { get; set; }
        public string Refcat { get; set; }
        public DateTime? Fent { get; set; }
        public DateTime? Fres { get; set; }
        public string Carpeta { get; set; }
        public string Expediente { get; set; }
        public decimal? Año { get; set; }
        public string Fin { get; set; }
        public DateTime? Ffin { get; set; }
        public string Observaciones { get; set; }
        public string Licencia { get; set; }
        public string Numlic { get; set; }
        public string Caducada { get; set; }
        public DateTime? Fcadu { get; set; }
        public string Denegada { get; set; }
        public DateTime? Fden { get; set; }
        public string Definitiva { get; set; }
        public DateTime? Fdef { get; set; }
        public string Terraza { get; set; }
    }
}
