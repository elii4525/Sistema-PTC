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
using FontAwesome.Sharp;

namespace Vistas.Formularios
{
    public partial class frmInventarioDIT : Form
    {
        //IconButton porque ese es el control que utilice en el formulario
        private IconButton botonSeleccionado;
        private Panel bordeInferiorbtn1;
        private Panel bordeInferiorbtn2;
        private Panel bordeInferiorbtn3;
        public frmInventarioDIT()
        {
            InitializeComponent();

            
            bordeInferiorbtn1 = new Panel();
            bordeInferiorbtn1.Size = new Size(168, 2);
            pnlContenedorPestañas.Controls.Add(bordeInferiorbtn1);

            bordeInferiorbtn2 = new Panel();
            bordeInferiorbtn2.Size = new Size(188, 2);
            pnlContenedorPestañas.Controls.Add(bordeInferiorbtn2);

            bordeInferiorbtn3 = new Panel();
            bordeInferiorbtn3.Size = new Size(202, 2);
            pnlContenedorPestañas.Controls.Add(bordeInferiorbtn3);


            IconButton btn1 = new IconButton();
            btn1.

            //Aqui llamo  al metodo para que al abrirse el boton de ver material sea el primero que se muestre
            BotonActivado(icbtnVerMaterial);
        }

        private void BotonActivado(object boton)
        {
            if (boton != null)
            {
                DesactivarBoton();
                botonSeleccionado = (IconButton)boton;
                botonSeleccionado.ForeColor = Color.FromArgb(255, 246, 224);
                botonSeleccionado.IconColor = Color.FromArgb(255, 246, 224);

                
                bordeInferiorbtn1.BackColor = Color.FromArgb(255, 246, 224);
                //En este le damos la ubicacion de botonSeleccionado
                bordeInferiorbtn1.Location = new Point(botonSeleccionado.Location.X, 73);
                bordeInferiorbtn1.Visible = true;
                bordeInferiorbtn1.BringToFront();
            }
        }

        private void DesactivarBoton()
        {
            //Con este if estamos diciendo = Si hay un boton seleccionado haz esto ->
            if (botonSeleccionado != null)
            {
                botonSeleccionado.ForeColor = Color.White;
                botonSeleccionado.IconColor = Color.White;
            }
        }



        private void icbtnVerMaterial_Click(object sender, EventArgs e)
        {
            //Sender es la referencia al objeto que dispara el evento. 
            //O sea, en este caso el metodo afecta al objeto que disparó este evento, o sea el btn.
            //Hacer esto ayuda a no hacer un metodo por btn.
            BotonActivado(sender);

            icbtnVerMaterial.FlatAppearance.MouseOverBackColor = Color.Transparent;
            icbtnVerMaterial.FlatAppearance.MouseDownBackColor = Color.Transparent;

            MostrarUserControl(new frmListaInventario());

        }

        private void icbtnAggMaterial_Click(object sender, EventArgs e)
        {
            BotonActivado(sender);

            icbtnAggMaterial.FlatAppearance.MouseOverBackColor = Color.Transparent;
            icbtnAggMaterial.FlatAppearance.MouseDownBackColor = Color.Transparent;
        }

        private void icbtnActualizarYEliminarMaterial_Click(object sender, EventArgs e)
        {
            BotonActivado(sender);

            //Permiten que cuando pase el mouse y haga click no se vea el recuadro de color q sale.
            icbtnActualizarYEliminarMaterial.FlatAppearance.MouseOverBackColor = Color.Transparent;
            icbtnActualizarYEliminarMaterial.FlatAppearance.MouseDownBackColor = Color.Transparent;
        }

        private void MostrarUserControl(UserControl frm)
        {
                pnlContenedorUC.Controls.Clear();
                frm.Dock = DockStyle.Fill;
                pnlContenedorUC.Controls.Add(frm);
                frm.Show();
        }

        private void frmInventarioDIT_Load(object sender, EventArgs e)
        {
            MostrarUserControl(new frmListaInventario());
        }
    }

}
