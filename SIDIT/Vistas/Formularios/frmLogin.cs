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
using Vistas.HelperBarraNegra;
using static Modelos.Entidades.Usuario;

namespace Vistas.Formularios
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            this.MinimumSize = new Size(1200, 800);
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);

            BarraNegra.TryApplyDarkTitleBar(this.Handle);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txtCorreo.Texts == "ejemplo.dit@gmail.com")
            {
                txtCorreo.Texts = "";
                txtCorreo.ForeColor = Color.White;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (txtCorreo.Texts == "")
            {
                txtCorreo.Texts = "ejemplo.dit@gmail.com";
                txtCorreo.ForeColor = Color.DarkGray;
            }
        }

        private void txtContra_Leave(object sender, EventArgs e)
        {
            if (txtContra.Texts == "")
            {
                txtContra.Texts = "X93esAX99";
                txtContra.ForeColor = Color.DarkGray;
                txtContra.PasswordChar = false;
            }
        }

        private void txtContra_Enter(object sender, EventArgs e)
        {
            if (txtContra.Texts == "X93esAX99")
            {
                txtContra.Texts = "";
                txtContra.ForeColor = Color.White;
                txtContra.PasswordChar = true;
            }
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string correo = txtCorreo.Texts.Trim();
            string contraseña = txtContra.Texts.Trim();

            // Validaciones básicas
            if (string.IsNullOrEmpty(correo))
            {
                lblError.Text = "Por favor ingrese un correo electrónico válido";
                lblError.Visible = true;
                return;
            }

            if (string.IsNullOrEmpty(contraseña))
            {
                lblError.Text = "Por favor ingrese una contraseña válida";
                lblError.Visible = true;
                return;
            }

            try
            {
                Usuario usuario = new Usuario();

                string rol = usuario.VerificarLogin(correo, contraseña);

                if (rol != null)
                {
                    DataTable datosUsuario = usuario.ObtenerDatosUsuario(correo); // SOLO correo

                    if (datosUsuario.Rows.Count > 0)
                    {
                        SesionActual.IdUsuario = Convert.ToInt32(datosUsuario.Rows[0]["idUsuario"]);
                        SesionActual.Nombre = datosUsuario.Rows[0]["nombre"].ToString();
                        SesionActual.Correo = datosUsuario.Rows[0]["correo"].ToString();
                        SesionActual.Telefono = datosUsuario.Rows[0]["telefono"].ToString();
                        SesionActual.Rol = datosUsuario.Rows[0]["tipoRol"].ToString();

                        if (datosUsuario.Rows[0]["fechaNacimiento"] != DBNull.Value)
                            SesionActual.FechaNacimiento = Convert.ToDateTime(datosUsuario.Rows[0]["fechaNacimiento"]);
                        else
                            SesionActual.FechaNacimiento = DateTime.Today;
                    }

                    // Abrir el formulario correspondiente según el rol
                    if (rol == "Jefatura")
                        new frmBienvenidaJefatura().Show();
                    else
                        new frmBienvenidoDIT().Show();

                    this.Hide();
                }
                else
                {
                    new frmLoginError().Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar sesión: " + ex.Message);
            }
        }



        private void frmLogin_Load(object sender, EventArgs e)
        {

            // Aqui iran todos los labels que se convertiran en la tipografia de Epilogue
            // Deben ser uno a uno y entre parentesis va el tamaño

            lblBienvenido.Font = FuenteHelper.ObtenerFuente(35);
            lblIngreseDatos.Font = FuenteHelper.ObtenerFuente(17);
            lblCorreo.Font = FuenteHelper.ObtenerFuente(10);
            lblContraseña.Font = FuenteHelper.ObtenerFuente(10);
            btnIniciarSesion.Font = FuenteHelper.ObtenerFuente(10);

        }
    }
}
