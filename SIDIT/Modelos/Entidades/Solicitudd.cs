using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Modelos.Conexion;

namespace Modelos.Entidades
{
    public class Solicitudd
    {
        public int IdSolicitud { get; set; }
        public string Motivo { get; set; }
        public int Cantidad { get; set; }
        public DateTime Fecha { get; set; }
        public string Estado { get; set; }
        public int IdUsuario { get; set; }
        public int IdMaterial { get; set; }

        private int idUsuarioActual;

        public Solicitudd() { }

        public Solicitudd(int idUsuario)
        {
            idUsuarioActual = idUsuario;
        }

        public int CrearSolicitud(string motivo, List<Solicitudd> materiales)
        {
            int idSolicitud = 0;

            using (SqlConnection con = ConexionDB.Conectar())
            {
                if (con == null) throw new Exception("No se pudo conectar a la base de datos.");

                string sql = @"INSERT INTO Solicitud (motivo, fecha, estado, id_Usuario) 
                               OUTPUT INSERTED.idSolicitud 
                               VALUES (@motivo, @fecha, @estado, @idUsuario)";

                     SqlCommand cmd = new SqlCommand(sql, con);
                     cmd.Parameters.AddWithValue("@motivo", motivo);
                     cmd.Parameters.AddWithValue("@fecha", DateTime.Now.Date);
                     cmd.Parameters.AddWithValue("@estado", "Pendiente");
                     cmd.Parameters.AddWithValue("@idUsuario", idUsuarioActual);

                     idSolicitud = (int)cmd.ExecuteScalar();

                foreach (var mat in materiales)
                {
                    if (mat.Cantidad < 1 || mat.Cantidad > 10) continue;

                    string sqlMat = @"INSERT INTO SolicitudMaterial (idSolicitud, idMaterial, cantidad) 
                                      VALUES (@idSolicitud, @idMaterial, @cantidad)";

                    SqlCommand cmdMat = new SqlCommand(sqlMat, con);
                    cmdMat.Parameters.AddWithValue("@idSolicitud", idSolicitud);
                    cmdMat.Parameters.AddWithValue("@idMaterial", mat.IdMaterial);
                    cmdMat.Parameters.AddWithValue("@cantidad", mat.Cantidad);
                    cmdMat.ExecuteNonQuery();
                }
            }

            return idSolicitud;
        }

        public SolicitudInfo ObtenerSolicitudCompleta(int idSolicitud)
        {
            SolicitudInfo info = null;

            using (SqlConnection con = ConexionDB.Conectar())
            {
                string query = @"
            SELECT 
                s.idSolicitud,
                u.nombre AS NombreUsuario,
                r.tipoRol AS Rol,
                s.fecha,
                s.motivo,
                m.nombreMaterial,
                sm.cantidad,
                ma.nombreMarca
            FROM Solicitud s
            INNER JOIN Usuario u ON u.idUsuario = s.id_Usuario
            INNER JOIN Rol r ON u.id_Rol = r.idRol
            INNER JOIN SolicitudMaterial sm ON sm.idSolicitud = s.idSolicitud
            INNER JOIN Material m ON m.idMaterial = sm.idMaterial
            INNER JOIN Marca ma ON ma.idMarca = m.id_Marca
            WHERE s.idSolicitud = @idSolicitud";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@idSolicitud", idSolicitud);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    if (info == null)
                    {
                        info = new SolicitudInfo
                        {
                            IdSolicitud = Convert.ToInt32(dr["idSolicitud"]),
                            NombreUsuario = dr["NombreUsuario"].ToString(),
                            Rol = dr["Rol"].ToString(),
                            Fecha = Convert.ToDateTime(dr["fecha"]),
                            Motivo = dr["motivo"].ToString(),
                            Materiales = new List<MaterialSolicitud>()
                        };
                    }

                    info.Materiales.Add(new MaterialSolicitud
                    {
                        NombreMaterial = dr["nombreMaterial"].ToString(),
                        Marca = dr["nombreMarca"].ToString(),
                        Cantidad = Convert.ToInt32(dr["cantidad"])
                    });
                }
            }

            return info;
        }


        public DataTable ObtenerMateriales()
        {
            using (SqlConnection con = ConexionDB.Conectar())
            {
                if (con == null) return null;

                SqlDataAdapter da = new SqlDataAdapter("SELECT idMaterial, nombreMaterial FROM Material", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable ObtenerSolicitudesPorUsuario(int idUsuario)
        {
            string query = @"SELECT 
                s.idSolicitud,
                u.nombre AS nombreUsuario,
                s.fecha,
                s.motivo,
                m.nombreMaterial,
                sm.cantidad,
                ma.nombreMarca,
                s.estado
            FROM Solicitud s
            INNER JOIN Usuario u ON u.idUsuario = s.id_Usuario
            INNER JOIN SolicitudMaterial sm ON sm.idSolicitud = s.idSolicitud
            INNER JOIN Material m ON m.idMaterial = sm.idMaterial
            INNER JOIN Marca ma ON ma.idMarca = m.id_Marca
            WHERE s.id_Usuario = @idUsuario
            ORDER BY s.fecha DESC, s.idSolicitud DESC;";

            using (SqlConnection con = ConexionDB.Conectar())
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@idUsuario", idUsuario);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable ObtenerSolicitudesJefatura()
        {
            string query = @"SELECT 
            s.idSolicitud,
            u.nombre AS nombreUsuario,
            s.fecha,
            s.motivo,
            m.nombreMaterial,
            sm.cantidad,
            ma.nombreMarca,
            s.estado
        FROM Solicitud s
        INNER JOIN Usuario u ON u.idUsuario = s.id_Usuario
        INNER JOIN SolicitudMaterial sm ON sm.idSolicitud = s.idSolicitud
        INNER JOIN Material m ON m.idMaterial = sm.idMaterial
        INNER JOIN Marca ma ON ma.idMarca = m.id_Marca
        ORDER BY s.fecha DESC, s.idSolicitud DESC;";

            using (SqlConnection con = ConexionDB.Conectar())
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }



        public DataTable ObtenerMarcasPorMaterial(int idMaterial)
        {
            using (SqlConnection con = ConexionDB.Conectar())
            {
                if (con == null) return null;

                string sql = @"SELECT m.idMarca, m.nombreMarca
                               FROM Material mat
                               INNER JOIN Marca m ON mat.id_Marca = m.idMarca
                               WHERE mat.idMaterial = @idMaterial";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@idMaterial", idMaterial);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static void CambiarEstadoSolicitud(int idSolicitud, string nuevoEstado)
        {
            using (SqlConnection con = ConexionDB.Conectar())
            {
                string query = "UPDATE Solicitud SET estado = @estado WHERE idSolicitud = @idSolicitud";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@estado", nuevoEstado);
                cmd.Parameters.AddWithValue("@idSolicitud", idSolicitud);

                cmd.ExecuteNonQuery();
            }
        }

        public DataTable ObtenerTodasLasSolicitudes()
        {
            string query = @"SELECT 
                s.idSolicitud,
                u.nombre AS nombreUsuario,
                r.tipoRol AS rol,
                s.fecha,
                s.motivo,
                m.nombreMaterial,
                sm.cantidad,
                ma.nombreMarca,
                s.estado
            FROM Solicitud s
            INNER JOIN Usuario u ON u.idUsuario = s.id_Usuario
            INNER JOIN Rol r ON r.idRol = u.id_Rol
            INNER JOIN SolicitudMaterial sm ON sm.idSolicitud = s.idSolicitud
            INNER JOIN Material m ON m.idMaterial = sm.idMaterial
            INNER JOIN Marca ma ON ma.idMarca = m.id_Marca
            ORDER BY s.fecha DESC;";

            using (SqlConnection con = ConexionDB.Conectar())
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }


    }
}

