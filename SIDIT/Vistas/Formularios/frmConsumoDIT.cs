using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Modelos.Entidades;

namespace Vistas.Formularios
{
    // Esta es una clase parcial del formulario.
    public partial class frmConsumoDIT : Form
    {
        private Consumo consumo = new Consumo();

        // Constructor del formulario. Aquí se inicializan todos los componentes.
        public frmConsumoDIT()
        {
            InitializeComponent();
        }

        // Evento que se ejecuta cuando se carga el formulario
        private void frmConsumoDIT_Load(object sender, EventArgs e)
        {
            // Carga los datos iniciales del catálogo, inventario y consumo
            CargarCatalogo();
            CargarGraficoInventario();
            // Llama al método para cargar el gráfico de consumo
            // Al cargar, establece un rango de fechas por defecto que incluye los datos de prueba
            CargarGraficoConsumo(new DateTime(2025, 1, 1), new DateTime(2025, 12, 31));
        }

        // Método para cargar el catálogo de materiales en el DataGridView
        private void CargarCatalogo()
        {
            try
            {
                // Obtiene la tabla de datos del catálogo. Si no hay datos, devuelve una tabla vacía.
                DataTable dt = consumo.ObtenerCatalogoMateriales();
                if (dt != null && dt.Rows.Count > 0)
                {
                    // Asigna la tabla de datos como la fuente para el DataGridView
                    dataGridViewCatalogo.DataSource = dt;
                    // Oculta la columna del ID del material para el usuario
                    dataGridViewCatalogo.Columns["idmaterial"].Visible = false;
                }
                else
                {
                    MessageBox.Show("No se encontraron materiales en el catálogo.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el catálogo: " + ex.Message);
            }
        }

        // Método para cargar el gráfico de inventario
        private void CargarGraficoInventario(string filtro = null)
        {
            try
            {
                // Limpia los datos existentes en el gráfico para evitar superposición
                chartInventario.Series.Clear();

                // Obtiene los datos del inventario. Si no hay datos, devuelve una tabla vacía.
                DataTable dt = consumo.ObtenerDatosInventario(filtro);
                if (dt != null && dt.Rows.Count > 0)
                {
                    // Crea una nueva serie para el gráfico
                    chartInventario.Series.Add("Inventario");
                    chartInventario.Series["Inventario"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

                    // Llena el gráfico con los datos de la tabla
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        chartInventario.Series["Inventario"].Points.AddXY(dt.Rows[i]["nombrematerial"], dt.Rows[i]["cantidad"]);
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron datos para el inventario con el filtro aplicado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el gráfico de inventario: " + ex.Message);
            }
        }

        // Método para cargar el gráfico de consumo mensual
        private void CargarGraficoConsumo(DateTime? fechaInicio = null, DateTime? fechaFin = null)
        {
            try
            {
                // Limpia los datos existentes en el gráfico para evitar superposición
                chartConsumo.Series.Clear();

                // Obtiene los datos de consumo. Si no hay datos, devuelve una tabla vacía.
                DataTable dt = consumo.ObtenerDatosConsumo(fechaInicio ?? DateTime.MinValue, fechaFin ?? DateTime.MaxValue);
                if (dt != null && dt.Rows.Count > 0)
                {
                    // Crea una nueva serie para el gráfico
                    chartConsumo.Series.Add("Consumo");
                    chartConsumo.Series["Consumo"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                    chartConsumo.Series["Consumo"].Color = Color.Blue; // Puedes personalizar el color

                    // Llena el gráfico con los datos de la tabla
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        chartConsumo.Series["Consumo"].Points.AddXY(dt.Rows[i]["mes"], dt.Rows[i]["totalconsumido"]);
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron datos de consumo en el rango de fechas seleccionado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el gráfico de consumo: " + ex.Message);
            }
        }

        // Evento que se ejecuta al hacer clic en el botón de búsqueda
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Obtiene el texto del cuadro de búsqueda y carga los gráficos y el catálogo
            string filtro = txtBuscar.Text;
            CargarCatalogo();
            CargarGraficoInventario(filtro);
            CargarGraficoConsumo(dtpInicio.Value, dtpFin.Value);
        }
    }
}
