using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Modelos.Conexion;

namespace Modelos.Entidades
{
    public class Material
    {

        private int idMaterial;
        private int cantidad;
        private DateTime fechaIngreso;
        private string descripcion;
        private string modelo;
        private string nombreMaterial;
        private int idCategoria;
        private int idMarca;

        public int IdMaterial { get => idMaterial; set => idMaterial = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int IdCategoria { get => idCategoria; set => idCategoria = value; }
        public int IdMarca { get => idMarca; set => idMarca = value; }
        public string NombreMaterial { get => nombreMaterial; set => nombreMaterial = value; }

        public static DataTable CargarMateriales()
        {
            SqlConnection conexion = ConexionDB.Conectar();
            string comando = "select *from selectMateriales;";
            SqlDataAdapter ad = new SqlDataAdapter(comando, conexion);
            DataTable dt = new DataTable();
            ad.Fill(dt); 
            return dt;
        }

        public static DataTable Buscar(string termino)
        {
            SqlConnection con = ConexionDB.Conectar();
            string comando = $"select m.nombreMaterial as " +
                $"[Nombre del Material], m.cantidad as Cantidad, " +
                $"m.fechaIngreso as [Fecha de Ingreso], m.descripcionMaterial " +
                $"as [Descripción], m.modelo as [Modelo], c.nombreCategoria " +
                $"as [Categoría], mar.nombreMarca as [Marca] from Material " +
                $"m Inner Join Categoria c on c.idCategoria = m.id_Categoria " +
                $"Inner Join Marca mar on mar.idMarca = m.id_Marca " +
                $"Where m.nombreMaterial like '%{termino}%';";
            SqlDataAdapter ad = new SqlDataAdapter(comando, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }

        public bool InsertarMaterial()
        {
            SqlConnection con = ConexionDB.Conectar();
            string comando = "insert into Material (nombreMaterial, cantidad, fechaIngreso, descripcionMaterial, " +
                "modelo, id_Categoria, id_Marca) values (@nombreMaterial, @cantidad, @fechaIngreso, @descripcionMaterial, " +
                "@modelo, @idCategoria, @idMarca);";
            SqlCommand cmd = new SqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@nombreMaterial", nombreMaterial);
            cmd.Parameters.AddWithValue("@descripcionMaterial", descripcion);
            cmd.Parameters.AddWithValue("@cantidad", cantidad);
            cmd.Parameters.AddWithValue("@fechaIngreso", fechaIngreso);
            cmd.Parameters.AddWithValue("@modelo", modelo);
            cmd.Parameters.AddWithValue("@idCategoria", idCategoria);
            cmd.Parameters.AddWithValue("@idMarca", idMarca);

            if (cmd.ExecuteNonQuery() >0 )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static DataTable CargarUltimosRegistros()
        {
            SqlConnection con = ConexionDB.Conectar();
            string comando = "select *from registrosUlt;";
            SqlDataAdapter add = new SqlDataAdapter(comando, con);
            DataTable dt = new DataTable();
            add.Fill(dt);
            return dt;
        }

        public bool EliminarMaterial(int id)
        {
            SqlConnection con = ConexionDB.Conectar();
            string comando = "delete from Material where idMaterial = @id";
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

        public bool ActualizarMaterial()
        {
            SqlConnection con = ConexionDB.Conectar();
            string comando = "Update Material set nombreMaterial = @nombre, cantidad = @cantidad where idMaterial = @id;";
            SqlCommand cmd = new SqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@nombre", nombreMaterial);
            cmd.Parameters.AddWithValue("@cantidad", cantidad);
            cmd.Parameters.AddWithValue("@id", idMaterial);

            if (cmd.ExecuteNonQuery() > 0)
                return true;
            else
                return false;

        }
    }
}
