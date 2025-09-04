using Modelos.Entidades;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Vistas.Formularios
{
    public partial class frmConsumoDIT : Form
    {
        private Consumo consumo = new Consumo();

        public frmConsumoDIT()
        {
            InitializeComponent();
        }

        private void frmConsumoDIT_Load(object sender, EventArgs e)
        {
            CargarTodo();
        }

        private void CargarTodo()
        {
            try
            {
                CargarCatalogo();
                CargarGraficoInventario();
                CargarGraficoConsumo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar: " + ex.Message);
            }
        }

        private void CargarCatalogo()
        {
            try
            {
                DataTable dt = consumo.ObtenerCatalogoCompleto();
                dataGridViewCatalogo.DataSource = dt;
                dataGridViewCatalogo.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en catálogo: " + ex.Message);
            }
        }

        private void CargarGraficoInventario()
        {
            try
            {
                chartInventario.Series.Clear();
                DataTable dt = consumo.ObtenerInventarioCompleto();
                
                if (dt != null && dt.Rows.Count > 0)
                {
                    // Crear una serie para el inventario
                    Series serie = chartInventario.Series.Add("Inventario");
                    serie.ChartType = SeriesChartType.Column;
                    
                    // Configurar para mostrar TODOS los nombres
                    chartInventario.ChartAreas[0].AxisX.Interval = 1;
                    chartInventario.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
                    chartInventario.ChartAreas[0].AxisX.LabelStyle.Format = "";

                    // Llenar con datos - MOSTRAR NOMBRES INDIVIDUALES
                    foreach (DataRow row in dt.Rows)
                    {
                        string material = row["nombrematerial"].ToString();
                        int cantidad = Convert.ToInt32(row["cantidad"]);
                        
                        // Agregar punto con el nombre del material
                        serie.Points.AddXY(material, cantidad);
                    }

                    chartInventario.Titles.Clear();
                    chartInventario.Titles.Add("Inventario - Todos los Materiales");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en inventario: " + ex.Message);
            }
        }

        private void CargarGraficoConsumo()
        {
            try
            {
                chartConsumo.Series.Clear();
                DataTable dt = consumo.ObtenerConsumoMaterial(); // <- CONSUMO POR MATERIAL (como antes)
                
                if (dt != null && dt.Rows.Count > 0)
                {
                    Series serie = chartConsumo.Series.Add("Consumo");
                    serie.ChartType = SeriesChartType.Bar;
                    serie.Color = Color.Red;

                    // Configurar para mostrar nombres
                    chartConsumo.ChartAreas[0].AxisX.Interval = 1;
                    chartConsumo.ChartAreas[0].AxisX.LabelStyle.Angle = -45;

                    foreach (DataRow row in dt.Rows)
                    {
                        string material = row["nombrematerial"].ToString();
                        int consumoValor = Convert.ToInt32(row["total_consumido"]);
                        
                        serie.Points.AddXY(material, consumoValor);
                    }

                    chartConsumo.Titles.Clear();
                    chartConsumo.Titles.Add("Consumo por Material");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en consumo: " + ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarTodo();
        }

        // Método para el botón que irá a otro formulario
        private void btnIrAOtroForm_Click(object sender, EventArgs e)
        {
            // Código para abrir otro formulario
        }
    }
}