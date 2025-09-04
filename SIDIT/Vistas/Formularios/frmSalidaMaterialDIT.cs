using Modelos.Entidades;
using System;
using System.Data;
using System.Windows.Forms;

namespace Vistas.Formularios
{
    public partial class frmSalidaMaterialDIT : Form
    {
        // CORREGIDO: Usar la clase correcta
        private SalidaMaterial gestionSalida = new SalidaMaterial();
        private int usuarioId = 2; // ID del usuario que registra

        public frmSalidaMaterialDIT()
        {
            InitializeComponent();
        }

        private void frmSalidaMaterialDIT_Load(object sender, EventArgs e)
        {
            CargarMateriales();
            CargarHistorial();
            dtpFechaConsumo.Value = DateTime.Now;
        }

        private void CargarMateriales()
        {
            try
            {
                DataTable dt = gestionSalida.ObtenerMaterialesCombo();
                cmbMaterial.DataSource = dt;
                cmbMaterial.DisplayMember = "nombrematerial";
                cmbMaterial.ValueMember = "idmaterial";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar materiales: " + ex.Message);
            }
        }

        private void CargarHistorial()
        {
            try
            {
                DataTable dt = gestionSalida.ObtenerHistorialSalidas();
                dgvHistorial.DataSource = dt;
                dgvHistorial.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar historial: " + ex.Message);
            }
        }

        private void btnRegistrarSalida_Click(object sender, EventArgs e)
        {
            try
            {
                // Validaciones
                if (cmbMaterial.SelectedValue == null)
                {
                    MessageBox.Show("Seleccione un material");
                    return;
                }

                if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad <= 0)
                {
                    MessageBox.Show("Ingrese una cantidad válida");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtMotivo.Text))
                {
                    MessageBox.Show("Ingrese el motivo de la salida");
                    return;
                }

                // Obtener valores
                int idMaterial = (int)cmbMaterial.SelectedValue;
                DateTime fechaConsumo = dtpFechaConsumo.Value;
                string motivo = txtMotivo.Text;

                // Registrar salida
                bool resultado = gestionSalida.RegistrarSalidaMaterial(idMaterial, cantidad, fechaConsumo, usuarioId, motivo);

                if (resultado)
                {
                    MessageBox.Show("Salida registrada exitosamente");

                    // Limpiar y recargar
                    txtCantidad.Clear();
                    txtMotivo.Clear();
                    CargarHistorial();
                    CargarMateriales();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void cmbMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMaterial.SelectedValue != null && cmbMaterial.SelectedItem is DataRowView row)
            {
                lblInfoMaterial.Text = $"Marca: {row["nombremarca"]} | Stock: {row["cantidad"]}";
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCantidad.Clear();
            txtMotivo.Clear();
            dtpFechaConsumo.Value = DateTime.Now;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}