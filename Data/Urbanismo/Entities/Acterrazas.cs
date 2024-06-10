using System;
using System.Collections.Generic;

namespace Data.Urbanismo.Entities
{
    public partial class Acterrazas
    {
        public decimal Idact { get; set; }
        public decimal Ejercicio { get; set; }
        public decimal? Idbar { get; set; }
        public decimal? Ejerbar { get; set; }
        public string Actividad { get; set; }
        public string Denominacion { get; set; }
        public string Tcomunica { get; set; }
        public decimal? Veladora { get; set; }
        public decimal? Velador { get; set; }
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
        public string Licb { get; set; }
        public string Tituact { get; set; }
        public string Pagado { get; set; }
        public DateTime? Fpagado { get; set; }
        public string Importe { get; set; }
    }
}
