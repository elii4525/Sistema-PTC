using Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas
{
    public partial class frmAggMaterial : UserControl
    {
        public frmAggMaterial()
        {
            InitializeComponent();
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

        private void pnlAggCategorias_Paint(object sender, PaintEventArgs e)
        {
            using (Pen lapiz = new Pen(Color.White, 3))
            {
                e.Graphics.DrawLine(lapiz, 0, pnlAggCategorias.Height - 1, 0, 0);
            }
        }

        private void frmAggMaterial_Load(object sender, EventArgs e)
        {
            pnlAggCategorias.BringToFront();
            pnlAggMarcas.BringToFront();
            MostrarCategorias();
            MostrarMarcas();
            MostrarRegistro();
        }

        private void pnlAggMarcas_Paint(object sender, PaintEventArgs e)
        {
            using (Pen lapiz = new Pen(Color.White, 3))
            {
                e.Graphics.DrawLine(lapiz, 0, pnlAggMarcas.Height - 1, 0, 0);
                e.Graphics.DrawLine(lapiz, 0, 3, pnlAggMarcas.Width - 1, 3);
            }
        }

        private void pnlAggCategorias_Resize(object sender, EventArgs e)
        {
            pnlAggCategorias.Invalidate(new Rectangle(0, 0, 3, pnlAggCategorias.Height));
        }

        private void pnlAggMarcas_Resize(object sender, EventArgs e)
        {
            pnlAggMarcas.Invalidate(new Rectangle(0, 0, 3, pnlAggMarcas.Height));
        }

        private void btnAggMarca_Click(object sender, EventArgs e)
        {
            try
            {
                Marca m = new Marca();
                m.NombreMarca = txtMarca.Text;
                m.InsertarMarca();
                MostrarMarcas();
                txtMarca.Clear();

                MessageBox.Show("El registro fue exitoso", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo añadir la Marca" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btnAggCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                Categoria c = new Categoria();
                c.NombreCategoria = txtCategoria.Text;
                c.InsertarCategorias();
                MostrarCategorias();
                txtCategoria.Clear();

                MessageBox.Show("El registro fue exitoso", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo añadir la categoria" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAggRegistro_Click(object sender, EventArgs e)
        {
            try
            {
                Material m = new Material();
                m.NombreMaterial = txtNombre.Text;
                m.IdMarca = Convert.ToInt32( cbMarcas.SelectedValue);
                m.Modelo = txtModelo.Text;
                m.IdCategoria = Convert.ToInt32(cbCategoria.SelectedValue);
                m.Descripcion = txtDescripcion.Text;
                m.FechaIngreso = dtpFechaIng.Value;
                m.Cantidad = Convert.ToInt32(txtCantidad.Text);
                m.InsertarMaterial();
                MostrarRegistro();
                
                MessageBox.Show("El registro fue exitoso", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo completar el registro" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void MostrarRegistro()
        {
            dgvMaterialAgg.DataSource = null;
            dgvMaterialAgg.DataSource = Material.CargarUltimosRegistros();
        }

    }
}
