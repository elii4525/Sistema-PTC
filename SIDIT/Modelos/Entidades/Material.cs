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
        private int idNombreMaterial;
        private int idCategoria;
        private int idMarca;

        public int IdMaterial { get => idMaterial; set => idMaterial = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int IdNombreMaterial { get => idNombreMaterial; set => idNombreMaterial = value; }
        public int IdCategoria { get => idCategoria; set => idCategoria = value; }
        public int IdMarca { get => idMarca; set => idMarca = value; }

       

    }
}
