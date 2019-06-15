using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Parcial_Bacque
{
    public partial class frmMagoBuscar : Form
    {
        Funciones funciones = new Funciones();
        Magos mago;

        public frmMagoBuscar()
        {
            InitializeComponent();
        }

        private void frmMagoBuscar_Load(object sender, EventArgs e)
        {
            cboMago.DataSource = funciones.MagosListarNombre();
            
            dgvHechizosTodos.DataSource = funciones.HechizosListar();
            dgvHechizosTodos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvHechizosTodos.Columns[0].Visible = false;
        }

        private void cboMago_SelectedIndexChanged(object sender, EventArgs e)
        {
            Funciones funciones = new Funciones();
            try
            {
                dgvMagos.Visible = true;
                dgvMagos.DataSource = funciones.MagosListar(cboMago.Text);
                dgvMagos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvMagos.Columns[0].Visible = false;

                dgvHechizos.Visible = false;
                lblHechizos.Visible = false;
                btnHechizoAgregar.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void dgvMagos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Funciones funciones = new Funciones();
            try
            {
                mago = (Magos)dgvMagos.CurrentRow.DataBoundItem;

                dgvHechizos.Visible = true;
                dgvHechizos.DataSource = funciones.HechizosListar(mago.ID);
                dgvHechizos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvHechizos.Columns[0].Visible = false;
                dgvHechizos.Columns[2].Visible = false;
                dgvHechizos.Columns[3].Visible = false;

                lblHechizos.Visible = true;

                btnHechizoAgregar.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnHechizoAgregar_Click(object sender, EventArgs e)
        {
            Magos mago = (Magos)dgvMagos.CurrentRow.DataBoundItem;

            funciones.HechizosAgregar(mago, (Hechizos)dgvHechizosTodos.CurrentRow.DataBoundItem);

            dgvHechizos.DataSource = funciones.HechizosListar(mago.ID);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

