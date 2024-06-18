using CapaPresentacion.BaseDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class ModDetallePrestamo : Form
    {
        librarydbEntities db = new librarydbEntities();
        public ModDetallePrestamo(int id_Prestamo, DateTime FechaPrestamo, DateTime FechaSugerida,
            string Nombre)
        {
            InitializeComponent();
            LoadData(id_Prestamo, FechaPrestamo, FechaSugerida, Nombre);
            gDgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void LoadData(int id_Prestamo, DateTime FechaPrestamo, DateTime FechaSugerida,
            string Nombre)
        {
            txtNomDonan.Text = Nombre;
            txtFecha.Text = FechaPrestamo.ToShortDateString();
            textBox1.Text = FechaSugerida.ToShortDateString();
            txtBusqueda.Text = id_Prestamo.ToString();

            var detalle = db.sp_selectAllDetallePrestamobyIDPrestamo(id_Prestamo).ToList();
            gDgvData.DataSource = detalle;
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void gDgvData_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

        }

        private void gDgvData_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtener el DataGridView y la fila actual
                DataGridView dgv = sender as DataGridView;
                DataGridViewRow row = dgv.Rows[e.RowIndex];

                // Verifica si la columna "stock" existe y tiene un valor
                if (dgv.Columns["idEstado"] != null && row.Cells["idEstado"].Value != null)
                {
                    // Obtener el valor de la celda "stock"
                    int Estado = Convert.ToInt32(row.Cells["idEstado"].Value);

                    // Si el valor de "stock" es 0, colorear la fila de rojo
                    if (Estado == 1001)
                    {
                        row.DefaultCellStyle.BackColor = Color.Goldenrod;
                        row.DefaultCellStyle.ForeColor = Color.White;
                    }
                    if (Estado == 1002)
                    {
                        row.DefaultCellStyle.BackColor = Color.Brown;
                        row.DefaultCellStyle.ForeColor = Color.White;
                    }
                    if (Estado == 1003)
                    {
                        row.DefaultCellStyle.BackColor = Color.ForestGreen;
                        row.DefaultCellStyle.ForeColor = Color.White;
                    }

                }
            }
        }
    }
}
