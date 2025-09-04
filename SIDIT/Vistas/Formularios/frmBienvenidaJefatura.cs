using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vistas.Helper;
using Vistas.HelperBarraNegra;

namespace Vistas.Formularios
{
    public partial class frmBienvenidaJefatura : Form
    {
        public frmBienvenidaJefatura()
        {
            InitializeComponent();
        }

        private void lblVer_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenuJefatura inven = new frmMenuJefatura();
            inven.Show();
            inven.MostrarFormInvenJEnPanel();

        }

        private void icbtnInventario_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenuJefatura inven = new frmMenuJefatura();
            inven.Show();
            inven.MostrarFormInvenJEnPanel();
        }

        private void lblVerSoli_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenuJefatura inven = new frmMenuJefatura();
            inven.Show();
            inven.MostrarFormSoliJEnPanel();
        }

        private void icbtnSol_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenuJefatura soli = new frmMenuJefatura();
            soli.Show();
            soli.MostrarFormSoliJEnPanel();
        }

        private void lblVerConsumo_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenuJefatura consumo = new frmMenuJefatura();
            consumo.Show();
            consumo.MostrarFormConsumoJEnPanel();
        }

        private void icbtnConsumo_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenuJefatura consumo = new frmMenuJefatura();
            consumo.Show();
            consumo.MostrarFormConsumoJEnPanel();
        }

        private void lblVerUsuarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenuJefatura usuario = new frmMenuJefatura();
            usuario.Show();
            usuario.MostrarFormUsuariosEnPanel();
        }

        private void icbtnUsuarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenuJefatura usuario = new frmMenuJefatura();
            usuario.Show();
            usuario.MostrarFormUsuariosEnPanel();
        }


        //Lineas
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            using (Pen lapiz = new Pen(Color.White, 3))
            {
                e.Graphics.DrawLine(lapiz, 0, 3, panel2.Width - 1, 3);
            }
        }

        private void panel2_Resize(object sender, EventArgs e)
        {
            //Invalida como para repintar pero solo esa area especifica.
            panel2.Invalidate(new Rectangle(0, 3, panel2.Width - 1, 3));
        }


        //Cambios de color de las label
        private void lblVer_MouseHover(object sender, EventArgs e)
        {
            lblVer.ForeColor = Color.FromArgb(99, 89, 133);
        }

        private void lblVer_MouseLeave(object sender, EventArgs e)
        {
            lblVer.ForeColor = Color.White;
        }

        private void lblVerSoli_MouseHover(object sender, EventArgs e)
        {
            lblVerSoli.ForeColor = Color.FromArgb(99, 89, 133);
        }

        private void lblVerSoli_MouseLeave(object sender, EventArgs e)
        {
            lblVerSoli.ForeColor = Color.White;
        }

        private void lblVerConsumo_MouseHover(object sender, EventArgs e)
        {
            lblVerConsumo.ForeColor = Color.FromArgb(99, 89, 133);
        }

        private void lblVerConsumo_MouseLeave(object sender, EventArgs e)
        {
            lblVerConsumo.ForeColor = Color.White;
        }

        private void lblVerUsuarios_MouseHover(object sender, EventArgs e)
        {
            lblVerUsuarios.ForeColor = Color.FromArgb(99, 89, 133);
        }

        private void lblVerUsuarios_MouseLeave(object sender, EventArgs e)
        {
            lblVerUsuarios.ForeColor = Color.White;
        }
    }
}
