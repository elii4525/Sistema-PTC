using Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas
{
    public partial class frmListaInventario : UserControl
    {
        public frmListaInventario()
        {
            InitializeComponent();
            
        }

        private void frmListaInventario_Load(object sender, EventArgs e)
        {
            MostrarMateriales();
        }

        private void MostrarMateriales()
        {
            dgvMaterialesD.DataSource = null;
            dgvMaterialesD.DataSource = Material.CargarMateriales();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvMaterialesD.DataSource = null;
                dgvMaterialesD.DataSource = Material.Buscar(txtBuscar.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            MostrarMateriales();
        }
    }
}
