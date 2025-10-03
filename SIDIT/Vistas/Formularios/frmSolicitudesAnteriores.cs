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
    public partial class frmSolicitudesAnteriores : Form
    {
        private int _idUsuario;

        // Constructor que recibe el idUsuario
        public frmSolicitudesAnteriores(int idUsuario)
        {
            InitializeComponent();
            _idUsuario = idUsuario;
            EstilizarDataGrid(dataGridView1);
            label1.Font = Helper.FuenteHelper.ObtenerFuente(15);
        }

        private void frmSolicitudesAnteriores_Load(object sender, EventArgs e)
        {
            Solicitudd sol = new Solicitudd();
            dataGridView1.DataSource = sol.ObtenerSolicitudesPorUsuario(_idUsuario);
        }

        private void buttonRedondeado2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EstilizarDataGrid(DataGridView dgv)
        {
            dgv.BorderStyle = BorderStyle.None;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.DefaultCellStyle.SelectionBackColor = Color.Gray;
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.BackgroundColor = Color.White;

            dgv.DefaultCellStyle.ForeColor = Color.Black;

            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;

            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv.RowTemplate.Height = 30;
            dgv.AllowUserToResizeColumns = true;
            dgv.AllowUserToResizeRows = false;
        }

    }
}
