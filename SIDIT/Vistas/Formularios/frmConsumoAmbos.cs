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
    public partial class frmConsumoAmbos : Form
    {
        public frmConsumoAmbos()
        {
            InitializeComponent();
        }

        private frmRegistroConsumo frmRegistro;
        private frmConsumo frmGraficas;

        Panel lineAbajo = new Panel();
        private void btnMouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            lineAbajo.Size = new Size(btn.Width, 3);
            lineAbajo.Location = new Point(btn.Left, btn.Bottom);
            lineAbajo.Visible = true;
            lineAbajo.BringToFront();
        }

        private void btnMouseLeave(object sender, EventArgs e)
        {
            lineAbajo.Visible = false;
        }


        private void frmConsumoAmbos_Load(object sender, EventArgs e)
        {
            MostrarRegistro();
            lineAbajo.BackColor = Color.White;
            lineAbajo.Size = new Size(0, 3);
            lineAbajo.Visible = false;
            pnlButtons.Controls.Add(lineAbajo);
        }

        private void icbtnRegistro_Click(object sender, EventArgs e)
        {
            MostrarRegistro();
        }

        private void MostrarRegistro()
        {
            pnlContenedor.Controls.Clear();
            if (frmRegistro == null || frmRegistro.IsDisposed)
                frmRegistro = new frmRegistroConsumo();

            frmRegistro.TopLevel = false;
            frmRegistro.FormBorderStyle = FormBorderStyle.None;
            frmRegistro.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(frmRegistro);
            frmRegistro.Show();
        }

        private void MostrarGraficas()
        {
            pnlContenedor.Controls.Clear();
            if (frmGraficas == null || frmGraficas.IsDisposed)
                frmGraficas = new frmConsumo();

            frmGraficas.TopLevel = false;
            frmGraficas.FormBorderStyle = FormBorderStyle.None;
            frmGraficas.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(frmGraficas);
            frmGraficas.Show();
        }

        private void icbtnGraficas_Click(object sender, EventArgs e)
        {
            MostrarGraficas();
        }

  
    }
}
