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
            label1.Font = Helper.FuenteHelper.ObtenerFuente(12);
        }

        private void frmInventarioJefatura_Load(object sender, EventArgs e)
        {
            MostrarMateriales();
            EstilizarDataGrid(dgvMaterialesJ);
        }

        private void MostrarMateriales()
        {
            dgvMaterialesJ.DataSource = null;
            dgvMaterialesJ.DataSource = Material.CargarMateriales();
        }



        private void EstilizarDataGrid(DataGridView dgv)
        {
            dgv.BorderStyle = BorderStyle.None;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(198, 216, 112);
            dgv.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgv.BackgroundColor = Color.White;

            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv.RowTemplate.Height = 30;
            dgv.AllowUserToResizeColumns = true;
            dgv.AllowUserToResizeRows = false;
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
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

        private void btnLimpiarB_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            MostrarMateriales();
        }
    }
}
