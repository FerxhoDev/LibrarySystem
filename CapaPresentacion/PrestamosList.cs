using CapaPresentacion.BaseDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class PrestamosList : Form
    {
        librarydbEntities db = new librarydbEntities();
        private int id_usuario;
        public PrestamosList()
        {
            InitializeComponent();
            updateData();
            gDgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void updateData()
        {
            var prestamos = db.sp_selectAllPrestamoswithUserAndEstado().ToList();
            gDgvData.DataSource = prestamos;
            
        }

        private void gBtnDetalle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(gTxtId.Text))
            {
                MessageBox.Show("Seleccione un prestamo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int idPrestamo = Convert.ToInt32(gTxtId.Text);
            DateTime Fecha_Prestamo = Convert.ToDateTime(gTxtFecha.Text);
            DateTime Fecha_Sugerida = Convert.ToDateTime(gTxtIndice.Text);
            string Nombre = gTxtDonante.Text;
            ModDetallePrestamo detalle = new ModDetallePrestamo(idPrestamo, Fecha_Prestamo, Fecha_Sugerida, Nombre);
            detalle.Show();
        }
        private void clearData()
        {
            gTxtDonante.Clear();
            gTxtId.Clear();
            gTxtIndice.Clear();
            gTxtFecha.Clear();
            id_usuario = 0;
            updateData();
        }
        private void fillData(int idPrestamo, string Nombre, DateTime Fecha, DateTime FechaSugerida)
        {
            gTxtId.Text = idPrestamo.ToString();
            gTxtDonante.Text = Nombre;
            gTxtFecha.Text = Fecha.ToShortDateString();
            gTxtIndice.Text = FechaSugerida.ToShortDateString();
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
                        row.DefaultCellStyle.BackColor = Color.Khaki;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                    if (Estado == 1002)
                    {
                        row.DefaultCellStyle.BackColor = Color.Tomato;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                    if (Estado == 1003)
                    {
                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }

                }
            }
        }

        private void gDgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                var clickedRow = senderGrid.Rows[e.RowIndex];
                int idPrestamo = (int)clickedRow.Cells["id"].Value;
                int idUsuario = (int)clickedRow.Cells["idUsuario"].Value;
                string Nombre = (string)clickedRow.Cells["Usuario"].Value;
                DateTime Fecha = (DateTime)clickedRow.Cells["FechaPrestamo"].Value;
                DateTime FechaSugerida = (DateTime)clickedRow.Cells["Devolucion"].Value;

                fillData(idPrestamo, Nombre, Fecha, FechaSugerida);
                id_usuario = idUsuario;

            }
        }

        private void gBtnLimpiar_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void gBtnDevolucion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(gTxtId.Text))
            {
                MessageBox.Show("Seleccione un prestamo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int idPrestamo = Convert.ToInt32(gTxtId.Text);
            DateTime Fecha_Prestamo = Convert.ToDateTime(gTxtFecha.Text);
            DateTime Fecha_Sugerida = Convert.ToDateTime(gTxtIndice.Text);
            string Nombre = gTxtDonante.Text;
            DevolucionesAdd devoluciones = new DevolucionesAdd(idPrestamo, Fecha_Prestamo, Fecha_Sugerida, Nombre, id_usuario);
            devoluciones.Show();

            clearData();
        }
    }
}
