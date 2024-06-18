using Data.Entities;
using Repository.Interfaces;
using Repository.Implementations;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using UtilidadesAytoCaceres;
using Shared;
using Data.Context;
using System.IO;
using Syncfusion.DocIO.DLS;
using Syncfusion.DocIO;
using Presentacion.Services.MailMerge;
using System.Diagnostics;
using Data.Policia.Context;

namespace Presentacion
{
    public partial class FormPlantillasAsesoria : Form
    {
        private IUnitOfWork _unitOfWork;
        private UtilidadesAytoCaceres.Modelos.Seguridad.Usuario _UsuarioUtils;
        private Plantillas _plantilla;
        private decimal _idPlantilla;
        private FormPrincipal _formPrincipal;
        private MyTAOMailMergeService _expedientesTaoService;
        private PoliciaContext _policiaContext;
        private AsesoriaMailMergeService _asesoriaService;

        public FormPlantillasAsesoria(decimal idPlantilla, FormPrincipal formPrincipal)
        {
            InitializeComponent();
            _unitOfWork = GetUnitOfWork();
            _idPlantilla = idPlantilla;
            _formPrincipal = formPrincipal;
            _expedientesTaoService = new MyTAOMailMergeService();
            _policiaContext = new PoliciaContext();
            _asesoriaService = new AsesoriaMailMergeService();
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

                CargarMaterias();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Constantes.MENSAJE_ERROR_GENERICO, Constantes.TITULO_ERROR_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message + " " + ex.StackTrace, Constantes.TITULO_ERROR_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarMaterias()
        {
            try
            {
                var listaMateria = _policiaContext.Jurmateria.OrderBy(m=>m.Materia).ToList();

                cmbMateria.DataSource = listaMateria;
                cmbMateria.DisplayMember = "MATERIA";
                cmbMateria.ValueMember = "MATERIA";
            }
            catch (Exception)
            {

                throw;
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
                if (cmbMateria.SelectedValue!=null && cmbEjercicio.SelectedItem!= null && !string.IsNullOrWhiteSpace(txtNumExp.Text))
                {
                    //Abro la plantilla de Word
                    FileStream fileStreamPath = new FileStream(_plantilla.RutaPlantilla, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                    WordDocument document = new WordDocument(fileStreamPath, FormatType.Docx);

                    //Instancio las variables para el mailMerge
                    var fieldNames = new string[_plantilla.Campos.Count];
                    var fieldValues = new string[_plantilla.Campos.Count];

                    //Recupero el expediente de Asesoría Jurídica(TO DO)
                    var expedienteAsesoria = _asesoriaService.GetExpedienteByNumeroExpediente(cmbMateria.SelectedValue.ToString(), cmbEjercicio.SelectedItem.ToString(), txtNumExp.Text);

                    if (expedienteAsesoria != null)
                    {
                        //Hacemos el mailMerge para los datos de la aplicación de Asesoría y para MyTao
                        if (!string.IsNullOrWhiteSpace(expedienteAsesoria.ExpedienteMyTao))
                        {
                            var ejercicio = expedienteAsesoria.ExpedienteMyTao.Split('/')[0];
                            var numeroExp = expedienteAsesoria.ExpedienteMyTao.Split('/')[1].Substring(0, expedienteAsesoria.ExpedienteMyTao.Split('/')[1].Length - 1);

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
                                        fieldValues[i] = expedienteAsesoria.GetValueByPropertyName(campo.CampoExterno);
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
                                        fieldValues[i] = expedienteAsesoria.GetValueByPropertyName(campo.CampoExterno);
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
                        //Hacemos el mailMerge solo con campos de la aplicación de Asesoría
                        else
                        {
                            MessageBox.Show(Constantes.MENSAJE_ERROR_NO_EXPEDIENTE_MYTAO_ASESORIA, Constantes.TITULO_AVISO_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            for (int i = 0; i < _plantilla.Campos.Count; i++)
                            {
                                var campo = _plantilla.Campos.ElementAt(i);

                                //Cargo los nombre de los campos de correspondencia
                                fieldNames[i] = campo.CampoPlantilla;
                                //Cargo el valor para cada campo de correspondencia, solo BBDD
                                if (campo.TipoCampoId == Constantes.VALOR_TIPO_CAMPO_BBDD)
                                {
                                    fieldValues[i] = expedienteAsesoria.GetValueByPropertyName(campo.CampoExterno);
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
                    }
                    else
                        MessageBox.Show(Constantes.MENSAJE_ERROR_NO_EXPEDIENTE_ASESORIA, Constantes.TITULO_AVISO_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Warning); 
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

        private void txtNumExp_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Solo se permiten números
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
