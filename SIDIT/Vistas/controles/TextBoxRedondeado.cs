using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Vistas.controles
{
    public partial class TextBoxRedondeado : UserControl
    {
        private Color borderColor = Color.White;
        private int borderSize = 2;
        private bool underlinedStyle = false;
        private bool soloNumeros = false;
        private bool soloLetras = false;
        private int borderRadius = 0;

        public TextBoxRedondeado()
        {
            InitializeComponent();
            textBox1.KeyPress += TextBox1_KeyPress;
            textBox1.KeyDown += TextBox1_KeyDown;
        }

        public new void Focus() => textBox1.Focus();

        // Bloquea cortar, copiar y pegar con Ctrl
        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.C || e.KeyCode == Keys.V || e.KeyCode == Keys.X))
                e.SuppressKeyPress = true;
        }

        public bool SoloNumeros
        {
            get => soloNumeros;
            set => soloNumeros = value;
        }

        public bool SoloLetras
        {
            get => soloLetras;
            set => soloLetras = value;
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (SoloNumeros && !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla, sin MessageBox para no molestar
            }

            if (SoloLetras && !char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        public int MaxLength
        {
            get => textBox1.MaxLength;
            set => textBox1.MaxLength = value;
        }

        public Color BorderColor
        {
            get => borderColor;
            set { borderColor = value; Invalidate(); }
        }

        public int BorderSize
        {
            get => borderSize;
            set { borderSize = value; Invalidate(); }
        }

        public bool ReadOnly
        {
            get => textBox1.ReadOnly;
            set => textBox1.ReadOnly = value;
        }

        public bool UnderlinedStyle
        {
            get => underlinedStyle;
            set { underlinedStyle = value; Invalidate(); }
        }

        public bool PasswordChar
        {
            get => textBox1.UseSystemPasswordChar;
            set => textBox1.UseSystemPasswordChar = value;
        }

        public bool Multiline
        {
            get => textBox1.Multiline;
            set => textBox1.Multiline = value;
        }

        public void Clear() => textBox1.Clear();

        public override Color BackColor
        {
            get => base.BackColor;
            set { base.BackColor = value; textBox1.BackColor = value; }
        }

        public override Font Font
        {
            get => base.Font;
            set
            {
                base.Font = value;
                textBox1.Font = value;
                if (DesignMode) UpdateControlHeight();
            }
        }

        public string Texts
        {
            get => textBox1.Text;
            set => textBox1.Text = value;
        }

        public HorizontalAlignment TextAlign
        {
            get => textBox1.TextAlign;
            set => textBox1.TextAlign = value;
        }

        public int BorderRadius
        {
            get => borderRadius;
            set
            {
                if (value >= 0)
                {
                    borderRadius = value;
                    Invalidate();
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (Width <= 0 || Height <= 0) return; // Evita error en diseñador

            Graphics graph = e.Graphics;
            graph.SmoothingMode = SmoothingMode.AntiAlias;

            if (BorderRadius > 1)
            {
                Rectangle rectBorderSmooth = ClientRectangle;
                Rectangle rectBorder = Rectangle.Inflate(rectBorderSmooth, -borderSize, -borderSize);
                int smoothSize = borderSize > 0 ? borderSize : 1;

                // Asegura radio válido
                int safeRadiusOuter = Math.Max(0, borderRadius);
                int safeRadiusInner = Math.Max(0, borderRadius - borderSize);

                using (GraphicsPath pathBorderSmooth = GetFigurePath(rectBorderSmooth, safeRadiusOuter))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, safeRadiusInner))
                using (Pen penBorderSmooth = new Pen(Parent?.BackColor ?? BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    Region = new Region(pathBorderSmooth);
                    penBorder.Alignment = PenAlignment.Center;

                    if (underlinedStyle)
                    {
                        graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                        graph.DrawLine(penBorder, 0, Height - 1, Width, Height - 1);
                    }
                    else
                    {
                        graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                        graph.DrawPath(penBorder, pathBorder);
                    }
                }
            }
            else
            {
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    if (underlinedStyle)
                    {
                        graph.DrawLine(penBorder, 0, Height - 1, Width, Height - 1);
                    }
                    else
                    {
                        graph.DrawRectangle(penBorder, 0, 0, Width - 0.5F, Height - 0.5F);
                    }
                }
            }
        }

        private void SetTextBoxRoundedRegion()
        {
            GraphicsPath pathTxt;
            if (Multiline)
            {
                pathTxt = GetFigurePath(textBox1.ClientRectangle, Math.Max(0, borderRadius - borderSize));
            }
            else
            {
                pathTxt = GetFigurePath(textBox1.ClientRectangle, Math.Max(0, borderSize * 2));
            }
            textBox1.Region = new Region(pathTxt);
        }

        private GraphicsPath GetFigurePath(Rectangle rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            // Protege de valores inválidos
            if (rect.Width <= 0 || rect.Height <= 0 || curveSize <= 0)
            {
                path.AddRectangle(rect);
                return path;
            }

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            UpdateControlHeight();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }

        private void UpdateControlHeight()
        {
            if (!textBox1.Multiline)
            {
                int txtHeight = TextRenderer.MeasureText("Text", Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.Height = txtHeight;
                Height = textBox1.Height + Padding.Top + Padding.Bottom;
                textBox1.Multiline = false;
            }
        }
    }
}


