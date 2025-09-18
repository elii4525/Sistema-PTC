using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelos.Entidades;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Vistas.Controles
{
    public partial class frmEliminarUsuario : UserControl
    {
        public frmEliminarUsuario()
        {
            InitializeComponent(); 
        }

        private void frmEliminarUsuario_Load(object sender, EventArgs e)
        {
            dgvUsuarios.DataSource = Usuario.cargarUsuariosEliminar();
            txtCodigoUsuario.ReadOnly = true;
            txtCodigoUsuario.Clear();
            EstilizarDataGrid(dgvUsuarios);
            label1.Font = Helper.FuenteHelper.ObtenerFuente(19);
            label2.Font = Helper.FuenteHelper.ObtenerFuente(12);
            btnEliminarUsuario.Font = Helper.FuenteHelper.ObtenerFuente(8);
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow fila = dgvUsuarios.Rows[e.RowIndex];
                txtCodigoUsuario.Texts = fila.Cells["Nombre"].Value.ToString();
            }
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvUsuarios.CurrentRow.Cells[0].Value.ToString());
            string registroAEliminar = dgvUsuarios.CurrentRow.Cells[1].Value.ToString();
            DialogResult respuesta = MessageBox.Show("¿Quieres eliminar este registro?\n" + registroAEliminar, "Advertencia eliminaras un registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                Usuario.EliminarUsuario(id);
                MessageBox.Show("Registro eliminado\n" + registroAEliminar, "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarUsuarios();
            }
            else
            {
                MessageBox.Show("Registro no eliminado", "seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            dgvUsuarios.DataSource = Usuario.cargarUsuariosEliminar();
        }

        private void EstilizarDataGrid(DataGridView dgv)
        {
            dgv.BorderStyle = BorderStyle.None;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
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

    }
}
