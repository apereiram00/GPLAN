using Data.Entities;
using Repository.Interfaces;
using Repository.Implementations;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilidadesAytoCaceres;
using Shared;
using Data.Context;
using Data.Urbanismo.Entities;
using System.IO;
using Syncfusion.DocIO.DLS;
using Syncfusion.DocIO;
using Presentacion.Services.MailMerge;
using System.Dynamic;
using System.Diagnostics;

namespace Presentacion
{
    public partial class FormPlantillasUrbanismo : Form
    {
        private IUnitOfWork _unitOfWork;
        private UtilidadesAytoCaceres.Modelos.Seguridad.Usuario _UsuarioUtils;
        private Plantillas _plantilla;
        private decimal _idPlantilla;
        private FormPrincipal _formPrincipal;
        private MyTAOMailMergeService _expedientesTaoService;
        private UrbanismoMailMergeService _urbanismoService;

        public FormPlantillasUrbanismo(decimal idPlantilla, FormPrincipal formPrincipal)
        {
            InitializeComponent();
            _unitOfWork = GetUnitOfWork();
            _idPlantilla = idPlantilla;
            _formPrincipal = formPrincipal;
            _expedientesTaoService = new MyTAOMailMergeService();
            _urbanismoService = new UrbanismoMailMergeService();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DisposeUnitOfWork(_unitOfWork);
            this.Close();
        }

        private void FormAplicaciones_Load(object sender, EventArgs e)
        {
            try
            {
                #region "Lógica relacionada con perfiles de usuarios"
                //Mapeo el usuario del webservice al usuario utulizado en Utilidades
                _UsuarioUtils = UtilidadesSeguridad.GetUsuarioFromJSON(_formPrincipal._UsuarioSeguridad.UsuarioJSON);
                #endregion

                _plantilla = _unitOfWork.Plantillas.GetById(_idPlantilla).Result;

                lblNombrePlantilla.Text = _plantilla.Nombre;
            }
            catch (Exception ex)
            {
                MessageBox.Show(Constantes.MENSAJE_ERROR_GENERICO, Constantes.TITULO_ERROR_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message + " " + ex.StackTrace, Constantes.TITULO_ERROR_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private IUnitOfWork GetUnitOfWork()
        {
            var _context = new GaelDbContext();

            return new UnitOfWork(_context, new CamposRepository(_context), new PlantillasRepository(_context), new TiposRepository(_context), new ValoresRepository(_context), new OrigenRepository(_context));
        }

        private void DisposeUnitOfWork(IUnitOfWork unitOfwork)
        {
            unitOfwork.Dispose();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtClaveExpediente.Text))
                {
                    //Abro la plantilla de Word
                    FileStream fileStreamPath = new FileStream(_plantilla.RutaPlantilla, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                    WordDocument document = new WordDocument(fileStreamPath, FormatType.Docx);

                    //Instancio las variables para el mailMerge
                    var fieldNames = new string[_plantilla.Campos.Count];
                    var fieldValues = new string[_plantilla.Campos.Count];

                    //Recupero el expediente de Urbanismo
                    var expedienteUrbanismo = _urbanismoService.GetExpedienteByClave(Convert.ToDecimal(txtClaveExpediente.Text));

                    if (expedienteUrbanismo != null)
                    {
                        //Comprobar que los datos del campo ExpedienteMyTAO vienen informados
                        if (!string.IsNullOrWhiteSpace(expedienteUrbanismo.ExpedienteMyTAO))
                        {
                            var ejercicio = expedienteUrbanismo.ExpedienteMyTAO.Split('/')[0];
                            var numeroExp = expedienteUrbanismo.ExpedienteMyTAO.Split('/')[1].Substring(0, expedienteUrbanismo.ExpedienteMyTAO.Split('/')[1].Length - 1);

                            var expedienteMyTAO = _expedientesTaoService.ConsultaExpedienteByIdentificacion(Convert.ToInt32(ejercicio), Convert.ToInt32(numeroExp));

                            if (expedienteMyTAO != null)
                            {
                                for (int i = 0; i < _plantilla.Campos.Count; i++)
                                {
                                    var campo = _plantilla.Campos.ElementAt(i);

                                    //Cargo los nombre de los campos de correspondencia
                                    fieldNames[i] = campo.CampoPlantilla;
                                    //Cargo el valor para cada campo de correspondencia, tanto BBDD como MYTAO
                                    if (campo.TipoCampoId == Constantes.VALOR_TIPO_CAMPO_BBDD)
                                    {
                                        fieldValues[i] = expedienteUrbanismo.GetValueByPropertyName(campo.CampoExterno);
                                    }
                                    else if (campo.TipoCampoId == Constantes.VALOR_TIPO_CAMPO_MYTAO)
                                    {
                                        fieldValues[i] = expedienteMyTAO.GetValueByPropertyName(campo.CampoExterno);
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show(Constantes.MENSAJE_ERROR_NO_EXPEDIENTE_MYTAO, Constantes.TITULO_AVISO_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                for (int i = 0; i < _plantilla.Campos.Count; i++)
                                {
                                    var campo = _plantilla.Campos.ElementAt(i);

                                    //Cargo los nombre de los campos de correspondencia
                                    fieldNames[i] = campo.CampoPlantilla;
                                    //Cargo el valor para cada campo de correspondencia, solo BBDD
                                    if (campo.TipoCampoId == Constantes.VALOR_TIPO_CAMPO_BBDD)
                                    {
                                        fieldValues[i] = expedienteUrbanismo.GetValueByPropertyName(campo.CampoExterno);
                                    }
                                }
                            }

                            //Ejecuto el Mail merge
                            document.MailMerge.Execute(fieldNames, fieldValues);

                            var rutaTemporal = @"c:\temp\plantilla.docx";
                            document.Save(rutaTemporal, FormatType.Docx);

                            Process p = new Process();
                            p.StartInfo.FileName = rutaTemporal;
                            p.Start();

                            document.Close();
                        }
                        else
                            MessageBox.Show(Constantes.MENSAJE_ERROR_NO_EXPEDIENTE_MYTAO_URBANISMO, Constantes.TITULO_AVISO_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                        MessageBox.Show(Constantes.MENSAJE_ERROR_NO_EXPEDIENTE_URBANISMO, Constantes.TITULO_AVISO_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                }
                else
                    MessageBox.Show(Constantes.MENSAJE_CAMPOS_OBLIGATORIOS, Constantes.TITULO_AVISO_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Constantes.MENSAJE_ERROR_GENERICO, Constantes.TITULO_ERROR_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message + " " + ex.StackTrace, Constantes.TITULO_ERROR_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
