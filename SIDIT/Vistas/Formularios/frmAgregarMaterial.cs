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
    public partial class frmAgregarMaterial : Form
    {
        public frmAgregarMaterial()
        {
            InitializeComponent();
        }

        private void icbtnSalir_Click(object sender, EventArgs e)
        {
            icbtnSalir.Cursor = Cursors.Hand;
            this.Close();
        }

        private void btnAggRegistro_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(cbCategoria.Text) || string.IsNullOrEmpty(cbMarcas.Text) || string.IsNullOrEmpty(txtModelo.Text) || string.IsNullOrEmpty(dtpFechaIng.Text) || string.IsNullOrEmpty(txtCantidad.Text))
                {
                    MessageBox.Show("Solo el campo 'Descripción' puede estar vacío", "Error");
                }
                else
                {
                    Material m = new Material();
                    m.NombreMaterial = txtNombre.Text;
                    m.IdMarca = Convert.ToInt32(cbMarcas.SelectedValue);
                    m.Modelo = txtModelo.Text;
                    m.IdCategoria = Convert.ToInt32(cbCategoria.SelectedValue);
                    m.Descripcion = txtDescripcion.Text;
                    m.FechaIngreso = dtpFechaIng.Value;
                    m.Cantidad = Convert.ToInt32(txtCantidad.Text);
                    m.InsertarMaterial();
                    

                    MessageBox.Show("El registro fue exitoso", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo completar el registro" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarCategorias()
        {
            cbCategoria.DataSource = null;
            cbCategoria.DataSource = Categoria.CargarCategorias();
            cbCategoria.DisplayMember = "Nombre";
            cbCategoria.ValueMember = "Id";
            cbCategoria.SelectedIndex = -1;
        }
        private void MostrarMarcas()
        {
            cbMarcas.DataSource = null;
            cbMarcas.DataSource = Marca.CargarMarcas();
            cbMarcas.DisplayMember = "Nombre";
            cbMarcas.ValueMember = "Id";
            cbMarcas.SelectedIndex = -1;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCantidad.Clear();
            txtNombre.Clear();
            txtModelo.Clear();
            cbCategoria.SelectedIndex = -1;
            txtDescripcion.Clear();
            cbMarcas.SelectedIndex = -1;
        }

        private void frmAgregarMaterial_Load(object sender, EventArgs e)
        {
            MostrarCategorias();
            MostrarMarcas();
        }
    }
}
