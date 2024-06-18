namespace Presentacion
{
    partial class FormNuevoOrigen
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvCamposOrigen = new System.Windows.Forms.DataGridView();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNombreOrigen = new System.Windows.Forms.TextBox();
            this.txtOrigenSrc = new System.Windows.Forms.TextBox();
            this.btnCrearOrigen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCamposOrigen)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(914, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nuevo Origen";
            // 
            // dgvCamposOrigen
            // 
            this.dgvCamposOrigen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCamposOrigen.BackgroundColor = System.Drawing.Color.White;
            this.dgvCamposOrigen.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvCamposOrigen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCamposOrigen.Location = new System.Drawing.Point(12, 201);
            this.dgvCamposOrigen.MultiSelect = false;
            this.dgvCamposOrigen.Name = "dgvCamposOrigen";
            this.dgvCamposOrigen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCamposOrigen.Size = new System.Drawing.Size(917, 358);
            this.dgvCamposOrigen.TabIndex = 0;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Origen";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Nombre";
            // 
            // txtNombreOrigen
            // 
            this.txtNombreOrigen.Location = new System.Drawing.Point(62, 59);
            this.txtNombreOrigen.MaxLength = 100;
            this.txtNombreOrigen.Name = "txtNombreOrigen";
            this.txtNombreOrigen.Size = new System.Drawing.Size(544, 20);
            this.txtNombreOrigen.TabIndex = 15;
            // 
            // txtOrigenSrc
            // 
            this.txtOrigenSrc.Location = new System.Drawing.Point(62, 111);
            this.txtOrigenSrc.MaxLength = 100;
            this.txtOrigenSrc.Name = "txtOrigenSrc";
            this.txtOrigenSrc.Size = new System.Drawing.Size(373, 20);
            this.txtOrigenSrc.TabIndex = 16;
            // 
            // btnCrearOrigen
            // 
            this.btnCrearOrigen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrearOrigen.FlatAppearance.BorderSize = 0;
            this.btnCrearOrigen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearOrigen.Image = global::Presentacion.Properties.Resources.boton;
            this.btnCrearOrigen.Location = new System.Drawing.Point(879, 42);
            this.btnCrearOrigen.Name = "btnCrearOrigen";
            this.btnCrearOrigen.Size = new System.Drawing.Size(50, 50);
            this.btnCrearOrigen.TabIndex = 10;
            this.btnCrearOrigen.UseVisualStyleBackColor = true;
            this.btnCrearOrigen.Click += new System.EventHandler(this.btnCrearOrigen_Click);
            // 
            // FormNuevoOrigen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(941, 571);
            this.Controls.Add(this.btnCrearOrigen);
            this.Controls.Add(this.txtOrigenSrc);
            this.Controls.Add(this.txtNombreOrigen);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvCamposOrigen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNuevoOrigen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nueva Plantilla";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCamposOrigen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvCamposOrigen;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNombreOrigen;
        private System.Windows.Forms.TextBox txtOrigenSrc;
        private System.Windows.Forms.Button btnCrearOrigen;
    }
}
    