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
using Vistas.Helper;

namespace Vistas.Controles
{
    public partial class frmVerUsuarios : UserControl
    {
        public frmVerUsuarios()
        {
            InitializeComponent();
            label1.Font = Helper.FuenteHelper.ObtenerFuente(13);
            label2.Font = Helper.FuenteHelper.ObtenerFuente(8);
        }

        private void frmVerUsuarios_Load(object sender, EventArgs e)
        {
            dgvVerUsuarios.DataSource = Usuario.cargarUsuarios();
            EstilizarDataGrid(dgvVerUsuarios);
            label1.Font = FuenteHelper.ObtenerFuente(15);
            label2.Font = FuenteHelper.ObtenerFuente(8);
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
