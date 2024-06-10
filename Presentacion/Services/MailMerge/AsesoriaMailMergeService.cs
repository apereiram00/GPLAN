using Data.Policia.Context;
using Microsoft.EntityFrameworkCore;
using Presentacion.DTO;
using System;
using System.Linq;

namespace Presentacion.Services.MailMerge
{
    public class AsesoriaMailMergeService
    {
        public AsesoriaDTOMailMerge GetExpedienteByNumeroExpediente(string materia, string ejercicio, string numExpediente)
        {
            try
            {
                var _policiaContext = new PoliciaContext();

                var expedienteAsesoria = _policiaContext.Jurexpedientes.Where(exp => exp.Materia.Equals(materia)
                                                                                         && exp.Ejercicio.Value == Convert.ToInt32(ejercicio)
                                                                                         && exp.Numexp.Value == Convert.ToInt32(numExpediente))
                                                                .Include(e => e.Jurtramitacion).Include(e => e.Jurinteresados)
                                                                .SingleOrDefault();

                if (expedienteAsesoria != null)
                {
                    //Instanciamos Numalets
                    var numaletNumeroEntero = new NumaletNumeroEntero();
                    var numaletNumeroDecimal = new NumaletNumeroDecimal();

                    //Recuperamos denunciado
                    var denunciado = expedienteAsesoria.Jurinteresados.Where(d => d.Dem.Equals("Denunciado")).FirstOrDefault();
                    //Recuperamos tramitacion
                    var tramitacion = expedienteAsesoria.Jurtramitacion.SingleOrDefault();

                    //Cargamos DTO
                    var expedienteDtoMailMerge = new AsesoriaDTOMailMerge();
                    //Campos del denunciado
                    expedienteDtoMailMerge.NifCifDenunciado = denunciado != null ? denunciado.Nif: string.Empty ;
                    expedienteDtoMailMerge.DomicilioDenunciado = denunciado != null ? denunciado.Domicilio : string.Empty;
                    expedienteDtoMailMerge.PoblacionDenunciado = denunciado != null ? denunciado.Poblacion : string.Empty;
                    expedienteDtoMailMerge.CodigoPostalDenunciado = denunciado != null ? denunciado.CodigoPostal : string.Empty;

                    //Campos generales del expediente
                    expedienteDtoMailMerge.ExpedienteMyTao = expedienteAsesoria.ExpedienteTao;
                    expedienteDtoMailMerge.FechaDenuncia = expedienteAsesoria.FecDenuncia.HasValue ? expedienteAsesoria.FecDenuncia.Value.ToShortDateString() : string.Empty;
                    expedienteDtoMailMerge.FechaDenunciaLargo = expedienteAsesoria.FecDenuncia.HasValue ? expedienteAsesoria.FecDenuncia.Value.ToString("d 'de' MMMM 'de' yyyy") : string.Empty;
                    expedienteDtoMailMerge.Hora = expedienteAsesoria.HoraDenuncia;
                    expedienteDtoMailMerge.AgentesDenunciantes = expedienteAsesoria.Agentes;
                    expedienteDtoMailMerge.LugarInfraccion = expedienteAsesoria.Lugar;
                    expedienteDtoMailMerge.HechoDenunciado = expedienteAsesoria.HechoDenunciado;
                    expedienteDtoMailMerge.NormaAplicacion = expedienteAsesoria.Norma;
                    expedienteDtoMailMerge.PreceptoInfraccion = expedienteAsesoria.PreceptoInfraccion;
                    expedienteDtoMailMerge.CalificacionInfraccion = expedienteAsesoria.CalificacionInfraccion;
                    expedienteDtoMailMerge.PreceptoSancion = expedienteAsesoria.PreceptoSancion;
                    if (expedienteAsesoria.Importe.HasValue)
                    {
                        //Número entero
                        if ((expedienteAsesoria.Importe.Value % 1) == 0)
                            expedienteDtoMailMerge.Importe = $" {numaletNumeroEntero.ToCustomString(expedienteAsesoria.Importe.Value)} ({expedienteAsesoria.Importe.Value} €)";
                        //Número decimal
                        else
                            expedienteDtoMailMerge.Importe =  $" {numaletNumeroDecimal.ToCustomString(expedienteAsesoria.Importe.Value)} ({expedienteAsesoria.Importe.Value} €)";
                    }
                    else
                        expedienteDtoMailMerge.Importe = string.Empty;
                    if (expedienteAsesoria.Importe20.HasValue)
                    {
                        //Número entero
                        if ((expedienteAsesoria.Importe20.Value % 1) == 0)
                            expedienteDtoMailMerge.ImporteReducido = $" {numaletNumeroEntero.ToCustomString(expedienteAsesoria.Importe20.Value)} ({expedienteAsesoria.Importe20.Value} €)";
                        //Número decimal
                        else
                            expedienteDtoMailMerge.ImporteReducido = $" {numaletNumeroDecimal.ToCustomString(expedienteAsesoria.Importe20.Value)} ({expedienteAsesoria.Importe20.Value} €)";
                    }
                    else
                        expedienteDtoMailMerge.ImporteReducido = string.Empty;
                    if (expedienteAsesoria.Importe40.HasValue)
                    {
                        //Número entero
                        if ((expedienteAsesoria.Importe40.Value % 1) == 0)
                            expedienteDtoMailMerge.ImporteReducidoMaximo = $" {numaletNumeroEntero.ToCustomString(expedienteAsesoria.Importe40.Value)} ({expedienteAsesoria.Importe40.Value} €)";
                        //Número decimal
                        else
                            expedienteDtoMailMerge.ImporteReducidoMaximo = $" {numaletNumeroDecimal.ToCustomString(expedienteAsesoria.Importe40.Value)} ({expedienteAsesoria.Importe40.Value} €)";
                    }
                    else
                        expedienteDtoMailMerge.ImporteReducidoMaximo = string.Empty;
                    //Campos de tramitacion
                    if(tramitacion!= null)
                    {
                        expedienteDtoMailMerge.FechaInicioExpSancionador = tramitacion.FecInicioExp.HasValue ? tramitacion.FecInicioExp.Value.ToString("d 'de' MMMM 'de' yyyy"): string.Empty;
                        expedienteDtoMailMerge.FechaNotifProviPublTeu1 = tramitacion.FecNotificacionInicio.HasValue ? tramitacion.FecNotificacionInicio.Value.ToString("d 'de' MMMM 'de' yyyy") : string.Empty;
                        expedienteDtoMailMerge.FechaPresentacionAlegaciones = tramitacion.FecPresentacionAlegaciones.HasValue ? tramitacion.FecPresentacionAlegaciones.Value.ToString("d 'de' MMMM 'de' yyyy") : string.Empty;
                        expedienteDtoMailMerge.FechaDiligenciaAlegaciones = tramitacion.FecDiligPresenAlegAgentes.HasValue ? tramitacion.FecDiligPresenAlegAgentes.Value.ToString("d 'de' MMMM 'de' yyyy") : string.Empty;
                        expedienteDtoMailMerge.FechaInformesAgentes = tramitacion.FecConstAlegacionesAgentes.HasValue ? tramitacion.FecConstAlegacionesAgentes.Value.ToString("d 'de' MMMM 'de' yyyy") : string.Empty;
                        expedienteDtoMailMerge.FechaPropuestaResolucion = tramitacion.FecPropuestaResolucion.HasValue ? tramitacion.FecPropuestaResolucion.Value.ToString("d 'de' MMMM 'de' yyyy") : string.Empty;
                        expedienteDtoMailMerge.FechaNotifPropuestaPublTeu2 = tramitacion.FecNotificacionPropuesta.HasValue ? tramitacion.FecNotificacionPropuesta.Value.ToString("d 'de' MMMM 'de' yyyy") : string.Empty;
                        expedienteDtoMailMerge.FechaPresentacionAlegacionesAudenciaPrevia = tramitacion.FecAlegPropResolucion.HasValue ? tramitacion.FecAlegPropResolucion.Value.ToString("d 'de' MMMM 'de' yyyy") : string.Empty;
                        expedienteDtoMailMerge.FechaDiligenciaAlegacionesAudenciaPrevia = tramitacion.FecDiligPresenAlegInstruc.HasValue ? tramitacion.FecDiligPresenAlegInstruc.Value.ToString("d 'de' MMMM 'de' yyyy") : string.Empty;
                        expedienteDtoMailMerge.FechaResolucion = tramitacion.FecResolucionExpediente.HasValue ? tramitacion.FecResolucionExpediente.Value.ToString("d 'de' MMMM 'de' yyyy") : string.Empty;
                    }
                    else
                    {
                        expedienteDtoMailMerge.FechaInicioExpSancionador = string.Empty;
                        expedienteDtoMailMerge.FechaNotifProviPublTeu1 = string.Empty;
                        expedienteDtoMailMerge.FechaPresentacionAlegaciones = string.Empty;
                        expedienteDtoMailMerge.FechaDiligenciaAlegaciones = string.Empty;
                        expedienteDtoMailMerge.FechaInformesAgentes = string.Empty;
                        expedienteDtoMailMerge.FechaPropuestaResolucion = string.Empty;
                        expedienteDtoMailMerge.FechaNotifPropuestaPublTeu2 = string.Empty;
                        expedienteDtoMailMerge.FechaPresentacionAlegacionesAudenciaPrevia = string.Empty;
                        expedienteDtoMailMerge.FechaDiligenciaAlegacionesAudenciaPrevia = string.Empty;
                        expedienteDtoMailMerge.FechaResolucion = string.Empty;
                    }
                   
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

        public string GetNumeroExpedienteMyTAO(string materia,string ejercicio,string numExpediente)
        {
            try
            {
                var _policiaContext = new PoliciaContext();

                if (numExpediente.Length > 0)
                {
                    var expediente = _policiaContext.Jurexpedientes.Where(exp => exp.Materia.Equals(materia)
                                                                                         && exp.Ejercicio.Value == Convert.ToInt32(ejercicio)
                                                                                         && exp.Numexp.Value == Convert.ToInt32(numExpediente)).SingleOrDefault();
                    if (expediente != null)
                    {
                        if (!string.IsNullOrWhiteSpace(expediente.ExpedienteTao))
                        {
                            return expediente.ExpedienteTao;
                        }
                        else
                            return string.Empty;
                    }
                    else
                        return string.Empty;
                }
                else
                {
                    return string.Empty;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
