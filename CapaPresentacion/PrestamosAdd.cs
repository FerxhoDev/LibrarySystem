using CapaPresentacion.BaseDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class PrestamosAdd : Form
    {
        librarydbEntities db = new librarydbEntities();
        private DataTable booksTable = new DataTable();
        int administrador_id;
        int totalCantidad;
        public PrestamosAdd(int id_admin)
        {
            InitializeComponent();
            administrador_id = id_admin;
            updateData();
            InitBooksTableTemp();
            gDgvData.DataSource = booksTable;
            gDtpDevolucion.MinDate = DateTime.Today.AddDays(1);
            gDtpDevolucion.MaxDate = DateTime.Today.AddYears(2);
        }
        public void InitBooksTableTemp()
        {
            booksTable.Columns.Add("id", typeof(int));
            booksTable.Columns.Add("codigo", typeof(string));
            booksTable.Columns.Add("libro", typeof(string));
            booksTable.Columns.Add("cantidad", typeof(int));
        }
        private void updateData()
        {
            txtFecha.Text = DateTime.Now.ToShortDateString();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void gBtnBuscarDn_Click(object sender, EventArgs e)
        {
            bool retry = true;
            while (retry)
            {
                ModUsuarioPrest forUs = new ModUsuarioPrest();
                var result = forUs.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string nombre = forUs.nombre;
                    int id = forUs.idUsuario;
                    int estado = forUs.estado;

                    if (estado == 1001 || estado == 1002)
                    {
                        var errorResult = MessageBox.Show("El usuario " + nombre + " tiene prestamos pendientes, no es posible realizar un nuevo prestamo",
                            "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                        if(errorResult == DialogResult.Cancel)
                        {
                            retry = false;
                            break;
                        }

                    }
                    else
                    {
                        txtIdUser.Text = id.ToString();
                        txtNombreUser.Text = nombre;
                        retry = false;
                    }

                    
                }
                else
                {
                    retry = false;
                }
            }
            
        }
        private void hardClearData()
        {
            booksTable.Clear();
            softClearData();
            txtIdUser.Clear();
            txtNombreUser.Clear();
            txtFecha.Text = DateTime.Now.ToShortDateString();
        }
        private void softClearData()
        {
            txtCodLib.Clear();
            txtidLib.Clear();
            txtLibro.Clear();
            gTxtCantidad.Value = 0;
        }
        private void gBtnBuscarLib_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodLib.Text))
            {
                MessageBox.Show("Debe Ingresar un Codigo de Libro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var Libro = db.sp_SelectLibrosByCodLibros(txtCodLib.Text).FirstOrDefault();

            if (Libro == null)
            {
                MessageBox.Show("No se ha encontrado un Libro con ese codigo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtLibro.Text = Libro.nombre;
            txtidLib.Text = Libro.idLibro.ToString();
        }

        private void gBtnAddtoCar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodLib.Text) ||
                string.IsNullOrWhiteSpace(txtIdUser.Text) ||
                string.IsNullOrWhiteSpace(txtNombreUser.Text) ||
                string.IsNullOrWhiteSpace(txtLibro.Text))
            {
                MessageBox.Show("Debe Ingresar todos los Datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int cantidad = Convert.ToInt32(gTxtCantidad.Value);
            if (cantidad > 3)
            {
                MessageBox.Show("Solo se permite un prestamo de 3 libros o menos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cantidad == 0 )
            {
                MessageBox.Show("Ingrese un numero mayor a 0", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (totalCantidad + cantidad > 3)
            {
                MessageBox.Show("Solo se permite un prestamo de 3 libros o menos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string codigo = txtCodLib.Text;

            var disponibilidadL = db.sp_selectAvaliableLibro(codigo).FirstOrDefault();
            if(cantidad > disponibilidadL.disponible)
            {
                MessageBox.Show("No hay suficientes libros para Realizar el prestamo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            totalCantidad = cantidad + totalCantidad;

            
            string libro = txtLibro.Text;
            int idLibro = Convert.ToInt32(txtidLib.Text);

            DataRow newRow = booksTable.NewRow();
            newRow["id"] = idLibro;
            newRow["codigo"] = codigo;
            newRow["libro"] = libro;
            newRow["cantidad"] = cantidad;
            booksTable.Rows.Add(newRow);
            softClearData();
        }

        private void gDgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                var clickedRow = senderGrid.Rows[e.RowIndex];
                var result = MessageBox.Show("¿Desea cancelar este prestamo?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int cantidad = (int)clickedRow.Cells["cantidad"].Value;
                    // Remove the row from the DataTable
                    totalCantidad = totalCantidad - cantidad;
                    booksTable.Rows[e.RowIndex].Delete();
                }

            }
        }

        private void gBtnAddCompra_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Desea realizar este Prestamo?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
               
                int idPrestamista = Convert.ToInt32(txtIdUser.Text);
                DateTime FechaDevolucion = gDtpDevolucion.Value;

                ObjectParameter idPrestamoParam = new ObjectParameter("idPrestamo", typeof(int));

                db.sp_createPrestamoReturnID(idPrestamista, administrador_id, DateTime.Now, FechaDevolucion,
                    1002, idPrestamoParam);

                int idPrestamo = (int)idPrestamoParam.Value;

                if (idPrestamo == 0)
                {
                    MessageBox.Show("No se ha podido ingresar el prestamo correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    foreach (DataRow row in booksTable.Rows)
                    {
                        // Extract the data from the row and store it in temporary variables
                        int id = Convert.ToInt32(row["id"]);
                        string codigo = row["codigo"].ToString();
                        string libro = row["libro"].ToString();
                        int cantidad = Convert.ToInt32(row["cantidad"]);
                        while(cantidad > 0)
                        {
                            var Resultado = db.sp_insertDetalle_Prestamo(idPrestamo, 1002, id);
                            cantidad--;
                        }
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se ha podido ingresar el prestamo correctamente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                hardClearData();
                MessageBox.Show("Se ha ingresado el prestamo Exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
