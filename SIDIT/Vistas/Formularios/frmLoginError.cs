using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas.Formularios
{
    public partial class frmLoginError : Form
    {
        public frmLoginError()
        {
            InitializeComponent();
            label1.Font = Helper.FuenteHelper.ObtenerFuente(15);
            label2.Font = Helper.FuenteHelper.ObtenerFuente(10);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
