using System;
using System.Collections.Generic;

namespace Data.Urbanismo.Entities
{
    public partial class Psegregacion
    {
        public decimal Idbien { get; set; }
        public string Iden1 { get; set; }
        public string Apenom1 { get; set; }
        public string Destino { get; set; }
        public string Destino2 { get; set; }
        public string Inicial { get; set; }
        public string Resultante { get; set; }
        public string Organo { get; set; }
        public DateTime? Fechaac { get; set; }
        public string Tipdoc { get; set; }
        public DateTime? Fecdoc { get; set; }
        public string Numesc { get; set; }
        public string Noti { get; set; }
        public string Obs { get; set; }
        public string Tipo { get; set; }
        public string Expediente { get; set; }
        public string Ejercicio { get; set; }
    }
}
