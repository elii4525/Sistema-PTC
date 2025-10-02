using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vistas.Controles;

namespace Vistas.Formularios
{
    public partial class frmMenuJefatura : Form
    {
        public frmMenuJefatura()
        {
            InitializeComponent();
        }

        //Mostrar formularios
        public void MostrarFormInvenJEnPanel()
        {
            pnlContenedorJ.Controls.Clear(); //Limpia lo que haya antes

            //Crear la instancia
            frmInventarioJefatura inventarioJ = new frmInventarioJefatura();

            //La propiedad TopLevel basicamente es la que permite que los form sean independientes
            //Al ser false, se le quita como esa independencia y le permite ser un control mas dentro 
            //de un panel, un groupBox y asi. Siginifica que ya no puede moverse ni tiene esos controles
            //que una ventana normal tiene.
            inventarioJ.TopLevel = false;
            inventarioJ.FormBorderStyle = FormBorderStyle.None;
            inventarioJ.Dock = DockStyle.Fill;    //Para que ocupe todo el panel.

            //Añado el form inventJ al panel contenedor
            pnlContenedorJ.Controls.Add(inventarioJ);
            inventarioJ.Show(); //Ya se muestra el formulario

            //Cambia los colores para el panel activo
            icbtnInventarioJ.BackColor = Color.FromArgb(18, 18, 18);
            icbtnInventarioJ.IconColor = Color.White;
            icbtnInventarioJ.ForeColor = Color.White;

            lblTituloInventarioJ.Visible = true;

            //Restaura los colores de solicitud
            ColoresSolicitud();
            //Consumo
            ColoresConsumo();
            //Usuario
            ColoresUsuario();

        }

        public void MostrarFormSoliJEnPanel()
        {
            //Limpiar lo q haya antes
            pnlContenedorJ.Controls.Clear();

            //Crear la instancia 
            frmSolJefatura solicitudJ = new frmSolJefatura();

            solicitudJ.TopLevel = false;
            solicitudJ.FormBorderStyle = FormBorderStyle.None;
            solicitudJ.Dock = DockStyle.Fill;
            //Añadir form
            pnlContenedorJ.Controls.Add(solicitudJ);
            //Mostramos el formulario
            solicitudJ.Show();

            //Indica panel activo
            icbtnSolicitudesJ.BackColor = Color.FromArgb(18, 18, 18);
            icbtnSolicitudesJ.IconColor = Color.White;
            icbtnSolicitudesJ.ForeColor = Color.White;
            lblTituloSolicitudJ.Visible = true;


            //Restablecer colores de paneles
            //Inventario
            ColoresInventario();
            //Consumo
            ColoresConsumo();
            //Usuario
            ColoresUsuario();
        }

        public void MostrarFormConsumoJEnPanel()
        {
            pnlContenedorJ.Controls.Clear();
            frmConsumoAmbos consumoJ = new frmConsumoAmbos();
            consumoJ.TopLevel = false;
            consumoJ.FormBorderStyle = FormBorderStyle.None;
            consumoJ.Dock = DockStyle.Fill;
            pnlContenedorJ.Controls.Add(consumoJ);
            consumoJ.Show();

            //Indicar panel activo
            icbtnConsumoJ.BackColor = Color.FromArgb(18, 18, 18);
            icbtnConsumoJ.IconColor = Color.White;
            icbtnConsumoJ.ForeColor = Color.White;
            lblTituloConsumoJ.Visible = true;

            //Restablecer colores de paneles 
            //Inventario
            ColoresInventario();
            //Solicitud
            ColoresSolicitud();
            //Usuario
            ColoresUsuario();
        }

        public void MostrarFormUsuariosEnPanel()
        {
            pnlContenedorJ.Controls.Clear();
            frmUsuarios usuario = new frmUsuarios();
            usuario.TopLevel = false;
            usuario.FormBorderStyle = FormBorderStyle.None;
            usuario.Dock = DockStyle.Fill;
            pnlContenedorJ.Controls.Add(usuario);
            usuario.Show();

            //Indicar panel activo
            icbtnUsuario.BackColor = Color.FromArgb(18, 18, 18);
            icbtnUsuario.IconColor = Color.White;
            icbtnUsuario.ForeColor = Color.White;
            lblTituloUsuarios.Visible = true;

            //Restablecer colores de paneles 
            //Inventario
            ColoresInventario();
            //Solicitud
            ColoresSolicitud();
            //Consumo
            ColoresConsumo();
        }

        //Colores 
        private void ColoresSolicitud()
        {
            icbtnSolicitudesJ.BackColor = Color.White;
            icbtnSolicitudesJ.IconColor = Color.Black;
            icbtnSolicitudesJ.ForeColor = Color.Black;

            //Tmb dejo indicado q el titulo debe ser false
            lblTituloSolicitudJ.Visible = false;
        }

        private void ColoresConsumo()
        {
            icbtnConsumoJ.BackColor = Color.White;
            icbtnConsumoJ.IconColor = Color.Black;
            icbtnConsumoJ.ForeColor = Color.Black;
            lblTituloConsumoJ.Visible = false;
        }

        private void ColoresInventario()
        {
            icbtnInventarioJ.BackColor = Color.White;
            icbtnInventarioJ.IconColor = Color.Black;
            icbtnInventarioJ.ForeColor = Color.Black;

            lblTituloInventarioJ.Visible = false;
        }

        private void ColoresUsuario()
        {
            icbtnUsuario.BackColor = Color.White;
            icbtnUsuario.IconColor = Color.Black;
            icbtnUsuario.ForeColor = Color.Black;

            lblTituloUsuarios.Visible = false;
        }


        //Load
        private void frmMenuJefatura_Load(object sender, EventArgs e)
        {
            MostrarFormInvenJEnPanel();
            pnlBarraSuperior.BringToFront();
            pnlBarraLateral.BringToFront();
            pbLogoITEC.BringToFront();

        }

        //Lineas dibujadas
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
                e.Graphics.DrawLine(lapiz, pnlBarraLateral.Width - 1, 0, pnlBarraLateral.Width - 1, pnlBarraLateral.Height - 1);
            }
        }

        private void pnlBarraLateral_Resize(object sender, EventArgs e)
        {
            pnlBarraLateral.Invalidate();
        }

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

        //Eventos click de los botones
        private void icbtnInventarioJ_Click(object sender, EventArgs e)
        {
            MostrarFormInvenJEnPanel();
        }

        private void icbtnSolicitudesJ_Click(object sender, EventArgs e)
        {
            MostrarFormSoliJEnPanel();
        }

        private void icbtnConsumoJ_Click(object sender, EventArgs e)
        {
            MostrarFormConsumoJEnPanel();
        }

        private void icbtnUsuario_Click(object sender, EventArgs e)
        {
            MostrarFormUsuariosEnPanel();
        }

        private void icpbConfiguracion_Click(object sender, EventArgs e)
        {
            Configuracion c = new Configuracion();
            c.Dock = DockStyle.Fill;
            pnlContenedorJ.Controls.Clear();
            pnlContenedorJ.Controls.Add(c);

            pnlContenedorJ.Controls.Clear(); 
            frmInventarioJefatura inventarioJ = new frmInventarioJefatura();
            inventarioJ.TopLevel = false;
            inventarioJ.FormBorderStyle = FormBorderStyle.None;
            inventarioJ.Dock = DockStyle.Fill;
            pnlContenedorJ.Controls.Add(inventarioJ);
            inventarioJ.Show(); 
        }

        private void icpbConfiguracion_Click(object sender, EventArgs e)
        {
            Configuracion uc = new Configuracion();
            FrmContenedorUC ven = new FrmContenedorUC(uc);

            if (ven.ShowDialog() == DialogResult.OK)
            {
                uc.Show();
            }

        }
    }
}
