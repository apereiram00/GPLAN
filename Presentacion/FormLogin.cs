using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Security.Principal;
using Shared;

namespace Presentacion
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Constantes.MENSAJE_ERROR_CONTACTE_INFORMATICA, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                using (SegAppService.SegAppClient SegAppClient = new SegAppService.SegAppClient())
                {
                    SegAppService.Usuario usuario;

                    usuario = SegAppClient.Authenticate(txtUsuario.Text, txtPassword.Text);

                    if(usuario.CodigoOperacion == Constantes.CODIGO_OPERACION_USUARIO_AUTENTICADO)
                    {
                        usuario = SegAppClient.AuthorizateJSON(txtUsuario.Text, Constantes.ID_APLICACION_GPLAN);

                        if(usuario.CodigoOperacion == Constantes.CODIGO_OPERACION_USUARIO_AUTORIZADO)
                        {
                            FormPrincipal formPrincipal = new FormPrincipal(usuario);

                            this.Hide();
                            formPrincipal.ShowDialog(this);

                            txtUsuario.Text = "";
                            txtPassword.Text = "";
                            this.Show();
                        }
                        else
                        {
                            MessageBox.Show(Constantes.MENSAJE_ERROR_AUTORIZACION, Constantes.TITULO_ERROR_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show(Constantes.MENSAJE_ERROR_AUTENTICACION, Constantes.TITULO_ERROR_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Constantes.MENSAJE_ERROR_GENERICO, Constantes.TITULO_ERROR_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message + " " + ex.StackTrace, Constantes.TITULO_ERROR_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                btnLogin.PerformClick();
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            try
            {
                //Instacio en objeto WindowsIdentity
                WindowsIdentity myIdentity = WindowsIdentity.GetCurrent();

                //Obtengo el dominio y el usuario
                string dominio = myIdentity.Name.Split('\\')[0];
                string userName = myIdentity.Name.Split('\\')[1];

                if (dominio != Constantes.DOMINIO_AYTO)
                {
                    //Fallo en SSO
                    panelLoginNormal.Visible = true;
                    panelLoginSSO.Visible = false;
                }

                if (!myIdentity.IsAuthenticated)
                {
                    //Fallo en SSO
                    panelLoginNormal.Visible = true;
                    panelLoginSSO.Visible = false;
                }

                using (SegAppService.SegAppClient SegAppClient = new SegAppService.SegAppClient())
                {
                    SegAppService.Usuario usuario = SegAppClient.Authorizate(userName, Constantes.ID_APLICACION_GPLAN);

                    if (usuario.CodigoOperacion == Constantes.CODIGO_OPERACION_USUARIO_AUTORIZADO)
                    {
                        //Éxito en SSO
                        txtUsuario.Focus();
                        btnIniciarSSo.Text = $"Iniciar Sesión como {userName}";
                        panelLoginNormal.Visible = false;
                        panelLoginSSO.Visible = true;
                    }
                    else
                    {
                        //Fallo en SSO
                        panelLoginNormal.Visible = true;
                        panelLoginSSO.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Constantes.MENSAJE_ERROR_GENERICO, Constantes.TITULO_ERROR_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message + " " + ex.StackTrace, Constantes.TITULO_ERROR_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }

        private void btnCancelarSSO_Click(object sender, EventArgs e)
        {
            try
            {
                panelLoginNormal.Visible = true;
                panelLoginSSO.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(Constantes.MENSAJE_ERROR_GENERICO, Constantes.TITULO_ERROR_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message + " " + ex.StackTrace, Constantes.TITULO_ERROR_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIniciarSSo_Click(object sender, EventArgs e)
        {
            try
            {
                using (SegAppService.SegAppClient SegAppClient = new SegAppService.SegAppClient())
                {
                    //Instacio en objeto WindowsIdentity
                    WindowsIdentity myIdentity = WindowsIdentity.GetCurrent();

                    //Obtengo el usuario
                    string userName = myIdentity.Name.Split('\\')[1];

                    SegAppService.Usuario usuario = SegAppClient.AuthorizateJSON(userName, Constantes.ID_APLICACION_GPLAN);

                    FormPrincipal formPrincipal = new FormPrincipal(usuario);

                    this.Hide();
                    formPrincipal.ShowDialog(this);

                    panelLoginSSO.Visible = false;
                    panelLoginNormal.Visible = true;
                    this.Show();
                }                 
            }
            catch (Exception ex)
            {
                MessageBox.Show(Constantes.MENSAJE_ERROR_GENERICO, Constantes.TITULO_ERROR_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message + " " + ex.StackTrace, Constantes.TITULO_ERROR_GENERICO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
