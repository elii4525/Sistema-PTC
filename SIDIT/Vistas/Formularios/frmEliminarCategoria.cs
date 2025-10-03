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
    public partial class frmEliminarCategoria : Form
    {
        public frmEliminarCategoria()
        {
            InitializeComponent();
            label5.Font = Helper.FuenteHelper.ObtenerFuente(15);
        }

        private void btnEliminarCategorias_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvCategorias.CurrentRow.Cells[0].Value.ToString());
            Categoria cat = new Categoria();
            string registroAEliminar = dgvCategorias.CurrentRow.Cells[1].Value.ToString();
            DialogResult respuesta = MessageBox.Show("¿Quieres eliminar este registro?\n" + registroAEliminar, "Advertencia eliminaras un registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                if (cat.EliminarCategorias(id) == true)
                {
                    MessageBox.Show("Registro eliminado\n" + registroAEliminar, "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarCategorias();
                }
            }
            else
            {
                MessageBox.Show("Registro no eliminado", "seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void icbtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            icbtnSalir.Cursor = Cursors.Hand;
        }

        private void MostrarCategorias()
        {
            dgvCategorias.DataSource = null;
            dgvCategorias.DataSource = Categoria.CargarCategorias();
        }

        private void frmEliminarCategoria_Load(object sender, EventArgs e)
        {
            MostrarCategorias();
            EstilizarDataGrid(dgvCategorias);
        }

        private void EstilizarDataGrid(DataGridView dgv)
        {
            dgv.BorderStyle = BorderStyle.None;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(198, 216, 112);
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
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
    }
}
