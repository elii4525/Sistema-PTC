using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelos.Entidades;
using Vistas.Formularios;
using static Modelos.Entidades.Usuario;

namespace Vistas.Controles
{
    public partial class Configuracion : UserControl
    {
        public Configuracion()
        {
            InitializeComponent();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Application.Restart(); // reinicia la app desde el frmLogin
        }

        private void Configuracion_Load(object sender, EventArgs e)
        {
            txtNombre.Texts = SesionActual.Nombre;
            txtCorreo.Texts = SesionActual.Correo;
            txtNumero.Texts = SesionActual.Telefono;
            txtRol.Texts = SesionActual.Rol;

            // Solo asignar la fecha si no es DateTime.MinValue
            dtpFecha.Value = SesionActual.FechaNacimiento != DateTime.MinValue
                              ? SesionActual.FechaNacimiento
                              : DateTime.Today;
        }
    }
}
