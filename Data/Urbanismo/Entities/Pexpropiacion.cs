using System;
using System.Collections.Generic;

namespace Data.Urbanismo.Entities
{
    public partial class Pexpropiacion
    {
        public decimal Idbien { get; set; }
        public string Iden1 { get; set; }
        public string Apenom1 { get; set; }
        public string Iden2 { get; set; }
        public string Apenom2 { get; set; }
        public string Destino { get; set; }
        public string Organo { get; set; }
        public DateTime? Fechaac { get; set; }
        public string Finca { get; set; }
        public string Super { get; set; }
        public string Dupi { get; set; }
        public DateTime? Fdecla { get; set; }
        public DateTime? Fprevia { get; set; }
        public DateTime? Furge { get; set; }
        public DateTime? Fpago { get; set; }
        public DateTime? Focu { get; set; }
        public string Urge { get; set; }
        public string Obs { get; set; }
        public string Tipo { get; set; }
        public string Expediente { get; set; }
        public decimal? Ejercicio { get; set; }
    }
}
