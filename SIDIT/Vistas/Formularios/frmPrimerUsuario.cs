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
    public partial class frmPrimerUsuario : Form
    {
        public frmPrimerUsuario()
        {
            InitializeComponent();
            CargarRolJefatura();
        }

        private void frmPrimerUsuario_Load(object sender, EventArgs e)
        {
            dtpFecha.MaxDate = DateTime.Today.AddYears(-18);
            dtpFecha.MinDate = DateTime.Today.AddYears(-100);

        }


        private void CargarRolJefatura()
        {
            try
            {
                Usuario usuario = new Usuario();
                DataTable roles = usuario.cargarRoles();

                cbRol.DataSource = roles;
                cbRol.DisplayMember = "tipoRol";
                cbRol.ValueMember = "idRol";

                foreach (DataRow row in roles.Rows)
                {
                    if (row["tipoRol"].ToString().ToLower().Contains("jefatura"))
                    {
                        cbRol.SelectedValue = row["idRol"];
                        cbRol.Enabled = false;
                        return;
                    }
                }

                MessageBox.Show("No se encontro el rol Jefatura en la base de datos ",
                    "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar roles: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtNumero.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                MessageBox.Show("Ingrese todos los campos, todos son necesarios.",
                                "Advertencia",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (txtNumero.Text.Length != 8)
            {
                MessageBox.Show("El número de teléfono debe tener 8 dígitos.",
                                "Advertencia",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                txtNumero.Focus();
                return;
            }

            if (!txtCorreo.Text.EndsWith("@gmail.com"))
            {
                MessageBox.Show("El correo debe terminar en @gmail.com",
                                "Advertencia",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                txtCorreo.Focus();
                return;
            }

            try
            {
                Usuario nuevo = new Usuario
                {
                    Nombre = txtNombre.Text.Trim(),
                    Telefono = txtNumero.Text.Trim(),
                    Correo = txtCorreo.Text.Trim().ToLower(), 
                    FechaNacimiento = dtpFecha.Value,
                    IdRol = Convert.ToInt32(cbRol.SelectedValue)
                };

                if (nuevo.RegistrarUsuario())
                {
                    MessageBox.Show("¡Bienvenido al sistema! Puedes iniciar sesión",
                                    "Éxito",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el usuario: " + ex.Message,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }


        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            BloquearCopiarPegar(e);
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
            SinEspacios(e);
        }

        private void txtNumero_KeyDown(object sender, KeyEventArgs e)
        {
            BloquearCopiarPegar(e);
        }

        private void txtCorreo_KeyDown(object sender, KeyEventArgs e)
        {
            BloquearCopiarPegar(e);
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            SinEspacios(e);
        }

        // Métodos de validación 

        private void SoloLetras(KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void SoloNumeros(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void SinEspacios(KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
                e.Handled = true;
        }

        private void BloquearCopiarPegar(KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.C || e.KeyCode == Keys.V || e.KeyCode == Keys.X))
                e.SuppressKeyPress = true;
        }
    }
}
