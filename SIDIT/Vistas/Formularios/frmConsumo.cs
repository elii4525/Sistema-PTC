using Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace Vistas.Formularios
{
    public partial class frmConsumo : Form
    {
        private const string connectionString = "Lenovo\\SQLEXPRESS; Initial Catalog=BasePTC2; Integrated Security=True;";
        public frmConsumo()
        {
            InitializeComponent();
            label1.Font = Helper.FuenteHelper.ObtenerFuente(10);
            label2.Font = Helper.FuenteHelper.ObtenerFuente(10);
            label3.Font = Helper.FuenteHelper.ObtenerFuente(10);
            label4.Font = Helper.FuenteHelper.ObtenerFuente(10);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // 1. Obtener parámetros de la UI

            string materialBuscado = txtBusqueda.Text.Trim();
            DateTime fechaInicio = dtpFechaInicio.Value.Date;
            DateTime fechaFin = dtpFechaFin.Value.Date;

            if (fechaInicio > fechaFin)
            {
                MessageBox.Show("La fecha de inicio no puede ser posterior a la fecha de fin.", "Error de Rango", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // --- 2. FUNCIONALIDAD DE CONSUMO (GRÁFICO) ---
            DataTable dtConsumo = ObtenerConsumoMaterial(materialBuscado, fechaInicio, fechaFin);
            chartConsumo.Series.Clear();
            chartConsumo.Titles.Clear();
            chartConsumo.Annotations.Clear(); // Limpiar antes de usar

            if (dtConsumo != null && dtConsumo.Rows.Count > 0)
            {
                ConfigurarYDibujarGrafico(dtConsumo, materialBuscado);
            }
            else
            {
                MostrarMensajeSinDatos(materialBuscado);
            }

            // --- 3. FUNCIONALIDAD DE INVENTARIO (GRÁFICO) ---
            DataTable dtInventario = ObtenerInventario(materialBuscado);

            // Limpiar y configurar el gráfico de Inventario
            chartInventario.Series.Clear();
            chartInventario.Titles.Clear();
            chartInventario.Annotations.Clear(); // Limpiar antes de usar

            if (dtInventario != null && dtInventario.Rows.Count > 0)
            {
                ConfigurarYDibujarInventario(dtInventario);
            }
            else
            {
                // Mensaje si no hay datos de inventario
                string titulo = string.IsNullOrWhiteSpace(materialBuscado)
                                ? "Inventario (Sin Materiales)"
                                : $"Inventario de '{materialBuscado}' (Sin Materiales)";
                chartInventario.Titles.Add(titulo);

                TextAnnotation textAnnotation = new TextAnnotation();
                textAnnotation.Text = "No hay materiales en inventario que coincidan con la búsqueda.";
                textAnnotation.ForeColor = Color.DarkGray;
                textAnnotation.Font = new Font("Arial", 10, FontStyle.Italic);
                textAnnotation.AnchorAlignment = ContentAlignment.MiddleCenter;
                chartInventario.Annotations.Add(textAnnotation);
            }
        }
        private DataTable ObtenerInventario(string nombreMaterial)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("spu_obtenerinventariomaterial", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@nombrematerial", nombreMaterial);

                        connection.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el inventario de material: " + ex.Message, "Error de SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            return dt;
        }

        private void dtpFechaInicio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void chartConsumo_Click(object sender, EventArgs e)
        {
            // Establecer el rango de fechas para incluir los datos de prueba de 2025
            dtpFechaInicio.Value = new DateTime(2023, 1, 1); // 1 de Enero de 2025
            dtpFechaFin.Value = new DateTime(2025, 12, 31); // 31 de Diciembre de 2025

        }
        private DataTable ObtenerConsumoMaterial(string nombreMaterial, DateTime fechaInicio, DateTime fechaFin)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("spu_consumomaterialpormes", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@nombrematerial", nombreMaterial);
                        command.Parameters.AddWithValue("@fechainicio", fechaInicio);
                        command.Parameters.AddWithValue("@fechafin", fechaFin);

                        connection.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el consumo de material: " + ex.Message, "Error de SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            return dt;
        }

        // Función para mostrar mensaje cuando no hay datos de consumo
        private void MostrarMensajeSinDatos(string materialBuscado)
        {
            string titulo = string.IsNullOrWhiteSpace(materialBuscado)
                                ? "Consumo Total (Sin Datos en el Rango)"
                                : $"Consumo de '{materialBuscado}' (Sin Datos)";
            chartConsumo.Titles.Add(titulo);

            chartConsumo.ChartAreas[0].BackColor = Color.White;

            chartConsumo.Annotations.Clear();
            TextAnnotation textAnnotation = new TextAnnotation();
            textAnnotation.Text = "No hay datos de consumo disponibles para el filtro y rango de fechas seleccionados.";
            textAnnotation.ForeColor = Color.DarkGray;
            textAnnotation.Font = new Font("Arial", 10, FontStyle.Italic);
            textAnnotation.AnchorAlignment = ContentAlignment.MiddleCenter;
            chartConsumo.Annotations.Add(textAnnotation);
        }

        // Función para dibujar el gráfico de Consumo
        private void ConfigurarYDibujarGrafico(DataTable dtConsumo, string materialBuscado)
        {
            chartConsumo.Annotations.Clear();

            string tituloGrafico = string.IsNullOrWhiteSpace(materialBuscado)
                                            ? "Consumo Total de Materiales por Mes"
                                            : $"Consumo de '{materialBuscado}' por Mes";
            chartConsumo.Titles.Add(tituloGrafico);
            chartConsumo.Titles[0].Font = new Font("Arial", 14, FontStyle.Bold);

            Series serieConsumo = new Series("Consumo Mensual")
            {
                ChartType = SeriesChartType.Line,
                IsVisibleInLegend = true,
                Color = Color.FromArgb(73, 153, 222),
                BorderWidth = 4,
                ShadowOffset = 2,
                MarkerStyle = MarkerStyle.Circle,
                MarkerSize = 10,
                MarkerColor = Color.FromArgb(170, 204, 238),
                MarkerBorderColor = Color.FromArgb(43, 84, 150),
                MarkerBorderWidth = 2
            };

            foreach (DataRow row in dtConsumo.Rows)
            {
                string mes = row["Mes"].ToString();
                int cantidad = Convert.ToInt32(row["CantidadConsumida"]);

                DataPoint point = new DataPoint();
                point.SetValueXY(mes, cantidad);

                point.Label = cantidad.ToString();
                point.Font = new Font("Arial", 9, FontStyle.Bold);
                point.LabelForeColor = Color.DarkSlateGray;

                serieConsumo.Points.Add(point);
            }

            chartConsumo.Series.Add(serieConsumo);

            // --- Configuración de Área y Ejes ---
            chartConsumo.ChartAreas[0].BackColor = Color.FromArgb(245, 245, 245);
            chartConsumo.ChartAreas[0].BackGradientStyle = GradientStyle.TopBottom;
            chartConsumo.ChartAreas[0].BackSecondaryColor = Color.White;
            chartConsumo.ChartAreas[0].BorderColor = Color.LightGray;
            chartConsumo.ChartAreas[0].BorderWidth = 1;

            // Eje X
            chartConsumo.ChartAreas[0].AxisX.Title = "Mes";
            chartConsumo.ChartAreas[0].AxisX.TitleFont = new Font("Arial", 11, FontStyle.Bold);
            chartConsumo.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.FromArgb(220, 220, 220);
            chartConsumo.ChartAreas[0].AxisX.LineColor = Color.DarkGray;

            // *** MODIFICACIÓN APLICADA: Etiquetas Verticales para el Consumo ***
            chartConsumo.ChartAreas[0].AxisX.LabelStyle.Angle = 90;
            // -----------------------------------------------------------------

            // Eje Y
            chartConsumo.ChartAreas[0].AxisY.Title = "Cantidad Consumida";
            chartConsumo.ChartAreas[0].AxisY.TitleFont = new Font("Arial", 11, FontStyle.Bold);
            chartConsumo.ChartAreas[0].AxisY.Minimum = 0;
            chartConsumo.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.FromArgb(220, 220, 220);
            chartConsumo.ChartAreas[0].AxisY.LineColor = Color.DarkGray;

            // Leyenda
            chartConsumo.Legends[0].Docking = Docking.Top;
            chartConsumo.Legends[0].Alignment = StringAlignment.Center;
        }

        // Función para dibujar el gráfico de Inventario
        private void ConfigurarYDibujarInventario(DataTable dtInventario)
        {
            chartInventario.Titles.Add("Inventario Actual por Material");
            chartInventario.Titles[0].Font = new Font("Arial", 14, FontStyle.Bold);

            Series serieInventario = new Series("Cantidad Inventario")
            {
                ChartType = SeriesChartType.Column,
                IsVisibleInLegend = false,
                Color = Color.FromArgb(244, 162, 97),
                BorderWidth = 1,
                ShadowOffset = 1,
                BorderColor = Color.FromArgb(231, 111, 81)
            };

            foreach (DataRow row in dtInventario.Rows)
            {
                string material = row["nombreMaterial"].ToString();
                int cantidad = Convert.ToInt32(row["cantidadInventario"]);

                DataPoint point = new DataPoint();
                point.SetValueXY(material, cantidad);

                point.Label = cantidad.ToString();
                point.Font = new Font("Arial", 9, FontStyle.Bold);
                point.LabelForeColor = Color.Black;

                serieInventario.Points.Add(point);
            }

            chartInventario.Series.Add(serieInventario);

            // --- Configuración de Área y Ejes ---
            chartInventario.ChartAreas[0].BackColor = Color.FromArgb(250, 250, 250);
            chartInventario.ChartAreas[0].BorderColor = Color.LightGray;
            chartInventario.ChartAreas[0].BorderWidth = 1;

            // Eje X (Materiales)
            chartInventario.ChartAreas[0].AxisX.Title = "Material";
            chartInventario.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

            // *** MODIFICACIÓN APLICADA: Forzar a mostrar TODAS las etiquetas (Interval = 1) ***
            chartInventario.ChartAreas[0].AxisX.Interval = 1;

            // *** Etiquetas Verticales (Para que quepan) ***
            chartInventario.ChartAreas[0].AxisX.LabelStyle.Angle = 90;

            // Eje Y (Cantidades)
            chartInventario.ChartAreas[0].AxisY.Title = "Unidades Disponibles";
            chartInventario.ChartAreas[0].AxisY.Minimum = 0;
            chartInventario.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.FromArgb(220, 220, 220);
        }

    }

}


