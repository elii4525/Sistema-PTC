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
    public partial class frmPruebaSolicitudes : Form
    {
        public frmPruebaSolicitudes()
        {
            InitializeComponent();
        }

        private int contador = 0;
        private int espacio = 10;



        private void CrearPanelDinamico(string[] valores)
        {
            Panel nuevoPanel = new Panel();
            nuevoPanel.Size = new Size(1040, 408);
            nuevoPanel.BackColor = Color.White;
            nuevoPanel.Location = new Point(200, btnAbrir.Height + 20 + (contador * (nuevoPanel.Height + espacio)));

            Label lbl1 = new Label { Text = valores[0], Location = new Point(50, 30) };
            Label lbl2 = new Label { Text = valores[1], Location = new Point(50, 150) };
            Label lbl3 = new Label { Text = valores[2], Location = new Point(200, 150) };
            Label lbl4 = new Label { Text = valores[3], Location = new Point(350, 150) };
            Label lbl5 = new Label { Text = valores[4], Location = new Point(500, 150) };
            

            nuevoPanel.Controls.Add(lbl1);
            nuevoPanel.Controls.Add(lbl2);
            nuevoPanel.Controls.Add(lbl3);
            nuevoPanel.Controls.Add(lbl4);
            nuevoPanel.Controls.Add(lbl5);
            

            this.Controls.Add(nuevoPanel);

            contador++;

        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            using (frmPedirMate frm = new frmPedirMate())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    // En este momento ya tienes los datos que el usuario llenó
                    CrearPanelDinamico(frm.Valores);
                }
            }
        }
    }
}
