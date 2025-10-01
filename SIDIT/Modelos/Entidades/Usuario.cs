using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        // Esta clase es para guardar los datos de la persona que inicio sesion y asi poder usarlos en el perfil

        public static bool ExistenUsuarios()
        {
            using (SqlConnection con = ConexionDB.Conectar())
            {
                string query = "SELECT COUNT(*) FROM Usuario";
                SqlCommand cmd = new SqlCommand(query, con);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        public static class SesionActual
        {
            public static int IdUsuario { get; set; }
            public static string Nombre { get; set; }
            public static string Correo { get; set; }
            public static string Telefono { get; set; }
            public static string Rol { get; set; }
            public static DateTime FechaNacimiento { get; set; }
        }

        public static void EliminarUsuario(int idUsuario)
        {
            SqlConnection conexion = ConexionDB.Conectar();
            SqlCommand cmd = new SqlCommand("delete Usuario where idUsuario = @idUsuario", conexion);

            cmd.Parameters.AddWithValue("@idUsuario", idUsuario);

            cmd.ExecuteNonQuery();

            cmd.Dispose();
            conexion.Close();
        }

        // Este metodo genera una contraseña de tamaño o longitud de 6 caracteres
        public static string GenerarContrasena(int longitud = 6)
        {
            const string caracteres = "abcdefghijklmnopqrsTUVWXYZABCDEFGHIJK1234567890";
            StringBuilder contrasena = new StringBuilder();
            Random rnd = new Random();

            for (int i = 0; i < longitud; i++)
            {
                contrasena.Append(caracteres[rnd.Next(caracteres.Length)]);
            }

            return contrasena.ToString();
        }

        // Aqui se usa el metodo anterior para hacer la contraseña y para que luego se hashee
        public bool RegistrarUsuario()
        {
            try
            {
                SqlConnection con = ConexionDB.Conectar();

                string contrasenaGenerada = GenerarContrasena();

                string contrasenaHasheada = BCrypt.Net.BCrypt.HashPassword(contrasenaGenerada);

                string query = @"insert into Usuario (nombre, fechaNacimiento, contraseña, telefono, correo, id_Rol)
                values (@Nombre, @Fechanacimiento, @Contraseña, @Telefono, @Correo, @RolId)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Nombre", Nombre);
                cmd.Parameters.AddWithValue("@Fechanacimiento", FechaNacimiento);
                cmd.Parameters.AddWithValue("@Contraseña", contrasenaHasheada);
                cmd.Parameters.AddWithValue("@Telefono", Telefono);
                cmd.Parameters.AddWithValue("@Correo", Correo);
                cmd.Parameters.AddWithValue("@RolId", IdRol);

                cmd.ExecuteNonQuery();

                MessageBox.Show($"Usuario registrado con éxito.\nContraseña generada: {contrasenaGenerada}",
                    "Registro exitoso"); // Aqui se genera el usuario y se muestra la contraseña creada a lo random

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public string VerificarLogin(string correo, string contraseña)
        {
            using (SqlConnection conn = ConexionDB.Conectar())
            {
                string sql = @"SELECT u.contraseña, r.tipoRol 
                       FROM Usuario u
                       INNER JOIN Rol r ON u.id_Rol = r.idRol
                       WHERE u.correo = @correo";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@correo", correo);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string hashAlmacenado = reader["contraseña"].ToString();
                        string rol = reader["tipoRol"].ToString();

                        // 🔑 Validar con BCrypt
                        if (BCrypt.Net.BCrypt.Verify(contraseña, hashAlmacenado))
                        {
                            return rol;
                        }
                    }
                }
            }
            return null; // si no coincide
        }

        public DataTable cargarRoles()
        {
            SqlConnection con = ConexionDB.Conectar();
            string query = @"select idRol, tipoRol from Rol";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable ObtenerDatosUsuario(string correo)
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = ConexionDB.Conectar())
            {
                string query = @"SELECT U.idUsuario, U.nombre, U.fechaNacimiento, U.telefono, U.correo, R.tipoRol
                         FROM Usuario U
                         INNER JOIN Rol R ON U.id_Rol = R.idRol
                         WHERE U.correo = @correo";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@correo", correo);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }

            return dt;
        }

        public static DataTable cargarUsuarios()
        {
            SqlConnection con = ConexionDB.Conectar();
            string query = @"select * from VerUsuarios";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //public static DataTable cargarUltimosUsuarios()
        //{
        //    SqlConnection con = ConexionDB.Conectar();
        //    string query = @"select * from VerUltimosUsuarios";
        //    SqlDataAdapter da = new SqlDataAdapter(query, con);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    return dt;
        //}

        public static DataTable cargarUsuariosEliminar()
        {
            SqlConnection con = ConexionDB.Conectar();
            string query = @"select idUsuario as Codigo, nombre as Nombre from Usuario";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static string ObtenerHashContraseña(int idUsuario)
        {
            using (SqlConnection conn = ConexionDB.Conectar())
            {
                string sql = "SELECT contraseña FROM Usuario WHERE idUsuario = @idUsuario";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                    object result = cmd.ExecuteScalar();
                    return result == null ? null : result.ToString();
                }
            }
        }

        public static void GuardarNuevaPassword(int idUsuario, string hashPassword)
        {
            using (SqlConnection conn = ConexionDB.Conectar())
            {
                string sql = "UPDATE Usuario SET contraseña = @pass WHERE idUsuario = @idUsuario";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@pass", hashPassword);
                    cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public string RecuperarContraseña(string usuarioSolicitando)
        {
            try
            {
                using (SqlConnection conexion = ConexionDB.Conectar())
                {
                    // Buscar por nombre o correo
                    string sql = "SELECT * FROM Usuario WHERE nombre = @usuario OR correo = @correo";

                    using (SqlCommand comando = new SqlCommand(sql, conexion))
                    {
                        comando.Parameters.AddWithValue("@usuario", usuarioSolicitando);
                        comando.Parameters.AddWithValue("@correo", usuarioSolicitando);
                        comando.CommandType = CommandType.Text;

                        using (SqlDataReader lector = comando.ExecuteReader())
                        {
                            if (lector.Read() == true)
                            {
                                // Obtenemos primero los datos del usuario
                                int idUsuario = Convert.ToInt32(lector["idUsuario"]);
                                string nombreUsuario = lector["nombre"].ToString();
                                string correoUsuario = lector["correo"].ToString();

                                // Generamos una nueva contraseña temporal
                                string nuevaPasswordTemporal = GenerarContrasena(8);
                                string hashTemporal = BCrypt.Net.BCrypt.HashPassword(nuevaPasswordTemporal);

                                lector.Close();

                                GuardarNuevaPassword(idUsuario, hashTemporal);

                                var servicioCorreo = new Modelos.ServiciosCorreoElectronico.SoporteCorreos();
                                string asunto = "SISTEMA: Solicitud de recuperación de contraseña";
                                string cuerpo = "Hola, " + nombreUsuario +
                                                "\nHas solicitado recuperar tu contraseña.\n" +
                                                "Tu nueva contraseña temporal es: " + nuevaPasswordTemporal +
                                                "\nPor favor, cambia tu contraseña inmediatamente una vez ingreses al sistema.";

                                servicioCorreo.enviarCorreo(asunto, cuerpo, new List<string> { correoUsuario });

                                return "Hola, " + nombreUsuario +
                                       "\nHas solicitado recuperar tu contraseña.\n" +
                                       "Revisa tu correo: " + correoUsuario +
                                       "\nRecuerda cambiar tu contraseña inmediatamente después de ingresar.";
                            }
                            else
                            {
                                return "No se encontró una cuenta con ese correo o nombre de usuario.";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar recuperar la contraseña: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public string recoverPassword(string usuarioSolicitando)
        {
            return RecuperarContraseña(usuarioSolicitando);
        }

    }
}