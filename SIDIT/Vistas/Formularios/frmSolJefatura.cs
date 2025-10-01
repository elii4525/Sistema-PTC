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
    public partial class frmSolJefatura : Form
    {
        public frmSolJefatura()
        {
            InitializeComponent();
        }

        private int idSolicitud1 = 0;
        private int idSolicitud2 = 0;
        private int idSolicitud3 = 0;

        private void CargarSolicitudes()
        {
            try
            {
                Solicitudd sol = new Solicitudd();

                // Trae TODAS las solicitudes
                DataTable dt = sol.ObtenerSolicitudesJefatura();

                // Ocultar paneles por defecto
                pnlSolicitud1.Visible = false;
                pnlSolicitud2.Visible = false;
                pnlSolicitud3.Visible = false;

                // Agrupar por idSolicitud (una solicitud puede tener varios materiales)
                var solicitudes = dt.AsEnumerable()
                    .GroupBy(r => r["idSolicitud"])
                    .OrderByDescending(g => Convert.ToDateTime(g.First()["fecha"]))
                    .Take(3) // máximo 3 solicitudes recientes
                    .ToList();

                int panelIndex = 0;

                foreach (var g in solicitudes)
                {
                    string estado = g.First()["estado"].ToString();

                    if (panelIndex == 0)
                    {
                        pnlSolicitud1.Visible = true;
                        idSolicitud1 = Convert.ToInt32(g.First()["idSolicitud"]);
                        lblNombre.Text = g.First()["nombreUsuario"].ToString();
                        lblRol.Text = "Empleado";
                        lblFecha.Text = Convert.ToDateTime(g.First()["fecha"]).ToString("dd/MM/yyyy");
                        lblDescripcion.Text = g.First()["motivo"].ToString();
                        lblEstado.Text = estado;

                        // limpiar labels
                        lblMaterial1.Text = lblCantidad1.Text = lblMarca1.Text = "";
                        lblMaterial2.Text = lblCantidad2.Text = lblMarca2.Text = "";
                        lblMaterial3.Text = lblCantidad3.Text = lblmarca3.Text = "";

                        int i = 0;
                        foreach (var fila in g)
                        {
                            if (i == 0)
                            {
                                lblMaterial1.Text = fila["nombreMaterial"].ToString();
                                lblCantidad1.Text = fila["cantidad"].ToString();
                                lblMarca1.Text = fila["nombreMarca"].ToString();
                            }
                            else if (i == 1)
                            {
                                lblMaterial2.Text = fila["nombreMaterial"].ToString();
                                lblCantidad2.Text = fila["cantidad"].ToString();
                                lblMarca2.Text = fila["nombreMarca"].ToString();
                            }
                            else if (i == 2)
                            {
                                lblMaterial3.Text = fila["nombreMaterial"].ToString();
                                lblCantidad3.Text = fila["cantidad"].ToString();
                                lblmarca3.Text = fila["nombreMarca"].ToString();
                            }
                            i++;
                        }

                        // Ocultar botones si ya fue procesada
                        btnAceptar.Visible = btnNegar.Visible = (estado == "Pendiente");
                    }
                    else if (panelIndex == 1)
                    {
                        pnlSolicitud2.Visible = true;
                        idSolicitud2 = Convert.ToInt32(g.First()["idSolicitud"]);
                        lblNombre2.Text = g.First()["nombreUsuario"].ToString();
                        lblRol2.Text = "Empleado";
                        lblFecha2.Text = Convert.ToDateTime(g.First()["fecha"]).ToString("dd/MM/yyyy");
                        lblMotivo2.Text = g.First()["motivo"].ToString();
                        lblEstado2.Text = estado;

                        lblMaterial4.Text = lblCantidad4.Text = lblMarca4.Text = "";
                        lblMaterial5.Text = lblCantidad5.Text = lblMarca5.Text = "";
                        lblMaterial6.Text = lblCantidad6.Text = lblMarca6.Text = "";

                        int i = 0;
                        foreach (var fila in g)
                        {
                            if (i == 0)
                            {
                                lblMaterial4.Text = fila["nombreMaterial"].ToString();
                                lblCantidad4.Text = fila["cantidad"].ToString();
                                lblMarca4.Text = fila["nombreMarca"].ToString();
                            }
                            else if (i == 1)
                            {
                                lblMaterial5.Text = fila["nombreMaterial"].ToString();
                                lblCantidad5.Text = fila["cantidad"].ToString();
                                lblMarca5.Text = fila["nombreMarca"].ToString();
                            }
                            else if (i == 2)
                            {
                                lblMaterial6.Text = fila["nombreMaterial"].ToString();
                                lblCantidad6.Text = fila["cantidad"].ToString();
                                lblMarca6.Text = fila["nombreMarca"].ToString();
                            }
                            i++;
                        }

                        btnAceptar2.Visible = btnNegar2.Visible = (estado == "Pendiente");
                    }
                    else if (panelIndex == 2)
                    {
                        pnlSolicitud3.Visible = true;
                        idSolicitud3 = Convert.ToInt32(g.First()["idSolicitud"]);
                        lblNombre3.Text = g.First()["nombreUsuario"].ToString();
                        lblRol3.Text = "Empleado";
                        lblFecha3.Text = Convert.ToDateTime(g.First()["fecha"]).ToString("dd/MM/yyyy");
                        lblMotivo3.Text = g.First()["motivo"].ToString();
                        lblEstado3.Text = estado;

                        lblMaterial7.Text = lblCantidad7.Text = lblMarca7.Text = "";
                        lblMaterial8.Text = lblCantidad8.Text = lblMarca8.Text = "";
                        lblMaterial9.Text = lblCantidad9.Text = lblMarca9.Text = "";

                        int i = 0;
                        foreach (var fila in g)
                        {
                            if (i == 0)
                            {
                                lblMaterial7.Text = fila["nombreMaterial"].ToString();
                                lblCantidad7.Text = fila["cantidad"].ToString();
                                lblMarca7.Text = fila["nombreMarca"].ToString();
                            }
                            else if (i == 1)
                            {
                                lblMaterial8.Text = fila["nombreMaterial"].ToString();
                                lblCantidad8.Text = fila["cantidad"].ToString();
                                lblMarca8.Text = fila["nombreMarca"].ToString();
                            }
                            else if (i == 2)
                            {
                                lblMaterial9.Text = fila["nombreMaterial"].ToString();
                                lblCantidad9.Text = fila["cantidad"].ToString();
                                lblMarca9.Text = fila["nombreMarca"].ToString();
                            }
                            i++;
                        }

                        btnAceptar3.Visible = btnNegar3.Visible = (estado == "Pendiente");
                    }

                    panelIndex++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar solicitudes (jefatura): " + ex.Message);
            }
        }

        private void btnAceptar2_Click(object sender, EventArgs e)
        {
            Solicitudd.CambiarEstadoSolicitud(idSolicitud2, "Aceptada");
            lblEstado2.Text = "Aceptada";
        }

        // Botón Negar Solicitud 2
        private void btnNegar2_Click(object sender, EventArgs e)
        {
            Solicitudd.CambiarEstadoSolicitud(idSolicitud2, "Negada");
            lblEstado2.Text = "Negada";
        }

        // Botón Aceptar Solicitud 3
        private void btnAceptar3_Click(object sender, EventArgs e)
        {
            Solicitudd.CambiarEstadoSolicitud(idSolicitud3, "Aceptada");
            lblEstado3.Text = "Aceptada";
        }

        // Botón Negar Solicitud 3
        private void btnNegar3_Click(object sender, EventArgs e)
        {
            Solicitudd.CambiarEstadoSolicitud(idSolicitud3, "Negada");
            lblEstado3.Text = "Negada";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Solicitudd.CambiarEstadoSolicitud(idSolicitud1, "Aceptada");
            lblEstado.Text = "Aceptada";
        }

        private void btnNegar_Click(object sender, EventArgs e)
        {
            Solicitudd.CambiarEstadoSolicitud(idSolicitud1, "Aceptada");
            lblEstado.Text = "Negada";
        }

        private void frmSolJefatura_Load(object sender, EventArgs e)
        {
            CargarSolicitudes();
        }
    }
}
