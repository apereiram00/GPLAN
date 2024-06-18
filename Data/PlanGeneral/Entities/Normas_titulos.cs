using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.PlanGeneral.Entities
{
    public partial class Normas_titulos
    {
        [Key]
        public decimal Id_titulo { get; set; }

        public decimal? Titulo_numero { get; set; }
        public string Titulo_denominacion { get; set; }

    }
}
