using FontAwesome.Sharp;
using Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace Vistas.Formularios
{

    public partial class frmInventarioDIT : Form
    {
        


        public frmInventarioDIT()
        {
            InitializeComponent();

        }


        Panel linea = new Panel();

        private void btnMouseEnter (object sender, EventArgs e)
        {
            Button btn = sender as Button;
            linea.Size = new Size(btn.Width, 3);
            linea.Location = new Point(btn.Left, btn.Bottom);
            linea.Visible = true;
            linea.BringToFront();
        }

        private void btnMouseLeave (object sender , EventArgs e)
        {
            linea.Visible = false;
        }

        private void frmInventarioDIT_Load(object sender, EventArgs e)
        {
            MostrarMateriales();
            EstilizarDataGrid(dgvMaterialesD);
            MostrarMarcas();
            MostrarCategorias();
            EstilizarDataGrid(dgvCategorias);
            EstilizarDataGrid(dgvMarcas);

            linea.BackColor = Color.White;
            linea.Size = new Size(0, 3);
            linea.Visible = false;
            pnlContenedorPestañas.Controls.Add(linea);
        }

        private void icbtnAgg_Click(object sender, EventArgs e)
        {
            if(!pnlAgg.Visible)
            {
                pnlAgg.Visible = true;
                pnlAgg.BringToFront();
                pnlEliminar.Visible = false;
            }
            else
            {
                pnlAgg.Visible = false;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvMaterialesD.DataSource = null;
                dgvMaterialesD.DataSource = Material.Buscar(txtBuscar.Text);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MostrarMateriales()
        {
            dgvMaterialesD.DataSource = null;
            dgvMaterialesD.DataSource = Material.CargarMateriales();
        }
        private void MostrarMarcas()
        {
            dgvMarcas.DataSource = null;
            dgvMarcas.DataSource = Marca.CargarMarcas();
        }

        private void MostrarCategorias()
        {
            dgvCategorias.DataSource = null;
            dgvCategorias.DataSource = Categoria.CargarCategorias();
        }

        private void EstilizarDataGrid(DataGridView dgv)
        {
            dgv.BorderStyle = BorderStyle.None;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(198, 216, 112);
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

        private void icbtnEliminar_Click(object sender, EventArgs e)
        {
            if (!pnlEliminar.Visible)
            {
                pnlEliminar.Visible = true;
                pnlEliminar.BringToFront();
                pnlAgg.Visible = false;
            }
            else
            {
                
                pnlEliminar.Visible = false;

            }
        }
        
        private void icbtnMaterial_Click(object sender, EventArgs e)
        {
            frmAgregarMaterial frm = new frmAgregarMaterial();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();

        }

        private void icbtnCategoria_Click(object sender, EventArgs e)
        {
            frmAggCategoria frm = new frmAggCategoria();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }

        private void icbtnMarca_Click(object sender, EventArgs e)
        {
            frmAggMarca frm = new frmAggMarca();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }

        private void icbtnMaterialEli_Click(object sender, EventArgs e)
        {
            frmEliminarMaterial frm = new frmEliminarMaterial();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }

        private void icbtnCategoriaEli_Click(object sender, EventArgs e)
        {
            frmEliminarCategoria frm = new frmEliminarCategoria();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }

        private void icbtnMarcaEli_Click(object sender, EventArgs e)
        {
            frmEliminarMarca frm = new frmEliminarMarca();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }

        private void btnLimpiarB_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            MostrarMateriales();
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            try
            {
                dgvMaterialesD.DataSource = null;
                dgvMaterialesD.DataSource = Material.Buscar(txtBuscar.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void icbtnActualizar_Click(object sender, EventArgs e)
        {
            pnlAgg.Visible = false;
            pnlEliminar.Visible = false;
            frmActualizarMaterial frm = new frmActualizarMaterial();
            frm.StartPosition = FormStartPosition.CenterScreen;
            
            frm.ShowDialog();
        }
    }
}
