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
        private string _rol;

        public frmSolicitudesAnteriores()
        {
            InitializeComponent();
            _idUsuario = Usuario.SesionActual.IdUsuario;
            _rol = Usuario.SesionActual.Rol;

            EstilizarDataGrid(dataGridView1);
            label1.Font = Helper.FuenteHelper.ObtenerFuente(15);
        }

        private void frmSolicitudesAnteriores_Load(object sender, EventArgs e)
        {
            Solicitudd sol = new Solicitudd();

            if (_rol == "Jefatura")
            {
                dataGridView1.DataSource = sol.ObtenerTodasLasSolicitudes();
            }
            else
            {
                dataGridView1.DataSource = sol.ObtenerSolicitudesPorUsuario(_idUsuario);
            }
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
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(198, 216, 112);
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
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
