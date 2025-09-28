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
using Vistas.controles;

namespace Vistas.Formularios
{
    public partial class frmSolicitudDIT : Form
    {
        public frmSolicitudDIT()
        {
            InitializeComponent();
        }

        private void buttonRedondeado1_Click(object sender, EventArgs e)
        {
            int idUsuario = Usuario.SesionActual.IdUsuario;

            frmEnviarSolicitud uc = new frmEnviarSolicitud(idUsuario);
            FrmContenedorUC ven = new FrmContenedorUC(uc);
            ven.ShowDialog();
        }
    }
}
