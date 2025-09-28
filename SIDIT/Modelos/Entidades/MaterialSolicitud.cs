using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Modelos.Conexion;
using System.Windows.Forms;

namespace Modelos.Entidades
{
    public class MaterialSolicitud
    {
        public string NombreMaterial { get; set; }
        public int Cantidad { get; set; }
        public string Marca { get; set; }
    }

    public class SolicitudInfo
    {
        public int IdSolicitud { get; set; }
        public string NombreUsuario { get; set; }
        public string Rol { get; set; }
        public DateTime Fecha { get; set; }
        public string Motivo { get; set; }
        public List<MaterialSolicitud> Materiales { get; set; } = new List<MaterialSolicitud>();
    }

    public class Solicitud
    {

        private Label[][] nombreUsuarios;
        private Label[][] roles;
        private Label[][] fechas;
        private Label[][] motivos;
        private Label[][] materiales;
        private Label[][] cantidades;
        private Label[][] marcas;

        public Solicitud(
            Label[][] nombreUsuarios,
            Label[][] roles,
            Label[][] fechas,
            Label[][] motivos,
            Label[][] materiales,
            Label[][] cantidades,
            Label[][] marcas)
        {
            this.nombreUsuarios = nombreUsuarios;
            this.roles = roles;
            this.fechas = fechas;
            this.motivos = motivos;
            this.materiales = materiales;
            this.cantidades = cantidades;
            this.marcas = marcas;
        }

        // Método para llenar los labels con las últimas 3 solicitudes
        public void CargarUltimasTresSolicitudes()
        {
            using (SqlConnection conexion = ConexionDB.Conectar())
            {

                string querySolicitudes = @"
                            SELECT TOP 3 
                                s.idSolicitud,
                                u.nombre AS NombreUsuario,
                                r.tipoRol AS Rol,
                                s.fecha AS FechaSolicitud,
                                s.motivo AS Motivo
                            FROM Solicitud s
                            INNER JOIN Usuario u ON s.id_Usuario = u.idUsuario
                            INNER JOIN Rol r ON u.id_Rol = r.idRol
                            ORDER BY s.idSolicitud DESC;";

                SqlCommand cmdSolicitudes = new SqlCommand(querySolicitudes, conexion);
                SqlDataReader drSolicitudes = cmdSolicitudes.ExecuteReader();

                List<int> ids = new List<int>();
                int bloqueIndex = 0;

                while (drSolicitudes.Read())
                {
                    ids.Add(Convert.ToInt32(drSolicitudes["idSolicitud"]));

                    if (bloqueIndex < 3)
                    {
                        nombreUsuarios[bloqueIndex][0].Text = drSolicitudes["NombreUsuario"].ToString();
                        roles[bloqueIndex][0].Text = drSolicitudes["Rol"].ToString();
                        fechas[bloqueIndex][0].Text = Convert.ToDateTime(drSolicitudes["FechaSolicitud"]).ToShortDateString();
                        motivos[bloqueIndex][0].Text = drSolicitudes["Motivo"].ToString();
                    }

                    bloqueIndex++;
                }
                drSolicitudes.Close();

                // Por cada solicitud, traer sus materiales
                for (int i = 0; i < ids.Count && i < 3; i++)
                {
                    string queryMateriales = @"
                                    SELECT 
                                        m.nombreMaterial AS Material,
                                        sm.cantidad AS Cantidad,
                                        ma.nombreMarca AS Marca
                                    FROM SolicitudMaterial sm
                                    INNER JOIN Material m ON sm.idMaterial = m.idMaterial
                                    INNER JOIN Marca ma ON m.id_Marca = ma.idMarca
                                    WHERE sm.idSolicitud = @idSolicitud;";

                    SqlCommand cmdMat = new SqlCommand(queryMateriales, conexion);
                    cmdMat.Parameters.AddWithValue("@idSolicitud", ids[i]);

                    SqlDataReader drMat = cmdMat.ExecuteReader();

                    int materialIndex = 0;

                    while (drMat.Read() && materialIndex < materiales[i].Length)
                    {
                        materiales[i][materialIndex].Text = drMat["Material"].ToString();
                        materiales[i][materialIndex].Visible = true;

                        cantidades[i][materialIndex].Text = drMat["Cantidad"].ToString();
                        cantidades[i][materialIndex].Visible = true;

                        marcas[i][materialIndex].Text = drMat["Marca"].ToString();
                        marcas[i][materialIndex].Visible = true;

                        materialIndex++;
                    }

                    drMat.Close();

                    // Esto es por si no se ocupa un label de material, cantidad o marca, para que se oculte
                    for (int j = materialIndex; j < materiales[i].Length; j++)
                    {
                        materiales[i][j].Visible = false;
                        cantidades[i][j].Visible = false;
                        marcas[i][j].Visible = false;
                    }
                }
            }
        }

    }


}
    
