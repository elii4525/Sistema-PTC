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
    public partial class frmMenuDIT : Form
    {
        public frmMenuDIT()
        {
            InitializeComponent();
        }

        private void frmMenuDIT_Load(object sender, EventArgs e)
        {
            MostrarFormInvenDEnPanel();
            pnlBarraSuperior.BringToFront();
            pnlBarraLateral.BringToFront();
            pbLogoITEC.BringToFront();
        }


        private void ColoresSolicitud()
        {
            icbtnSolicitudesD.BackColor = Color.White;
            icbtnSolicitudesD.IconColor = Color.Black;
            icbtnSolicitudesD.ForeColor = Color.Black;

            //Tmb dejo indicado q el titulo debe ser false
            lblTituloSolicitudD.Visible = false;
        }

        private void ColoresConsumo()
        {
            icbtnConsumoD.BackColor = Color.White;
            icbtnConsumoD.IconColor = Color.Black;
            icbtnConsumoD.ForeColor = Color.Black;
            lblTituloConsumoD.Visible = false;
        }

        private void ColoresInventario()
        {
            icbtnInventarioD.BackColor = Color.White;
            icbtnInventarioD.IconColor = Color.Black;
            icbtnInventarioD.ForeColor = Color.Black;

            lblTituloInventarioD.Visible = false;
        }

        private void MostrarFormInvenDEnPanel()
        {
            pnlContenedorDIT.Controls.Clear(); //Limpia lo que haya antes

            //Crear la instancia
            frmInventarioDIT inventarioD = new frmInventarioDIT();

            //La propiedad TopLevel basicamente es la que permite que los form sean independientes
            //Al ser false, se le quita como esa independencia y le permite ser un control mas dentro 
            //de un panel, un groupBox y asi. Siginifica que ya no puede moverse ni tiene esos controles
            //que una ventana normal tiene.
            inventarioD.TopLevel = false;
            inventarioD.FormBorderStyle = FormBorderStyle.None;
            inventarioD.Dock = DockStyle.Fill;    //Para que ocupe todo el panel.

            //Añado el form inventDit al panel contenedor
            pnlContenedorDIT.Controls.Add(inventarioD);
            inventarioD.Show(); //Ya se muestra el formulario

            //Cambia los colores para el panel activo
            icbtnInventarioD.BackColor = Color.FromArgb(18, 18, 18);
            icbtnInventarioD.IconColor = Color.White;
            icbtnInventarioD.ForeColor = Color.White;
            
            lblTituloInventarioD.Visible = true;

            //Restaura los colores de solicitud
            ColoresSolicitud();
            //Consumo
            ColoresConsumo();
            
        }

        private void MostrarFormSoliDEnPanel()
        {
            //Limpiar lo q haya antes
            pnlContenedorDIT.Controls.Clear();

            //Crear la instancia 
            frmSolicitudDIT solicitudD = new frmSolicitudDIT();

            solicitudD.TopLevel = false;
            solicitudD.FormBorderStyle = FormBorderStyle.None;
            solicitudD.Dock = DockStyle.Fill;
            //Añadir form
            pnlContenedorDIT.Controls.Add(solicitudD);
            //Mostramos el formulario
            solicitudD.Show();

            //Indica panel activo
            icbtnSolicitudesD.BackColor = Color.FromArgb(18, 18, 18);
            icbtnSolicitudesD.IconColor = Color.White;
            icbtnSolicitudesD.ForeColor = Color.White;
            lblTituloSolicitudD.Visible = true;


            //Restablecer colores de paneles
            //Inventario
            ColoresInventario();
            //Consumo
            ColoresConsumo();
        }

        private void MostrarFormConsumoDEnPanel()
        {
            pnlContenedorDIT.Controls.Clear();
            frmConsumoDIT consumoD = new frmConsumoDIT();
            consumoD.TopLevel = false;
            consumoD.FormBorderStyle = FormBorderStyle.None;
            consumoD.Dock = DockStyle.Fill;
            pnlContenedorDIT.Controls.Add(consumoD);
            consumoD.Show();

            //Indicar panel activo
            icbtnConsumoD.BackColor = Color.FromArgb(18, 18, 18);
            icbtnConsumoD.IconColor = Color.White;
            icbtnConsumoD.ForeColor = Color.White;
            lblTituloConsumoD.Visible = true;

            //Restablecer colores de paneles 
            //Inventario
            ColoresInventario();
            //Solicitud
            ColoresSolicitud();
        }

        private void icbtnInventarioD_Click(object sender, EventArgs e)
        {
            MostrarFormInvenDEnPanel();
        }

        private void icbtnSolicitudesD_Click(object sender, EventArgs e)
        {
            MostrarFormSoliDEnPanel();
        }

        private void icbtnConsumoD_Click(object sender, EventArgs e)
        {
            MostrarFormConsumoDEnPanel();
        }



        private void pnlBarraSuperior_Paint(object sender, PaintEventArgs e)
        {
            using (Pen lapiz = new Pen(Color.White, 2))
            {
                e.Graphics.DrawLine(lapiz, 0, pnlBarraSuperior.Height - 3, pnlBarraSuperior.Width - 1, pnlBarraSuperior.Height - 3);
            }
        }

        private void pnlBarraSuperior_Resize(object sender, EventArgs e)
        {
            //Permite que el la linea se repinte de nuevo.
            pnlBarraSuperior.Invalidate();
        }

        private void pnlBarraLateral_Paint(object sender, PaintEventArgs e)
        {
            using (Pen lapiz = new Pen(Color.White, 2))
            {
                e.Graphics.DrawLine(lapiz, pnlBarraLateral.Width -1, 0, pnlBarraLateral.Width -1, pnlBarraLateral.Height - 1);
            }
        }

        private void pnlBarraLateral_Resize(object sender, EventArgs e)
        {
            pnlBarraLateral.Invalidate();
        }

        //private void pnlLogo_Paint(object sender, PaintEventArgs e)
        //{
           
        //}

        private void pbLogoITEC_Paint(object sender, PaintEventArgs e)
        {
            using (Pen lapiz = new Pen(Color.White, 2))
            {
                e.Graphics.DrawLine(lapiz, pbLogoITEC.Width - 1, 0, pbLogoITEC.Width - 1, pbLogoITEC.Height - 1);
                e.Graphics.DrawLine(lapiz, 0, pbLogoITEC.Height - 1, pbLogoITEC.Width - 1, pbLogoITEC.Height - 1);
            }
        }

        private void pbLogoITEC_Resize(object sender, EventArgs e)
        {
            pbLogoITEC.Invalidate();
        }
    }
}
