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
            label1.Font = Helper.FuenteHelper.ObtenerFuente(12);
            label2.Font = Helper.FuenteHelper.ObtenerFuente(8);
            label3.Font = Helper.FuenteHelper.ObtenerFuente(8);
            label4.Font = Helper.FuenteHelper.ObtenerFuente(8);
            label5.Font = Helper.FuenteHelper.ObtenerFuente(8);
            label6.Font = Helper.FuenteHelper.ObtenerFuente(8);

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Application.Restart(); // reinicia la app desde el Login
        }

        private void Configuracion_Load(object sender, EventArgs e)
        {
            txtNombre.Texts = SesionActual.Nombre;
            txtCorreo.Texts = SesionActual.Correo;
            txtNumero.Texts = SesionActual.Telefono;
            txtRol.Texts = SesionActual.Rol;

            dtpFecha.Value = SesionActual.FechaNacimiento != DateTime.MinValue
                              ? SesionActual.FechaNacimiento
                              : DateTime.Today;
        }

        private void btnCambiarContraseña_Click(object sender, EventArgs e)
        {
            frmCambiarContraseña frm = new frmCambiarContraseña();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog(); 
        }
    }
}
