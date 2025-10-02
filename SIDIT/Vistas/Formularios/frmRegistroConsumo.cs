using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Vistas.Formularios
{
    public partial class frmRegistroConsumo : Form
    {
        // Asegúrate de que esta cadena de conexión sea la correcta.
        private const string ConnectionString = "Data Source=DESKTOP-K37VDNM\\SQLEXPRESS;Initial Catalog=BasePTC;Integrated Security=True;";

        // ID del usuario que registra la salida (debería ser dinámico en una aplicación real)
        private const int IdUsuarioLogueado = 1;

        public frmRegistroConsumo()
        {
            InitializeComponent();
        }

        private void frmRegistroConsumo_Load(object sender, EventArgs e)
        {
            // Cargar el historial de salidas al iniciar el formulario
            CargarDatosSalidas();
            EstilizarDataGrid(dgvConsumo);
        }

        /// <summary>
        /// Inserta la salida del material. Delega las validaciones de existencia y stock al Stored Procedure de SQL.
        /// </summary>
        private void InsertarSalida()
        {
            string nombreMaterial = txtNombreMaterial.Text.Trim();

            if (!int.TryParse(txtCantidad.Text, out int cantidadConsumida))
            {
                return;
            }

            DateTime fechaConsumo = dtpFechaSalida.Value.Date;
            string motivoSalida = txtMotivo.Text;

            // Usamos el Stored Procedure de SQL que valida el nombre y el stock
            string query = "sp_registrar_salida_material";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // IMPORTANTE: El SP ahora espera el nombre, no el ID.
                    command.Parameters.AddWithValue("@nombre_material", nombreMaterial);
                    command.Parameters.AddWithValue("@cantidad_consumida", cantidadConsumida);
                    command.Parameters.AddWithValue("@fecha_consumo", fechaConsumo);
                    command.Parameters.AddWithValue("@id_usuario", IdUsuarioLogueado);
                    command.Parameters.AddWithValue("@motivo_salida", motivoSalida);

                    connection.Open();
                    command.ExecuteNonQuery();

                    MessageBox.Show("Salida de material registrada y **inventario actualizado**.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDatosSalidas(); // Refresca el DataGridView 
                    LimpiarCampos(); // Limpia los TextBoxes
                }
                catch (SqlException sqlEx)
                {
                    // Captura errores específicos de SQL (RAISERROR del SP para stock o existencia)
                    if (sqlEx.Number >= 50000 || sqlEx.Class == 16)
                    {
                        // Muestra el mensaje de error que viene directamente desde el SP (ej: "Stock insuficiente...")
                        MessageBox.Show(sqlEx.Message, "Error de Validación de Inventario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        // Otros errores de SQL (ej: conexión, permisos, etc.)
                        MessageBox.Show("Error al registrar salida: " + sqlEx.Message, "Error de Transacción SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    // Errores de C# inesperados
                    MessageBox.Show("Error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Valida que los campos no estén vacíos y que la cantidad sea numérica.
        /// </summary>
        private bool ValidarCamposAgregar()
        {
            if (string.IsNullOrWhiteSpace(txtCantidad.Text) ||
                string.IsNullOrWhiteSpace(txtNombreMaterial.Text) ||
                string.IsNullOrWhiteSpace(txtMotivo.Text))
            {
                MessageBox.Show("Todos los campos (Cantidad, Material, Motivo) son obligatorios para el registro.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("La cantidad debe ser un número entero válido mayor a cero.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Carga los datos del historial de salidas en el DataGridView.
        /// </summary>
        private void CargarDatosSalidas()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();

                    // Usamos el Stored Procedure de SQL para obtener el historial
                    SqlCommand command = new SqlCommand("sp_obtener_historial_salidas", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();

                    adapter.Fill(dt);

                    dgvConsumo.DataSource = dt;

                    // Ocultar la columna de ID que necesitamos para eliminar/actualizar
                    if (dgvConsumo.Columns.Contains("idSalidamaterial"))
                    {
                        dgvConsumo.Columns["idSalidamaterial"].Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos: " + ex.Message, "Error de SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Ejecuta la eliminación del registro de salida seleccionado.
        /// </summary>
        private void EliminarSalidaSeleccionada()
        {
            if (dgvConsumo.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una fila completa del registro para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // CORRECCIÓN: Verifica si la columna existe en las columnas del DataGridView, no en las celdas de la fila.
            if (!dgvConsumo.Columns.Contains("idSalidamaterial"))
            {
                MessageBox.Show("Error de configuración: La columna 'idSalidamaterial' no está presente en la tabla. Asegúrate de que el procedimiento almacenado la devuelva.", "Error de Columna", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Usamos la columna OCULTA 'idSalidamaterial' para identificar la fila
            int idSalida = Convert.ToInt32(dgvConsumo.SelectedRows[0].Cells["idSalidamaterial"].Value);

            DialogResult result = MessageBox.Show("¿Está seguro de eliminar esta salida de material? Esta acción es irreversible y NO restaurará el inventario.", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string query = "DELETE FROM salidaDeMaterial WHERE idSalidamaterial = @ID";

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@ID", idSalida);
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Registro eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarDatosSalidas(); // Refrescar DataGridView
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error de SQL al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void LimpiarCampos()
        {
            txtCantidad.Clear();
            txtNombreMaterial.Clear();
            txtMotivo.Clear();
            dtpFechaSalida.Value = DateTime.Now;
        }

        // --- Manejadores de Eventos (Event Handlers) ---

        // Manejador del botón de AGREGAR/REGISTRAR (Asegúrate que este sea el que usa tu botón en el diseñador)
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            if (ValidarCamposAgregar())
            {
                InsertarSalida();
            }
        }

        // Manejador del botón de AGREGAR/REGISTRAR (Manejador original si el diseñador lo usa)
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarCamposAgregar())
            {
                InsertarSalida();
            }
        }

        // Manejador del botón de ELIMINAR
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarSalidaSeleccionada();
        }

        // Manejador del botón de ACTUALIZAR (solo placeholder)
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La funcionalidad de Actualizar requiere un procedimiento UPDATE en SQL.", "Pendiente", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}