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
using Modelos.ServiciosCorreoElectronico;

namespace Vistas.Formularios
{
    public partial class frmRecuperarContraseña : Form
    {
        public frmRecuperarContraseña()
        {
            InitializeComponent();
            label1.Font = Helper.FuenteHelper.ObtenerFuente(8);
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuarioOContraseña.Text))
            {
                MessageBox.Show("Por favor, ingresa tu correo electrónico para recuperar la contraseña.",
                                "Campo vacío",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                txtUsuarioOContraseña.Focus();
                return; 
            }

            var user = new Usuario();
            var result = user.RecuperarContraseña(txtUsuarioOContraseña.Text);
            lblResultado.Text = result;
        }

        private void txtUsuarioOContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
                e.Handled = true;
        }
    }
}
