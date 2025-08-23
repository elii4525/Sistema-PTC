using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Entidades
{
    public class Rol
    {

        private int idRol;
        private string tipoRol;
        private string descripcionRol;

        public int IdRol { get => idRol; set => idRol = value; }
        public string TipoRol { get => tipoRol; set => tipoRol = value; }
        public string DescripcionRol { get => descripcionRol; set => descripcionRol = value; }

    }
}
