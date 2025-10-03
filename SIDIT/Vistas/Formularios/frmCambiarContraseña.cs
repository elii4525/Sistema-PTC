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
            label1.Font = Helper.FuenteHelper.ObtenerFuente(10);
            label2.Font = Helper.FuenteHelper.ObtenerFuente(8);
            label3.Font = Helper.FuenteHelper.ObtenerFuente(8);

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                string nueva = txtContraseñaNueva.Text ?? "";
                string confirmar = txtConfirmarContraseña.Text ?? "";

                if (string.IsNullOrWhiteSpace(nueva) || string.IsNullOrWhiteSpace(confirmar))
                {
                    MessageBox.Show("Ingresar una nueva contraseña");
                    return;
                }

                if (nueva != confirmar)
                {
                    MessageBox.Show("Las contraseñas nuevas no coinciden.");
                    return;
                }

                int idUsuario = Usuario.SesionActual.IdUsuario;
                if (idUsuario <= 0)
                {
                    MessageBox.Show("No hay datos del usuario");
                    return;
                }

                string nuevoHash = SeguridadHelper.HashContraseña(nueva);
                Usuario.GuardarNuevaPassword(idUsuario, nuevoHash);

                MessageBox.Show("Contraseña cambiada exitosamente");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cambiar contraseña: " + ex.Message);
            }
        }
    }
}
