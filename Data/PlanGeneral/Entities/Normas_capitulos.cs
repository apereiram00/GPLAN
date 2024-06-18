using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.PlanGeneral.Entities
{
    public partial class Normas_capitulos
    {
        [Key]
        public decimal Id_capitulo { get; set; }

        public decimal? Capitulo_titulo_pertenece { get; set; }
        public decimal? Capitulo_numero { get; set; }
        public string Capitulo_denominacion { get; set; }

    }
}
