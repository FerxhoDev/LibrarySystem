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
    public partial class Responsables : Form
    {
        librarydbEntities db = new librarydbEntities();
        public Responsables()
        {
            InitializeComponent();
            updateData();
            clearData();
        }

        public void updateData()
        {
            var responsables = db.sp_selectAllResponsables().ToList();
            gDgvResponsables.DataSource = responsables;
        }

        public void clearData()
        {
            gtxtid.Clear();
            gTxtTelefono.Clear();
            gtxtNombre.Clear();
            gTxtCui.Clear();
        }

        public void fillData(string nombre, int telefono, string cui, int id)
        {
            gtxtNombre.Text = nombre;
            gTxtTelefono.Text = telefono.ToString();
            gTxtCui.Text = cui;
            gtxtid.Text = id.ToString();
        }

        public void updateResponsables()
        {
            int id = Convert.ToInt32(gtxtid.Text);
            string nombre = gtxtNombre.Text;
            string cui = gTxtCui.Text;
            int telefono = Convert.ToInt32(gTxtTelefono.Text);

            DialogResult result = MessageBox.Show("¿Desea modificar el Responsable?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                var resultadoQ = db.sp_updateResponsable(id, nombre, telefono, cui);


            }
            else
            {
                return;
            }
        }

        private void gbtnLimpiar_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void gDgvResponsables_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                var clickedRow = senderGrid.Rows[e.RowIndex];

                int idResponsable = (int)clickedRow.Cells["id"].Value;
                string nombre = (string)clickedRow.Cells["nombre"].Value;
                int telefono = (int)clickedRow.Cells["telefono"].Value;
                string cui = (string)clickedRow.Cells["cui"].Value;


                fillData(nombre, telefono, cui, idResponsable);


            }
        }

        private void gbtnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(gtxtNombre.Text) ||
                string.IsNullOrWhiteSpace(gTxtCui.Text) ||
                string.IsNullOrWhiteSpace(gTxtTelefono.Text))
            {
                MessageBox.Show("Todos los datos deben ser llenados.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (gtxtid.Text == string.Empty)
            {
                //Metodo Guardar nuevo
                try
                {
                    string nombre = gtxtNombre.Text;
                    int telefono = Convert.ToInt32(gTxtTelefono.Text);
                    string cui = gTxtCui.Text;
                    var resultado = db.sp_insertResponsable(nombre, telefono, cui);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se ha podido ingresar al responsable", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                MessageBox.Show("Se ha ingresado el responsable", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                updateResponsables();
            }

            updateData();
            clearData();
        }

        private void gbtnEliminar_Click(object sender, EventArgs e)
        {
            if (gtxtid.Text == string.Empty)
            {
                MessageBox.Show("No se ha seleccionado ningun responsable", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                DialogResult result = MessageBox.Show("¿Desea eliminar al responsable?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    int idElim = Convert.ToInt32(gtxtid.Text);
                    try
                    {
                        db.sp_deleteResponsable(idElim);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se ha podido Eliminar al responsable. El responsable esta ligado " +
                            "a datos registrados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                }
                else
                {
                    return;
                }


            }
            MessageBox.Show("Se ha eliminado al responsable", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            updateData();
            clearData();
        }
    }
}
