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
    public partial class DonacionAdd : Form
    {
        librarydbEntities db = new librarydbEntities();
        private DataTable booksTable = new DataTable();
        int Administrador_id;
        public DonacionAdd(int id_admin)
        {
            InitializeComponent();
            InitBooksTableTemp();
            updateData();
            gDgvData.DataSource = booksTable;
            Administrador_id = id_admin;
        }

        public void InitBooksTableTemp()
        {
            booksTable.Columns.Add("id", typeof(int));
            booksTable.Columns.Add("codigo", typeof(string));
            booksTable.Columns.Add("libro", typeof (string));
            booksTable.Columns.Add("cantidad", typeof(int));
        }
        public void updateData()
        {
            txtFecha.Text = DateTime.Now.ToShortDateString();

        }

        private void gBtnBuscarDn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreDn.Text))
            {
                MessageBox.Show("Debe Ingresar un Donante", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var donante =  db.sp_SelectDonatorsByName(txtNombreDn.Text).FirstOrDefault();

            if (donante == null)
            {
                MessageBox.Show("No se ha encontrado un donante", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtNombreDn.Text = donante.nombre;
            txtIdDn.Text = donante.idDonante.ToString();
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

        private void softClearData()
        {
            txtCodLib.Clear();
            txtidLib.Clear();
            txtLibro.Clear();
            gTxtCantidad.Value = 0;
        }

        private void gBtnAddtoCar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodLib.Text) ||
                string.IsNullOrWhiteSpace(txtIdDn.Text) ||
                string.IsNullOrWhiteSpace(txtNombreDn.Text) ||
                string.IsNullOrWhiteSpace(txtLibro.Text))
            {
                MessageBox.Show("Debe Ingresar todos los Datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int cantidad = Convert.ToInt32(gTxtCantidad.Value);
            if(cantidad == 0)
            {
                MessageBox.Show("La donacion debe ser mayor a 0", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string codigo = txtCodLib.Text;
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
                var result = MessageBox.Show("¿Desea eliminar esta donacion?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Remove the row from the DataTable
                    booksTable.Rows[e.RowIndex].Delete();
                }

            }
        }

        private void gBtnAddCompra_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Desea realizar esta donacion?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int idDonante = Convert.ToInt32(txtIdDn.Text);
                ObjectParameter idDonacionParam = new ObjectParameter("idDonacion", typeof(int));

                db.sp_createDonacionReturnID1(idDonante, Administrador_id, DateTime.Now.Date, idDonacionParam);

                int idDonacion = (int)idDonacionParam.Value;

                if (idDonacion == 0)
                {
                    MessageBox.Show("No se ha podido ingresar la donacion correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                        var Resultado = db.sp_insertDetalle_Donacion(idDonacion, id, cantidad, DateTime.Now.Date);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se ha podido ingresar la donacion correctamente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("Se ha ingresado la donacion Exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                booksTable.Clear();
            }
        }

    }
}
