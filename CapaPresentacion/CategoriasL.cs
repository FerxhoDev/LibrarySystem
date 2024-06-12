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
    public partial class CategoriasL : Form
    {
        librarydbEntities db = new librarydbEntities();
        public CategoriasL()
        {
            InitializeComponent();

            var categorias = db.sp_selectAllCatLibro().ToList();
            ActualizarDatos();
            clearData();

        }

        public void ActualizarDatos()
        {
            var libroscategorias = db.sp_selectAllCatLibro().ToList();
            gDgvData.DataSource = libroscategorias;

        }

        public void clearData()
        {
            gTxtCategoria.Clear();
            gTxtId.Clear();
            gTxtIndice.Clear();
        }

        public void fillData(int id, string nombre)
        {
            gTxtCategoria.Text = nombre;
            gTxtId.Text = id.ToString();
        }

        private void gDgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                var clickedRow = senderGrid.Rows[e.RowIndex];

                int idCategoria = (int)clickedRow.Cells["id"].Value;
                string nombreCategoria = (string)clickedRow.Cells["nombre"].Value;

                fillData(idCategoria, nombreCategoria);
                

            }
        }

        private void gBtnLimpiar_Click(object sender, EventArgs e)
        {
            clearData();
        }
        
        public void updateCategoria()
        {
            int id = Convert.ToInt32(gTxtId.Text);
            string nombre = gTxtCategoria.Text;

            DialogResult result = MessageBox.Show("¿Desea modificar la categoria?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                var resultadoQ = db.sp_updateCategoriaLibro(id, nombre);


            }
            else
            {
                return;
            }
        }

        private void gBtnGuardar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(gTxtCategoria.Text))
            {
                MessageBox.Show("Todos los datos deben ser llenados.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (gTxtId.Text == string.Empty)
            {
                //Metodo Guardar nuevo
                try
                {
                    var resultado = db.sp_insertCategoria_Libro(gTxtCategoria.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se ha podido ingresar la Categoria", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                
                MessageBox.Show("Se ha ingresado el nuevo libro", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                updateCategoria();
            }

            ActualizarDatos();
            clearData();
        }

        private void gBtnEliminar_Click(object sender, EventArgs e)
        {
            if(gTxtId.Text == string.Empty)
            {
                MessageBox.Show("No se ha seleccionado ninguna Categoria", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                DialogResult result = MessageBox.Show("¿Desea eliminar la categoria?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    int idElim = Convert.ToInt32(gTxtId.Text);
                    try
                    {
                        db.sp_deleteCategoriaLibro(idElim);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se ha podido Eliminar la categoria. La categoria esta ligada " +
                            "a libros registrados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                }
                else
                {
                    return;
                }

                
            }
            MessageBox.Show("Se ha eliminado la categoria", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ActualizarDatos();
            clearData() ;
        }
    }
}
