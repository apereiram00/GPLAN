﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace Data.Policia.Entities
{
    public partial class Jurexpedientes
    {
        public Jurexpedientes()
        {
            Juractuaciones = new HashSet<Juractuaciones>();
            Jurdocumentos = new HashSet<Jurdocumentos>();
            Jurinteresados = new HashSet<Jurinteresados>();
            Jurtramitacion = new HashSet<Jurtramitacion>();
            Jurvencimientos = new HashSet<Jurvencimientos>();
        }

        public short Idexp { get; set; }
        public string Materia { get; set; }
        public int? Ejercicio { get; set; }
        public int? Numexp { get; set; }
        public string Auto { get; set; }
        public string HechoDenunciado { get; set; }
        public DateTime? Fecentrada { get; set; }
        public string Observaciones { get; set; }
        public decimal? Estado { get; set; }
        public string Norma { get; set; }
        public string PreceptoInfraccion { get; set; }
        public string PreceptoSancion { get; set; }
        public string CalificacionInfraccion { get; set; }
        public decimal? Importe { get; set; }
        public decimal? Importe20 { get; set; }
        public decimal? Importe40 { get; set; }
        public DateTime? FecDenuncia { get; set; }
        public string HoraDenuncia { get; set; }
        public string Lugar { get; set; }
        public string ExpedienteTao { get; set; }
        public string Agentes { get; set; }
        public string SancionPecuniaria { get; set; }
        public string SancionNoPecuniaria { get; set; }
        public string DescripcionNoPecuniaria { get; set; }
        public decimal? ImporteRecaudado { get; set; }

        public virtual Jurestados EstadoNavigation { get; set; }
        public virtual ICollection<Juractuaciones> Juractuaciones { get; set; }
        public virtual ICollection<Jurdocumentos> Jurdocumentos { get; set; }
        public virtual ICollection<Jurinteresados> Jurinteresados { get; set; }
        public virtual ICollection<Jurtramitacion> Jurtramitacion { get; set; }
        public virtual ICollection<Jurvencimientos> Jurvencimientos { get; set; }
    }
}