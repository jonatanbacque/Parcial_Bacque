namespace Parcial_Bacque
{
    partial class frmMagosListar
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
            this.dgvMagos = new System.Windows.Forms.DataGridView();
            this.btnHechizo = new System.Windows.Forms.Button();
            this.dgvHechizos = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHechizos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMagos
            // 
            this.dgvMagos.AllowUserToAddRows = false;
            this.dgvMagos.AllowUserToDeleteRows = false;
            this.dgvMagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMagos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMagos.Location = new System.Drawing.Point(29, 44);
            this.dgvMagos.MultiSelect = false;
            this.dgvMagos.Name = "dgvMagos";
            this.dgvMagos.ReadOnly = true;
            this.dgvMagos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMagos.Size = new System.Drawing.Size(203, 220);
            this.dgvMagos.TabIndex = 0;
            this.dgvMagos.Click += new System.EventHandler(this.dgvMagos_Click);
            // 
            // btnHechizo
            // 
            this.btnHechizo.Location = new System.Drawing.Point(278, 44);
            this.btnHechizo.Name = "btnHechizo";
            this.btnHechizo.Size = new System.Drawing.Size(222, 40);
            this.btnHechizo.TabIndex = 1;
            this.btnHechizo.Text = "Ver Hechizos";
            this.btnHechizo.UseVisualStyleBackColor = true;
            this.btnHechizo.Click += new System.EventHandler(this.btnHechizos_Click);
            // 
            // dgvHechizos
            // 
            this.dgvHechizos.AllowUserToAddRows = false;
            this.dgvHechizos.AllowUserToDeleteRows = false;
            this.dgvHechizos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHechizos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvHechizos.Location = new System.Drawing.Point(278, 101);
            this.dgvHechizos.MultiSelect = false;
            this.dgvHechizos.Name = "dgvHechizos";
            this.dgvHechizos.ReadOnly = true;
            this.dgvHechizos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHechizos.Size = new System.Drawing.Size(221, 163);
            this.dgvHechizos.TabIndex = 2;
            // 
            // btnSalir
            // 
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Location = new System.Drawing.Point(278, 295);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(222, 40);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmMagosListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(528, 347);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvHechizos);
            this.Controls.Add(this.btnHechizo);
            this.Controls.Add(this.dgvMagos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMagosListar";
            this.Text = "Lista de Magos";
            this.Load += new System.EventHandler(this.MagoListar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHechizos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMagos;
        private System.Windows.Forms.Button btnHechizo;
        private System.Windows.Forms.DataGridView dgvHechizos;
        private System.Windows.Forms.Button btnSalir;
    }
}