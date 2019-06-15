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
            this.button1 = new System.Windows.Forms.Button();
            this.dgvHechizos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
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
            this.dgvMagos.Name = "dgvMagos";
            this.dgvMagos.ReadOnly = true;
            this.dgvMagos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMagos.Size = new System.Drawing.Size(203, 220);
            this.dgvMagos.TabIndex = 0;
            this.dgvMagos.Click += new System.EventHandler(this.dgvMagos_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(278, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ver Hechizos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnHechizos_Click);
            // 
            // dgvHechizos
            // 
            this.dgvHechizos.AllowUserToAddRows = false;
            this.dgvHechizos.AllowUserToDeleteRows = false;
            this.dgvHechizos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHechizos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvHechizos.Location = new System.Drawing.Point(278, 101);
            this.dgvHechizos.Name = "dgvHechizos";
            this.dgvHechizos.ReadOnly = true;
            this.dgvHechizos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHechizos.Size = new System.Drawing.Size(221, 163);
            this.dgvHechizos.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // frmMagosListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 347);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvHechizos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvMagos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMagosListar";
            this.Text = "Lista de Magos";
            this.Load += new System.EventHandler(this.MagoListar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHechizos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMagos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvHechizos;
        private System.Windows.Forms.Label label1;
    }
}