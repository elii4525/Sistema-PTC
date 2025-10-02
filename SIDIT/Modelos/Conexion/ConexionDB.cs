using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modelos.Conexion
{
    public class ConexionDB
    {

        private static string servidor = "Orlando\\SQLEXPRESS";
        private static string database = "BasePTC2";

        //private static string servidor = "Lenovo\\SQLEXPRESS";
        //private static string database = "BasePTC";


        public static SqlConnection Conectar()
        {
            try
            {
                string cadena = $"Data Source={servidor};Initial Catalog={database};Integrated Security=true;";
                SqlConnection conexion = new SqlConnection(cadena);
                conexion.Open();
                return conexion;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo conectar al servidor" +ex, "Error de Conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            

        }

    }
}
