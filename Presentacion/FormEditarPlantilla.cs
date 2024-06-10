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
    public partial class FormEditarPlantilla : Form
    {
        private IUnitOfWork _unitOfWork;
        private Plantillas _plantilla;
        private decimal _idPlantilla;
        private FormPrincipal _formPrincipal;

        private UtilidadesAytoCaceres.Modelos.Seguridad.Usuario _UsuarioUtils;


        public FormEditarPlantilla(decimal idPlantilla, FormPrincipal formPrincipal, IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
            _idPlantilla = idPlantilla;
            _formPrincipal = formPrincipal;
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

                //Cargo los diferentes combos
                CargaComboEstado();
                CargaComboDepartamento();

                //Configuro OpenFileDialog
                ConfigurarOpenFileDialog();

                //Configuro columnas del DataGridView
                ConfigurarDataGridView();

                CargaDatosPlantilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Constantes.MENSAJE_ERROR_GENERICO, Constantes.TITULO_ERROR_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message + " " + ex.StackTrace, Constantes.TITULO_ERROR_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargaDatosPlantilla()
        {
            try
            {
                _plantilla = _unitOfWork.Plantillas.GetById(_idPlantilla).Result;

                if(_plantilla != null)
                {
                    txtNombre.Text = _plantilla.Nombre;
                    txtPlantilla.Text = _plantilla.RutaPlantilla;
                    cmbEstado.SelectedValue = _plantilla.EstadoId;
                    cmbOrigen.SelectedValue = _plantilla.OrigenId;

                    if (_plantilla.Campos.Count>0)
                    {
                        foreach (var campo in _plantilla.Campos.OrderBy(c => c.CampoPlantilla))
                        {
                            dgvCamposPlantilla.Rows.Add(new object[] { campo.CampoPlantilla, campo.CampoExterno, campo.TipoCampoId });
                        }
                    }

                    //Solo el usuario con rol administrador puede modificar el estado de las plantillas
                    if (_UsuarioUtils.TienePerfil(Constantes.PERFIL_ADMINISTRADOR))
                    {
                        cmbEstado.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show(Constantes.MENSAJE_ERROR_NO_EXISTE_PLANTILLA, Constantes.TITULO_ERROR_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (Exception)
            {
                throw;
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

                if (dgvCamposPlantilla.Rows.Count == 0)
                {
                    MessageBox.Show(Constantes.MENSAJE_ERROR_NO_CAMPOS_PLANTILLA, Constantes.TITULO_AVISO_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (dgvCamposPlantilla.Rows[0].Cells[0].Value == null || dgvCamposPlantilla.Rows[0].Cells[1].Value == null || dgvCamposPlantilla.Rows[0].Cells[2].Value == null)
                {
                    MessageBox.Show(Constantes.MENSAJE_ERROR_NO_CAMPOS_PLANTILLA, Constantes.TITULO_AVISO_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //Si pasamos las comprobaciones modificamos la plantilla
                var nuevaPlantilla = new Plantillas();
                nuevaPlantilla.Nombre = txtNombre.Text;
                nuevaPlantilla.OrigenId = Convert.ToDecimal(cmbOrigen.SelectedValue);
                nuevaPlantilla.SeguridadId = Constantes.VALOR_ESTADO_PENDIENTE_CONFIGURAR;
                nuevaPlantilla.EstadoId = Convert.ToDecimal(cmbEstado.SelectedValue);

                //Si se cumple se ha modificado la plantilla
                if(txtPlantilla.Text != _plantilla.RutaPlantilla)
                {
                    //Elimino la plantilla anterior
                    File.Delete(_plantilla.RutaPlantilla);

                    //Genero una nueva ruta y guardo la nueva plantilla
                    string dest = ConfigurationManager.AppSettings["directorioPlantillas"].ToString();
                    nuevaPlantilla.RutaPlantilla = $"{dest}\\{DateTime.Now:yyyyMMdd-HHmmss}-plantilla.docx";
                    txtPlantilla.Text = nuevaPlantilla.RutaPlantilla;

                    File.Copy(openFileDialog.FileName, nuevaPlantilla.RutaPlantilla);
                }
                else
                {
                    nuevaPlantilla.RutaPlantilla = txtPlantilla.Text;
                }

                //Actualizo los datos de la plantilla
                _unitOfWork.Plantillas.Update(nuevaPlantilla, _idPlantilla, _UsuarioUtils.Username);

                //Actualizo los datos de los campos
                //Primero borro los anteriores
                foreach (var campo in _plantilla.Campos)
                {
                    _unitOfWork.Campos.Delete(campo.Camposid);
                }
                //Añado los nuevos campos a la plantilla
                foreach (DataGridViewRow  fila in dgvCamposPlantilla.Rows)
                {
                    if (fila.Cells[0].Value != null && fila.Cells[1].Value != null && fila.Cells[2].Value != null)
                    {
                        var nuevoCamposPlantilla = new Campos();
                        nuevoCamposPlantilla.CampoPlantilla = fila.Cells[0].Value.ToString();
                        nuevoCamposPlantilla.CampoExterno = fila.Cells[1].Value.ToString();
                        nuevoCamposPlantilla.TipoCampoId = Convert.ToDecimal(fila.Cells[2].Value);
                        nuevoCamposPlantilla.PlantillaId = _idPlantilla;

                        _unitOfWork.Campos.Create(nuevoCamposPlantilla,_UsuarioUtils.Username);
                    }
                }

                //Confirmo los cambios
                _unitOfWork.CommitWork();

                MessageBox.Show(Constantes.MENSAJE_EXITO_GENERICO, Constantes.TITULO_EXITO_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
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

            return new UnitOfWork(_context, new CamposRepository(_context), new PlantillasRepository(_context), new TiposRepository(_context), new ValoresRepository(_context), new OrigenRepository(_context);
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

        private void CargaComboDepartamento()
        {
            var listaDeptos = _unitOfWork.Valores.GetAll().Result;
            listaDeptos = listaDeptos.Where(v => v.TiposId == Constantes.TIPO_DEPARTAMENTOS).ToList();

            cmbOrigen.DataSource = listaDeptos;
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

            dgvCamposPlantilla.Columns.AddRange(c1, c2, c3);
        }

        private async void btnCargarCampos_Click(object sender, EventArgs e)
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
                }
                else
                    MessageBox.Show(Constantes.MENSAJE_ERROR_NO_EXISTE_PLANTILLA, Constantes.TITULO_AVISO_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Constantes.MENSAJE_ERROR_GENERICO, Constantes.TITULO_ERROR_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message + " " + ex.StackTrace, Constantes.TITULO_ERROR_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtIdPlantilla_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Solo se permiten números
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnBorrarCampos_Click(object sender, EventArgs e)
        {
            try
            {
                dgvCamposPlantilla.Rows.Clear();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
