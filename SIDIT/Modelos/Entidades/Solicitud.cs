using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Entidades
{
    internal class Solicitud
    {

        private int idSolicitud;
        private string motivo;
        private int cantidad;
        private DateTime fecha;
        private string estado;
        private int idUsuario;
        private int idMaterial;

        public int IdSolicitud { get => idSolicitud; set => idSolicitud = value; }
        public string Motivo { get => motivo; set => motivo = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Estado { get => estado; set => estado = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public int IdMaterial { get => idMaterial; set => idMaterial = value; }

    }
}
