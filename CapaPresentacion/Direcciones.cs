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
    public partial class Direcciones : Form
    {
        librarydbEntities db = new librarydbEntities();
        public Direcciones()
        {
            InitializeComponent();
            ActualizarDatos();
            clearData();
        }

        public void ActualizarDatos()
        {
            var Aldeas = db.sp_SelectAllAldeas().ToList();
            var Sectores = db.sp_selectAllCategoriaswAldeas().ToList();
            gDgvDataAldea.DataSource = Aldeas;
            
            
            gDgvDataSector.DataSource = Sectores;
            //combo
            gCmbAldea.DataSource = Aldeas;
            gCmbAldea.DisplayMember = "nombre";
            gCmbAldea.ValueMember = "idAldea";
        }

        public void clearData()
        {
            gCmbAldea.SelectedIndex = 0;
            gTxtNombreSec.Clear();
            gTxtNombreAldea.Clear();
            gTxtidAldea.Clear();
            gTxtidsector.Clear();
            gTxtindiceAldea.Clear();
            gTxtindiceSector.Clear();
        }

        public void fillDataAldea(int id, string nombre)
        {
            gTxtidAldea.Text = id.ToString();
            gTxtNombreAldea.Text = nombre;
        }

        public void fillDataSector(int id, int id_aldea,string nombre)
        {
            gTxtidsector.Text = id.ToString();
            gTxtindiceSector.Text = id_aldea.ToString();
            gTxtNombreSec.Text = nombre;

            gCmbAldea.SelectedValue = id_aldea;
        }


        private void gDgvDataAldea_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                var clickedRow = senderGrid.Rows[e.RowIndex];

                int idAldea = (int)clickedRow.Cells["id"].Value;
                string nombreAldea = (string)clickedRow.Cells["aldea"].Value;

                fillDataAldea(idAldea, nombreAldea);


            }
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            clearData();
        }

        public void updateAldea()
        {
            int id = Convert.ToInt32(gTxtidAldea.Text);
            string nombre = gTxtNombreAldea.Text;

            DialogResult result = MessageBox.Show("¿Desea modificar la Aldea?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                var resultadoQ = db.sp_updateAldea(id, nombre);


            }
            else
            {
                return;
            }
        }

        public void updateSector()
        {
            int idSector = Convert.ToInt32(gTxtidsector.Text);
            int idAldea = Convert.ToInt32(gCmbAldea.SelectedValue);
            string nombre = gTxtNombreSec.Text;

            DialogResult result = MessageBox.Show("¿Desea modificar el Sector?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                var resultadoQ = db.sp_updateSector(idSector, nombre, idAldea);


            }
            else
            {
                return;
            }
        }

        private void btnGuardarAldea_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(gTxtNombreAldea.Text))
            {
                MessageBox.Show("Todos los datos deben ser llenados.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (gTxtidAldea.Text == string.Empty)
            {
                //Metodo Guardar nuevo
                try
                {
                    var resultado = db.sp_InsertAldea(gTxtNombreAldea.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se ha podido ingresar la Aldea", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                MessageBox.Show("Se ha ingresado la nueva Aldea", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                updateAldea();
            }

            ActualizarDatos();
            clearData();
        }

        private void btnDeleteAldea_Click(object sender, EventArgs e)
        {
            if (gTxtidAldea.Text == string.Empty)
            {
                MessageBox.Show("No se ha seleccionado ninguna Aldea", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                DialogResult result = MessageBox.Show("¿Desea eliminar la Aldea?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    int idElim = Convert.ToInt32(gTxtidAldea.Text);
                    try
                    {
                        db.sp_deleteAldea(idElim);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se ha podido Eliminar la Aldea. La Aldea esta ligada " +
                            "a otros datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                }
                else
                {
                    return;
                }


            }
            MessageBox.Show("Se ha eliminado la Aldea", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ActualizarDatos();
            clearData();
        }

        private void btnClearSector_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void btnGuardarSector_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(gTxtNombreSec.Text))
            {
                MessageBox.Show("Todos los datos deben ser llenados.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (gTxtidsector.Text == string.Empty)
            {
                //Metodo Guardar nuevo
                try
                {
                    int idAldea = Convert.ToInt32(gCmbAldea.SelectedValue);
                    var resultado = db.sp_InsertSector(gTxtNombreSec.Text, idAldea);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se ha podido ingresar el sector", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                MessageBox.Show("Se ha ingresado el nuevo sector", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                updateSector();
            }

            ActualizarDatos();
            clearData();
        }

        private void gDgvDataSector_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                var clickedRow = senderGrid.Rows[e.RowIndex];

                int idSector = (int)clickedRow.Cells["idsector"].Value;
                string nombreSector = (string)clickedRow.Cells["nombresector"].Value;
                int idAldea = (int)clickedRow.Cells["idaldea"].Value;
                string nombreAldea = (string)clickedRow.Cells["nombrealdea"].Value;

                fillDataSector(idSector, idAldea, nombreSector);


            }
        }

        private void btnDeleteSector_Click(object sender, EventArgs e)
        {
            if (gTxtidsector.Text == string.Empty)
            {
                MessageBox.Show("No se ha seleccionado ningun Sector", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                DialogResult result = MessageBox.Show("¿Desea eliminar el sector?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    int idElim = Convert.ToInt32(gTxtidsector.Text);
                    try
                    {
                        db.sp_deleteSector(idElim);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se ha podido Eliminar el sector. El sector esta ligado " +
                            "a otros datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                }
                else
                {
                    return;
                }


            }
            MessageBox.Show("Se ha eliminado el sector", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ActualizarDatos();
            clearData();
        }
    }
}
