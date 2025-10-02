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
        private const string ConnectionString = "Data Source=DESKTOP-K37VDNM\\SQLEXPRESS;Initial Catalog=BasePTC;Integrated Security=True;";

        private const int IdUsuarioLogueado = 1;
        public frmRegistroConsumo()
        {
            InitializeComponent();
        }

        private void frmRegistroConsumo_Load(object sender, EventArgs e)
        {

        }

        private void InsertarSalida()
        {

            // ... (Validación y obtención de idMaterial, cantidadConsumida, fechaConsumo, motivoSalida)

            string nombreMaterial = txtNombreMaterial.Text.Trim();

            // Obtener ID del Material (esta función está bien)
            int idMaterial = ObtenerIdMaterial(nombreMaterial);

            if (idMaterial == 0)
            {
                MessageBox.Show($"El material '{nombreMaterial}' no se encontró o el nombre no es exacto.", "Error de Material", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtCantidad.Text, out int cantidadConsumida))
            { return; } // Ya validado

            DateTime fechaConsumo = dtpFechaSalida.Value.Date;
            string motivoSalida = txtMotivo.Text;

            // Usamos el Stored Procedure de INSERT/UPDATE
            string query = "sp_registrar_salida_material";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    command.CommandType = CommandType.StoredProcedure; // ¡MUY IMPORTANTE!

                    // 2. Definir Parámetros (usando los nombres de tu SP en SQL)
                    command.Parameters.AddWithValue("@id_material", idMaterial);
                    command.Parameters.AddWithValue("@cantidad_consumida", cantidadConsumida);
                    command.Parameters.AddWithValue("@fecha_consumo", fechaConsumo);
                    command.Parameters.AddWithValue("@id_usuario", IdUsuarioLogueado);
                    command.Parameters.AddWithValue("@motivo_salida", motivoSalida);

                    // 3. Ejecutar
                    connection.Open();
                    command.ExecuteNonQuery();

                    MessageBox.Show("Salida de material registrada y **inventario actualizado**.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDatosSalidas(); // Refresca el DataGridView para que se vea el nuevo registro
                    LimpiarCampos(); // Limpia los TextBoxes
                }
                catch (Exception ex)
                {
                    // Este catch atrapará errores de SQL, incluyendo si el inventario queda negativo (si el SP lo permite).
                    MessageBox.Show("Error al registrar salida o actualizar inventario: " + ex.Message, "Error de Transacción SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        // Función para validar la cantidad y el texto
        private bool ValidarCamposAgregar()
        {
            if (string.IsNullOrWhiteSpace(txtCantidad.Text) ||
                string.IsNullOrWhiteSpace(txtNombreMaterial.Text) ||
                string.IsNullOrWhiteSpace(txtMotivo.Text))
            {
                MessageBox.Show("Todos los campos (Cantidad, Material, Motivo) son obligatorios para el registro.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtCantidad.Text, out _)) // Usamos 'int' porque la columna es 'int'
            {
                MessageBox.Show("La cantidad debe ser un número entero válido.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private int ObtenerIdMaterial(string nombreMaterial)
        {
            string query = "SELECT idMaterial FROM Material WHERE nombreMaterial = @Nombre";
            int idMaterial = 0;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    command.Parameters.AddWithValue("@Nombre", nombreMaterial);
                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        idMaterial = Convert.ToInt32(result);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar material: " + ex.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return idMaterial;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarCamposAgregar())
            {
                // 1. Ejecutar INSERT en SQL
                // 2. Volver a llamar a CargarDatos() para que el DataGridView muestre el nuevo registro.
                // 3. Limpiar los TextBoxes.
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (dgvConsumo.SelectedRows.Count > 0)
            {
                // Obtener el ID de la fila seleccionada (asumiendo que tienes una columna 'ID' oculta o visible)
                int idRegistro = Convert.ToInt32(dgvConsumo.SelectedRows[0].Cells["ID"].Value);

                DialogResult result = MessageBox.Show("¿Está seguro de eliminar este registro?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // 1. Ejecutar DELETE en SQL usando el 'idRegistro'
                    //    DELETE FROM Consumos WHERE ID = @ID
                    // 2. Volver a llamar a CargarDatos() para que el DataGridView se refresque.
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila del registro para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (ValidarCamposAgregar()) // Puedes reusar la misma validación
            {
                // 1. Obtener el ID del registro que se está editando (debe estar guardado en alguna variable o control oculto).
                // 2. Ejecutar UPDATE en SQL usando el ID y los nuevos valores de los TextBoxes.
                // 3. Volver a llamar a CargarDatos() para refrescar.
            }
        }
        private void CargarDatosSalidas()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();

                    // Usamos el Stored Procedure de SQL
                    SqlCommand command = new SqlCommand("sp_obtener_historial_salidas", connection);
                    command.CommandType = CommandType.StoredProcedure; // ¡MUY IMPORTANTE! Indica que es un SP

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();

                    adapter.Fill(dt);

                    //  ESTO HACE QUE LOS DATOS APAREZCAN EN LA PANTALLA
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
        private void EliminarSalidaSeleccionada()
        {
            if (dgvConsumo.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una fila completa del registro para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Usamos la columna OCULTA 'idSalidamaterial' para identificar la fila
            int idSalida = Convert.ToInt32(dgvConsumo.SelectedRows[0].Cells["idSalidamaterial"].Value);

            DialogResult result = MessageBox.Show("¿Está seguro de eliminar esta salida de material? Esta acción es irreversible.", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
            dtpFechaSalida.Value = DateTime.Now; // Pone la fecha actual
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            if (ValidarCamposAgregar())
            {
                InsertarSalida(); //  Esta línea resuelve la inserción y el refresco.
            }
        }
    }
}
