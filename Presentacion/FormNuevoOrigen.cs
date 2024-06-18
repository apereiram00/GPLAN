﻿using Data.Context;
using Data.Entities;
using Repository.Implementations;
using Repository.Interfaces;
using Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using UtilidadesAytoCaceres;

namespace Presentacion
{
    public partial class FormNuevoOrigen : Form
    {
        private IUnitOfWork _unitOfWork;
        private UtilidadesAytoCaceres.Modelos.Seguridad.Usuario _UsuarioUtils;
        public FormNuevoOrigen()
        {
            InitializeComponent();
            _unitOfWork = GetUnitOfWork();
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
                //Recupero la instancia del FormPrincipal
                FormPrincipal frmPrincipal = (FormPrincipal)this.Parent.Parent.Parent;
                //Mapeo el usuario del webservice al usuario utulizado en Utilidades
                _UsuarioUtils = UtilidadesSeguridad.GetUsuarioFromJSON(frmPrincipal._UsuarioSeguridad.UsuarioJSON);
                #endregion

                //Cargo los diferentes combos
                CargaComboEstado();
                CargaComboOrigen();

                //Configuro OpenFileDialog
                ConfigurarOpenFileDialog();

                //Configuro columnas del DataGridView
                ConfigurarDataGridView();

                InicializarUsuarioUtils();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Constantes.MENSAJE_ERROR_GENERICO, Constantes.TITULO_ERROR_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message + " " + ex.StackTrace, Constantes.TITULO_ERROR_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InicializarUsuarioUtils()
        {
            try
            {
                // Recupero la instancia del FormPrincipal
                FormPrincipal frmPrincipal = (FormPrincipal)this.Parent.Parent.Parent;

                // Mapeo el usuario del webservice al usuario utilizado en Utilidades
                _UsuarioUtils = UtilidadesSeguridad.GetUsuarioFromJSON(frmPrincipal._UsuarioSeguridad.UsuarioJSON);
            }
            catch (Exception ex)
            {
                // Manejo de errores si algo sale mal al inicializar el usuario
                MessageBox.Show("Error al inicializar el usuario de seguridad: " + ex.Message, Constantes.TITULO_ERROR_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
             
        private void CargaComboOrigen()
        {
            var listaOrig = _unitOfWork.Origen.GetAll().Result;
            listaOrig = listaOrig.Where(v => v.Origenid == Constantes.TIPO_ORIGEN).ToList();

           /*cmbOrigen.DataSource = listaOrig;
            cmbOrigen.ValueMember = "Origenid";
            cmbOrigen.DisplayMember = "Nombre";*/
        }

        private void CargaComboEstado()
        {
            var listaEstados = _unitOfWork.Valores.GetAll().Result;
            listaEstados = listaEstados.Where(v => v.TiposId == Constantes.TIPO_ESTADOS).ToList();

           /* cmbEstado.DataSource = listaEstados;
            cmbEstado.ValueMember = "Valoresid";
            cmbEstado.DisplayMember = "NombreValor";*/
        }

        private void ConfigurarOpenFileDialog()
        {
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFileDialog.RestoreDirectory = true;
            openFileDialog.Filter = @"Word File (.docx)|*.docx";
            openFileDialog.FileName = "";
        }
        private void ConfigurarDataGridView()
        {
            var c1 = new DataGridViewTextBoxColumn();
            c1.Name = "CampoPlantilla";
            c1.HeaderText = "Campo en Plantilla";
            c1.Width = 150;

            var c2 = new DataGridViewTextBoxColumn();
            c2.Name = "CampoExterno";
            c2.HeaderText = "Campo Externo";
            c2.Width = 150;

            var listaTiposCampo = _unitOfWork.Valores.GetAll().Result;
            listaTiposCampo = listaTiposCampo.Where(v => v.TiposId == Constantes.TIPO_TIPOS_CAMPO).ToList();

            var c3 = new DataGridViewComboBoxColumn();
            c3.Name = "TipoCampo";
            c3.HeaderText = "Tipo de Campo";
            c3.Width = 150;
            c3.DataSource = listaTiposCampo;
            c3.ValueMember = "Valoresid";
            c3.DisplayMember = "NombreValor";

            dgvCamposOrigen.Columns.AddRange(c1, c2, c3);
        } 
        
        private void txtIdPlantilla_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Solo se permiten números
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnCrearOrigen_Click(object sender, EventArgs e)
        {
            try
            {
                //Comprobaciones
                if (string.IsNullOrWhiteSpace(txtNombreOrigen.Text))
                {
                    MessageBox.Show(Constantes.MENSAJE_ERROR_NO_NOMBRE_PLANTILLA, Constantes.TITULO_AVISO_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtOrigenSrc.Text))
                {
                    MessageBox.Show(Constantes.MENSAJE_ERROR_NO_PLANTILLA, Constantes.TITULO_AVISO_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Verificación de _UsuarioUtils
                if (_UsuarioUtils == null)
                {
                    InicializarUsuarioUtils();

                    if (_UsuarioUtils == null)
                    {
                        MessageBox.Show("El usuario de seguridad no está inicializado.", Constantes.TITULO_ERROR_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                //Si pasamos las comprobaciones damos el alta de la plantilla
                var nuevoOrigen = new Origen();

                nuevoOrigen.Nombre = txtNombreOrigen.Text;
                nuevoOrigen.OrigenSrc = txtOrigenSrc.Text;
                nuevoOrigen.Uuid = Guid.NewGuid().ToString();
                

                //string dest = ConfigurationManager.AppSettings["directorioOrigen"].ToString();
                //nuevoOrigen.OrigenSrc = $"{dest}\\{DateTime.Now:yyyyMMdd-HHmmss}-plantilla.docx";
                string dest = $"Data Source=(DESCRIPTION =(ADDRESS=(PROTOCOL=TCP)(HOST=oraclescan)(PORT=1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME = AYTOCC)(FAILOVER_MODE =(TYPE = SELECT)(METHOD = BASIC)(RETRIES = 180)(DELAY = 5))));User Id={nuevoOrigen.Nombre};Password=;";
                
                nuevoOrigen.OrigenSrc = dest;
                //nuevoOrigen.CamposOrigen = new List<Campos>();

                /*foreach (DataGridViewRow fila in dgvCamposPlantilla.Rows)
                {
                    if (fila.Cells[0].Value != null && fila.Cells[1].Value != null && fila.Cells[2].Value != null)
                    {
                        var nuevoCamposPlantilla = new Campos();
                        nuevoCamposPlantilla.CampoPlantilla = fila.Cells[0].Value.ToString();
                        nuevoCamposPlantilla.CampoExterno = fila.Cells[1].Value.ToString();
                        nuevoCamposPlantilla.TipoCampoId = Convert.ToDecimal(fila.Cells[2].Value);

                        nuevoOrigen.Campos.Add(nuevoCamposPlantilla);
                    }
                }*/

                _unitOfWork.Origen.Create(nuevoOrigen, _UsuarioUtils.Username);
                _unitOfWork.CommitWork();

                MessageBox.Show(Constantes.MENSAJE_EXITO_GENERICO, Constantes.TITULO_EXITO_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Constantes.MENSAJE_ERROR_GENERICO, Constantes.TITULO_ERROR_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message + " " + ex.StackTrace, Constantes.TITULO_ERROR_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

