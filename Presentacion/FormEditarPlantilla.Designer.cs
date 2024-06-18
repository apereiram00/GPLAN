namespace Presentacion
{
    partial class FormEditarPlantilla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditarPlantilla));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCrearPlantilla = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvCamposPlantilla = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtPlantilla = new System.Windows.Forms.TextBox();
            this.btnSeleccionarPlantilla = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.cmbOrigen = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCargarCampos = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdPlantilla = new System.Windows.Forms.TextBox();
            this.btnBorrarCampos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCamposPlantilla)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(62, 58);
            this.txtNombre.MaxLength = 100;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(544, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(914, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnCrearPlantilla
            // 
            this.btnCrearPlantilla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrearPlantilla.FlatAppearance.BorderSize = 0;
            this.btnCrearPlantilla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearPlantilla.Image = ((System.Drawing.Image)(resources.GetObject("btnCrearPlantilla.Image")));
            this.btnCrearPlantilla.Location = new System.Drawing.Point(879, 42);
            this.btnCrearPlantilla.Name = "btnCrearPlantilla";
            this.btnCrearPlantilla.Size = new System.Drawing.Size(50, 50);
            this.btnCrearPlantilla.TabIndex = 10;
            this.btnCrearPlantilla.UseVisualStyleBackColor = true;
            this.btnCrearPlantilla.Click += new System.EventHandler(this.btnCrearPlantilla_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Editar Plantilla";
            // 
            // dgvCamposPlantilla
            // 
            this.dgvCamposPlantilla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCamposPlantilla.BackgroundColor = System.Drawing.Color.White;
            this.dgvCamposPlantilla.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCamposPlantilla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCamposPlantilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCamposPlantilla.Location = new System.Drawing.Point(12, 201);
            this.dgvCamposPlantilla.MultiSelect = false;
            this.dgvCamposPlantilla.Name = "dgvCamposPlantilla";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCamposPlantilla.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCamposPlantilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCamposPlantilla.Size = new System.Drawing.Size(917, 358);
            this.dgvCamposPlantilla.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Campos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Plantilla";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // txtPlantilla
            // 
            this.txtPlantilla.Enabled = false;
            this.txtPlantilla.Location = new System.Drawing.Point(62, 97);
            this.txtPlantilla.MaxLength = 100;
            this.txtPlantilla.Name = "txtPlantilla";
            this.txtPlantilla.Size = new System.Drawing.Size(544, 20);
            this.txtPlantilla.TabIndex = 15;
            // 
            // btnSeleccionarPlantilla
            // 
            this.btnSeleccionarPlantilla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSeleccionarPlantilla.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSeleccionarPlantilla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionarPlantilla.Location = new System.Drawing.Point(612, 91);
            this.btnSeleccionarPlantilla.Name = "btnSeleccionarPlantilla";
            this.btnSeleccionarPlantilla.Size = new System.Drawing.Size(116, 30);
            this.btnSeleccionarPlantilla.TabIndex = 16;
            this.btnSeleccionarPlantilla.Text = "Seleccionar plantilla";
            this.btnSeleccionarPlantilla.UseVisualStyleBackColor = true;
            this.btnSeleccionarPlantilla.Click += new System.EventHandler(this.btnSeleccionarPlantilla_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Estado";
            // 
            // cmbEstado
            // 
            this.cmbEstado.Enabled = false;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(62, 138);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(191, 21);
            this.cmbEstado.TabIndex = 18;
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.FormattingEnabled = true;
            this.cmbOrigen.Location = new System.Drawing.Point(354, 138);
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(308, 21);
            this.cmbOrigen.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(310, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Origen";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnCargarCampos
            // 
            this.btnCargarCampos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCargarCampos.FlatAppearance.BorderSize = 0;
            this.btnCargarCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarCampos.Location = new System.Drawing.Point(663, 165);
            this.btnCargarCampos.Name = "btnCargarCampos";
            this.btnCargarCampos.Size = new System.Drawing.Size(171, 28);
            this.btnCargarCampos.TabIndex = 23;
            this.btnCargarCampos.Text = "Cargar campos de otra plantilla";
            this.btnCargarCampos.UseVisualStyleBackColor = true;
            this.btnCargarCampos.Click += new System.EventHandler(this.btnCargarCampos_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(854, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Id Plantilla";
            // 
            // txtIdPlantilla
            // 
            this.txtIdPlantilla.Location = new System.Drawing.Point(849, 170);
            this.txtIdPlantilla.MaxLength = 100;
            this.txtIdPlantilla.Name = "txtIdPlantilla";
            this.txtIdPlantilla.Size = new System.Drawing.Size(69, 20);
            this.txtIdPlantilla.TabIndex = 25;
            this.txtIdPlantilla.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdPlantilla_KeyPress);
            // 
            // btnBorrarCampos
            // 
            this.btnBorrarCampos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBorrarCampos.FlatAppearance.BorderSize = 0;
            this.btnBorrarCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarCampos.Location = new System.Drawing.Point(486, 165);
            this.btnBorrarCampos.Name = "btnBorrarCampos";
            this.btnBorrarCampos.Size = new System.Drawing.Size(171, 28);
            this.btnBorrarCampos.TabIndex = 27;
            this.btnBorrarCampos.Text = "Borrar todos los campos";
            this.btnBorrarCampos.UseVisualStyleBackColor = true;
            this.btnBorrarCampos.Click += new System.EventHandler(this.btnBorrarCampos_Click);
            // 
            // FormEditarPlantilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(941, 571);
            this.Controls.Add(this.btnBorrarCampos);
            this.Controls.Add(this.txtIdPlantilla);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCargarCampos);
            this.Controls.Add(this.cmbOrigen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSeleccionarPlantilla);
            this.Controls.Add(this.txtPlantilla);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCrearPlantilla);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvCamposPlantilla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEditarPlantilla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nueva Plantilla";
            this.Load += new System.EventHandler(this.FormAplicaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCamposPlantilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCrearPlantilla;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvCamposPlantilla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox txtPlantilla;
        private System.Windows.Forms.Button btnSeleccionarPlantilla;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.ComboBox cmbOrigen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCargarCampos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdPlantilla;
        private System.Windows.Forms.Button btnBorrarCampos;
    }
}