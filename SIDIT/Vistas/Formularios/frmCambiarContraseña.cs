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

namespace Vistas.Formularios
{
    public partial class frmCambiarContraseña : Form
    {
        public frmCambiarContraseña()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string actual = txtActual.Text;
            string nueva = txtNueva.Text;
            string confirmar = txtConfirmar.Text;

            if (nueva != confirmar)
            {
                MessageBox.Show("Las contraseñas nuevas no coinciden.");
                return;
            }

            int idUsuario = Usuario.SesionActual.IdUsuario;

            // 1. Obtener el hash actual desde BD
            string hashActual = ObtenerHashDesdeBD(idUsuario);

            // 2. Validar que la contraseña actual coincida
            if (!SeguridadHelper.VerificarPassword(actual, hashActual))
            {
                MessageBox.Show("La contraseña actual es incorrecta.");
                return;
            }

            // 3. Hashear la nueva contraseña
            string hashNuevo = SeguridadHelper.HashPassword(nueva);

            // 4. Guardar en BD
            GuardarNuevaPassword(idUsuario, hashNuevo);

            MessageBox.Show("Contraseña cambiada correctamente.");
            this.Close();
        }
    }
}
