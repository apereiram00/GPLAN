using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion.DTO
{
    public class UrbanismoDTOMailMerge
    {
        public string Clave { get; set; }
        public string NumExpediente { get; set; }
        public string Asunto { get; set; }
        public string Ubicacion { get; set; }
        public string Interesado { get; set; }
        public string NifCifInteresado { get; set; }
        public string ExpedienteMyTAO { get; set; }

        internal string GetValueByPropertyName(string campoExterno)
        {
            switch (campoExterno)
            {
                case nameof(Clave):
                    return Clave;
                case nameof(NumExpediente):
                    return NumExpediente;
                case nameof(Asunto):
                    return Asunto;
                case nameof(Ubicacion):
                    return Ubicacion;
                case nameof(Interesado):
                    return Interesado;
                case nameof(NifCifInteresado):
                    return NifCifInteresado;
                case nameof(ExpedienteMyTAO):
                    return ExpedienteMyTAO;
                default:
                    return string.Empty;
            }
        }
    }
}
