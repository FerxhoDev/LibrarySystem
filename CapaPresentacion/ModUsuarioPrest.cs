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
    public partial class ModUsuarioPrest : Form
    {
        
        librarydbEntities db = new librarydbEntities();
        public int idUsuario { get; set; }
        public string nombre { get; set; }
        public int estado { get; set; }
        public ModUsuarioPrest()
        {
            InitializeComponent();
            updateData();
            clearData();
        }

        private void updateData()
        {
            var usuariosEstados = db.sp_selectAllUsersWithEstadoOfPrestamo().ToList();
            gDgvData.DataSource = usuariosEstados;
        }

        private void clearData() {
            gTxtIndice.Clear();
            gTxtId.Clear();
            gtxtUsuario.Clear();
        }

        private void clearSearch()
        {
            txtbuscar.Clear();
            updateData();
        }
        private void fillData(int id, string Nombre, string Estado, int idEstado)
        {
            gTxtId.Text = id.ToString();
            gTxtIndice.Text = idEstado.ToString();
            gtxtUsuario.Text = Nombre;
            LblEstado.Text = Estado;
            if(idEstado == 1001){
                LblEstado.ForeColor = Color.Goldenrod;
            }
            if (idEstado == 1002)
            {
                LblEstado.ForeColor = Color.Brown;
            }
            if (idEstado == 1003)
            {
                LblEstado.ForeColor = Color.ForestGreen;
            }
        }

        private void ModUsuarioPrest_Load(object sender, EventArgs e)
        {
            //LblEstado.Text = "Hola Louis";
            //LblEstado.ForeColor = Color.Aquamarine;
            updateData();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void gDgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                var clickedRow = senderGrid.Rows[e.RowIndex];

                int id = (int)clickedRow.Cells["id"].Value;
                int idEstado = (int)clickedRow.Cells["idEstado"].Value;
                string Nombre = (string)clickedRow.Cells["nombre"].Value +" "+
                    (string)clickedRow.Cells["apellido"].Value;
                string Estado = (string)clickedRow.Cells["Estado"].Value;

                //Poner datos en las barras:
                fillData(id, Nombre, Estado, idEstado);
                

            }
        }

        private void gBtnElegir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(gTxtId.Text))
            {
                MessageBox.Show("Debe seleccionar un usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.idUsuario = Convert.ToInt32(gTxtId.Text);
            this.nombre = gtxtUsuario.Text;
            this.estado = Convert.ToInt32(gTxtIndice.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
            

        }

        private void gBtnLimpiar_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void gBtnLimpiarBusc_Click(object sender, EventArgs e)
        {
            clearSearch();
        }

        private void gBtnBuscar_Click(object sender, EventArgs e)
        {
            var usuarios = db.sp_selectAllUsersWithEstadoOfPrestamo();
            string textoBusqueda = txtbuscar.Text.Trim().ToLower();

            // Filtro inicial
            var usuariosFiltrados = usuarios.AsQueryable();

            if (!string.IsNullOrEmpty(textoBusqueda))
            {
                usuariosFiltrados = usuariosFiltrados.Where(u =>
                    u.nombre.ToLower().Contains(textoBusqueda) ||
                    u.apellido.ToLower().Contains(textoBusqueda) ||
                    (u.nombre + " " + u.apellido).ToLower().Contains(textoBusqueda)
                );
            }

            // Set the filtered data to the grid
            gDgvData.DataSource = usuariosFiltrados.ToList();

        }
    }
}
