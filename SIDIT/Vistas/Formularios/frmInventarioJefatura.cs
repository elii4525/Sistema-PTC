using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelos.Entidades;

namespace Vistas.Formularios
{
    public partial class frmInventarioJefatura : Form
    {
        public frmInventarioJefatura()
        {
            InitializeComponent();
        }

        private void frmInventarioJefatura_Load(object sender, EventArgs e)
        {
            MostrarMateriales();
        }

        private void MostrarMateriales()
        {
            dgvMaterialesJ.DataSource = null;
            dgvMaterialesJ.DataSource = Material.CargarMateriales();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvMaterialesJ.DataSource = null;
                dgvMaterialesJ.DataSource = Material.Buscar(txtBuscar.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLimpiarBusqueda_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            MostrarMateriales();
        }
    }
}
