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
    public partial class frmUsuarios : Form
    {
        private Button botonSeleccionado;

        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void BotonActivado(object boton)
        {
            if (boton != null)
            {
                DesactivarBoton();
                botonSeleccionado = (Button)boton;
                botonSeleccionado.FlatAppearance.MouseOverBackColor = Color.Transparent;
                botonSeleccionado.FlatAppearance.MouseDownBackColor = Color.Transparent;
                botonSeleccionado.Invalidate();
            }
        }

        private void DesactivarBoton()
        {
            if (botonSeleccionado != null)
            {
                botonSeleccionado.Invalidate();
                botonSeleccionado = null;
            }
        }

        //private void icbtnVerMaterial_Click(object sender, EventArgs e)
        //{
        //    BotonActivado(sender);
        //    MostrarUserControl(new frmListaInventario());
        //}
        private void MostrarUserControl(UserControl frm)
        {
            pnlContenedorUC.Controls.Clear();
            frm.Dock = DockStyle.Fill;
            pnlContenedorUC.Controls.Add(frm);
            frm.Show();
        }

        private void DibujarLinea_Paint(object sender, PaintEventArgs e)
        {
            Button botonLinea = sender as Button;
            if (botonLinea == null) return;
            using (Pen lapiz = new Pen(Color.White, 3))
            {
                e.Graphics.DrawLine(lapiz, 0, botonLinea.Height - 7, botonLinea.Width - 1, botonLinea.Height - 7);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            BotonActivado(sender);
            MostrarUserControl(new frmAgregarUsuario());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            BotonActivado(sender);
            MostrarUserControl(new frmEliminarUsuario());
        }

        private void btnVerUsuarios_Click(object sender, EventArgs e)
        {
            BotonActivado(sender);
            MostrarUserControl(new frmVerUsuarios());
        }

        private void btnAgregar_Paint(object sender, PaintEventArgs e)
        {
            if (botonSeleccionado == sender) DibujarLinea_Paint(sender, e);
        }

        private void btnEliminar_Paint(object sender, PaintEventArgs e)
        {
            if (botonSeleccionado == sender) DibujarLinea_Paint(sender, e);
        }

        private void btnVerUsuarios_Paint(object sender, PaintEventArgs e)
        {
            if (botonSeleccionado == sender) DibujarLinea_Paint(sender, e);
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            MostrarUserControl(new frmAgregarUsuario());
            BotonActivado(btnAgregar);

            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.BackColor = pnlContenedorUC.BackColor;
            btnAgregar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnAgregar.FlatAppearance.MouseDownBackColor = Color.Transparent;

            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.BackColor = pnlContenedorUC.BackColor;
            btnEliminar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnEliminar.FlatAppearance.MouseDownBackColor = Color.Transparent;

            btnVerUsuarios.FlatStyle = FlatStyle.Flat;
            btnVerUsuarios.FlatAppearance.BorderSize = 0;
            btnVerUsuarios.BackColor = pnlContenedorUC.BackColor;
            btnVerUsuarios.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnVerUsuarios.FlatAppearance.MouseDownBackColor = Color.Transparent;
        }
    }
}
