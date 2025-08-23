using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Conexion
{
    public class ConexionDB
    {

        private static string servidor = "DESKTOP-JVGVM0A\\SQLEXPRESS";
        private static string database = "BasePTC";

        public static SqlConnection Conectar()
        {

            string cadena = $"Data Source={servidor};Initial Catalog={database};Integrated Security=true;";
            SqlConnection conexion = new SqlConnection(cadena);
            conexion.Open();
            return conexion;

        }

    }
}
