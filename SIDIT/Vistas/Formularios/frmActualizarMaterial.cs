using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Modelos.Entidades;

namespace Vistas.Formularios
{
    public partial class frmActualizarMaterial : Form
    {
        public frmActualizarMaterial()
        {
            InitializeComponent();
        }

        private void icbtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            icbtnSalir.Cursor = Cursors.Hand;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvMaterial.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un material de la lista.", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtCantidad.Text))
            {
                MessageBox.Show("Debe ingresar nombre y cantidad.", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idMaterial = int.Parse(dgvMaterial.CurrentRow.Cells[0].Value.ToString());
            int cantidadNueva = int.Parse(txtCantidad.Text);

            // 🔹 Obtener la cantidad actual desde la BD
            int cantidadActual = Material.ObtenerCantidad(idMaterial);

            // 🔹 Validar que la nueva cantidad no sea menor
            if (cantidadNueva < cantidadActual)
            {
                MessageBox.Show($"No puedes asignar una cantidad menor a la actual ({cantidadActual}).",
                                "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCantidad.Text = cantidadActual.ToString(); // Restaurar valor
                return;
            }

            Material m = new Material
            {
                NombreMaterial = txtNombre.Text.Trim(),
                Cantidad = cantidadNueva,
                IdMaterial = idMaterial
            };

            if (m.ActualizarMaterial())
            {
                MostrarMateriales();
                txtCantidad.Clear();
                txtNombre.Clear();
                MessageBox.Show("Material actualizado correctamente.", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Hubo un error al actualizar.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarMateriales()
        {
            dgvMaterial.DataSource = null;
            dgvMaterial.DataSource = Material.CargarMateriales();
        }

        private void dgvMaterial_DoubleClick(object sender, EventArgs e)
        {
            txtNombre.Text = dgvMaterial.CurrentRow.Cells[1].Value.ToString();
            txtCantidad.Text = dgvMaterial.CurrentRow.Cells[2].Value.ToString();
        }

        private void frmActualizarMaterial_Load(object sender, EventArgs e)
        {
            MostrarMateriales();
            label7.Font = Helper.FuenteHelper.ObtenerFuente(15);
            label6.Font = Helper.FuenteHelper.ObtenerFuente(10);
            label1.Font = Helper.FuenteHelper.ObtenerFuente(10);
            label8.Font = Helper.FuenteHelper.ObtenerFuente(10);
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permitir dígitos y control (backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
