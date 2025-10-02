using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Media.Media3D;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using Modelos.Entidades;
using Vistas.controles;

namespace Vistas.Formularios
{
    public partial class frmSolicitudDIT : Form
    {
        public frmSolicitudDIT()
        {
            InitializeComponent();
            label2.Font = Helper.FuenteHelper.ObtenerFuente(12);
            lblNombre.Font = Helper.FuenteHelper.ObtenerFuente(8);
            lblNombre2.Font = Helper.FuenteHelper.ObtenerFuente(8);
            lblNombre3.Font = Helper.FuenteHelper.ObtenerFuente(8);
            lblRol.Font = Helper.FuenteHelper.ObtenerFuente(8);
            lblRol2.Font = Helper.FuenteHelper.ObtenerFuente(8);
            lblRol3.Font = Helper.FuenteHelper.ObtenerFuente(8);
            lblMaterial1.Font = Helper.FuenteHelper.ObtenerFuente(8);
            lblMaterial2.Font = Helper.FuenteHelper.ObtenerFuente(8);
            lblMaterial3.Font = Helper.FuenteHelper.ObtenerFuente(8);
            lblMaterial4.Font = Helper.FuenteHelper.ObtenerFuente(8);
            lblMaterial5.Font = Helper.FuenteHelper.ObtenerFuente(8);
            lblMaterial6.Font = Helper.FuenteHelper.ObtenerFuente(8);
            lblMaterial7.Font = Helper.FuenteHelper.ObtenerFuente(8);
            lblMaterial8.Font = Helper.FuenteHelper.ObtenerFuente(8);
            lblMaterial9.Font = Helper.FuenteHelper.ObtenerFuente(8);
            lblMarca1.Font = Helper.FuenteHelper.ObtenerFuente(8);
            lblMarca2.Font = Helper.FuenteHelper.ObtenerFuente(8);
            lblMarca4.Font = Helper.FuenteHelper.ObtenerFuente(8);
            lblMarca5.Font = Helper.FuenteHelper.ObtenerFuente(8);
            lblmarca3.Font = Helper.FuenteHelper.ObtenerFuente(8);
            lblMarca6.Font = Helper.FuenteHelper.ObtenerFuente(8);
            lblMarca7.Font = Helper.FuenteHelper.ObtenerFuente(8);
            lblMarca8.Font = Helper.FuenteHelper.ObtenerFuente(8);
            lblMarca9.Font = Helper.FuenteHelper.ObtenerFuente(8);
            lblCantidad1.Font = Helper.FuenteHelper.ObtenerFuente(8);
            lblCantidad2.Font = Helper.FuenteHelper.ObtenerFuente(8);
            lblCantidad3.Font = Helper.FuenteHelper.ObtenerFuente(8);
            lblCantidad4.Font = Helper.FuenteHelper.ObtenerFuente(8);
            lblCantidad5.Font = Helper.FuenteHelper.ObtenerFuente(8);
            lblCantidad6.Font = Helper.FuenteHelper.ObtenerFuente(8);
            lblCantidad7.Font = Helper.FuenteHelper.ObtenerFuente(8);
            lblCantidad8.Font = Helper.FuenteHelper.ObtenerFuente(8);
            lblCantidad9.Font = Helper.FuenteHelper.ObtenerFuente(8);
            label1.Font = Helper.FuenteHelper.ObtenerFuente(8);
            label12.Font = Helper.FuenteHelper.ObtenerFuente(8);
            label17.Font = Helper.FuenteHelper.ObtenerFuente(8);
            label2.Font = Helper.FuenteHelper.ObtenerFuente(8);
            label25.Font = Helper.FuenteHelper.ObtenerFuente(8);
            label28.Font = Helper.FuenteHelper.ObtenerFuente(8);
            label3.Font = Helper.FuenteHelper.ObtenerFuente(8);
            label33.Font = Helper.FuenteHelper.ObtenerFuente(8);
            label5.Font = Helper.FuenteHelper.ObtenerFuente(8);
            label8.Font = Helper.FuenteHelper.ObtenerFuente(8);
            label9.Font = Helper.FuenteHelper.ObtenerFuente(8);
            lblEstado.Font = Helper.FuenteHelper.ObtenerFuente(8);
            lblEstado2.Font = Helper.FuenteHelper.ObtenerFuente(8);
            lblEstado3.Font = Helper.FuenteHelper.ObtenerFuente(8);
        }

        private void GenerarPdfSolicitud(
      int idSolicitud,
      string nombre,
      string rol,
      string fecha,
      string estado,
      string motivo,
      List<(string material, string cantidad, string marca)> materiales)
        {
            try
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "PDF file|*.pdf";
                saveFile.Title = "Guardar Solicitud en PDF";
                saveFile.FileName = $"Solicitud_{idSolicitud}.pdf";

                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream stream = new FileStream(saveFile.FileName, FileMode.Create))
                    {
                        Document pdfDoc = new Document(PageSize.A4, 25, 25, 30, 30);
                        PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();

                        string projectPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\.."));
                        string path = Path.Combine(projectPath, @"Vistas\Plantillas\solicitud.html");
                        string html = File.ReadAllText(path);

                        // Reemplazar variables en la plantilla
                        html = html.Replace("{{usuario}}", nombre);
                        html = html.Replace("{{rol}}", rol);         // 👈 ahora si se inserta rol
                        html = html.Replace("{{fecha}}", fecha);
                        html = html.Replace("{{estado}}", estado);
                        html = html.Replace("{{motivo}}", motivo);   // 👈 ahora si se inserta motivo

                        // Construir filas de la tabla dinámicamente
                        string filas = "";
                        foreach (var m in materiales)
                        {
                            if (!string.IsNullOrWhiteSpace(m.material))
                            {
                                filas += $"<tr><td>{m.material}</td><td>{m.marca}</td><td>{m.cantidad}</td></tr>";
                            }
                        }
                        html = html.Replace("{{filasMateriales}}", filas);

                        using (var sr = new StringReader(html))
                        {
                            XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                        }

                        pdfDoc.Close();
                        stream.Close();
                    }

                    MessageBox.Show("PDF generado correctamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar PDF: " + ex.Message);
            }
        }



        private void frmSolicitudDIT_Load(object sender, EventArgs e)
        {
            CargarSolicitudes();
        }

        private int idSolicitud1 = 0;
        private int idSolicitud2 = 0;
        private int idSolicitud3 = 0;

        private void CargarSolicitudes()
        {
            try
            {
                Solicitudd sol = new Solicitudd();
                int idUsuario = Usuario.SesionActual.IdUsuario;

                // Traer SOLO las solicitudes de este usuario
                DataTable dt = sol.ObtenerSolicitudesPorUsuario(idUsuario);

                // Ocultar paneles por defecto
                pnlSolicitud1.Visible = false;
                pnlSolicitud2.Visible = false;
                pnlSolicitud3.Visible = false;

                // Agrupar por idSolicitud (una solicitud puede tener varios materiales)
                var solicitudes = dt.AsEnumerable()
                    .GroupBy(r => r["idSolicitud"])
                    .OrderByDescending(g => Convert.ToDateTime(g.First()["fecha"]))
                    .Take(3) // mostrar solo 3 solicitudes
                    .ToList();

                int panelIndex = 0;

                foreach (var g in solicitudes)
                {
                    if (panelIndex == 0)
                    {
                        pnlSolicitud1.Visible = true;
                        idSolicitud1 = Convert.ToInt32(g.First()["idSolicitud"]);
                        lblNombre.Text = g.First()["nombreUsuario"].ToString();
                        lblRol.Text = Usuario.SesionActual.Rol;
                        lblFecha.Text = Convert.ToDateTime(g.First()["fecha"]).ToString("dd/MM/yyyy");
                        lblDescripcion.Text = g.First()["motivo"].ToString();
                        lblEstado.Text = g.First()["estado"].ToString();

                        // Limpiar labels
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

                        btnGenerarPdf1.Visible = (g.First()["estado"].ToString() == "Aceptada");
                    }
                    else if (panelIndex == 1)
                    {
                        pnlSolicitud2.Visible = true;
                        idSolicitud2 = Convert.ToInt32(g.First()["idSolicitud"]);
                        lblNombre2.Text = g.First()["nombreUsuario"].ToString();
                        lblRol2.Text = Usuario.SesionActual.Rol;
                        lblFecha2.Text = Convert.ToDateTime(g.First()["fecha"]).ToString("dd/MM/yyyy");
                        lblMotivo2.Text = g.First()["motivo"].ToString();
                        lblEstado2.Text = g.First()["estado"].ToString();

                        // Limpiar labels
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

                        btnGenerarPdf2.Visible = (g.First()["estado"].ToString() == "Aceptada");
                    }
                    else if (panelIndex == 2)
                    {
                        pnlSolicitud3.Visible = true;
                        idSolicitud3 = Convert.ToInt32(g.First()["idSolicitud"]);
                        lblNombre3.Text = g.First()["nombreUsuario"].ToString();
                        lblRol3.Text = Usuario.SesionActual.Rol;
                        lblFecha3.Text = Convert.ToDateTime(g.First()["fecha"]).ToString("dd/MM/yyyy");
                        lblMotivo3.Text = g.First()["motivo"].ToString();
                        lblEstado3.Text = g.First()["estado"].ToString();

                        // Limpiar labels
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

                        btnGenerarPdf3.Visible = (g.First()["estado"].ToString() == "Aceptada");
                    }

                    panelIndex++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar solicitudes de usuario: " + ex.Message);
            }
        }



        // 🔹 Botón para enviar nueva solicitud
        private void buttonRedondeado1_Click(object sender, EventArgs e)
        {
            int idUsuario = Usuario.SesionActual.IdUsuario;

            frmEnviarSolicitud uc = new frmEnviarSolicitud(idUsuario);
            FrmContenedorUC ven = new FrmContenedorUC(uc);

            if (ven.ShowDialog() == DialogResult.OK)
            {
                CargarSolicitudes();
            }
        }

        // 🔹 Botón para ver solicitudes anteriores
        private void btnSolicitudesAnteriores_Click(object sender, EventArgs e)
        {
            int idUsuario = Usuario.SesionActual.IdUsuario;

            frmSolicitudesAnteriores frm = new frmSolicitudesAnteriores(idUsuario);
            frm.ShowDialog();
        }

        // 🔹 Botones de Generar PDF
        private void btnGenerarPdf1_Click(object sender, EventArgs e)
        {
            GenerarPdf(idSolicitud1);
        }

        private void btnGenerarPdf2_Click(object sender, EventArgs e)
        {
            GenerarPdf(idSolicitud2);
        }

        private void btnGenerarPdf3_Click(object sender, EventArgs e)
        {
            GenerarPdf(idSolicitud3);
        }

        private void GenerarPdf(int idSolicitud)
        {
            // Aquí va tu lógica real de exportar a PDF
            MessageBox.Show("Generando PDF para la solicitud: " + idSolicitud);
        }

        private void GenerarPDF(string nombre, string departamento, string fecha, string estado,
                        string material1, string cantidad1, string marca1,
                        string material2, string cantidad2, string marca2,
                        string material3, string cantidad3, string marca3)
        {
            try
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "PDF file|*.pdf";
                saveFile.Title = "Guardar Solicitud en PDF";
                saveFile.FileName = "Solicitud.pdf";

                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream stream = new FileStream(saveFile.FileName, FileMode.Create))
                    {
                        Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 20f, 20f);
                        PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();

                        // 🔹 Encabezado
                        pdfDoc.Add(new Paragraph("Solicitud de Materiales", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16)));
                        pdfDoc.Add(new Paragraph(" "));

                        // 🔹 Datos generales
                        pdfDoc.Add(new Paragraph("Empleado: " + nombre));
                        pdfDoc.Add(new Paragraph("Departamento: " + departamento));
                        pdfDoc.Add(new Paragraph("Fecha: " + fecha));
                        pdfDoc.Add(new Paragraph("Estado: " + estado));
                        pdfDoc.Add(new Paragraph(" "));

                        // 🔹 Materiales (uno por línea)
                        pdfDoc.Add(new Paragraph("Materiales solicitados: "));
                        pdfDoc.Add(new Paragraph($" - {material1}, Cantidad: {cantidad1}, Marca: {marca1}"));
                        pdfDoc.Add(new Paragraph($" - {material2}, Cantidad: {cantidad2}, Marca: {marca2}"));
                        pdfDoc.Add(new Paragraph($" - {material3}, Cantidad: {cantidad3}, Marca: {marca3}"));

                        pdfDoc.Close();
                        stream.Close();
                    }

                    MessageBox.Show("✅ PDF generado correctamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al generar PDF: " + ex.Message);
            }
        }


        private void btnGenerarPdf3_Click_1(object sender, EventArgs e)
        {
            var materiales = new List<(string, string, string)>
    {
        (lblMaterial7.Text, lblCantidad7.Text, lblMarca7.Text),
        (lblMaterial8.Text, lblCantidad8.Text, lblMarca8.Text),
        (lblMaterial9.Text, lblCantidad9.Text, lblMarca9.Text)
    };

            GenerarPdfSolicitud(
                idSolicitud3,
                lblNombre3.Text,
                lblRol3.Text,
                lblFecha3.Text,
                lblEstado3.Text,
                lblMotivo3.Text,
                materiales
            );
        }

        private void btnGenerarPdf2_Click_1(object sender, EventArgs e)
        {
            var materiales = new List<(string, string, string)>
    {
        (lblMaterial4.Text, lblCantidad4.Text, lblMarca4.Text),
        (lblMaterial5.Text, lblCantidad5.Text, lblMarca5.Text),
        (lblMaterial6.Text, lblCantidad6.Text, lblMarca6.Text)
    };

            GenerarPdfSolicitud(
                idSolicitud2,
                lblNombre2.Text,
                lblRol2.Text,
                lblFecha2.Text,
                lblEstado2.Text,
                lblMotivo2.Text,
                materiales
            );

        }

        private void btnGenerarPdf1_Click_1(object sender, EventArgs e)
        {
            var materiales = new List<(string, string, string)>
    {
        (lblMaterial1.Text, lblCantidad1.Text, lblMarca1.Text),
        (lblMaterial2.Text, lblCantidad2.Text, lblMarca2.Text),
        (lblMaterial3.Text, lblCantidad3.Text, lblmarca3.Text)
    };

            GenerarPdfSolicitud(
                idSolicitud1,
                lblNombre.Text,
                lblRol.Text,
                lblFecha.Text,
                lblEstado.Text,
                lblDescripcion.Text,
                materiales
            );
        }
    }
}
