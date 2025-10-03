using Modelos.Entidades;
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
    public partial class frmAggCategoria : Form
    {
        public frmAggCategoria()
        {
            InitializeComponent();
        }

        
        private void icbtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            icbtnSalir.Cursor = Cursors.Hand;
        }

        private void btnAggCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCategoria.Text))
                {
                    MessageBox.Show("No se puede agregar un campo vacío", "Error");
                }
                else
                {
                    Categoria c = new Categoria();
                    c.NombreCategoria = txtCategoria.Text;
                    c.InsertarCategorias();
                    txtCategoria.Clear();

                    MessageBox.Show("El registro fue exitoso", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo añadir la categoria" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pnlAggCategorias_Paint(object sender, PaintEventArgs e)
        {
            label1.Font = Helper.FuenteHelper.ObtenerFuente(8);
            label5.Font = Helper.FuenteHelper.ObtenerFuente(15);
        }
    }
}
