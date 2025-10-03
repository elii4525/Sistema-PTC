using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Modelos.Conexion;

namespace Vistas.Formularios
{
    public partial class frmConsumo : Form
    {
        public frmConsumo()
        {
            InitializeComponent();
            this.MinimumSize = new Size(800, 480);
            this.Load += frmConsumo_Load;
        }

        private void frmConsumo_Load(object sender, EventArgs e)
        {
            CargarGraficoInventario();
            CargarGraficoConsumo();
            dtpFechaFin.MaxDate = DateTime.Today;
            dtpFechaInicio.MinDate = new DateTime(2025, 1, 1);
            dtpFechaInicio.MaxDate = DateTime.Today;
        }

        private Chart GetOrCreateChart(string chartName, int index)
        {
            var found = this.Controls.Find(chartName, true);
            if (found.Length > 0 && found[0] is Chart c) return c;

            int margin = 16;
            int width = Math.Max(300, (this.ClientSize.Width - (3 * margin)) / 2);
            int height = Math.Max(240, this.ClientSize.Height - 2 * margin - 60);
            int left = margin + (index * (width + margin));
            int top = margin;

            Chart chart = new Chart
            {
                Name = chartName,
                Left = left,
                Top = top,
                Width = width,
                Height = height,
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
            };

            chart.ChartAreas.Add(new ChartArea("Area1"));
            chart.Legends.Add(new Legend("Legend1"));
            this.Controls.Add(chart);
            chart.BringToFront();

            return chart;
        }

        private void CargarGraficoInventario(string nombreMaterial = "%")
        {
            try
            {
                DataTable dt = ObtenerInventario(nombreMaterial);

                Chart chartInventario = GetOrCreateChart("chartInventario", 0);

                chartInventario.Series.Clear();
                Series serie = new Series("Inventario")
                {
                    ChartType = SeriesChartType.Column,
                    IsValueShownAsLabel = true
                };

                if (dt != null && dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        string nombre = row["nombreMaterial"].ToString();
                        int cantidad = Convert.ToInt32(row["cantidadInventario"]);
                        serie.Points.AddXY(nombre, cantidad);
                    }
                }
                else
                {
                    serie.Points.AddXY("Sin datos", 0);
                }

                chartInventario.Series.Add(serie);

                // estilo del gráfico
                var areaInv = chartInventario.ChartAreas[0];
                areaInv.AxisX.Title = "Material";
                areaInv.AxisY.Title = "Unidades Disponibles";
                areaInv.AxisX.LabelStyle.Angle = 90; 
                areaInv.AxisX.Interval = 1;
                areaInv.AxisX.IsLabelAutoFit = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar gráfico de inventario: " + ex.Message);
            }
        }

        private void CargarGraficoConsumo()
        {
            try
            {
                DataTable dt = ObtenerConsumoMaterial();
                Chart chartConsumo = GetOrCreateChart("chartConsumo", 1);
                chartConsumo.Series.Clear();

                Series serie = new Series("Consumo")
                {
                    ChartType = SeriesChartType.Column,
                    IsValueShownAsLabel = true
                };

                if (dt != null && dt.Rows.Count > 0)
                {
                    string colEtiqueta = dt.Columns.Contains("Mes") ? "Mes" :
                                         dt.Columns.Contains("nombreMaterial") ? "nombreMaterial" : dt.Columns[0].ColumnName;

                    string colValor = dt.Columns.Contains("CantidadConsumida") ? "CantidadConsumida" :
                                      dt.Columns.Contains("total_consumido") ? "total_consumido" : dt.Columns[1].ColumnName;

                    foreach (DataRow row in dt.Rows)
                    {
                        string etiqueta = row[colEtiqueta]?.ToString() ?? "N/A";
                        int valor = 0;
                        int.TryParse(row[colValor]?.ToString() ?? "0", out valor);
                        serie.Points.AddXY(etiqueta, valor);
                    }
                }
                else serie.Points.AddXY("Sin datos", 0);

                chartConsumo.Series.Add(serie);

                var areaCon = chartConsumo.ChartAreas[0];
                areaCon.BackColor = Color.FromArgb(245, 245, 245);
                areaCon.BorderColor = Color.LightGray;
                areaCon.BorderWidth = 1;
                areaCon.AxisX.Title = "Mes / Material";
                areaCon.AxisX.LabelStyle.Angle = 90;
                areaCon.AxisY.Title = "Cantidad Consumida";
                areaCon.AxisY.Minimum = 0;
                areaCon.AxisY.MajorGrid.LineColor = Color.FromArgb(220, 220, 220);

                if (chartConsumo.Legends.Count > 0)
                {
                    chartConsumo.Legends[0].Docking = Docking.Top;
                    chartConsumo.Legends[0].Alignment = StringAlignment.Center;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar gráfico de consumo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable ObtenerInventario(string nombreMaterial)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection cn = ConexionDB.Conectar())
                {
                    if (cn == null) return dt;

                    using (SqlCommand cmd = new SqlCommand("spu_obtenerinventariomaterial", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@nombrematerial", nombreMaterial ?? "%");
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en ObtenerInventario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        private DataTable ObtenerConsumoMaterial()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection cn = ConexionDB.Conectar())
                {
                    if (cn == null) return dt;

                    using (SqlCommand cmd = new SqlCommand("sp_obtener_consumo_material", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en ObtenerConsumoMaterial: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filtro = txtBusqueda.Text.Trim();
            if (string.IsNullOrEmpty(filtro))
                filtro = "%"; 
            CargarGraficoInventario(filtro);
        }

        private void frmConsumo_Load_1(object sender, EventArgs e)
        {
            CargarGraficoInventario();
            CargarGraficoConsumo();
        }
    }
}
