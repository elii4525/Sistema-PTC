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

        private void pbInventarioBJ_Click(object sender, EventArgs e)
        {
            this.Hide(); //Oculta el form actual
            frmMenuJefatura menuJefatura = new frmMenuJefatura();   //Crea una instancia del nuevo form
            menuJefatura.Show();   //Se muestra el form nuevo
        }

        private void lblVerInventarioJefatura_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenuJefatura menuJefatura = new frmMenuJefatura();
            menuJefatura.Show();
        }

        private void pbUsuarioBJ_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenuJefatura menuJefatura = new frmMenuJefatura();
            menuJefatura.Show();
        }

        private void lblVerUsuarioJefatura_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenuJefatura menuJefatura = new frmMenuJefatura();
            menuJefatura.Show();
        }

        private void pbSolicitudesBJ_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenuJefatura menuJefatura = new frmMenuJefatura();
            menuJefatura.Show();
        }

        private void lblVerSolicitudesJefatura_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenuJefatura menuJefatura = new frmMenuJefatura();
            menuJefatura.Show();
        }

        private void pbConsumoBJ_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenuJefatura menuJefatura = new frmMenuJefatura();
            menuJefatura.Show();
        }

        private void lblVerConsumoJefatura_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenuJefatura menuJefatura = new frmMenuJefatura();
            menuJefatura.Show();
        }




        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);

            BarraNegra.TryApplyDarkTitleBar(this.Handle);
        }

        private void frmBienvenidaJefatura_Load(object sender, EventArgs e)
        {
            lblConsumoDes.Font = FuenteHelper.ObtenerFuente2(40);
            lblInventarioDes.Font = FuenteHelper.ObtenerFuente2(9);
            lblUsuariosDes.Font = FuenteHelper.ObtenerFuente2(5);
            lblSolicitudesDes.Font = FuenteHelper.ObtenerFuente2(5);
            lblInventarioJefatura.Font = FuenteHelper.ObtenerFuente2(13);
            lblQueDesea.Font = FuenteHelper.ObtenerFuente2(45);  
            lblVerConsumoJefatura.Font = FuenteHelper.ObtenerFuente2(15);
            lblVerInventarioJefatura.Font = FuenteHelper.ObtenerFuente2(10);
            lblVerUsuarioJefatura.Font = FuenteHelper.ObtenerFuente2(15);
            lblVerSolicitudesJefatura.Font = FuenteHelper.ObtenerFuente2(15);
            lblUsuarioJefatura.Font = FuenteHelper.ObtenerFuente2(15);
            lblConsumoJefatura.Font = FuenteHelper.ObtenerFuente2(15);
            lblConsumoJefatura.Font = FuenteHelper.ObtenerFuente2(15);

        }
    }
}
