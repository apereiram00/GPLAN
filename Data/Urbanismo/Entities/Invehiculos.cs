using System;
using System.Collections.Generic;

namespace Data.Urbanismo.Entities
{
    public partial class Invehiculos
    {
        public string Matricula { get; set; }
        public string Servicio { get; set; }
        public string Seccion { get; set; }
        public string Tipo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public DateTime? Fechamat { get; set; }
        public decimal? Anoi { get; set; }
        public DateTime? Fechaitv { get; set; }
        public string Forma { get; set; }
        public string Tarjeta { get; set; }
        public string Seguro { get; set; }
        public DateTime? Fechase { get; set; }
        public string Documentacion { get; set; }
        public DateTime? Fechadoc { get; set; }
        public string Baja { get; set; }
        public DateTime? Fechabaj { get; set; }
        public string Observaciones { get; set; }
    }
}
