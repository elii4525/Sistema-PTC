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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MiTextBox = Vistas.Controles.TextBox;

namespace Vistas.Controles
{
    public partial class frmAgregarUsuario : UserControl
    {
        public frmAgregarUsuario()
        {
            InitializeComponent();
            CargarRoles();
        }

        private void frmAgregarUsuario_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
            EstilizarDataGrid(dgvUltimosUsuarios);
            lbl1.Font = Helper.FuenteHelper.ObtenerFuente(17);
            lbl2.Font = Helper.FuenteHelper.ObtenerFuente(10);
            btnAgregarUsuario.Font = Helper.FuenteHelper.ObtenerFuente(9);
            lbl3.Font = Helper.FuenteHelper.ObtenerFuente(10);
            lbl4.Font = Helper.FuenteHelper.ObtenerFuente(10);
            lbl5.Font = Helper.FuenteHelper.ObtenerFuente(10);
            lbl6.Font = Helper.FuenteHelper.ObtenerFuente(10);
            ConfigurarEdad(dtpFechaNacimiento);
            txtNumero.SoloNumeros = true;
            txtNombre.SoloLetras = true;
            txtNumero.MaxLength = 8;
        }

        public static bool NoEsNulo(MiTextBox txt, string mensajeError = "El campo no puede estar vacío")
        {
            if (string.IsNullOrWhiteSpace(txt.Texts))
            {
                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt.Focus();
                return false;
            }
            return true;
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {

            if (!NoEsNulo(txtNombre, "El nombre es obligatorio"))
                return; 

            if (!NoEsNulo(txtNumero, "El número es obligatorio"))
                return;

            if (!NoEsNulo(txtCorreo, "El correo es obligatorio"))
                return;

            Usuario nu = new Usuario();

            nu.Nombre = txtNombre.Texts;
            nu.FechaNacimiento = dtpFechaNacimiento.Value; 
            nu.Telefono = txtNumero.Texts;
            nu.Correo = txtCorreo.Texts;
            nu.IdRol = Convert.ToInt32(cbRol.SelectedValue);

            if (nu.RegistrarUsuario() == true)
            {
                CargarUsuarios();
                LimpiarCampos();
            }

        }

        // Con esto se configura el DateTimePicker y solo se agregan personas mayores de 18 años
        private void ConfigurarEdad(DateTimePicker dtpEdad)
        {
            DateTime hoy = DateTime.Today;
            dtpEdad.MaxDate = hoy.AddYears(-18);
            dtpEdad.MinDate = hoy.AddYears(-100);
            dtpEdad.Value = dtpEdad.MaxDate; 
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

        private void CargarRoles()
        {
            Usuario u = new Usuario(); 
            DataTable roles = u.cargarRoles();

            cbRol.DataSource = roles;
            cbRol.DisplayMember = "tipoRol"; 
            cbRol.ValueMember = "idRol";      
            cbRol.SelectedIndex = -1;      
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtNumero.Clear();
            txtCorreo.Clear();
            cbRol.SelectedIndex = -1;
        }

        private void CargarUsuarios()
        {
            dgvUltimosUsuarios.DataSource = Usuario.cargarUltimosUsuarios();
        }
    }
    
}
