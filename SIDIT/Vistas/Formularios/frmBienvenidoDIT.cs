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
    public partial class frmBienvenidoDIT : Form
    {
        public frmBienvenidoDIT()
        {
            InitializeComponent();
        }

        private void pbVerInventario_Click(object sender, EventArgs e)
        {
            this.Hide(); //Oculta el form actual
            frmMenuDIT menuDIT = new frmMenuDIT();   //Crea una instancia del nuevo form
            menuDIT.Show();   //Se muestra el form nuevo
        }

        private void lblVerInventarioDIT_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenuDIT menuDIT = new frmMenuDIT();
            menuDIT.Show();
        }

        private void pbVerSolicitudes_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenuDIT menuDIT = new frmMenuDIT();
            menuDIT.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenuDIT menuDIT = new frmMenuDIT();
            menuDIT.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenuDIT menuDIT = new frmMenuDIT();
            menuDIT.Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenuDIT menuDIT = new frmMenuDIT();
            menuDIT.Show();
        }


    }
}
