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
        }

        private void frmEnviarSolicitud_Load(object sender, EventArgs e)
        {
            // Llenar materiales
            DataTable dtMat = solicitud.ObtenerMateriales();

            cbMaterial1.DataSource = dtMat.Copy();
            cbMaterial1.DisplayMember = "nombreMaterial";
            cbMaterial1.ValueMember = "idMaterial";
            cbMaterial1.SelectedIndex = -1;

            cbMaterial2.DataSource = dtMat.Copy();
            cbMaterial2.DisplayMember = "nombreMaterial";
            cbMaterial2.ValueMember = "idMaterial";
            cbMaterial2.SelectedIndex = -1;

            cbMaterial3.DataSource = dtMat.Copy();
            cbMaterial3.DisplayMember = "nombreMaterial";
            cbMaterial3.ValueMember = "idMaterial";
            cbMaterial3.SelectedIndex = -1;

            // Fecha bloqueada en hoy
            dtpFecha.Value = DateTime.Now;
            dtpFecha.MinDate = DateTime.Now.Date;
            dtpFecha.MaxDate = DateTime.Now.Date;
        }

        private void cbMaterial1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMaterial1.SelectedValue != null)
            {
                int idMaterial = Convert.ToInt32(cbMaterial1.SelectedValue);
                DataTable dtMarcas = solicitud.ObtenerMarcasPorMaterial(idMaterial);
                cbMarca1.DataSource = dtMarcas;
                cbMarca1.DisplayMember = "nombreMarca";
                cbMarca1.ValueMember = "idMarca";
                cbMarca1.SelectedIndex = -1;
            }
        }

        private void cbMaterial2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMaterial2.SelectedValue != null)
            {
                int idMaterial = Convert.ToInt32(cbMaterial2.SelectedValue);
                DataTable dtMarcas = solicitud.ObtenerMarcasPorMaterial(idMaterial);
                cbMarca2.DataSource = dtMarcas;
                cbMarca2.DisplayMember = "nombreMarca";
                cbMarca2.ValueMember = "idMarca";
                cbMarca2.SelectedIndex = -1;
            }
        }

        private void cbMaterial3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMaterial3.SelectedValue != null)
            {
                int idMaterial = Convert.ToInt32(cbMaterial3.SelectedValue);
                DataTable dtMarcas = solicitud.ObtenerMarcasPorMaterial(idMaterial);
                cbMarca3.DataSource = dtMarcas;
                cbMarca3.DisplayMember = "nombreMarca";
                cbMarca3.ValueMember = "idMarca";
                cbMarca3.SelectedIndex = -1;
            }
        }

        private void btnEnviarSolicitud_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMotivo.Text))
                {
                    MessageBox.Show("Debe ingresar un motivo para la solicitud.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                List<Solicitudd> materiales = new List<Solicitudd>();

                // Validar Material 1
                if (cbMaterial1.SelectedIndex != -1)
                {
                    if (string.IsNullOrWhiteSpace(txtCantidad1.Text) || cbMarca1.SelectedIndex == -1)
                    {
                        MessageBox.Show("Debe indicar la cantidad y marca para el Material 1.", "Validación",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    materiales.Add(new Solicitudd(0)
                    {
                        IdMaterial = Convert.ToInt32(cbMaterial1.SelectedValue),
                        Cantidad = Convert.ToInt32(txtCantidad1.Text)
                    });
                }

                // Validar Material 2
                if (cbMaterial2.SelectedIndex != -1)
                {
                    if (string.IsNullOrWhiteSpace(txtCantidad2.Text) || cbMarca2.SelectedIndex == -1)
                    {
                        MessageBox.Show("Debe indicar la cantidad y marca para el Material 2.", "Validación",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    materiales.Add(new Solicitudd(0)
                    {
                        IdMaterial = Convert.ToInt32(cbMaterial2.SelectedValue),
                        Cantidad = Convert.ToInt32(txtCantidad2.Text)
                    });
                }

                // Validar Material 3
                if (cbMaterial3.SelectedIndex != -1)
                {
                    if (string.IsNullOrWhiteSpace(txtCantidad3.Text) || cbMarca3.SelectedIndex == -1)
                    {
                        MessageBox.Show("Debe indicar la cantidad y marca para el Material 3.", "Validación",
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

                // Guardar en BD
                int idSolicitud = solicitud.CrearSolicitud(txtMotivo.Text, materiales);

                MessageBox.Show($"Solicitud enviada con éxito. ID: {idSolicitud}",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al enviar solicitud: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
