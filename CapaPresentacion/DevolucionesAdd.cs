using CapaPresentacion.BaseDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class DevolucionesAdd : Form
    {
        librarydbEntities db = new librarydbEntities();
        private int id_Prestamo;
        private DateTime fechaSugerida;

        public DevolucionesAdd(int idPrestamo, DateTime FechaPrestamo, DateTime FechaSugerida,
            string NombreUsuario, int idUsuario)
        {
            InitializeComponent();
            txtNombreUser.Text = NombreUsuario;
            txtIdUser.Text = idUsuario.ToString();
            txtFecha.Text = FechaPrestamo.ToShortDateString();
            txtDevolucion.Text = DateTime.Now.ToShortDateString();

            gDgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            id_Prestamo = idPrestamo;
            fechaSugerida = FechaSugerida;
            txtFechaSugerida.Text = fechaSugerida.ToShortDateString();

            gCmbEstado.DisplayMember = "Texto";
            gCmbEstado.ValueMember = "Value";
            gCmbEstado.Items.Add(new { Texto = "Completado", Value = 1003 });
            gCmbEstado.Items.Add(new { Texto = "En Prestamo", Value = 1002 });

            loadGrid();
        }
        

        private void loadGrid()
        {
            var detalle = db.sp_SelectPrestamobyIDforDevolucion(id_Prestamo).ToList();
            gDgvData.DataSource = detalle;
        }

        private void clearData()
        {
            gTxtLibro.Clear();
            txtidLibro.Clear();
        }

        private void gBtnAddtoCar_Click(object sender, EventArgs e)
        {

        }

        private void gBtnBuscarDn_Click(object sender, EventArgs e)
        {
            ModUsuarioPrest forUs = new ModUsuarioPrest();
            forUs.Show();
        }

        private void gBtnAddCompra_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea actualizar el estado del libro?", "Devoluciones", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Asegúrate de que hay una fila seleccionada
                if (gDgvData.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = gDgvData.SelectedRows[0];

                    // Verificar que la celda "id_estado" no sea null antes de acceder a su valor
                    if (selectedRow.Cells["id_estado"] != null && selectedRow.Cells["id_estado"].Value != null)
                    {
                        int currentEstado = Convert.ToInt32(selectedRow.Cells["id_estado"].Value);

                        // Verificar que gCmbEstado.SelectedIndex no sea -1 antes de usarlo
                        if (gCmbEstado.SelectedIndex != -1)
                        {
                            int selectedEstado = (gCmbEstado.SelectedIndex == 0) ? 1003 : 1002;

                            // Actualizar el valor de id_estado si es diferente
                            if (currentEstado != selectedEstado)
                            {
                                selectedRow.Cells["id_estado"].Value = selectedEstado;
                                selectedRow.Cells["Estado"].Value = (gCmbEstado.SelectedIndex == 0) ? "Completado" : "En Prestamo"; ;

                                // Actualizar visualmente la fila según el nuevo estado
                                UpdateRowStyle(selectedRow, selectedEstado);

                                MessageBox.Show("Operacion confirmada", "Devoluciones", MessageBoxButtons.OK);
                            }
                            else
                            {
                                MessageBox.Show("El estado seleccionado es el mismo que el actual.", "Devoluciones", MessageBoxButtons.OK);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se ha seleccionado un estado válido.", "Devoluciones", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("La fila seleccionada no tiene un estado válido.", "Devoluciones", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("No hay ninguna fila seleccionada.", "Devoluciones", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("No se realizó la operación", "Devoluciones", MessageBoxButtons.OK);
            }
        }

        private void UpdateRowStyle(DataGridViewRow row, int estado)
        {
            switch (estado)
            {
                case 1001:
                    row.DefaultCellStyle.BackColor = Color.Goldenrod;
                    row.DefaultCellStyle.ForeColor = Color.White;
                    break;
                case 1002:
                    row.DefaultCellStyle.BackColor = Color.Brown;
                    row.DefaultCellStyle.ForeColor = Color.White;
                    break;
                case 1003:
                    row.DefaultCellStyle.BackColor = Color.ForestGreen;
                    row.DefaultCellStyle.ForeColor = Color.White;
                    break;
            }
        }
            private void gDgvData_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtener el DataGridView y la fila actual
                DataGridView dgv = sender as DataGridView;
                DataGridViewRow row = dgv.Rows[e.RowIndex];

                // Verifica si la columna "stock" existe y tiene un valor
                if (dgv.Columns["id_Estado"] != null && row.Cells["id_Estado"].Value != null)
                {
                    // Obtener el valor de la celda "stock"
                    int Estado = Convert.ToInt32(row.Cells["id_Estado"].Value);

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

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fillData(int idLibro, string NombreLibro, int idEstado)
        {
            txtidLibro.Text = idLibro.ToString();
            gTxtLibro.Text = NombreLibro.ToString();
            if(idEstado == 1002)
            {
                gCmbEstado.SelectedIndex = 1;
            }
            if (idEstado == 1003)
            {
                gCmbEstado.SelectedIndex = 0;
            }
        }

        private void gDgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                var clickedRow = senderGrid.Rows[e.RowIndex];
                int idLibro = (int)clickedRow.Cells["id_libro"].Value;
                string NombreLibro = (string)clickedRow.Cells["libro"].Value;
                int idEstado = (int)clickedRow.Cells["id_estado"].Value;

                fillData(idLibro, NombreLibro, idEstado);
                

            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Confirmar los cambios?", "Devoluciones", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    foreach (DataGridViewRow row in gDgvData.Rows)
                    {
                        // Asegúrate de que la fila no es una fila nueva antes de intentar procesarla
                        if (!row.IsNewRow)
                        {
                            // Extract the data from the row and store it in temporary variables
                            int id = Convert.ToInt32(row.Cells["idPrestamoDetalle"].Value);
                            int idPrestamo = Convert.ToInt32(row.Cells["Idprestamo"].Value);
                            int estado = Convert.ToInt32(row.Cells["id_estado"].Value);
                            int idlibro = Convert.ToInt32(row.Cells["id_libro"].Value);

                            // Llama al procedimiento almacenado
                            var Resultado = db.sp_updateDetallePrestamo(id, idPrestamo, estado, idlibro);
                            if (estado == 1003)
                            {
                                db.sp_UpdateFechaDevueltoDetallePrestamoDevol(DateTime.Now, id);
                            }
                            else
                            {
                                db.sp_UpdateFechaDevueltoDetallePrestamoDevol(null, id);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se ha podido ingresar el prestamo correctamente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            this.Close();

        }
    }
}
