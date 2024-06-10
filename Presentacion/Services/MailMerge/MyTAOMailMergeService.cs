using Presentacion.DTO;
using Shared;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAOClienteProdWS.Expedientes;

namespace Presentacion.Services.MailMerge
{
    public class MyTAOMailMergeService
    {
        private ExpedientesClient _clienteExpedientesTAO = new ExpedientesClient(ConfigurationManager.AppSettings["aplicationNameBuroweb"],
                                                                        ConfigurationManager.AppSettings["businessNameExpedientes"],
                                                                        ConfigurationManager.AppSettings["userLoginMyTAO"],
                                                                        ConfigurationManager.AppSettings["passwordLoginMyTAO"]);
        public MyTAODTOMailMerge ConsultaExpedienteByDboid(string DboID)
        {
            try
            {
                var respuesta = _clienteExpedientesTAO.ConsultaEXPByDboid(DboID, "es", true, true);

                if (respuesta.Expediente != null)
                {
                    var myTaoMailMergeDTO = new MyTAODTOMailMerge();

                    myTaoMailMergeDTO.DboID = respuesta.Expediente.Dboid;
                    myTaoMailMergeDTO.NumExpediente = respuesta.Expediente.NumeroFormateado;
                    myTaoMailMergeDTO.TipoSolicitud = respuesta.Expediente.TipoSolicitudDescripcion;
                    myTaoMailMergeDTO.FechaAlta = respuesta.Expediente.FechaAlta;
                    myTaoMailMergeDTO.FechaPresentacion = respuesta.Expediente.FechaPresentacion;
                    myTaoMailMergeDTO.Descripcion = respuesta.Expediente.DescripcionExp;
                    myTaoMailMergeDTO.Estado = respuesta.Expediente.EstadoDesc;
                    myTaoMailMergeDTO.InfoAdicional = respuesta.Expediente.InformacionAdicional;
                    myTaoMailMergeDTO.NumActuaciones = respuesta.Expediente.ListaActuaciones.Count().ToString();
                    myTaoMailMergeDTO.NumDocumentos = respuesta.Expediente.ListaDocAportada.Count().ToString();

                    //Lógica para sacar al primer interesado(cambiará en un futuro)
                    if (respuesta.Expediente.PersonasExp.Count() >= 0)
                    {
                        foreach (var persona in respuesta.Expediente.PersonasExp)
                        {
                            if (persona.TipoPersonaRelCodigo == "INTERESADO")
                            {
                                myTaoMailMergeDTO.Interesado = persona.NombreCompleto;
                                myTaoMailMergeDTO.NifCifInteresado = persona.dni;
                                break;
                            }
                        }
                    }

                    return myTaoMailMergeDTO;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public MyTAODTOMailMerge ConsultaExpedienteByIdentificacion(int ejercicio, int numero)
        {
            try
            {
                var respuesta = _clienteExpedientesTAO.ConsultaExpByIdent(ejercicio, true, numero, true, "es", "", true, true, "");

                if (respuesta.expediente != null)
                {
                    var myTaoMailMergeDTO = new MyTAODTOMailMerge();

                    myTaoMailMergeDTO.DboID = respuesta.expediente.Dboid;
                    myTaoMailMergeDTO.NumExpediente = respuesta.expediente.NumeroFormateado;
                    myTaoMailMergeDTO.TipoSolicitud = respuesta.expediente.TipoSolicitudDescripcion;
                    myTaoMailMergeDTO.FechaAlta = respuesta.expediente.FechaAlta;
                    myTaoMailMergeDTO.FechaPresentacion = respuesta.expediente.FechaPresentacion;
                    myTaoMailMergeDTO.Descripcion = respuesta.expediente.DescripcionExp;
                    myTaoMailMergeDTO.Estado = respuesta.expediente.EstadoDesc;
                    myTaoMailMergeDTO.InfoAdicional = respuesta.expediente.InformacionAdicional;
                    myTaoMailMergeDTO.NumActuaciones = respuesta.expediente.ListaActuaciones != null ? respuesta.expediente.ListaActuaciones.Count().ToString() : "0";
                    myTaoMailMergeDTO.NumDocumentos = respuesta.expediente.ListaDocAportada != null ?  respuesta.expediente.ListaDocAportada.Count().ToString(): "0";

                    //Lógica para sacar al primer interesado(cambiará en un futuro)
                    if (respuesta.expediente.PersonasExp.Count() >= 0)
                    {
                        foreach (var persona in respuesta.expediente.PersonasExp)
                        {
                            if (persona.TipoPersonaRelCodigo == "INTERESADO")
                            {
                                myTaoMailMergeDTO.Interesado = persona.NombreCompleto;
                                myTaoMailMergeDTO.NifCifInteresado = persona.dni;
                                break;
                            }
                        }
                    }

                    return myTaoMailMergeDTO;
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
