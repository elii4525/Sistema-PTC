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


        private void frmAggMaterial_Load(object sender, EventArgs e)
        {

            MostrarCategorias();
            MostrarMarcas();
            MostrarRegistro();
            EstilizarDataGrid(dgvMaterialAgg);
            
            
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
                if (string.IsNullOrEmpty(txtMarca.Text))
                {
                    MessageBox.Show("No se puede agregar un campo vacío", "Error");
                }
                else
                {
                    Marca m = new Marca();
                    m.NombreMarca = txtMarca.Text;
                    m.InsertarMarca();
                    MostrarMarcas();
                    txtMarca.Clear();

                    MessageBox.Show("El registro fue exitoso", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

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
                if(string.IsNullOrEmpty(txtCategoria.Text))
                {
                    MessageBox.Show("No se puede agregar un campo vacío", "Error");
                }
                else
                {
                    Categoria c = new Categoria();
                    c.NombreCategoria = txtCategoria.Text;
                    c.InsertarCategorias();
                    MostrarCategorias();
                    txtCategoria.Clear();

                    MessageBox.Show("El registro fue exitoso", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
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
                if(string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(cbCategoria.Text) || string.IsNullOrEmpty(cbMarcas.Text) || string.IsNullOrEmpty(txtModelo.Text) || string.IsNullOrEmpty(dtpFechaIng.Text) || string.IsNullOrEmpty(txtCantidad.Text))
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
                    MostrarRegistro();

                    MessageBox.Show("El registro fue exitoso", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
                
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

        private void EstilizarDataGrid(DataGridView dgv)
        {
            dgv.BorderStyle = BorderStyle.None;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgv.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgv.BackgroundColor = Color.White;

            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv.RowTemplate.Height = 30;
            dgv.AllowUserToResizeColumns = true;
            dgv.AllowUserToResizeRows = false;
        }

        
    }
}
