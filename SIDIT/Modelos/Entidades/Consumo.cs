using System;
using System.Data;
using System.Data.SqlClient;

namespace Modelos.Entidades
{
    public class Consumo
    {
        private string connectionString = "Data Source=DESKTOP-K37VDNM\\SQLEXPRESS;Initial Catalog=BasePTC;Integrated Security=True;";

        // Obtener catálogo completo de materiales
        public DataTable ObtenerCatalogoMateriales()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT idmaterial, nombrematerial, cantidad, fechaingreso, descripcionmaterial, modelo FROM material";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dt);
                }
            }
            return dt;
        }

        // Obtener inventario filtrado por texto (nombre o modelo)
        public DataTable ObtenerDatosInventario(string textoBusqueda)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT nombrematerial, cantidad FROM material";
                if (!string.IsNullOrEmpty(textoBusqueda))
                {
                    query += " WHERE nombrematerial LIKE @textoBusqueda OR modelo LIKE @textoBusqueda";
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
            return dt;
        }

        // Obtener datos de consumo agrupados por mes desde salida_de_material
        public DataTable ObtenerDatosConsumo(DateTime fechaInicio, DateTime fechaFin)
        {
            DataTable dt = new DataTable();
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
            return dt;
        }
    }
}
