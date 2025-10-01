using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelos.Entidades;

namespace Vistas.Formularios
{
    public partial class frmActualizarMaterial : Form
    {
        public frmActualizarMaterial()
        {
            InitializeComponent();
        }

  

        private void icbtnSalir_Click(object sender, EventArgs e)
        {
            
            this.Close();
            icbtnSalir.Cursor = Cursors.Hand;
            
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Material m = new Material();
            m.NombreMaterial = txtNombre.Text;
            m.Cantidad = int.Parse(txtCantidad.Text);
            m.IdMaterial = int.Parse(dgvMaterial.CurrentRow.Cells[0].Value.ToString());

            if (m.ActualizarMaterial() == true )
            {
                MostrarMateriales();
                txtCantidad.Clear();
                txtNombre.Clear();
                //frmActualizarMaterial frm = new frmActualizarMaterial();
                //frm.FormClosed += (s, args) =>
                //MostrarMateriales();  //La s y args son los parametros del evento. s = sender.
            }
            else
            {
                MessageBox.Show("Hubo un error", "Error");
            }
        }

        private void MostrarMateriales()
        {
            dgvMaterial.DataSource = null;
            dgvMaterial.DataSource = Material.CargarMateriales();
        }

        private void dgvMaterial_DoubleClick(object sender, EventArgs e)
        {
            txtNombre.Text = dgvMaterial.CurrentRow.Cells[1].Value.ToString();
            txtCantidad.Text = dgvMaterial.CurrentRow.Cells[2].Value.ToString();
        }

        private void frmActualizarMaterial_Load(object sender, EventArgs e)
        {
            MostrarMateriales();
            
        }
    }
}
