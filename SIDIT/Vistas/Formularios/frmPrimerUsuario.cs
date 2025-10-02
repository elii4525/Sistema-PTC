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

                // Buscar "Jefatura" y dejarlo fijo
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
                MessageBox.Show("Ingrese todos los campos, todos son necesarios.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Usuario nuevo = new Usuario
                {
                    Nombre = txtNombre.Text.Trim(),
                    Telefono = txtNumero.Text.Trim(),
                    Correo = txtCorreo.Text.Trim(),
                    FechaNacimiento = dtpFecha.Value,
                    IdRol = Convert.ToInt32(cbRol.SelectedValue)
                };

                if (nuevo.RegistrarUsuario())
                {
                    MessageBox.Show("¡Bienvenido al sistema! Puedes iniciar sesión",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el usuario: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
