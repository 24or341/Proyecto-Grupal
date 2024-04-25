using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace EXAU3___CASTAÑEDA
{
    public partial class Frm_Ejercicio02 : Form
    {
        private string connectionString = "SERVER=DESKTOP-D3UV59G; DATABASE=db_ventas; integrated security=true";
        public Frm_Ejercicio02()
        {
            InitializeComponent();
            chart1D.Visible = false;
            chart2L.Visible = false;
            chart3.Visible = false;
        }

        private void Frm_Ejercicio02_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(connectionString);

            try
            {
                cn.Open();
                string query = @"
                    SELECT c.Nombre AS Categoria, COUNT(p.IdProducto) AS CantProductos,
                    CAST(COUNT(p.IdProducto) * 100.0 / SUM(COUNT(p.IdProducto)) OVER () AS DECIMAL(5,2)) AS Porcentaje
                    FROM Categoria c
                    JOIN Producto p ON c.IdCategoria = p.IdCategoria
                    GROUP BY c.Nombre";
                SqlCommand cm = new SqlCommand(query, cn);
                SqlDataAdapter adapter = new SqlDataAdapter(cm);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dt.Columns.Add("Nro.", typeof(int));
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i]["Nro."] = i + 1;
                }
                dt.Columns["Nro."].SetOrdinal(0);
                dgvCantidad.DataSource = dt;
                dgvCantidad.Columns["Porcentaje"].DefaultCellStyle.Format = "0.00'%'";
            }
            catch
            {
               
            }

            
        }

        private void rbtnDoughnut_CheckedChanged(object sender, EventArgs e)
        {
            chart1D.Series.Clear();
            chart1D.Titles.Clear();
            chart1D.Titles.Add("Gráfico Doughnut");
            chart1D.ChartAreas[0].AxisX.Title = "Categoría";
            chart1D.ChartAreas[0].AxisY.Title = "Cantidad de Productos";

            Series doughnutSeries = new Series("Doughnut");
            doughnutSeries.ChartType = SeriesChartType.Doughnut;

            foreach (DataGridViewRow row in dgvCantidad.Rows)
            {
                string categoria = row.Cells["Categoria"].Value.ToString();
                int cantidadProductos = Convert.ToInt32(row.Cells["CantProductos"].Value);

                doughnutSeries.Points.AddXY(categoria, cantidadProductos);
            }

            chart1D.Series.Add(doughnutSeries);
            chart1D.Visible = true;
            chart2L.Visible = false;
            chart3.Visible = false;
        }

        private void rtnLineal_CheckedChanged(object sender, EventArgs e)
        {
            chart2L.Series.Clear();
            chart2L.Titles.Clear();
            chart2L.Titles.Add("Gráfico Lineal");
            chart2L.ChartAreas[0].AxisX.Title = "Categoría";
            chart2L.ChartAreas[0].AxisY.Title = "Porcentaje";

            Series ls = new Series("Porcentaje");
            ls.ChartType = SeriesChartType.Line;

            foreach (DataGridViewRow row in dgvCantidad.Rows)
            {
                string CatL = row.Cells["Categoria"].Value.ToString();
                int cantidadProductos = Convert.ToInt32(row.Cells["PORCENTAJE"].Value);
                ls.Points.AddXY(CatL, cantidadProductos);
            }

            chart2L.Series.Add(ls);
            chart1D.Visible = false;
            chart2L.Visible = true;
            chart3.Visible = false;
        }

        private void rbtnPyramid_CheckedChanged(object sender, EventArgs e)
        {
            chart3.Series.Clear();
            chart3.Titles.Clear();
            chart3.Titles.Add("Gráfico Pyramid");
            chart3.ChartAreas[0].AxisX.Title = "Categoría";
            chart3.ChartAreas[0].AxisY.Title = "Cantidad de Productos";

            Series pyramidSeries = new Series("Pyramid");
            pyramidSeries.ChartType = SeriesChartType.Pyramid;

            foreach (DataGridViewRow row in dgvCantidad.Rows)
            {
                string categoria = row.Cells["Categoria"].Value.ToString();
                int cantidadProductos = Convert.ToInt32(row.Cells["CantProductos"].Value);

                pyramidSeries.Points.AddXY(categoria, cantidadProductos);
            }

            chart3.Series.Add(pyramidSeries);
            chart1D.Visible = false;
            chart2L.Visible = false;
            chart3.Visible = true;
        }

        private void dgvCantidad_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in dgvCantidad.Rows)
            {
                int f = row.Index;
                if ((f % 2) == 0)
                {
                    row.DefaultCellStyle.BackColor = Color.SkyBlue;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 192);
                }
            }
        }
    }
}