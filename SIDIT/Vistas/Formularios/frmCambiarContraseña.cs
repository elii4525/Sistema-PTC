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
                    MessageBox.Show("Debe ingresar la nueva contraseña.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (nueva.Length < 8)
                {
                    MessageBox.Show("La contraseña debe tener al menos 8 caracteres.", "Contraseña insegura",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (nueva != confirmar)
                {
                    MessageBox.Show("Las contraseñas no coinciden.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int idUsuario = Usuario.SesionActual.IdUsuario;
                if (idUsuario <= 0)
                {
                    MessageBox.Show("No hay datos del usuario.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Guardar nueva contraseña
                string nuevoHash = SeguridadHelper.HashContraseña(nueva);
                Usuario.GuardarNuevaPassword(idUsuario, nuevoHash);

                MessageBox.Show("Contraseña cambiada exitosamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cambiar contraseña: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
