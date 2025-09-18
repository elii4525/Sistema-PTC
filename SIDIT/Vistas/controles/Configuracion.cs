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
            SesionActual.IdUsuario = 0;
            SesionActual.Nombre = null;
            SesionActual.Correo = null;
            SesionActual.Telefono = null;
            SesionActual.Rol = null;

            frmLogin l = new frmLogin();
            l.Show();
            this.Hide();
        }

        private void Configuracion_Load(object sender, EventArgs e)
        {
            txtNombre.Texts = SesionActual.Nombre;
            txtCorreo.Texts = SesionActual.Correo;
            txtNumero.Texts = SesionActual.Telefono;
            txtRol.Texts = SesionActual.Rol;
            dtpFecha.Value = SesionActual.FechaNacimiento;
        }
    }
}
