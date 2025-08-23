using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelos.Entidades;

namespace Vistas.Formularios
{
    public partial class frmInventarioDIT : Form
    {
        public frmInventarioDIT()
        {
            InitializeComponent();
        }

        //Panel p = new Panel();
        //private Panel pnlInventarioCategoria;

        private void btnMouseEnter(object sender, EventArgs e)
        {
            //Button btn = sender as Button;
            //pnlInventarioCategoria.Controls.Add(p);

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (!pnlMenuDesplegable.Visible)
            {
                pnlMenuDesplegable.Visible = true;
            }
            else
            {
                pnlMenuDesplegable.Visible = false;
            }
        }
    }
}
