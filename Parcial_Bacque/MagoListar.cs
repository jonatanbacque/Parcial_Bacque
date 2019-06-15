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
    public partial class frmMagosListar : Form
    {
        public frmMagosListar()
        {
            InitializeComponent();
        }

        private void cargarDvgMagos()
        {
            Funciones funciones = new Funciones();
            try
            {
                dgvMagos.DataSource = funciones.MagosListar();
                dgvMagos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvMagos.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void MagoListar_Load(object sender, EventArgs e)
        {
            cargarDvgMagos();
            dgvHechizos.Visible = false;
        }

        private void btnHechizos_Click(object sender, EventArgs e)
        {
            Funciones funciones = new Funciones();
            try
            {
                Magos magos = (Magos)dgvMagos.CurrentRow.DataBoundItem;

                dgvHechizos.Visible = true;
                dgvHechizos.DataSource = funciones.HechizosListar(magos.ID);
                dgvHechizos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvHechizos.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvMagos_Click(object sender, EventArgs e)
        {
            dgvHechizos.Visible = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
