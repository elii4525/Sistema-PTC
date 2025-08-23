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
    public partial class frmMenuJefatura : Form
    {
        public frmMenuJefatura()
        {
            InitializeComponent();
        }

        public void MostrarFormInvEnPanel()
        {
            pnlContenedor.Controls.Clear();
            frmInventarioJefatura invenJefatura = new frmInventarioJefatura();
            invenJefatura.TopLevel = false;
            invenJefatura.FormBorderStyle = FormBorderStyle.None;
            invenJefatura.Dock = DockStyle.Fill;
            invenJefatura.Controls.Add(invenJefatura);
            invenJefatura.Show();

            //Cambiar colores de panel activo 

            //Restauracion de colores para paneles inactivos
        }
    }
}
