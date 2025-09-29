using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelos.Entidades;
using FontAwesome.Sharp;

namespace Vistas.Formularios
{

    public partial class frmInventarioDIT : Form
    {
        


        public frmInventarioDIT()
        {
            InitializeComponent();

        }

        
        Panel p = new Panel();

        private void btnMouseEnter (object sender, EventArgs e)
        {
            Button btn = sender as Button;
            pnlContenedorPestañas.Controls.Add(p);
            p.BackColor = Color.White;
            p.Size = new Size(164, 5);
            p.Location = new Point(btn.Location.X, btn.Location.Y + 63);
            p.BringToFront();
        }

        private void btnMouseLeave (object sender , EventArgs e)
        {
            pnlContenedorPestañas.Controls.Remove(p);
        }

        private void frmInventarioDIT_Load(object sender, EventArgs e)
        {
            MostrarMateriales();
            EstilizarDataGrid(dgvMaterialesD);
            MostrarMarcas();
            MostrarCategorias();
            EstilizarDataGrid(dgvCategorias);
            EstilizarDataGrid(dgvMarcas);
            
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            MostrarMateriales();
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
    }

}
