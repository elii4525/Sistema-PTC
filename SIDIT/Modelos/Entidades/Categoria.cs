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
    public class Categoria
    {

        private int idCategoria;
        private string nombreCategoria;
        private string descripcion;

        public int IdCategoria { get => idCategoria; set => idCategoria = value; }
        public string NombreCategoria { get => nombreCategoria; set => nombreCategoria = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        public static DataTable CargarCategorias()
        {
            SqlConnection con = ConexionDB.Conectar();
            string comando = "Select idCategoria as Id, nombreCategoria as Nombre from Categoria";
            SqlDataAdapter add = new SqlDataAdapter(comando, con);
            DataTable dt = new DataTable();
            add.Fill(dt);
            return dt;
        }


        public bool InsertarCategorias()
        {
            SqlConnection con = ConexionDB.Conectar();
            string comando = "insert into Categoria (nombreCategoria) values (@nombreCategoria);";
            SqlCommand cmd = new SqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@nombreCategoria", nombreCategoria);

            if (cmd.ExecuteNonQuery() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool EliminarCategorias(int id)
        {
            SqlConnection con = ConexionDB.Conectar();
            string comando = "delete from Categoria where idCategoria = @id";
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
