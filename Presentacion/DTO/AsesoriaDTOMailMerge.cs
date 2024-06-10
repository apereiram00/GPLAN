using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion.DTO
{
    public class AsesoriaDTOMailMerge
    {
        public string ExpedienteMyTao { get; set; }
        public string NifCifDenunciado { get; set; }
        public string DomicilioDenunciado { get; set; }
        public string PoblacionDenunciado { get; set; }
        public string FechaDenuncia { get; set; }
        public string Hora { get; set; }
        public string AgentesDenunciantes { get; set; }
        public string LugarInfraccion { get; set; }
        public string HechoDenunciado { get; set; }
        public string NormaAplicacion { get; set; }
        public string PreceptoInfraccion { get; set; }
        public string CalificacionInfraccion { get; set; }
        public string PreceptoSancion { get; set; }
        public string Importe { get; set; }
        public string ImporteReducido { get; set; }
        public string ImporteReducidoMaximo { get; set; }
        public string FechaInicioExpSancionador { get; set; }
        public string FechaNotifProviPublTeu1 { get; set; }
        public string FechaPresentacionAlegaciones { get; set; }
        public string FechaDiligenciaAlegaciones { get; set; }
        public string FechaInformesAgentes { get; set; }
        public string FechaPropuestaResolucion { get; set; }
        public string FechaNotifPropuestaPublTeu2 { get; set; }
        public string FechaPresentacionAlegacionesAudenciaPrevia { get; set; }
        public string FechaDiligenciaAlegacionesAudenciaPrevia { get; set; }
        public string CodigoPostalDenunciado { get; set; }
        public string FechaResolucion { get; set; }
        public string FechaDenunciaLargo { get; set; }

        internal string GetValueByPropertyName(string campoExterno)
        {
            switch (campoExterno)
            {
                case nameof(ExpedienteMyTao):
                    return ExpedienteMyTao;
                case nameof(NifCifDenunciado):
                    return NifCifDenunciado;
                case nameof(DomicilioDenunciado):
                    return DomicilioDenunciado;
                case nameof(PoblacionDenunciado):
                    return PoblacionDenunciado;
                case nameof(FechaDenuncia):
                    return FechaDenuncia;
                case nameof(Hora):
                    return Hora;
                case nameof(AgentesDenunciantes):
                    return AgentesDenunciantes;
                case nameof(LugarInfraccion):
                    return LugarInfraccion;
                case nameof(HechoDenunciado):
                    return HechoDenunciado;
                case nameof(NormaAplicacion):
                    return NormaAplicacion;
                case nameof(PreceptoInfraccion):
                    return PreceptoInfraccion;
                case nameof(CalificacionInfraccion):
                    return CalificacionInfraccion;
                case nameof(PreceptoSancion):
                    return PreceptoSancion;
                case nameof(Importe):
                    return Importe;
                case nameof(ImporteReducido):
                    return ImporteReducido;
                case nameof(ImporteReducidoMaximo ):
                    return ImporteReducido;
                case nameof(FechaInicioExpSancionador):
                    return FechaInicioExpSancionador;
                case nameof(FechaNotifProviPublTeu1):
                    return FechaNotifProviPublTeu1;
                case nameof(FechaPresentacionAlegaciones):
                    return FechaPresentacionAlegaciones;
                case nameof(FechaDiligenciaAlegaciones):
                    return FechaDiligenciaAlegaciones;
                case nameof(FechaInformesAgentes):
                    return FechaInformesAgentes;
                case nameof(FechaPropuestaResolucion):
                    return FechaPropuestaResolucion;
                case nameof(FechaNotifPropuestaPublTeu2):
                    return FechaNotifPropuestaPublTeu2;
                case nameof(FechaPresentacionAlegacionesAudenciaPrevia):
                    return FechaPresentacionAlegacionesAudenciaPrevia;
                case nameof(FechaDiligenciaAlegacionesAudenciaPrevia):
                    return FechaDiligenciaAlegacionesAudenciaPrevia;
                case nameof(CodigoPostalDenunciado):
                    return CodigoPostalDenunciado;
                case nameof(FechaResolucion):
                    return FechaResolucion;
                case nameof(FechaDenunciaLargo):
                    return FechaDenunciaLargo;
                default:
                    return string.Empty;
            }
        }
    }
}
