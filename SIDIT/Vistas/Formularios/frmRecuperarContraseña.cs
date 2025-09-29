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
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            var user = new Usuario();
            var result = user.RecuperarContraseña(txtUsuarioOContraseña.Text);
            lblResultado.Text = result;
        }
    }
}
