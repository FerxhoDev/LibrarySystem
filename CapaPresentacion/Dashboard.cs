using CapaPresentacion.BaseDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Dashboard : Form
    {
        librarydbEntities db = new librarydbEntities();
        public Dashboard()
        {
            InitializeComponent();
            guna2DateTimePicker2.Value = DateTime.Now;
            guna2DateTimePicker1.Value = DateTime.Now.AddMonths(-1);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void UpdateData()
        {
            var TotalDonaciones = db.sp_selectTotalDonaciones().FirstOrDefault();
            var TotalLibros = db.sp_selectTotalStockLibros().FirstOrDefault();
            var TotalUsuarios = db.sp_selectTotalUsuarios().FirstOrDefault();
            var TotalDirecciones = db.sp_selectTotalDirecciones().FirstOrDefault();

            var TotalPrestamosComp = db.sp_selectTotalPrestamosRatioDevoluciones().FirstOrDefault();
            int Prestamos = (int)TotalPrestamosComp.Prestamos;
            int Devoluciones = (int)TotalPrestamosComp.Devoluciones;

            double porcentajeCPB = Devoluciones * 100;
            double porcentC = porcentajeCPB / Prestamos;

            lblTotalDonacion.Text = "Total: " + TotalDonaciones.ToString();
            lblTotalUsuarios.Text = "Total: " + TotalUsuarios.ToString();
            lblTotalDirecciones.Text = "Total: " + TotalDirecciones.ToString();
            lblTotalInventario.Text = "Total: " + TotalLibros.ToString();

            gPbTotPres.Maximum = 100;
            gPbTotPres.Value = 100;

            gPbTotUser.Maximum = 100;
            gPbTotUser.Value = 100;

            gPbTotAddres.Maximum = 100;
            gPbTotAddres.Value = 100;

            gPbTotInvet.Maximum = 100;
            gPbTotInvet.Value = 100;

            //int Porcentajetop1 = ((int)topLibros[0].Prestamos * 100 / Prestamos);
            //int Porcentajetop2 = ((int)topLibros[1].Prestamos * 100 / Prestamos);
            //int Porcentajetop3 = ((int)topLibros[2].Prestamos * 100 / Prestamos);


            var topLibros = db.sp_selectTop3LibrosPopulares().ToList();
            if (Devoluciones != 0)
            {
                lblPorcentajeG.Text = ((Devoluciones * 100) / Prestamos).ToString() + "%";
            }

            if (topLibros.Count > 1)
            {
                lblLibTop1.Text = topLibros[0].nombre;
                lblCantTop1.Text = topLibros[0].Prestamos.ToString();
                gCPBTop1.Maximum = Prestamos;
                gCPBTop1.Value = (int)topLibros[0].Prestamos;
                lblPortop1.Text = (((int)topLibros[0].Prestamos * 100) / Prestamos).ToString() + "%";
            }
            else
            {
                pictureBox1.Visible = false;
                label28.Visible = false;
                lblLibTop1.Visible = false;
                lblCantTop1.Visible = false;
                gCPBTop1.Visible = false;
                lblPortop1.Visible = false;

                pictureBox2.Visible = false;
                label29.Visible = false;
                lblLibTop2.Visible = false;
                lblCantTop2.Visible = false;
                gCPBTop2.Visible = false;
                lblPortop2.Visible = false;

                pictureBox3.Visible = false;
                label30.Visible = false;
                lblLibTop3.Visible = false;
                lblCantTop3.Visible = false;
                gCPBTop3.Visible = false;
                lblPortop3.Visible = false;

            }

            if (topLibros.Count > 2)
            {
                lblLibTop2.Text = topLibros[1].nombre;
                lblCantTop2.Text = topLibros[1].Prestamos.ToString();
                gCPBTop2.Maximum = Prestamos;
                gCPBTop2.Value = (int)topLibros[1].Prestamos;
                lblPortop2.Text = (((int)topLibros[1].Prestamos * 100) / Prestamos).ToString() + "%";
            }
            else
            {
                pictureBox2.Visible = false;
                label29.Visible = false;
                lblLibTop2.Visible = false;
                lblCantTop2.Visible = false;
                gCPBTop2.Visible = false;
                lblPortop2.Visible = false;

                pictureBox3.Visible = false;
                label30.Visible = false;
                lblLibTop3.Visible = false;
                lblCantTop3.Visible = false;
                gCPBTop3.Visible = false;
                lblPortop3.Visible = false;
            }

            if (topLibros.Count > 3)
            {
                lblLibTop3.Text = topLibros[2].nombre;
                lblCantTop3.Text = topLibros[2].Prestamos.ToString();
                gCPBTop3.Maximum = Prestamos;
                gCPBTop3.Value = (int)topLibros[2].Prestamos;
                lblPortop3.Text = (((int)topLibros[2].Prestamos * 100) / Prestamos).ToString() + "%";
            }
            else
            {

                pictureBox3.Visible = false;
                label30.Visible = false;
                lblLibTop3.Visible = false;
                lblCantTop3.Visible = false;
                gCPBTop3.Visible = false;
                lblPortop3.Visible = false;
            }

            gCPBLibPD.Maximum = Prestamos;
            gCPBLibPD.Value = Devoluciones;
            lblPrestamos.Text = Prestamos.ToString();
            lblDevoluciones.Text = Devoluciones.ToString();
            
            Thread.CurrentThread.CurrentCulture = new CultureInfo("es-ES");

            DateTime Fecha1 = guna2DateTimePicker1.Value;
            DateTime Fecha2 = guna2DateTimePicker2.Value;

            // Fetch data from the stored procedure
            var graficaData = db.sp_selectPrestamosLibrosBetweenDates(Fecha1, Fecha2).ToList();

            // Clear existing series
            ChartPrestamo.Series.Clear();

            // Create a new series and set its properties
            var series = new System.Windows.Forms.DataVisualization.Charting.Series("LibrosCount");
            series.XValueMember = "Date";
            series.YValueMembers = "LibrosCount";
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea; // Choose appropriate chart type

            // Set gradient for the series
            series.Color = Color.FromArgb(255, 0, 255, 255); // Start color with some transparency
            series.BackSecondaryColor = Color.FromArgb(255, 170, 188, 150); // End color with some transparency
            series.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight; // Gradient style

            // Add the series to the chart
            ChartPrestamo.Series.Add(series);

            // Set the data source for the chart
            ChartPrestamo.DataSource = graficaData;

            ChartPrestamo.ChartAreas[0].AxisX.LabelStyle.Format = "MMM dd";

            // Optional: Configure additional properties of the X-axis for better readability
            ChartPrestamo.ChartAreas[0].AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Days;
            ChartPrestamo.ChartAreas[0].AxisX.Interval = 1;
            ChartPrestamo.ChartAreas[0].AxisX.LabelStyle.Angle = -45; // Rotate labels for better fit


            // Data bind the chart
            ChartPrestamo.DataBind();

            

        }

        private void guna2DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            guna2DateTimePicker1.MaxDate =  guna2DateTimePicker2.Value.AddDays(-1);
            UpdateData();
        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            guna2DateTimePicker2.MinDate = guna2DateTimePicker1.Value.AddDays(1);
            UpdateData();
        }
    }
}
