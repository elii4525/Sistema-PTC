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
    public partial class frmAgregarMaterial : Form
    {
        public frmAgregarMaterial()
        {
            InitializeComponent();
        }

        private void icbtnSalir_Click(object sender, EventArgs e)
        {
            icbtnSalir.Cursor = Cursors.Hand;
            this.Close();
        }
    }
}
