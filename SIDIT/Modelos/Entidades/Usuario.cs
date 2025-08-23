using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos.Conexion;

namespace Modelos.Entidades
{
    public class Usuario
    {
        private int idUsuario;
        private string nombre;
        private DateTime fechaNacimiento;
        private string contraseña;
        private string telefono;
        private string correo;
        private int idRol;

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }
        public int IdRol { get => idRol; set => idRol = value; }

        public string Login(string correo, string contraseña)
        {
            using (SqlConnection conexion = ConexionDB.Conectar())
            {
                string consulta = @"
                SELECT R.tipoRol
                FROM Usuario U
                INNER JOIN Rol R ON U.id_Rol = R.idRol
                WHERE U.correo = @correo AND U.contraseña = @contraseña";

                using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                {
                    cmd.Parameters.AddWithValue("@correo", correo);
                    cmd.Parameters.AddWithValue("@contraseña", contraseña);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader["tipoRol"].ToString();
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }

        public static DataTable VerUsuarios()
        {
            SqlConnection conexion = ConexionDB.Conectar();
            string consulta = @"select idUsuario as Codigo_Usuario, nombre as Nombre, fechaNacimiento as Fecha_de_nacimiento, telefono as Telefono, tipoRol as Rol, contraseña as Contraseña, correo as Correo_electronicofrom Usuario  Uinner join Rol R on R.idRol = U.id_Rol";
            SqlDataAdapter add = new SqlDataAdapter(consulta, conexion);
            DataTable tablaVirtual = new DataTable();
            add.Fill(tablaVirtual);
            return tablaVirtual;
        }

        public static void EliminarUsuario(int idUsuario)
        {
            SqlConnection conexion = ConexionDB.Conectar();
            SqlCommand cmd = new SqlCommand(@"delete from Usuario
            where idUsuario = @idUsuario", conexion);
        
            cmd.Parameters.AddWithValue("@idUsuario", idUsuario);

            conexion.Open();
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conexion.Close();
        }
        public void AgregaUsuariol()
        {
            SqlConnection conexion = ConexionDB.Conectar();
            SqlCommand cmd = new SqlCommand(@"insert into Usuario 
            values (@idUsuario, @nombre, @fechaNacimiento, @contraseña, @telefono, @correo, @id_Rol)", conexion);
            cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@fechaNacimiento", fechaNacimiento);
            cmd.Parameters.AddWithValue("@contraseña", contraseña);
            cmd.Parameters.AddWithValue("@telefono", telefono);
            cmd.Parameters.AddWithValue("@correo", correo);
    
            cmd.Parameters.AddWithValue("@id_Rol", idRol);

            conexion.Open();
            cmd.ExecuteNonQuery();

            cmd.Dispose();
            conexion.Dispose();
        }

    }
}
