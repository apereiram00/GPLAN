using Data.Entities;
using Repository.Interfaces;
using Repository.Implementations;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using UtilidadesAytoCaceres;
using Shared;
using Data.Context;
using System.IO;
using System.Configuration;

namespace Presentacion
{
    public partial class FormNuevaPlantillas : Form
    {
        private IUnitOfWork _unitOfWork;

        private UtilidadesAytoCaceres.Modelos.Seguridad.Usuario _UsuarioUtils;

        public FormNuevaPlantillas()
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
                // ConfigurarDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Constantes.MENSAJE_ERROR_GENERICO, Constantes.TITULO_ERROR_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message + " " + ex.StackTrace, Constantes.TITULO_ERROR_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCrearPlantilla_Click(object sender, EventArgs e)
        {
            try
            {
                //Comprobaciones
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show(Constantes.MENSAJE_ERROR_NO_NOMBRE_PLANTILLA, Constantes.TITULO_AVISO_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtPlantilla.Text))
                {
                    MessageBox.Show(Constantes.MENSAJE_ERROR_NO_PLANTILLA, Constantes.TITULO_AVISO_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //Si pasamos las comprobaciones damos el alta de la plantilla
                var nuevaPlantilla = new Plantillas();

                nuevaPlantilla.Nombre = txtNombre.Text;
                nuevaPlantilla.OrigenId = Convert.ToDecimal(cmbOrigen.SelectedValue);
                nuevaPlantilla.SeguridadId = Constantes.VALOR_ESTADO_PENDIENTE_CONFIGURAR;
                nuevaPlantilla.EstadoId = Convert.ToDecimal(cmbEstado.SelectedValue);

                string dest = ConfigurationManager.AppSettings["directorioPlantillas"].ToString();
                nuevaPlantilla.RutaPlantilla = $"{dest}\\{DateTime.Now:yyyyMMdd-HHmmss}-plantilla.docx";

                File.Copy(openFileDialog.FileName, nuevaPlantilla.RutaPlantilla);

                nuevaPlantilla.Campos = new List<Campos>();

                _unitOfWork.Plantillas.Create(nuevaPlantilla, _UsuarioUtils.Username);
                _unitOfWork.CommitWork();

                MessageBox.Show(Constantes.MENSAJE_EXITO_GENERICO, Constantes.TITULO_EXITO_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Information);

                ResetControlesSuperiores();

            }
            catch (Exception ex)
            {
                MessageBox.Show(Constantes.MENSAJE_ERROR_GENERICO, Constantes.TITULO_ERROR_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message + " " + ex.StackTrace, Constantes.TITULO_ERROR_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetControlesSuperiores()
        {
            txtNombre.Text = "";
            txtPlantilla.Text = "";
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

        private void btnSeleccionarPlantilla_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtPlantilla.Text = openFileDialog.FileName;
            }
        }

        private void CargaComboOrigen()
        {
            var listaOrig = _unitOfWork.Origen.GetAll().Result;
           //listaOrig = listaOrig.Where(v => v.Origenid == Constantes.TIPO_ORIGEN).ToList();

            cmbOrigen.DataSource = listaOrig;
            cmbOrigen.ValueMember = "Origenid";
            cmbOrigen.DisplayMember = "Nombre";
        }

        private void CargaComboEstado()
        {
            var listaEstados = _unitOfWork.Valores.GetAll().Result;
            listaEstados = listaEstados.Where(v => v.TiposId == Constantes.TIPO_ESTADOS).ToList();

            cmbEstado.DataSource = listaEstados;
            cmbEstado.ValueMember = "Valoresid";
            cmbEstado.DisplayMember = "NombreValor";
        }

        private void ConfigurarOpenFileDialog()
        {
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFileDialog.RestoreDirectory = true;
            openFileDialog.Filter = @"Word File (.docx)|*.docx";
            openFileDialog.FileName = "";
        }
       /* private void ConfigurarDataGridView()
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

            dgvCamposPlantilla.Columns.AddRange(c1, c2, c3);
        }*/

        /*private async void btnCargarCampos_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtIdPlantilla.Text))
                {
                    MessageBox.Show(Constantes.MENSAJE_ERROR_CAMPO_OBLIGATORIO_PLANTILLA, Constantes.TITULO_AVISO_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var plantilla = await _unitOfWork.Plantillas.GetById(Convert.ToDecimal(txtIdPlantilla.Text));

                if(plantilla != null)
                {
                    dgvCamposPlantilla.Rows.Clear();

                    foreach (var campo in plantilla.Campos.OrderBy(c=>c.CampoPlantilla))
                    {
                        dgvCamposPlantilla.Rows.Add(new object[] { campo.CampoPlantilla, campo.CampoExterno, campo.TipoCampoId });
                    }

                    txtPlantilla.Text = string.Empty;
                }
                else
                    MessageBox.Show(Constantes.MENSAJE_ERROR_NO_EXISTE_PLANTILLA, Constantes.TITULO_AVISO_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Constantes.MENSAJE_ERROR_GENERICO, Constantes.TITULO_ERROR_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message + " " + ex.StackTrace, Constantes.TITULO_ERROR_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/

        private void txtIdPlantilla_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Solo se permiten números
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
