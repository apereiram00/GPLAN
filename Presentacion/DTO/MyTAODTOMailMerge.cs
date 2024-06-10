using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion.DTO
{
    public class MyTAODTOMailMerge
    {
        public string DboID { get; set; }
        public string NumExpediente { get; set; }
        public string TipoSolicitud { get; set; }
        public string FechaPresentacion { get; set; }
        public string FechaAlta { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
        public string InfoAdicional { get; set; }
        public string Interesado { get; set; }
        public string NifCifInteresado { get; set; }
        public string NumActuaciones { get; set; }
        public string NumDocumentos { get; set; }

        internal string GetValueByPropertyName(string campoExterno)
        {
            switch (campoExterno)
            {
                case nameof(DboID):
                    return DboID;
                case nameof(NumExpediente):
                    return NumExpediente;
                case nameof(TipoSolicitud):
                    return TipoSolicitud;
                case nameof(FechaPresentacion):
                    return FechaPresentacion;
                case nameof(FechaAlta):
                    return FechaAlta;
                case nameof(Descripcion):
                    return Descripcion;
                case nameof(Estado):
                    return Estado;
                case nameof(InfoAdicional):
                    return InfoAdicional;
                case nameof(Interesado):
                    return Interesado;
                case nameof(NifCifInteresado):
                    return NifCifInteresado;
                case nameof(NumActuaciones):
                    return NumActuaciones;
                case nameof(NumDocumentos):
                    return NumDocumentos;
                default:
                    return string.Empty;
            }
        }
    }
}
