using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Modelos.Conexion;
using Modelos.Entidades;
using System.Drawing;

namespace Vistas
{
    public partial class frmRegistroConsumo : Form
    {
        public frmRegistroConsumo()
        {
            InitializeComponent();
        }

        private void frmRegistroConsumo_Load(object sender, EventArgs e)
        {
            cmbMaterial.DropDownStyle = ComboBoxStyle.DropDownList;
            CargarMateriales();
            cmbMaterial.SelectedIndex = -1;
            CargarHistorialConsumo();
            EstilizarDataGrid(dgvHistorial);
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cmbMaterial.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un material.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCantidad.Text))
            {
                MessageBox.Show("Debe ingresar una cantidad.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int idUsuario = Usuario.SesionActual.IdUsuario;
                int idMaterial = Convert.ToInt32(cmbMaterial.SelectedValue);
                int cantidad = Convert.ToInt32(txtCantidad.Text);
                DateTime fecha = dtpFechaSalida.Value;
                string motivo = txtMotivo.Text;

                if (cantidad <= 0)
                {
                    MessageBox.Show("La cantidad debe ser mayor que cero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int stockDisponible = ObtenerStockDisponible(idMaterial);
                if (cantidad > stockDisponible)
                {
                    MessageBox.Show($"No puede consumir más de lo disponible.\nStock actual: {stockDisponible}",
                        "Cantidad inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SqlConnection cn = ConexionDB.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand("sp_registrar_salida_materialll", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_usuario", idUsuario);
                        cmd.Parameters.AddWithValue("@id_material", idMaterial);
                        cmd.Parameters.AddWithValue("@cantidad_consumida", cantidad);
                        cmd.Parameters.AddWithValue("@fecha_consumo", fecha);
                        cmd.Parameters.AddWithValue("@motivo_salida", motivo);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Consumo registrado correctamente.");
                CargarHistorialConsumo();

                cmbMaterial.SelectedIndex = -1;
                txtCantidad.Clear();
                txtMotivo.Clear();
                dtpFechaSalida.Value = DateTime.Today;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar consumo: " + ex.Message);
            }
        }

        private int ObtenerStockDisponible(int idMaterial)
        {
            try
            {
                using (SqlConnection cn = ConexionDB.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand("sp_obtener_stock_material", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id_material", idMaterial);

                        object result = cmd.ExecuteScalar();
                        return result != null ? Convert.ToInt32(result) : 0;
                    }
                }
            }
            catch
            {
                return 0; 
            }
        }



        private void CargarMateriales()
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection connection = ConexionDB.Conectar())
                {
                    if (connection == null) return;

                    using (SqlCommand command = new SqlCommand("sp_obtener_materiales_combo", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dt);
                    }
                }

                cmbMaterial.DataSource = dt;
                cmbMaterial.DisplayMember = "nombreMaterial";
                cmbMaterial.ValueMember = "idMaterial";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar materiales: " + ex.Message,
                    "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarHistorialConsumo()
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection connection = ConexionDB.Conectar())
                {
                    if (connection == null) return;

                    using (SqlCommand command = new SqlCommand("sp_obtener_historial_salidas", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dt);
                    }
                }

                dgvHistorial.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar historial: " + ex.Message,
                    "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
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
