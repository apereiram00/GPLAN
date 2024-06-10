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

namespace Presentacion
{
    public partial class FormPlantillas : Form
    {
        private IUnitOfWork _unitOfWork;
        private List<Plantillas> listaPlantillas;
        private FormPrincipal _frmPrincipal;

        private UtilidadesAytoCaceres.Modelos.Seguridad.Usuario _UsuarioUtils;

        public FormPlantillas()
        {
            InitializeComponent();
            _unitOfWork = GetUnitOfWork();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DisposeUnitOfWork(_unitOfWork);
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            _unitOfWork.Dispose();
            _unitOfWork = GetUnitOfWork();

            try
            {
                IEnumerable<Plantillas> listaPlantillasTemp = _unitOfWork.Plantillas.GetAllActive().Result;

                if(Convert.ToDecimal(cmbOrigen.SelectedValue) > 0)
                    listaPlantillasTemp = listaPlantillasTemp.Where(p=>p.OrigenId == Convert.ToDecimal(cmbOrigen.SelectedValue));
                if (Convert.ToDecimal(cmbEstado.SelectedValue) > 0)
                    listaPlantillasTemp = listaPlantillasTemp.Where(p=>p.EstadoId == Convert.ToDecimal(cmbEstado.SelectedValue));

                if (!string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    listaPlantillasTemp = listaPlantillasTemp.Where(p => p.Nombre.ToUpper().StartsWith(txtNombre.Text.ToUpper()));
                }

                //De momento la carga de todas las plantilla es pública
                listaPlantillas = listaPlantillasTemp.ToList();

                CargaDGVPlantillas(listaPlantillas);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Constantes.MENSAJE_ERROR_GENERICO, Constantes.TITULO_ERROR_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message + " " + ex.StackTrace, Constantes.TITULO_ERROR_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormAplicaciones_Load(object sender, EventArgs e)
        {
            try
            {
                #region "Lógica relacionada con perfiles de usuarios"
                //Recupero la instancia del FormPrincipal
                _frmPrincipal = (FormPrincipal)this.Parent.Parent.Parent;
                //Mapeo el usuario del webservice al usuario utulizado en Utilidades
                _UsuarioUtils = UtilidadesSeguridad.GetUsuarioFromJSON(_frmPrincipal._UsuarioSeguridad.UsuarioJSON);
                #endregion

                //Cargo los diferentes combos
                CargaComboEstado();
                CargaComboOrigen();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Constantes.MENSAJE_ERROR_GENERICO, Constantes.TITULO_ERROR_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message + " " + ex.StackTrace, Constantes.TITULO_ERROR_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargaDGVPlantillas(List<Plantillas> listaPlantillas)
        {
            dgvPlantillas.DataSource = listaPlantillas;

            dgvPlantillas.Columns["PLANTILLASID"].HeaderText = "Id";
            dgvPlantillas.Columns["PLANTILLASID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvPlantillas.Columns["NOMBRE"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvPlantillas.Columns["ESTADO"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvPlantillas.Columns["ORIGEN"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgvPlantillas.Columns["RUTAPLANTILLA"].Visible = false;
            dgvPlantillas.Columns["FECHAALTA"].Visible = false;
            dgvPlantillas.Columns["USUARIOCREACION"].Visible = false;
            dgvPlantillas.Columns["FECHABAJA"].Visible = false;
            dgvPlantillas.Columns["MOTIVOBAJA"].Visible = false;
            dgvPlantillas.Columns["FECHAULTIMAMODIF"].Visible = false;
            dgvPlantillas.Columns["USUARIOULTIMAMODIF"].Visible = false;
            dgvPlantillas.Columns["SEGURIDADID"].Visible = false;
            dgvPlantillas.Columns["SEGURIDAD"].Visible = false;
            dgvPlantillas.Columns["ESTADOID"].Visible = false;
            dgvPlantillas.Columns["ORIGENID"].Visible = false;
            dgvPlantillas.Columns["CAMPOS"].Visible = false;
            dgvPlantillas.Columns["UUID"].Visible = false;

        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPlantillas.SelectedRows.Count > 0)
                {
                    _unitOfWork.Dispose();
                    _unitOfWork = GetUnitOfWork();

                    //Recupero la sección de la plantilla
                    var idOrigenPlantilla = Convert.ToDecimal(dgvPlantillas.SelectedRows[0].Cells["ORIGENID"].Value);
                    var origenPlantilla = await _unitOfWork.Valores.GetById(idOrigenPlantilla);
                    if (origenPlantilla!= null)
                    {
                        //Comprobamos si el usuario tiene permisos para la sección de la plantilla.
                        //Coincide la descripción del perfil de SegApp con la descripción de la tabla Valores y con el nombre de la UO de MyTao
                        var resultadoPerfil = _UsuarioUtils.Perfiles.Where(p => p.DescripcionPerfil == origenPlantilla.DescripcionValor).FirstOrDefault();

                        //Si es admin también tiene permisos
                        if(resultadoPerfil != null || _UsuarioUtils.TienePerfil(Constantes.PERFIL_ADMINISTRADOR))
                        {
                            decimal idPlantilla = Convert.ToDecimal(dgvPlantillas.SelectedRows[0].Cells["PLANTILLASID"].Value);

                            FormEditarPlantilla frmEditarPlantilla = new FormEditarPlantilla(idPlantilla, _frmPrincipal,_unitOfWork);
                            _frmPrincipal.AbrirFormEnPanelConParametros(frmEditarPlantilla);
                        }
                        else
                            MessageBox.Show(Constantes.MENSAJE_ERROR_AUTORIZACION_EDITAR_PLANTILLA, Constantes.TITULO_AVISO_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                        MessageBox.Show(Constantes.MENSAJE_ERROR_GENERICO, Constantes.TITULO_ERROR_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show(Constantes.MENSAJE_ERROR_NO_FILA_SELECCIONADA, Constantes.TITULO_AVISO_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Constantes.MENSAJE_ERROR_GENERICO, Constantes.TITULO_ERROR_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message + " " + ex.StackTrace, Constantes.TITULO_ERROR_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPlantillas.SelectedRows.Count > 0)
                {
                    DialogResult resultadoConfirmacion = MessageBox.Show(Constantes.MENSAJE_CONFIRMACION_ELIMINAR_PLANTILLA, Constantes.TITULO_AVISO_GENERICO, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resultadoConfirmacion == DialogResult.Yes)
                    {
                        _unitOfWork.Dispose();
                        _unitOfWork = GetUnitOfWork();

                        decimal idPlantilla = Convert.ToDecimal(dgvPlantillas.SelectedRows[0].Cells["PLANTILLASID"].Value);

                        //Elimino la plantilla
                        _unitOfWork.Plantillas.DeleteLogical(idPlantilla, string.Empty, _UsuarioUtils.Username);

                        //Elimino los campos de la plantilla
                        var listaCamposPlantilla = _unitOfWork.Campos.GetAll().Result;
                        listaCamposPlantilla = listaCamposPlantilla.Where(c => c.PlantillaId == idPlantilla).ToList();
                        listaCamposPlantilla.ToList().ForEach(c => { _unitOfWork.Campos.DeleteLogical(c.Camposid, string.Empty, _UsuarioUtils.Username); });

                        _unitOfWork.CommitWork();

                        MessageBox.Show(Constantes.MENSAJE_EXITO_GENERICO, Constantes.TITULO_EXITO_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Information);

                        btnBuscar.PerformClick();
                    }
                }
                else
                {
                    MessageBox.Show(Constantes.MENSAJE_ERROR_NO_FILA_SELECCIONADA, Constantes.TITULO_AVISO_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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

            return new UnitOfWork(_context, new CamposRepository(_context), new PlantillasRepository(_context), new TiposRepository(_context), new ValoresRepository(_context));
        }

        private void DisposeUnitOfWork(IUnitOfWork unitOfwork)
        {
            unitOfwork.Dispose();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                //Abro el formulario de la sección en concreto
                if (dgvPlantillas.SelectedRows.Count > 0)
                {
                    decimal idOrigenPlantilla = Convert.ToDecimal(dgvPlantillas.SelectedRows[0].Cells["ORIGENID"].Value);
                    decimal idPlantilla = Convert.ToDecimal(dgvPlantillas.SelectedRows[0].Cells["PLANTILLASID"].Value);
                    decimal idEstadoPlantilla = Convert.ToDecimal(dgvPlantillas.SelectedRows[0].Cells["ESTADOID"].Value);

                    //Solo puedo imprimir plantillas preparadas (excepto administrador)
                    if (idEstadoPlantilla == Constantes.VALOR_ESTADO_PREPARADA || _UsuarioUtils.TienePerfil(Constantes.PERFIL_ADMINISTRADOR))
                    {
                        if (idOrigenPlantilla == Constantes.VALOR_ORIGEN_URBANISMO)
                        {
                            //Compruebo que tenga el perfil de Urbanismo
                            if (_UsuarioUtils.TienePerfil(Constantes.PERFIL_URBANISMO) || _UsuarioUtils.TienePerfil(Constantes.PERFIL_ADMINISTRADOR))
                            {
                                //Abro el formulario para Urbanismo
                                FormPlantillasUrbanismo formPlantillasUrbanismo = new FormPlantillasUrbanismo(idPlantilla, (FormPrincipal)this.Parent.Parent.Parent);
                                formPlantillasUrbanismo.ShowDialog(this);
                            }
                            else
                                MessageBox.Show(Constantes.MENSAJE_ERROR_AUTORIZACION_IMPRIMIR_PLANTILLA, Constantes.TITULO_AVISO_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                        if (idOrigenPlantilla == Constantes.VALOR_ORIGEN_SANCIONES)
                        {
                            //Compruebo que tenga el perfil de Sanciones y DAC
                            if (_UsuarioUtils.TienePerfil(Constantes.PERFIL_SANCIONES) || _UsuarioUtils.TienePerfil(Constantes.PERFIL_ADMINISTRADOR))
                            {
                                //Abro el formulario para Sanciones
                                FormPlantillasAsesoria formPlantillasSanciones = new FormPlantillasAsesoria(idPlantilla, (FormPrincipal)this.Parent.Parent.Parent);
                                formPlantillasSanciones.ShowDialog(this);
                            }
                            else
                                MessageBox.Show(Constantes.MENSAJE_ERROR_AUTORIZACION_IMPRIMIR_PLANTILLA, Constantes.TITULO_AVISO_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                        if (idOrigenPlantilla == Constantes.VALOR_ORIGEN_LICENCIAS)
                        {

                            //Compruebo que tenga el perfil de Licencias
                            if (_UsuarioUtils.TienePerfil(Constantes.PERFIL_LICENCIAS) || _UsuarioUtils.TienePerfil(Constantes.PERFIL_ADMINISTRADOR))
                            {
                                MessageBox.Show("En construcción");
                                //Abro el formulario para Licencias
                                //FormPlantillasAsesoria formPlantillasSanciones = new FormPlantillasAsesoria(idPlantilla, (FormPrincipal)this.Parent.Parent.Parent);
                                //formPlantillasSanciones.ShowDialog(this);
                            }
                            else
                                MessageBox.Show(Constantes.MENSAJE_ERROR_AUTORIZACION_IMPRIMIR_PLANTILLA, Constantes.TITULO_AVISO_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        } 
                    }
                    else
                        MessageBox.Show(Constantes.MENSAJE_ERROR_PLANTILLA_NO_PREPARADA, Constantes.TITULO_AVISO_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Constantes.MENSAJE_ERROR_GENERICO, Constantes.TITULO_ERROR_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message + " " + ex.StackTrace, Constantes.TITULO_ERROR_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPlantillas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                //Muestro el nombre del Departamento
                if (e.ColumnIndex == 13) //Columna del Departamento
                {
                    var plantillaItem = (Plantillas)(this.dgvPlantillas.Rows[e.RowIndex].DataBoundItem);
                    if (plantillaItem.Origen != null)
                        e.Value = plantillaItem.Origen.Nombre;
                }
                //Muestro el nombre del Estado de la plantilla
                if (e.ColumnIndex == 14) //Columna del Estado
                {
                    var plantillaItem = (Plantillas)(this.dgvPlantillas.Rows[e.RowIndex].DataBoundItem);
                    if (plantillaItem.Estado != null)
                        e.Value = plantillaItem.Estado.NombreValor;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Constantes.MENSAJE_ERROR_GENERICO, Constantes.TITULO_ERROR_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message + " " + ex.StackTrace, Constantes.TITULO_ERROR_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            try
            {
                btnBuscar.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Constantes.MENSAJE_ERROR_GENERICO, Constantes.TITULO_ERROR_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message + " " + ex.StackTrace, Constantes.TITULO_ERROR_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void CargaComboEstado()
        {
            IEnumerable<Valores> iEnumerableEstados = await _unitOfWork.Valores.GetAll();
            var listaEstados = iEnumerableEstados.Where(v => v.TiposId == Constantes.TIPO_ESTADOS).ToList();

            var nuevoEstadoVacio = new Valores() { Valoresid = 0, NombreValor = "Todos" };
            listaEstados.Add(nuevoEstadoVacio);

            cmbEstado.DataSource = listaEstados.OrderBy(e => e.Valoresid).ToList();
            cmbEstado.ValueMember = "Valoresid";
            cmbEstado.DisplayMember = "NombreValor";
        }

        private async void CargaComboOrigen()
        {
            IEnumerable<Valores> iEnumerableOrig = await _unitOfWork.Valores.GetAll();
            var listaOrig = iEnumerableOrig.Where(v => v.TiposId == Constantes.TIPO_ORIGEN).ToList();

            var nuevoEstadoVacio = new Valores() { Valoresid = 0, NombreValor = "Todos" };
            listaOrig.Add(nuevoEstadoVacio);

            cmbOrigen.DataSource = listaDeptos.OrderBy(e => e.Valoresid).ToList();
            cmbOrigen.ValueMember = "Origenid";
            cmbOrigen.DisplayMember = "Nombre";
        }

    }
}
