using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilidadesAytoCaceres;
using Shared;
using Repository.Interfaces;
using Repository.Implementations;
using Data.Context;

namespace Presentacion
{
    public partial class FormPrincipal : Form
    {
        private UtilidadesAytoCaceres.Modelos.Seguridad.Usuario _UsuarioUtils;
        public SegAppService.Usuario _UsuarioSeguridad;

        public FormPrincipal(SegAppService.Usuario user)
        {
            InitializeComponent();
            _UsuarioSeguridad = user;
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                #region "Lógica relacionada con perfiles de usuarios"
                lblUsuario.Text = _UsuarioSeguridad.Nombre;
                if(_UsuarioSeguridad.Perfiles.Length > 0)
                    lblDepartamento.Text = _UsuarioSeguridad.Perfiles[0].NombrePerfil;

                //Mapeo el usuario de la seguridad al de utilidades
                _UsuarioUtils = UtilidadesSeguridad.GetUsuarioFromJSON(_UsuarioSeguridad.UsuarioJSON);
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(Constantes.MENSAJE_ERROR_GENERICO, Constantes.TITULO_ERROR_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message + " " + ex.StackTrace, Constantes.TITULO_ERROR_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AbrirFormEnPanel<MiForm>() where MiForm : Form, new()
        {
            //Cierro todos los formulario abiertos
            foreach (Form formularioPanelContenedor in panelFormularios.Controls.OfType<Form>())
            {
                formularioPanelContenedor.Close();
            }

            Form formulario;
            formulario = panelContenedor.Controls.OfType<MiForm>().FirstOrDefault();

            //si el formulario/instancia no existe, creamos nueva instancia y mostramos
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelFormularios.Controls.Add(formulario);
                panelFormularios.Tag = formulario;
                formulario.Show();

                formulario.BringToFront();              
            }
            else
            {
                //si la Formulario/instancia existe, lo traemos a frente
                formulario.BringToFront();

                //Si la instancia esta minimizada mostramos
                if (formulario.WindowState == FormWindowState.Minimized)
                {
                    formulario.WindowState = FormWindowState.Normal;
                }

            }
        }

        public void AbrirFormEnPanelConParametros(Form formulario)
        {
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelFormularios.Controls.Add(formulario);
                panelFormularios.Tag = formulario;
                formulario.Show();

                formulario.BringToFront();
        }

        #region "Funcionalidades funcionamiento del formulario"

        //RESIZE METODO PARA REDIMENSIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        //Comentado porque pega flashazo al cargar formulario
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.panelContenedor.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(51, 86, 153));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Capturar posicion y tamaño antes de maximinzar
        int lx, ly;
        int sw, sh;

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;

            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;

            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.Location = new Point(lx, ly);
            this.Size = new Size(sw, sh);

            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
        }

        private void panelBarraTitulo_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (btnMaximizar.Visible == true)
                {
                    lx = this.Location.X;
                    ly = this.Location.Y;
                    sw = this.Size.Width;
                    sh = this.Size.Height;

                    this.Size = Screen.PrimaryScreen.WorkingArea.Size;
                    this.Location = Screen.PrimaryScreen.WorkingArea.Location;

                    btnMaximizar.Visible = false;
                    btnRestaurar.Visible = true;

                }
                else
                {
                    this.Location = new Point(lx, ly);
                    this.Size = new Size(sw, sh);

                    btnMaximizar.Visible = true;
                    btnRestaurar.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Constantes.MENSAJE_ERROR_GENERICO, Constantes.TITULO_ERROR_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message + " " + ex.StackTrace, Constantes.TITULO_ERROR_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panelBarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        #endregion

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                _UsuarioSeguridad = null;
                lblUsuario.Text = "";
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Constantes.MENSAJE_ERROR_GENERICO, Constantes.TITULO_ERROR_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message + " " + ex.StackTrace, Constantes.TITULO_ERROR_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSolicitarPlantilla_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(Constantes.MENSAJE_SOLICITAR_PLANTILLA, Constantes.TITULO_AVISO_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Constantes.MENSAJE_ERROR_GENERICO, Constantes.TITULO_ERROR_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message + " " + ex.StackTrace, Constantes.TITULO_ERROR_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPlantillas_Click(object sender, EventArgs e)
        {
            try
            {
                AbrirFormEnPanel<FormPlantillas>();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Constantes.MENSAJE_ERROR_GENERICO, Constantes.TITULO_ERROR_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message + " " + ex.StackTrace, Constantes.TITULO_ERROR_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevaPlantilla_Click(object sender, EventArgs e)
        {
            try
            {
                AbrirFormEnPanel<FormNuevaPlantillas>();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Constantes.MENSAJE_ERROR_GENERICO, Constantes.TITULO_ERROR_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message + " " + ex.StackTrace, Constantes.TITULO_ERROR_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
