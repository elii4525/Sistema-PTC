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
    public partial class frmAggMarca : Form
    {
        public frmAggMarca()
        {
            InitializeComponent();
        }

        private void icbtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            icbtnSalir.Cursor = Cursors.Hand;
        }

        private void btnAggMarca_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMarca.Text))
                {
                    MessageBox.Show("No se puede agregar un campo vacío", "Error");
                }
                else
                {
                    Marca m = new Marca();
                    m.NombreMarca = txtMarca.Text;
                    m.InsertarMarca();
                    txtMarca.Clear();

                    MessageBox.Show("El registro fue exitoso", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo añadir la Marca" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
