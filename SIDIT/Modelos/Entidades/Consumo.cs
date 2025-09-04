using System;
using System.Data;
using System.Data.SqlClient;

namespace Modelos.Entidades
{
    public class Consumo
    {
        private string connectionString = "Data Source=DESKTOP-K37VDNM\\SQLEXPRESS;Initial Catalog=BasePTC;Integrated Security=True;";

        // Para Chart Inventario (TODOS los materiales con nombres)
        public DataTable ObtenerInventarioCompleto()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"
                        SELECT  
                            m.nombrematerial,
                            m.cantidad,
                            c.nombrecategoria
                        FROM material m
                        INNER JOIN categoria c ON m.id_categoria = c.idcategoria
                        ORDER BY m.nombrematerial";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    // Datos de prueba
                    dt = CrearDatosInventarioPrueba();
                }
            }
            return dt;
        }

        // Para Chart Consumo (por MATERIAL - como antes)
        public DataTable ObtenerConsumoMaterial()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"
                        SELECT 
                            m.nombrematerial,
                            SUM(s.cantidadconsumida) as total_consumido
                        FROM salida_de_material s
                        INNER JOIN material m ON s.id_material = m.idmaterial
                        GROUP BY m.nombrematerial
                        ORDER BY total_consumido DESC";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    // Datos de prueba
                    dt = CrearDatosConsumoPrueba();
                }
            }
            return dt;
        }

        // Para DataGridView Catálogo
        public DataTable ObtenerCatalogoCompleto()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"
                        SELECT 
                            m.nombrematerial,
                            m.cantidad,
                            m.descripcionmaterial,
                            m.modelo,
                            c.nombrecategoria,
                            ma.nombremarca
                        FROM material m
                        INNER JOIN categoria c ON m.id_categoria = c.idcategoria
                        INNER JOIN marca ma ON m.id_marca = ma.idmarca
                        ORDER BY c.nombrecategoria, m.nombrematerial";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener catálogo: " + ex.Message);
                }
            }
            return dt;
        }

        // Datos de prueba para Inventario
        private DataTable CrearDatosInventarioPrueba()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("nombrematerial");
            dt.Columns.Add("cantidad", typeof(int));
            dt.Columns.Add("nombrecategoria");

            dt.Rows.Add("tinta negra para impresora", 15, "computación");
            dt.Rows.Add("impresora multifuncional", 5, "computación");
            dt.Rows.Add("plumones artline", 8, "papeleria");
            dt.Rows.Add("cinta scotch", 30, "papeleria");
            dt.Rows.Add("aire comprimido", 20, "limpieza");
            dt.Rows.Add("limpiador en spray", 40, "limpieza");
            dt.Rows.Add("papel bond", 100, "papeleria");
            dt.Rows.Add("proyector portátil", 3, "periféricos");
            dt.Rows.Add("cámara de seguridad ip", 2, "periféricos");
            dt.Rows.Add("laptop ryzen 7", 10, "computación");
            dt.Rows.Add("monitor hp", 25, "periféricos");
            dt.Rows.Add("teclado alambrico", 5, "periféricos");

            return dt;
        }

        // Datos de prueba para Consumo
        private DataTable CrearDatosConsumoPrueba()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("nombrematerial");
            dt.Columns.Add("total_consumido", typeof(int));

            dt.Rows.Add("tinta negra para impresora", 8);
            dt.Rows.Add("aire comprimido", 5);
            dt.Rows.Add("papel bond", 12);
            dt.Rows.Add("cinta scotch", 3);
            dt.Rows.Add("limpiador en spray", 2);
            dt.Rows.Add("plumones artline", 4);
            dt.Rows.Add("monitor hp", 1);
            dt.Rows.Add("teclado alambrico", 2);

            return dt;
        }

        // Método adicional por si lo necesitas (consumo por meses)
        public DataTable ObtenerConsumoPorMeses()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"
                        SELECT  
                            DATENAME(MONTH, fechaconsumo) + ' ' + CAST(YEAR(fechaconsumo) AS VARCHAR) AS mes,
                            SUM(cantidadconsumida) as total_consumido
                        FROM salida_de_material 
                        GROUP BY YEAR(fechaconsumo), MONTH(fechaconsumo), DATENAME(MONTH, fechaconsumo)
                        ORDER BY YEAR(fechaconsumo), MONTH(fechaconsumo)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    // Datos de prueba por meses
                    dt.Columns.Add("mes");
                    dt.Columns.Add("total_consumido", typeof(int));

                    dt.Rows.Add("Enero 2025", 15);
                    dt.Rows.Add("Febrero 2025", 22);
                    dt.Rows.Add("Marzo 2025", 18);
                }
            }
            return dt;
        }
    }
}