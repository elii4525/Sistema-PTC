using System;
using System.Data;
using System.Data.SqlClient;

namespace Modelos.Entidades
{
    public class SalidaMaterial
    {
        private string connectionString = "Data Source=DESKTOP-K37VDNM\\SQLEXPRESS;Initial Catalog=BasePTC;Integrated Security=True;";

        // Obtener materiales para ComboBox
        public DataTable ObtenerMaterialesCombo()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"
                        SELECT 
                            m.idmaterial,
                            m.nombrematerial,
                            ma.nombremarca,
                            m.cantidad
                        FROM material m
                        INNER JOIN marca ma ON m.id_marca = ma.idmarca
                        ORDER BY m.nombrematerial";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener materiales: " + ex.Message);
                }
            }
            return dt;
        }

        // Registrar salida de material
        public bool RegistrarSalidaMaterial(int idMaterial, int cantidadConsumida, DateTime fechaConsumo, int idUsuario, string motivoSalida)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"
                        BEGIN TRY
                            BEGIN TRANSACTION;
                            
                            -- Insertar en salida_de_material
                            INSERT INTO salida_de_material (id_material, cantidadconsumida, fechaconsumo, id_usuario, motivosalida)
                            VALUES (@id_material, @cantidad_consumida, @fecha_consumo, @id_usuario, @motivo_salida);
                            
                            -- Actualizar el inventario (restar cantidad)
                            UPDATE material 
                            SET cantidad = cantidad - @cantidad_consumida
                            WHERE idmaterial = @id_material;
                            
                            COMMIT TRANSACTION;
                        END TRY
                        BEGIN CATCH
                            ROLLBACK TRANSACTION;
                            THROW;
                        END CATCH";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id_material", idMaterial);
                        command.Parameters.AddWithValue("@cantidad_consumida", cantidadConsumida);
                        command.Parameters.AddWithValue("@fecha_consumo", fechaConsumo);
                        command.Parameters.AddWithValue("@id_usuario", idUsuario);
                        command.Parameters.AddWithValue("@motivo_salida", motivoSalida);

                        command.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al registrar salida: " + ex.Message);
                }
            }
        }

        // Obtener historial de salidas
        public DataTable ObtenerHistorialSalidas()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"
                        SELECT 
                            s.idsalidamaterial,
                            m.nombrematerial,
                            ma.nombremarca,
                            s.cantidadconsumida,
                            s.fechaconsumo,
                            s.motivosalida,
                            u.nombre as usuario_registra
                        FROM salida_de_material s
                        INNER JOIN material m ON s.id_material = m.idmaterial
                        INNER JOIN marca ma ON m.id_marca = ma.idmarca
                        INNER JOIN usuario u ON s.id_usuario = u.idusuario
                        ORDER BY s.fechaconsumo DESC";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener historial: " + ex.Message);
                }
            }
            return dt;
        }
    }
}