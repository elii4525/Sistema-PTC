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

namespace Vistas.Formularios
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void txtCorreo_Enter(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "ejemplo.dit@gmail.com")
            {
                txtCorreo.Text = "";
                txtCorreo.ForeColor = Color.White;
            }
        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "")
            {
                txtCorreo.Text = "ejemplo.dit@gmail.com";
                txtCorreo.ForeColor = Color.DarkGray;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "X93eSaa33";
                txtContraseña.ForeColor = Color.DarkGray;
                txtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "X93eSaa33")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.White;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if(txtCorreo.Text != "ejemplo.dit@gmail.com")
            {
                if(txtContraseña.Text != "X93eSaa33")
                {

                    Usuario usuario = new Usuario();
                    string rol = usuario.Login(txtCorreo.Text, txtContraseña.Text);

                    if (rol != null)
                    {
                        if (rol == "Jefatura")
                        {
                            new frmBienvenidaJefatura().Show();
                        }
                        else
                        {
                            new frmBienvenidoDIT().Show();
                        }
                        this.Hide();
                    }
                    else
                    {
                        new frmLoginError().Show();
                    }

                }
                else
                {
                    lblError.Text = "      " + "Por favor ingresar una contraseña valida";
                    lblError.Visible = true;
                }
            }
            else
            {
                lblError.Text = "      " + "Por favor ingresar un correo electrónico valido";
                lblError.Visible = true;
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

            // Aqui iran todos los labels que se convertiran en la tipografia de Epilogue, deben ser uno a uno y entre parentesis va el tamaño

            lblBienvenido.Font = FuenteHelper.ObtenerFuente(35);
            lblIngreseDatos.Font = FuenteHelper.ObtenerFuente(17);
            lblCorreo.Font = FuenteHelper.ObtenerFuente(10);
            lblContraseña.Font = FuenteHelper.ObtenerFuente(10);
            btnIniciarSesion.Font = FuenteHelper.ObtenerFuente(10);

        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);

            BarraNegra.TryApplyDarkTitleBar(this.Handle);
        }

    }
}
