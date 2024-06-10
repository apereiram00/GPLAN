namespace Presentacion
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.panelInferiorUsuario = new System.Windows.Forms.Panel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelLoginSSO = new System.Windows.Forms.Panel();
            this.btnIniciarSSo = new System.Windows.Forms.Button();
            this.btnCancelarSSO = new System.Windows.Forms.Button();
            this.panelLoginNormal = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.panelContenedor.SuspendLayout();
            this.panelLoginSSO.SuspendLayout();
            this.panelLoginNormal.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(6, 31);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(219, 22);
            this.txtUsuario.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Contraseña:";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(6, 85);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(219, 22);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(146, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Bienvenido a la Aplicación";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(169, 174);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 130);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Location = new System.Drawing.Point(165, 572);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "¿Problemas para iniciar sesión?";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(410, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Teclee su nombre de usuario y contraseña de Windows para acceder a la aplicación." +
    "";
            // 
            // btnLogin
            // 
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.Image")));
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(6, 122);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(219, 32);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Iniciar Sesión";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(86)))), ((int)(((byte)(153)))));
            this.panelBarraTitulo.Controls.Add(this.label6);
            this.panelBarraTitulo.Controls.Add(this.btnCerrar);
            this.panelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(485, 40);
            this.panelBarraTitulo.TabIndex = 15;
            this.panelBarraTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBarraTitulo_MouseMove);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(370, 29);
            this.label6.TabIndex = 4;
            this.label6.Text = "Generador dinámico de Plantillas";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(457, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(16, 16);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panelInferiorUsuario
            // 
            this.panelInferiorUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(86)))), ((int)(((byte)(153)))));
            this.panelInferiorUsuario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInferiorUsuario.Location = new System.Drawing.Point(0, 588);
            this.panelInferiorUsuario.Name = "panelInferiorUsuario";
            this.panelInferiorUsuario.Size = new System.Drawing.Size(485, 40);
            this.panelInferiorUsuario.TabIndex = 16;
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.panelLoginSSO);
            this.panelContenedor.Controls.Add(this.panelLoginNormal);
            this.panelContenedor.Controls.Add(this.panelBarraTitulo);
            this.panelContenedor.Controls.Add(this.panelInferiorUsuario);
            this.panelContenedor.Controls.Add(this.label4);
            this.panelContenedor.Controls.Add(this.label5);
            this.panelContenedor.Controls.Add(this.label3);
            this.panelContenedor.Controls.Add(this.pictureBox1);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(485, 628);
            this.panelContenedor.TabIndex = 17;
            // 
            // panelLoginSSO
            // 
            this.panelLoginSSO.Controls.Add(this.btnIniciarSSo);
            this.panelLoginSSO.Controls.Add(this.btnCancelarSSO);
            this.panelLoginSSO.Location = new System.Drawing.Point(110, 383);
            this.panelLoginSSO.Name = "panelLoginSSO";
            this.panelLoginSSO.Size = new System.Drawing.Size(265, 121);
            this.panelLoginSSO.TabIndex = 20;
            // 
            // btnIniciarSSo
            // 
            this.btnIniciarSSo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnIniciarSSo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.btnIniciarSSo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.btnIniciarSSo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSSo.ForeColor = System.Drawing.Color.Black;
            this.btnIniciarSSo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIniciarSSo.Location = new System.Drawing.Point(3, 3);
            this.btnIniciarSSo.Name = "btnIniciarSSo";
            this.btnIniciarSSo.Size = new System.Drawing.Size(100, 100);
            this.btnIniciarSSo.TabIndex = 18;
            this.btnIniciarSSo.Text = "Iniciar Sesión como ...";
            this.btnIniciarSSo.UseVisualStyleBackColor = true;
            this.btnIniciarSSo.Click += new System.EventHandler(this.btnIniciarSSo_Click);
            // 
            // btnCancelarSSO
            // 
            this.btnCancelarSSO.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancelarSSO.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.btnCancelarSSO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.btnCancelarSSO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarSSO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarSSO.ForeColor = System.Drawing.Color.Black;
            this.btnCancelarSSO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarSSO.Location = new System.Drawing.Point(162, 3);
            this.btnCancelarSSO.Name = "btnCancelarSSO";
            this.btnCancelarSSO.Size = new System.Drawing.Size(100, 100);
            this.btnCancelarSSO.TabIndex = 19;
            this.btnCancelarSSO.Text = "Iniciar Sesión con otro Usuario";
            this.btnCancelarSSO.UseVisualStyleBackColor = true;
            this.btnCancelarSSO.Click += new System.EventHandler(this.btnCancelarSSO_Click);
            // 
            // panelLoginNormal
            // 
            this.panelLoginNormal.Controls.Add(this.label1);
            this.panelLoginNormal.Controls.Add(this.label2);
            this.panelLoginNormal.Controls.Add(this.txtPassword);
            this.panelLoginNormal.Controls.Add(this.btnLogin);
            this.panelLoginNormal.Controls.Add(this.txtUsuario);
            this.panelLoginNormal.Location = new System.Drawing.Point(122, 340);
            this.panelLoginNormal.Name = "panelLoginNormal";
            this.panelLoginNormal.Size = new System.Drawing.Size(240, 181);
            this.panelLoginNormal.TabIndex = 17;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(485, 628);
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generador dinámico de Plantillas";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelBarraTitulo.ResumeLayout(false);
            this.panelBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            this.panelLoginSSO.ResumeLayout(false);
            this.panelLoginNormal.ResumeLayout(false);
            this.panelLoginNormal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel panelBarraTitulo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Panel panelInferiorUsuario;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panelLoginSSO;
        private System.Windows.Forms.Button btnIniciarSSo;
        private System.Windows.Forms.Button btnCancelarSSO;
        private System.Windows.Forms.Panel panelLoginNormal;
    }
}