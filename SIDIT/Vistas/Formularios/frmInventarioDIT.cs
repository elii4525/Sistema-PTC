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
        private frmListaInventario frmLista = null;
        private frmEliminarMaterial frmEliminar = null;
        private frmAggMaterial frmAgg = null;


        public frmInventarioDIT()
        {
            InitializeComponent();

        }

        private void BotonActivado(object boton)
        {
            if (boton != null)  //Verifica que el objeto que se pasó no sea null evitando errores.
            {
                DesactivarBoton();

                botonSeleccionado = (IconButton)boton;
                botonSeleccionado.FlatAppearance.MouseOverBackColor = Color.Transparent;
                botonSeleccionado.FlatAppearance.MouseDownBackColor = Color.Transparent;
                //El boton seleccionado es el que disparó el evento, este tiene un paint predeterminado, so lo que hago es forzarlo a que
                //se repinte, o sea el evento Paint que yo hice en codigo se ejecute.
                //El invalidate lo marca como invalido haciendo que se llame de nuevo al evento paint (no es que Invalidate lo repinta
                //directamente).
                botonSeleccionado.Invalidate();
            }
               
        }

        private void DesactivarBoton()
        {
            //Verifica que si haya un boton activo
            if (botonSeleccionado != null)
            {
                //Aqui nuevamente invalido para que se ejecute de nuevo el evento paint. 
                //Esto borra la linea del boton anterior
                botonSeleccionado.Invalidate(); 
                //Esto basicamente indica que no hay ningun boton seleccionado.
                botonSeleccionado = null;
            }
        }


        //Llamar metodo botonSeleccionado
        private void icbtnVerMaterial_Click(object sender, EventArgs e)
        {

            //Sender es la referencia al objeto que dispara el evento. 
            //O sea, en este caso el metodo afecta al objeto que disparó este evento, o sea el btn.
            //Hacer esto ayuda a no hacer un metodo por btn.
            BotonActivado(sender);
            MostrarUCLista();
           
        }

        private void icbtnAggMaterial_Click(object sender, EventArgs e)
        {
            MostrarUCAgg();
                BotonActivado(sender);
        }

        private void icbtnActualizarYEliminarMaterial_Click(object sender, EventArgs e)
        {
 
            BotonActivado(sender);
            MostrarUCEliminar();
   
        }


        private void MostrarUCLista()
        {
            if (frmLista == null)
            {
                frmLista = new frmListaInventario();
                frmLista.Dock = DockStyle.Fill;

            }
                pnlContenedorUC.Controls.Clear();
                frmLista.Dock = DockStyle.Fill;
                pnlContenedorUC.Controls.Add(frmLista);
                frmLista.Show();
        }
           

        private void MostrarUCAgg()
        {
           if(frmAgg == null)
            {
                frmAgg = new frmAggMaterial();
                frmAgg.Dock = DockStyle.Fill;
            }
            
            pnlContenedorUC.Controls.Clear();
            frmAgg.Dock = DockStyle.Fill;
            pnlContenedorUC.Controls.Add(frmAgg);
            frmAgg.Show();
        }
        private void MostrarUCEliminar()
        {
            if (frmEliminar == null)
            {
                frmEliminar = new frmEliminarMaterial();
                frmEliminar.Dock = DockStyle.Fill;
            }
            
            pnlContenedorUC.Controls.Clear();
            pnlContenedorUC.Controls.Add(frmEliminar);
            frmEliminar.Show();
        }


        

        private void frmInventarioDIT_Load(object sender, EventArgs e)
        {

            
            BotonActivado(icbtnVerMaterial);
            icbtnActualizarYEliminarMaterial.FlatAppearance.MouseOverBackColor = Color.Transparent;
            icbtnActualizarYEliminarMaterial.FlatAppearance.MouseDownBackColor = Color.Transparent;

            icbtnAggMaterial.FlatAppearance.MouseOverBackColor = Color.Transparent;
            icbtnAggMaterial.FlatAppearance.MouseDownBackColor = Color.Transparent;

            icbtnVerMaterial.FlatAppearance.MouseOverBackColor = Color.Transparent;
            icbtnVerMaterial.FlatAppearance.MouseDownBackColor = Color.Transparent;
        }


        //Estos son los metodos donde pinto la linea a los botones.
        private void icbtnVerMaterial_Paint(object sender, PaintEventArgs e)
        {
            if(botonSeleccionado == sender)
            {
                DibujarLinea_Paint(sender, e);
            }
            
        }

        private void icbtnAggMaterial_Paint(object sender, PaintEventArgs e)
        {
            if (botonSeleccionado == sender)
            {
                DibujarLinea_Paint(sender, e);
            }
        }

        private void icbtnActualizarYEliminarMaterial_Paint(object sender, PaintEventArgs e)
        {
            if (botonSeleccionado == sender)
            {
                DibujarLinea_Paint(sender, e);
            }
        }



        // Metodo para no dibujar en cada boton
        private void DibujarLinea_Paint(object sender, PaintEventArgs e)
        {
            //El 'PaintEventArgs e' me da acceso al objeto Graphics

            //Aqui convierto el sender en un IconButton
            //Permite que si el que llamó al evento no es un IconButton se evitan errores y no hace nada.
            IconButton botonLinea = sender as IconButton;
            if (botonLinea == null) return;
            

            //Using permite liberar los recursos del sistema cuando Pen se termina de usar (necesario).
            using (Pen lapiz = new Pen(Color.White, 3))
            {
                //Graphics es como el lienzo donde se dibuja la linea, lo que esta entre parentesis son las coordenadas de incio y fin de 
                //la linea. (pen, x1, y1, x2, y2) Basicamente son los dos puntos entre los que se diuja la linea.
                e.Graphics.DrawLine(lapiz, 0, botonLinea.Height - 7, botonLinea.Width - 1, botonLinea.Height - 7);
            }
        }
    }

}
