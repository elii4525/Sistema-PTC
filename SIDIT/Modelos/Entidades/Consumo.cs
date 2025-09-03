using System;
using System.Data;
using System.Data.SqlClient;

namespace Modelos.Entidades
{
    // Esta clase maneja toda la lógica de la base de datos para el consumo de materiales.
    public class Consumo
    {
        // La cadena de conexión a tu base de datos.
        // **IMPORTANTE**: Reemplaza "NombreDeTuServidor" con el nombre de tu servidor SQL.
        private string connectionString = "Data Source=DESKTOP-H7V4BEU\\SQLEXPRESS01;Initial Catalog=BasePTC;Integrated Security=True;";

        // Método para obtener todos los materiales para el DataGridView del Catálogo.
        public DataTable ObtenerCatalogoMateriales()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT idMaterial, nombreMaterial, cantidad, fechaIngreso, descripcionMaterial, modelo FROM Material";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                // En caso de error, se devuelve un DataTable vacío para evitar errores en la interfaz.
                Console.WriteLine("Error en ObtenerCatalogoMateriales: " + ex.Message);
            }
            return dt;
        }

        // Método para buscar materiales por nombre, fecha de ingreso, o modelo.
        public DataTable BuscarMateriales(string textoBusqueda, DateTime fechaInicio, DateTime fechaFin)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    // Se usa un comodín (%) para buscar coincidencias parciales.
                    string query = "SELECT idMaterial, nombreMaterial, cantidad, fechaIngreso, descripcionMaterial, modelo FROM Material WHERE nombreMaterial LIKE @textoBusqueda OR modelo LIKE @textoBusqueda OR fechaIngreso BETWEEN @fechaInicio AND @fechaFin";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@textoBusqueda", "%" + textoBusqueda + "%");
                        command.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                        command.Parameters.AddWithValue("@fechaFin", fechaFin);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en BuscarMateriales: " + ex.Message);
            }
            return dt;
        }

        // Método para obtener datos de inventario para el gráfico.
        public DataTable ObtenerDatosInventario(string textoBusqueda)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT nombreMaterial, cantidad FROM Material";
                    if (!string.IsNullOrEmpty(textoBusqueda))
                    {
                        query += " WHERE nombreMaterial LIKE @textoBusqueda OR modelo LIKE @textoBusqueda";
                    }

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        if (!string.IsNullOrEmpty(textoBusqueda))
                        {
                            command.Parameters.AddWithValue("@textoBusqueda", "%" + textoBusqueda + "%");
                        }
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en ObtenerDatosInventario: " + ex.Message);
            }
            return dt;
        }

        // Método para obtener datos de consumo por mes de la tabla Salida_de_Material.
        public DataTable ObtenerDatosConsumo(DateTime fechaInicio, DateTime fechaFin)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        SELECT  
                            DATENAME(MONTH, fechaconsumo) + '-' + CAST(YEAR(fechaconsumo) AS VARCHAR) AS mes,
                            SUM(cantidadconsumida) AS totalconsumido
                        FROM salida_de_material
                        WHERE fechaconsumo BETWEEN @fechaInicio AND @fechaFin
                        GROUP BY YEAR(fechaconsumo), MONTH(fechaconsumo), DATENAME(MONTH, fechaconsumo)
                        ORDER BY YEAR(fechaconsumo), MONTH(fechaconsumo);";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                        command.Parameters.AddWithValue("@fechaFin", fechaFin);
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en ObtenerDatosConsumo: " + ex.Message);
            }
            return dt;
        }
    }
}
