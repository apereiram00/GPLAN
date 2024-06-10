using Data.Urbanismo.Entities;
using Presentacion.DTO;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion.Services.MailMerge
{
    public class UrbanismoMailMergeService
    {
        public UrbanismoDTOMailMerge GetExpedienteByClave(decimal clave)
        {
            try
            {
                var _urbanismoContext = new UrbanismoDbContext();
                var expedienteUrbanismo = _urbanismoContext.Urexpedientes.Where(u => u.Id == clave).FirstOrDefault();

                if (expedienteUrbanismo != null)
                {
                    var expedienteDtoMailMerge = new UrbanismoDTOMailMerge();

                    expedienteDtoMailMerge.Clave = expedienteUrbanismo.Id.ToString();
                    expedienteDtoMailMerge.NumExpediente = $"{expedienteUrbanismo.Seccion}/{expedienteUrbanismo.Expediente}/{expedienteUrbanismo.Nexp}";
                    expedienteDtoMailMerge.Asunto = expedienteUrbanismo.Asunto;
                    expedienteDtoMailMerge.Ubicacion = expedienteUrbanismo.Dir;
                    expedienteDtoMailMerge.Interesado = expedienteUrbanismo.Apenom;
                    expedienteDtoMailMerge.NifCifInteresado = expedienteUrbanismo.Cif;
                    expedienteDtoMailMerge.ExpedienteMyTAO = expedienteUrbanismo.ExpedienteMytao;

                    return expedienteDtoMailMerge;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
