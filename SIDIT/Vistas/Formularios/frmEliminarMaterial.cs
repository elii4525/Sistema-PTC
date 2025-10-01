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

namespace Vistas.Formularios
{
    public partial class frmEliminarMaterial : Form
    {
        public frmEliminarMaterial()
        {
            InitializeComponent();
        }

        private void icbtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            icbtnSalir.Cursor = Cursors.Hand;
        }



        private void MostrarMateriales()
        {
            dgvMaterial.DataSource = null;
            dgvMaterial.DataSource = Material.CargarMateriales();
        }

        private void frmEliminarMaterial_Load(object sender, EventArgs e)
        {
            MostrarMateriales();
            EstilizarDataGrid(dgvMaterial);
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

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            int id = int.Parse(dgvMaterial.CurrentRow.Cells[0].Value.ToString());
            Material m = new Material();
            string registroAEliminar = dgvMaterial.CurrentRow.Cells[1].Value.ToString();
            DialogResult respuesta = MessageBox.Show("¿Quieres eliminar este registro?\n" + registroAEliminar, "Advertencia eliminaras un registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                if (m.EliminarMaterial(id) == true)
                {
                    MessageBox.Show("Registro eliminado\n" + registroAEliminar, "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Registro no eliminado", "seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
