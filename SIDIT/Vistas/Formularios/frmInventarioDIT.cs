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

    /// <summary>
    /// Se debe solucionar error de panel border, pasa que cuando los controles se acomodan, el panel al ser fijo se esconde ya que otro lo cubre.
    /// Se debe solucionar que cada que se toca un boton (de pestñas) al "reinicio" se puede ver el color blanquesito que muestra el size del boton.
    /// </summary>
    public partial class frmInventarioDIT : Form
    {
        //IconButton porque ese es el control que utilice en el formulario
        private IconButton botonSeleccionado;
        private Panel bordeInferior;
        public frmInventarioDIT()
        {
            InitializeComponent();

            
            bordeInferior = new Panel();
            bordeInferior.Size = new Size(209, 2);
            //pnlContenedorPestañas.Controls.Add(bordeInferior);
            bordeInferior.BringToFront();
            botonSeleccionado.Controls.Add(bordeInferior);



            //Aqui llamo  al metodo para que al abrirse el boton de ver material sea el primero que se muestre
            BotonActivado(icbtnVerMaterial);
        }

        private void BotonActivado(object boton)
        {
            if (boton != null)
            {
                DesactivarBoton();

                //Aqui se debe arreglar el error de parapadeos y en si ambos errores.

                //botonSeleccionado = (IconButton)boton;
                //botonSeleccionado.ForeColor = Color.FromArgb(255, 246, 224);
                //botonSeleccionado.IconColor = Color.FromArgb(255, 246, 224);

                //bordeInferior.BackColor = Color.FromArgb(255, 246, 224);
                //En este le damos la ubicacion de botonSeleccionado
                //bordeInferior.Location = new Point(botonSeleccionado.Location.X, 73);
                //bordeInferior.Visible = true;
                bordeInferior.BringToFront();
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
