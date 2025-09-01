using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas.ControlesPersonalizados
{

    [DefaultEvent("_TextChanged")]
    public partial class UserControlControlesP : UserControl
    {
        public UserControlControlesP()
        {
            InitializeComponent();
        }


        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 2;
        private bool underlineStyle = false;
        private Color textEnfocado = Color.Red;
        private bool Enfocado = false;
        private int borderRadius = 0;

        //Constructores
        //Propiedades publicas que permiten modificar y leer las variables internas 
        //El invalidate(); basicamente invalida el control pq no esta actualizado, para que se vuelva a dibujar, haciendo 
        //que se dispare el evento OnPaint entrando asi, mi codigo que dibuja los nuevos valores para los bordes.
        //Basicamente solo permite que se puedan ocupar los valores nuevos del codigo para dibujar.
        //Permiten cambiar los valores desde el diseñador.
        public Color BorderColor { get => borderColor; set { borderColor = value; this.Invalidate(); } }
        public int BorderSize { get => borderSize; set { borderSize = value; this.Invalidate(); } }
        public bool UnderlineStyle { get => underlineStyle; set { underlineStyle = value; this.Invalidate(); } }
        public bool Enfocado1 { get => Enfocado; set => Enfocado = value; }
        



        //Anular metodos
        //Este metodo sobreescribe el método OnPaint que la clase base (UserControl) llama cuando Windows necesita dibujar el control.
        //Al sobreescribir es como agrego mi diseño
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e); //Llama al comportamiento original y borra/limpia el fondo.
            Graphics graph = e.Graphics; //Graphics es un objeto que nos permite dibujar lineas, rectangulos, etc.


            if(borderRadius > 1) //Si es asi entonces es un textBox redondeado
            {
                var rectBorderSmooth = this.ClientRectangle;
                var rectBorder = Rectangle.Inflate(rectBorderSmooth, -borderSize, -borderSize);
                int SmoothSize = borderSize > 0 ? borderSize : 1;

                using (GraphicsPath pathBorderSmooth = GetFigurePath(rectBorderSmooth, borderRadius))
                using (GraphicsPath pathBoorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                using (Pen penBorderSmooth = new Pen(this.Parent.BackColor, SmoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    //Dibujo de redondeados suaves
                    this.Region = new Region(pathBorderSmooth);
                    if (borderRadius > 15) RegionTextBoxRedondo();
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;

                    if(Enfocado) penBorder.Color = textEnfocado;
                    if (underlineStyle)
                    {
                        graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                        graph.SmoothingMode = SmoothingMode.None;
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    }
                    else
                    {
                        graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                        graph.DrawPath(penBorder, pathBorderSmooth);
                    }

                }

            }
            else //Cuadro de texto normal
            {
                //Dibujar borde
                //Pen dibuja un color y grosor.
                //using asegura que el Pen se elimine y libere recursos GDI al terminar (importante para no agotar recursos del sistema).
                //GDI es lo que Windows usa para dibujar ventanas, controles, líneas, etc.
                //Si se crea un Pen sin liberarlo, esos recursos no se liberan automáticamente
                //y si se dibuja muchas veces, el sistema puede quedarse sin recursos y el programa puede fallar.

                this.Region = new Region(this.ClientRectangle);
                using (Pen penBorde = new Pen(borderColor, borderSize))
                {
                    penBorde.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;  //Indica que el trazo quede dentro de los límites del rectángulo en vez de centrado en el borde
                                                                                       //es importante cuando borderSize es > 1: con Inset el borde no “se sale” del área visible.


                    if (!Enfocado)
                    {

                        if (underlineStyle)
                        {
                            //Se dibuja la linea horizontal
                            graph.DrawLine(penBorde, 0, this.Height - 1, this.Width, this.Height - 1);
                        }
                        else
                        {
                            //Se dibuja el rectangulo alrededor del control
                            graph.DrawRectangle(penBorde, 0, 0, this.Width - 0.5f, this.Height - 0.5f);
                        }
                    }
                    else
                    {
                        penBorde.Color = textEnfocado;

                        if (underlineStyle)
                        {
                            //Se dibuja la linea horizontal
                            graph.DrawLine(penBorde, 0, this.Height - 1, this.Width, this.Height - 1);
                        }
                        else
                        {
                            //Se dibuja el rectangulo alrededor del control
                            graph.DrawRectangle(penBorde, 0, 0, this.Width - 0.5f, this.Height - 0.5f);
                        }
                    }
                }
            }

                
        }

        private void RegionTextBoxRedondo()
        {
            GraphicsPath pathTxt;
            if(Multiline)
            {
                pathTxt = GetFigurePath(textBox1.ClientRectangle, borderRadius - borderSize);
                textBox1.Region = new Region(pathTxt);
            }
            else
            {
                pathTxt = GetFigurePath(textBox1.ClientRectangle, borderSize * 2);
                textBox1.Region = new Region(pathTxt);
            }
        }

        private GraphicsPath GetFigurePath(Rectangle rectangulo, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float tamañoCurva = radius * 2F;

            path.StartFigure();
            path.AddArc(rectangulo.X, rectangulo.Y, tamañoCurva, tamañoCurva, 180, 90);
            path.AddArc(rectangulo.Right - tamañoCurva, rectangulo.Y, tamañoCurva, tamañoCurva, 270, 90);
            path.AddArc(rectangulo.Right - tamañoCurva, rectangulo.Bottom - tamañoCurva, tamañoCurva, tamañoCurva, 0, 90);
            path.AddArc(rectangulo.X, rectangulo.Bottom - tamañoCurva, tamañoCurva, tamañoCurva, 90, 90);
            path.CloseFigure();
            return path;
        }

        //Protected override signifca que estoy sobreescribiendo el metodo de la clase base {UserControl}
        protected override void OnResize(EventArgs e)
        {

            //Este es un metodo que se llama automaticamente cada que se cambia el tamaño del control
            //arrastrando bordes, cambiando ancho o altura en tiempo de ejecución o diseño
            base.OnResize(e);
            if (this.DesignMode) //Esta linea indica si se esta dentro del diseñador de Visual
                ActualizarAltura();
            //Cuando se arrastra el control en el diseñador, se ajusta su altura automaticamente.
        }

        protected override void OnLoad(EventArgs e)
        {
            //cuando el control termina de cargarse en ejecución (cuando el formulario se va a mostrar).
            //A diferencia del OnResize que se activa cuando cambio el tamaño, este se activa una solaa vez, carga el control para 
            //inicializar su altura correctamente antes de mostrarlo.
            base.OnLoad(e);
            ActualizarAltura();
        }

        private void ActualizarAltura()
        {
            //Aplica solo si el textBox esta configurado para ser de una sola linea
            if (textBox1.Multiline == false)
            {

                //El TextRenderer.MeasureText mide la altura que ocupa el texto con esa fuente, sumandole 1 de altura para que el texto
                //no se corte. "Text" seria como solo un ejemplo para que se pueda medir la altura que ocupa.
                int txtAltura = TextRenderer.MeasureText("Text", this.Font).Height + 1;

                //Hace que si el txtBox es multiline se ajuste a la txtAltura.
                //Pone multiline true, para fijar el minimumSize y luego poner false.
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, txtAltura);
                textBox1.Multiline = false;

                //Esto ajusta el userControl para que la altura del txtBox y el padding encajen bien
                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
            }

        }


        //Eventos (Se estan poniendo como los eventos principales del textBox, no todos)
        public event EventHandler _TextChanged;


        //Propiedades del textBox

        [Category("Propiedades Personalizadas")]
        public bool PasswordChar
        {
            get { return textBox1.UseSystemPasswordChar; }
            set { textBox1.UseSystemPasswordChar = value; }
        }

        [Category("Propiedades Personalizadas")]
        public bool Multiline
        {
            get { return textBox1.Multiline; }
            set { textBox1.Multiline = value; }
        }

        [Category("Propiedades Personalizadas")]
        public override Color BackColor
        {
            get { return base.BackColor; }
            set { base.BackColor = value; textBox1.BackColor = value; }
        }

        [Category("Propiedades Personalizadas")]
        public override Color ForeColor
        {
            get { return base.ForeColor; }
            set { base.ForeColor = value; textBox1.ForeColor = value; }
        }

        [Category("Propiedades Personalizadas")]
        public override Font Font { get => base.Font; set { base.Font = value; textBox1.Font = value;
                if (this.DesignMode) ActualizarAltura();
            } }

        [Category("Propiedades Personalizadas")] //Esto agrupa las propiedades personalizadas en una categoria, haciendo mas facil de localizar en el cuadro de propiedades
        public string Texts
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        [Category("Propiedades Personalizadas")]
        public int BorderRadius 
        {
            get { return borderRadius; }
            set
            {
                if (value >= 0)
                {
                    borderRadius = value;
                    this.Invalidate(); //Redibuja el control ya que invoca el metodo paint
                }
            }
           
        }


        ///Eventos para el textBox (solo son algunos, se pueden poner mas)
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(_TextChanged !=null)
            {
                _TextChanged.Invoke(sender, e);
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            Enfocado = true;
            this.Invalidate();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            Enfocado = false;
            this.Invalidate();
        }
    }
}
