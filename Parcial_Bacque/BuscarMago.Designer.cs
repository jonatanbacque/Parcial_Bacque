namespace Parcial_Bacque
{
    partial class frmMagoBuscar
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
            this.cboMago = new System.Windows.Forms.ComboBox();
            this.lblMago = new System.Windows.Forms.Label();
            this.dgvHechizos = new System.Windows.Forms.DataGridView();
            this.dgvHechizosTodos = new System.Windows.Forms.DataGridView();
            this.lblMagoElegido = new System.Windows.Forms.Label();
            this.lblHechizos = new System.Windows.Forms.Label();
            this.lblHechizosTodos = new System.Windows.Forms.Label();
            this.btnHechizoAgregar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHechizos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHechizosTodos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMagos
            // 
            this.dgvMagos.AllowUserToAddRows = false;
            this.dgvMagos.AllowUserToDeleteRows = false;
            this.dgvMagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMagos.Location = new System.Drawing.Point(15, 77);
            this.dgvMagos.Name = "dgvMagos";
            this.dgvMagos.ReadOnly = true;
            this.dgvMagos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMagos.Size = new System.Drawing.Size(205, 267);
            this.dgvMagos.TabIndex = 0;
            this.dgvMagos.Visible = false;
            this.dgvMagos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMagos_CellContentClick);
            // 
            // cboMago
            // 
            this.cboMago.FormattingEnabled = true;
            this.cboMago.Location = new System.Drawing.Point(111, 12);
            this.cboMago.Name = "cboMago";
            this.cboMago.Size = new System.Drawing.Size(241, 21);
            this.cboMago.TabIndex = 1;
            this.cboMago.SelectedIndexChanged += new System.EventHandler(this.cboMago_SelectedIndexChanged);
            // 
            // lblMago
            // 
            this.lblMago.AutoSize = true;
            this.lblMago.Location = new System.Drawing.Point(31, 15);
            this.lblMago.Name = "lblMago";
            this.lblMago.Size = new System.Drawing.Size(63, 13);
            this.lblMago.TabIndex = 2;
            this.lblMago.Text = "Elegir Mago";
            // 
            // dgvHechizos
            // 
            this.dgvHechizos.AllowUserToAddRows = false;
            this.dgvHechizos.AllowUserToDeleteRows = false;
            this.dgvHechizos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHechizos.Location = new System.Drawing.Point(235, 77);
            this.dgvHechizos.Name = "dgvHechizos";
            this.dgvHechizos.ReadOnly = true;
            this.dgvHechizos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHechizos.Size = new System.Drawing.Size(205, 267);
            this.dgvHechizos.TabIndex = 3;
            this.dgvHechizos.Visible = false;
            // 
            // dgvHechizosTodos
            // 
            this.dgvHechizosTodos.AllowUserToAddRows = false;
            this.dgvHechizosTodos.AllowUserToDeleteRows = false;
            this.dgvHechizosTodos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHechizosTodos.Location = new System.Drawing.Point(455, 77);
            this.dgvHechizosTodos.Name = "dgvHechizosTodos";
            this.dgvHechizosTodos.ReadOnly = true;
            this.dgvHechizosTodos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHechizosTodos.Size = new System.Drawing.Size(205, 267);
            this.dgvHechizosTodos.TabIndex = 4;
            // 
            // lblMagoElegido
            // 
            this.lblMagoElegido.AutoSize = true;
            this.lblMagoElegido.Location = new System.Drawing.Point(100, 52);
            this.lblMagoElegido.Name = "lblMagoElegido";
            this.lblMagoElegido.Size = new System.Drawing.Size(34, 13);
            this.lblMagoElegido.TabIndex = 5;
            this.lblMagoElegido.Text = "Mago";
            // 
            // lblHechizos
            // 
            this.lblHechizos.AutoSize = true;
            this.lblHechizos.Location = new System.Drawing.Point(288, 52);
            this.lblHechizos.Name = "lblHechizos";
            this.lblHechizos.Size = new System.Drawing.Size(98, 13);
            this.lblHechizos.TabIndex = 6;
            this.lblHechizos.Text = "Hechizos del Mago";
            this.lblHechizos.Visible = false;
            // 
            // lblHechizosTodos
            // 
            this.lblHechizosTodos.AutoSize = true;
            this.lblHechizosTodos.Location = new System.Drawing.Point(507, 52);
            this.lblHechizosTodos.Name = "lblHechizosTodos";
            this.lblHechizosTodos.Size = new System.Drawing.Size(100, 13);
            this.lblHechizosTodos.TabIndex = 7;
            this.lblHechizosTodos.Text = "Todos los Hechizos";
            // 
            // btnHechizoAgregar
            // 
            this.btnHechizoAgregar.Location = new System.Drawing.Point(475, 360);
            this.btnHechizoAgregar.Name = "btnHechizoAgregar";
            this.btnHechizoAgregar.Size = new System.Drawing.Size(173, 25);
            this.btnHechizoAgregar.TabIndex = 8;
            this.btnHechizoAgregar.Text = "Agregar Hechizo";
            this.btnHechizoAgregar.UseVisualStyleBackColor = true;
            this.btnHechizoAgregar.Click += new System.EventHandler(this.btnHechizoAgregar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Location = new System.Drawing.Point(475, 406);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(173, 25);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmMagoBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(680, 443);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnHechizoAgregar);
            this.Controls.Add(this.lblHechizosTodos);
            this.Controls.Add(this.lblHechizos);
            this.Controls.Add(this.lblMagoElegido);
            this.Controls.Add(this.dgvHechizosTodos);
            this.Controls.Add(this.dgvHechizos);
            this.Controls.Add(this.lblMago);
            this.Controls.Add(this.cboMago);
            this.Controls.Add(this.dgvMagos);
            this.Name = "frmMagoBuscar";
            this.Text = "BuscarMago";
            this.Load += new System.EventHandler(this.frmMagoBuscar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHechizos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHechizosTodos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMagos;
        private System.Windows.Forms.ComboBox cboMago;
        private System.Windows.Forms.Label lblMago;
        private System.Windows.Forms.DataGridView dgvHechizos;
        private System.Windows.Forms.DataGridView dgvHechizosTodos;
        private System.Windows.Forms.Label lblMagoElegido;
        private System.Windows.Forms.Label lblHechizos;
        private System.Windows.Forms.Label lblHechizosTodos;
        private System.Windows.Forms.Button btnHechizoAgregar;
        private System.Windows.Forms.Button btnSalir;
    }
}