using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Entidades
{
    public class HistorialSolicitud
    {
        private int idHistorialSolicitud;
        private string estadoSolicitud;
        private DateTime fechaRespuesta;
        private int idSolicitud;

        public int IdHistorialSolicitud { get => idHistorialSolicitud; set => idHistorialSolicitud = value; }
        public string EstadoSolicitud { get => estadoSolicitud; set => estadoSolicitud = value; }
        public DateTime FechaRespuesta { get => fechaRespuesta; set => fechaRespuesta = value; }
        public int IdSolicitud { get => idSolicitud; set => idSolicitud = value; }

    }
}
