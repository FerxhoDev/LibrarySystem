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
    public partial class DonacionPersona : Form
    {
        librarydbEntities db = new librarydbEntities();
        public DonacionPersona()
        {
            InitializeComponent();
            clearData();
            updateData();
        }

        public void updateData()
        {
            var donantes = db.sp_selectAllDonantes();
            gDgvData.DataSource = donantes;
        }
        public void clearData()
        {
            gTxtId.Clear();
            gTxtIndice.Clear();
            gTxtNombre.Clear();
        }

        public void FillData(int id, string nombre)
        {
            gTxtId.Text = id.ToString();
            gTxtNombre.Text = nombre;
        }

        private void gBtnLimpiar_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void gBtnGuardar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(gTxtNombre.Text)) {
                MessageBox.Show("Todos los datos deben ser llenados.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(string.IsNullOrWhiteSpace(gTxtId.Text))
            {
                //metodo nuevo
                try
                {
                    var resultado = db.sp_insertDonantes(gTxtNombre.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se ha podido ingresar el Donante", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("Se ha ingresado el nuevo donante", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    var resultado = db.sp_updateDonante(Convert.ToInt32(gTxtId.Text), gTxtNombre.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se ha podido actualizar el Donante", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("Se ha actualizado el nuevo donante", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            updateData();
            clearData();
        }

        private void gDgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                var clickedRow = senderGrid.Rows[e.RowIndex];

                int idDonante = (int)clickedRow.Cells["id"].Value;
                string nombre = (string)clickedRow.Cells["nombre"].Value;
                

                //Poner datos en las barras:
                FillData(idDonante, nombre);

            }
        }

        private void gBtnEliminar_Click(object sender, EventArgs e)
        {
            if (gTxtId.Text == string.Empty)
            {
                MessageBox.Show("No se ha seleccionado ningun donante", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                DialogResult result = MessageBox.Show("¿Desea eliminar el donante?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    int idElim = Convert.ToInt32(gTxtId.Text);
                    try
                    {
                        db.sp_deleteDonantes(idElim);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se ha podido Eliminar el donante. El donante esta ligado " +
                            "a datos registrados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                }
                else
                {
                    return;
                }


            }
            MessageBox.Show("Se ha eliminado el donante.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            updateData();
            clearData();
        }
    }
}
