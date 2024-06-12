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
    public partial class CentrosEducativos : Form
    {
        librarydbEntities db = new librarydbEntities();
        public CentrosEducativos()
        {
            InitializeComponent();
            var centrosEduc = db.sp_selectAllCentroEduca().ToList();
            ActualizarDatos();
            clearData();
        }
        public void ActualizarDatos()
        {
            var centrosEduc = db.sp_selectAllCentroEduca().ToList();
            gDgvData.DataSource = centrosEduc;
        }

        public void clearData()
        {
            gTxtId.Clear();
            gTxtIndice.Clear();
            gTxtNombre.Clear();
        }

        public void fillData(int id, string nombre)
        {
            gTxtId.Text = id.ToString();
            gTxtNombre.Text = nombre;
        }

        private void CentrosEducativos_Load(object sender, EventArgs e)
        {

        }

        private void gDgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                var clickedRow = senderGrid.Rows[e.RowIndex];

                int idCentro = (int)clickedRow.Cells["id"].Value;
                string nombreCentro = (string)clickedRow.Cells["nombre"].Value;

                fillData(idCentro, nombreCentro);


            }
        }

        private void gBtnLimpiar_Click(object sender, EventArgs e)
        {
            clearData();
        }
        public void updateCentroEducativo()
        {
            int id = Convert.ToInt32(gTxtId.Text);
            string nombre = gTxtNombre.Text;

            DialogResult result = MessageBox.Show("¿Desea modificar el Centro Educativo?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                var resultadoQ = db.sp_updateCentroEducativo(id, nombre);

            }
            else
            {
                return;
            }
        }

        private void gBtnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(gTxtNombre.Text))
            {
                MessageBox.Show("Todos los datos deben ser llenados.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (gTxtId.Text == string.Empty)
            {
                //Metodo Guardar nuevo
                try
                {
                    var resultado = db.sp_insertCentro_Educativo(gTxtNombre.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se ha podido ingresar el Centro Educativo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                MessageBox.Show("Se ha ingresado el nuevo Centro Educativo", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                updateCentroEducativo();
            }

            ActualizarDatos();
            clearData();
        }

        private void gBtnEliminar_Click(object sender, EventArgs e)
        {
            if (gTxtId.Text == string.Empty)
            {
                MessageBox.Show("No se ha seleccionado ningun Centro Educativo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                DialogResult result = MessageBox.Show("¿Desea eliminar el Centro Educativo?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    int idElim = Convert.ToInt32(gTxtId.Text);
                    try
                    {
                        db.sp_deleteCentroEducativo(idElim);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se ha podido Eliminar el Centro Educatuvi. El centro educativo" +
                            "esta ligado a otros datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                }
                else
                {
                    return;
                }


            }
            MessageBox.Show("Se ha eliminado el centro educativo.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ActualizarDatos();
            clearData();
        }
    }
}
