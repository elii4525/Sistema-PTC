using System;
using System.IO;
using DinkToPdf;
using DinkToPdf.Contracts;
using Modelos.Entidades;
using System.Diagnostics;

namespace Vistas
{
    public class PdfCreator
    {
        private readonly IConverter _converter;

        public PdfCreator()
        {
            _converter = new SynchronizedConverter(new PdfTools());
        }

        public string GenerarPdfSolicitud(int idSolicitud)
        {
            var dao = new Modelos.Entidades.Solicitudd();
            var solicitud = dao.ObtenerSolicitudCompleta(idSolicitud);
            if (solicitud == null) throw new Exception("Solicitud no encontrada.");

            string projectPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\.."));
            string rutaPlantilla = Path.Combine(projectPath, @"Vistas\Plantillas\solicitud.html");
            string html = File.ReadAllText(rutaPlantilla);

            string logoPath = Path.Combine(projectPath, @"Resources\logo.png");

            html = html.Replace("{{logo}}", logoPath.Replace("\\", "/"));

            if (!File.Exists(rutaPlantilla))
                throw new FileNotFoundException("No se encontró la plantilla HTML.", rutaPlantilla);

            html = html.Replace("{{usuario}}", solicitud.NombreUsuario ?? "");
            html = html.Replace("{{rol}}", solicitud.Rol ?? "No especificado");
            html = html.Replace("{{motivo}}", solicitud.Motivo ?? "No especificado");
            html = html.Replace("{{fecha}}", solicitud.Fecha.ToString("dd/MM/yyyy"));
            html = html.Replace("{{estado}}", solicitud.Estado ?? "");

            string filas = "";
            foreach (var m in solicitud.Materiales)
            {
                filas += $"<tr>" +
                         $"<td>{System.Net.WebUtility.HtmlEncode(m.NombreMaterial)}</td>" +
                         $"<td>{System.Net.WebUtility.HtmlEncode(m.Marca)}</td>" +
                         $"<td>{m.Cantidad}</td>" +
                         $"</tr>";
            }

            if (string.IsNullOrWhiteSpace(filas))
                filas = "<tr><td colspan='3'>No hay materiales registrados.</td></tr>";

            html = html.Replace("{{filasMateriales}}", filas);

            string fileName = $"Solicitud_{solicitud.IdSolicitud}.pdf";
            string outPath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName);

            var doc = new HtmlToPdfDocument()
            {
                GlobalSettings = new GlobalSettings
                {
                    PaperSize = PaperKind.A4,
                    Orientation = Orientation.Portrait,
                    Margins = new MarginSettings { Top = 20, Bottom = 20, Left = 20, Right = 20 }
                },
                Objects = {
                    new ObjectSettings
                    {
                        HtmlContent = html,
                        WebSettings = { DefaultEncoding = "utf-8" }
                    }
                }
            };

            byte[] pdf = _converter.Convert(doc);
            File.WriteAllBytes(outPath, pdf);

            try
            {
                Process.Start(new ProcessStartInfo(outPath) { UseShellExecute = true });
            }
            catch { }

            return outPath;
        }
    }
}
