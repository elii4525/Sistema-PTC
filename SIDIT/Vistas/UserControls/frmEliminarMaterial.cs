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
    public partial class frmEliminarMaterial : UserControl
    {
        public frmEliminarMaterial()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
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
                    MostrarMateriales();
                }
            }
            else
            {
                MessageBox.Show("Registro no eliminado", "seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarMateriales()
        {
            dgvMaterial.DataSource = null;
            dgvMaterial.DataSource = Material.CargarMateriales();
        }

        private void MostrarMarcas()
        {
            dgvMarcas.DataSource = null;
            dgvMarcas.DataSource = Marca.CargarMarcas();
        }

        private void MostrarCategorias()
        {
            dgvCategorias.DataSource = null;
            dgvCategorias.DataSource = Categoria.CargarCategorias();
        }

        private void frmEliminarMaterial_Load(object sender, EventArgs e)
        {
            MostrarMateriales();
            MostrarMarcas();
            MostrarCategorias();
        }

        private void btnEliminarMarcas_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvMarcas.CurrentRow.Cells[0].Value.ToString());
            Marca mar = new Marca();
            string registroAEliminar = dgvMarcas.CurrentRow.Cells[1].Value.ToString();
            DialogResult respuesta = MessageBox.Show("¿Quieres eliminar este registro?\n" + registroAEliminar, "Advertencia eliminaras un registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                if (mar.EliminarMarca(id) == true)
                {
                    MessageBox.Show("Registro eliminado\n" + registroAEliminar, "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarMarcas();
                }
            }
            else
            {
                MessageBox.Show("Registro no eliminado", "seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MostrarMarcas();
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
            MostrarCategorias();
        }
    }
}
