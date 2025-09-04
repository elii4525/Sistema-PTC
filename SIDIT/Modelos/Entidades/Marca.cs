using Modelos.Conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Entidades
{
    public class Marca
    {

        private int idMarca;
        private string nombreMarca;

        public int IdMarca { get => idMarca; set => idMarca = value; }
        public string NombreMarca { get => nombreMarca; set => nombreMarca = value; }

        public static DataTable CargarMarcas()
        {
            SqlConnection con = ConexionDB.Conectar();
            string comando = "select idmarca as Id, nombremarca as Nombre from marca;";
            SqlDataAdapter add = new SqlDataAdapter(comando, con);
            DataTable dt = new DataTable();
            add.Fill(dt);
            return dt;
        }

       
        public bool InsertarMarca()
        {
            SqlConnection con = ConexionDB.Conectar();
            string comando = "insert into marca (nombremarca) values (@nombremarca);";
            SqlCommand cmd = new SqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@nombremarca", nombreMarca);

            if(cmd.ExecuteNonQuery() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool EliminarMarca(int id)
        {
            SqlConnection con = ConexionDB.Conectar();
            string comando = "delete from marca where idmarca = @id";
            SqlCommand cmd = new SqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@id", id);
            if (cmd.ExecuteNonQuery() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
