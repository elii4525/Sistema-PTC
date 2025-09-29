using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Modelos.Entidades;

namespace Vistas.controles
{
    public partial class frmEnviarSolicitud : UserControl
    {
        private Solicitudd solicitud;

        public frmEnviarSolicitud(int idUsuario)
        {
            InitializeComponent();
            solicitud = new Solicitudd(idUsuario);

            // Bloquear edición en los ComboBox
            cbMaterial1.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMaterial2.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMaterial3.DropDownStyle = ComboBoxStyle.DropDownList;

            cbMarca1.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMarca2.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMarca3.DropDownStyle = ComboBoxStyle.DropDownList;

            // Validar que las cantidades solo acepten números
            txtCantidad1.KeyPress += ValidarSoloNumeros;
            txtCantidad2.KeyPress += ValidarSoloNumeros;
            txtCantidad3.KeyPress += ValidarSoloNumeros;

            // 🔹 Fijar fecha de hoy en el DateTimePicker (y bloquear edición)
            dtpFecha.Value = DateTime.Today;
            dtpFecha.Enabled = false;
        }

        private void frmEnviarSolicitud_Load(object sender, EventArgs e)
        {
            DataTable dtMat = solicitud.ObtenerMateriales();

            cbMaterial1.DataSource = dtMat.Copy();
            cbMaterial1.DisplayMember = "nombreMaterial";
            cbMaterial1.ValueMember = "idMaterial";
            cbMaterial1.SelectedIndex = -1;
            cbMaterial1.SelectionChangeCommitted += CargarMarcas1;

            cbMaterial2.DataSource = dtMat.Copy();
            cbMaterial2.DisplayMember = "nombreMaterial";
            cbMaterial2.ValueMember = "idMaterial";
            cbMaterial2.SelectedIndex = -1;
            cbMaterial2.SelectionChangeCommitted += CargarMarcas2;

            cbMaterial3.DataSource = dtMat.Copy();
            cbMaterial3.DisplayMember = "nombreMaterial";
            cbMaterial3.ValueMember = "idMaterial";
            cbMaterial3.SelectedIndex = -1;
            cbMaterial3.SelectionChangeCommitted += CargarMarcas3;
        }

        private void CargarMarcas1(object sender, EventArgs e)
        {
            int idMaterial = Convert.ToInt32(cbMaterial1.SelectedValue);
            DataTable dtMarcas = solicitud.ObtenerMarcasPorMaterial(idMaterial);

            cbMarca1.DataSource = dtMarcas.Rows.Count > 0 ? dtMarcas : null;
            cbMarca1.DisplayMember = "nombreMarca";
            cbMarca1.ValueMember = "idMarca";
            cbMarca1.SelectedIndex = -1;
        }

        private void CargarMarcas2(object sender, EventArgs e)
        {
            int idMaterial = Convert.ToInt32(cbMaterial2.SelectedValue);
            DataTable dtMarcas = solicitud.ObtenerMarcasPorMaterial(idMaterial);

            cbMarca2.DataSource = dtMarcas.Rows.Count > 0 ? dtMarcas : null;
            cbMarca2.DisplayMember = "nombreMarca";
            cbMarca2.ValueMember = "idMarca";
            cbMarca2.SelectedIndex = -1;
        }

        private void CargarMarcas3(object sender, EventArgs e)
        {
            int idMaterial = Convert.ToInt32(cbMaterial3.SelectedValue);
            DataTable dtMarcas = solicitud.ObtenerMarcasPorMaterial(idMaterial);

            cbMarca3.DataSource = dtMarcas.Rows.Count > 0 ? dtMarcas : null;
            cbMarca3.DisplayMember = "nombreMarca";
            cbMarca3.ValueMember = "idMarca";
            cbMarca3.SelectedIndex = -1;
        }

        private void ValidarSoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquea letras y símbolos
            }
        }

        private void btnEnviarSolicitud_Click_1(object sender, EventArgs e)
        {
            try
            {
                // 🔹 Validar fecha (solo hoy)
                DateTime fechaSeleccionada = dtpFecha.Value.Date;
                if (fechaSeleccionada != DateTime.Today)
                {
                    MessageBox.Show("Solo se permite enviar solicitudes con la fecha de hoy.",
                        "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 🔹 Validar motivo
                if (string.IsNullOrWhiteSpace(txtMotivo.Text))
                {
                    MessageBox.Show("Debe ingresar un motivo para la solicitud.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                List<Solicitudd> materiales = new List<Solicitudd>();

                // Material 1
                if (cbMaterial1.SelectedIndex != -1)
                {
                    if (string.IsNullOrWhiteSpace(txtCantidad1.Text) || cbMarca1.SelectedIndex == -1)
                    {
                        MessageBox.Show("Ingrese cantidad y marca para el Material 1", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    materiales.Add(new Solicitudd(0)
                    {
                        IdMaterial = Convert.ToInt32(cbMaterial1.SelectedValue),
                        Cantidad = Convert.ToInt32(txtCantidad1.Text)
                    });
                }

                if (cbMaterial2.SelectedIndex != -1)
                {
                    if (string.IsNullOrWhiteSpace(txtCantidad2.Text) || cbMarca2.SelectedIndex == -1)
                    {
                        MessageBox.Show("Ingrese cantidad y marca para el Material 2", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    materiales.Add(new Solicitudd(0)
                    {
                        IdMaterial = Convert.ToInt32(cbMaterial2.SelectedValue),
                        Cantidad = Convert.ToInt32(txtCantidad2.Text)
                    });
                }

                if (cbMaterial3.SelectedIndex != -1)
                {
                    if (string.IsNullOrWhiteSpace(txtCantidad3.Text) || cbMarca3.SelectedIndex == -1)
                    {
                        MessageBox.Show("Ingrese cantidad y marca para el Material 3", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    materiales.Add(new Solicitudd(0)
                    {
                        IdMaterial = Convert.ToInt32(cbMaterial3.SelectedValue),
                        Cantidad = Convert.ToInt32(txtCantidad3.Text)
                    });
                }

                if (materiales.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar al menos un material.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 🔹 Guardar solicitud
                int idSolicitud = solicitud.CrearSolicitud(txtMotivo.Text, materiales);

                MessageBox.Show($"¡Solicitud enviada con éxito!\nID: {idSolicitud}",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 🔹 Cerrar el form contenedor si existe
                if (this.ParentForm != null)
                {
                    this.ParentForm.DialogResult = DialogResult.OK;
                    this.ParentForm.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al enviar solicitud: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (this.ParentForm != null)
                this.ParentForm.Close();
            else
                this.Visible = false;
        }
    }
}
