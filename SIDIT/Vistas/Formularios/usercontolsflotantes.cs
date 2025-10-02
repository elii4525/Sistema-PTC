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
    public partial class FrmContenedorUC : Form
    {
        public FrmContenedorUC(UserControl control) // 👈 Esto es el constructor
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(control.Width + 20, control.Height + 40);
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // Agregamos el UserControl al form
            control.Dock = DockStyle.Fill;
            this.Controls.Add(control);
        }
    }

}
