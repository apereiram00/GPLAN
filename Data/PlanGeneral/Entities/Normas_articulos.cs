using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.PlanGeneral.Entities
{
    public partial class Normas_articulos
    {
        [Key]
        public decimal Id_articulo { get; set; }

        public decimal? Titulo_articulo { get; set; }
        public decimal? Articulo_capitulo { get; set; }
        public string Seccion { get; set; }
        public string Apartado { get; set; }
        public decimal? Articulo { get; set; }
        public string Denominacion { get; set; }
        public string Tipo { get; set; }
        public string Contenido { get; set; }
        public string Vigente { get; set; }
        public DateTime? FechaAlta { get; set; }
        public string MotivoAlta { get; set; }
        public DateTime? FechaBaja { get; set; }
        public string MotivoBaja { get; set; }

    }
}
