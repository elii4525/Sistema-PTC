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
            pbInventarioD2.Show();
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
            pnlInventarioD.BackColor = Color.FromArgb(18, 18, 18);
            pbInventarioD2.Visible = true;
            lblInventarioD.ForeColor = Color.White;
            lblTituloInventarioD.Visible = true;

            //Restaura los colores de solicitud
            pnlSolicitudD.BackColor = Color.White;
            lblSolicitudD.ForeColor = Color.Black;
            pbSolicitudD2.Visible = false;
            pbSolicitudD.Visible = true;
            lblTituloSolicitudD.Visible = false;
            //Consumo
            pnlConsumoD.BackColor = Color.White;
            lblConsumoD.ForeColor = Color.Black;
            pbConsumoD.Visible = true;
            pbConsumoD2.Visible = false;
            lblTituloConsumoD.Visible = false;
            
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
            pnlSolicitudD.BackColor = Color.FromArgb(18, 18, 18);
            pbSolicitudD.Visible = false;
            pbSolicitudD2.Visible = true;
            lblSolicitudD.ForeColor = Color.White;
            lblTituloSolicitudD.Visible = true;


            //Restablecer colores de paneles
            //Inventario
            pnlInventarioD.BackColor = Color.White;
            pbInventarioD.Visible = true;
            pbInventarioD2.Visible = false;
            lblInventarioD.ForeColor = Color.Black;
            lblTituloInventarioD.Visible = false;
            //Consumo
            pnlConsumoD.BackColor = Color.White;
            lblConsumoD.ForeColor = Color.Black;
            pbConsumoD.Visible = true;
            pbConsumoD2.Visible = false;
            lblTituloConsumoD.Visible = false;
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
            pnlConsumoD.BackColor = Color.FromArgb(18, 18, 18);
            lblConsumoD.ForeColor = Color.White;
            pbConsumoD.Visible = false;
            pbConsumoD2.Visible = true;
            lblTituloConsumoD.Visible = true;

            //Restablecer colores de paneles 
            //Inventario
            pnlInventarioD.BackColor = Color.White;
            pbInventarioD.Visible = true;
            pbInventarioD2.Visible = false;
            lblInventarioD.ForeColor = Color.Black;
            lblTituloInventarioD.Visible = false;
            //Solicitud
            pnlSolicitudD.BackColor = Color.White;
            lblSolicitudD.ForeColor = Color.Black;
            pbSolicitudD2.Visible = false;
            pbSolicitudD.Visible = true;
            lblTituloSolicitudD.Visible = false;
        }

        private void pbInventarioD2_Click(object sender, EventArgs e)
        {
            MostrarFormInvenDEnPanel();
        }



        private void pbSolicitudD_Click(object sender, EventArgs e)
        {
            MostrarFormSoliDEnPanel();
        }

        private void pbInventarioD_Click(object sender, EventArgs e)
        {
            MostrarFormInvenDEnPanel();
        }

        private void pbConsumoD_Click(object sender, EventArgs e)
        {
            MostrarFormConsumoDEnPanel();
        }

        private void lblInventarioD_Click(object sender, EventArgs e)
        {
            MostrarFormInvenDEnPanel();
        }

        private void lblSolicitudD_Click(object sender, EventArgs e)
        {
            MostrarFormSoliDEnPanel();
        }

        private void lblConsumoD_Click(object sender, EventArgs e)
        {
            MostrarFormConsumoDEnPanel();
        }
    }
}
