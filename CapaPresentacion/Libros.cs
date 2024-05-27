using CapaPresentacion.BaseDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Libros : Form
    {
        librarydbEntities db = new librarydbEntities();
        int modoBusqueda = 0;
        int stockSec;
        public Libros()
        {
            InitializeComponent();

            var categorias = db.sp_selectAllCatLibro().ToList();
            var libros = db.sp_selectAllLibros().ToList();

            actualizarGrid();

            gCmbCategoria.DataSource = categorias;
            gCmbCategoria.DisplayMember = "nombre";
            gCmbCategoria.ValueMember = "idCategoria";

            gTxtId.Clear();
            gTxtIndice.Clear();

            gCmbBusqueda.Items.Add("Nombre");
            gCmbBusqueda.Items.Add("Codigo");
            gCmbBusqueda.Items.Add("Categoria");

            gCmbBusquedaCategoria.DataSource = categorias;
            gCmbBusquedaCategoria.DisplayMember = "nombre";
            gCmbBusquedaCategoria.ValueMember = "idCategoria";
            gCmbBusqueda.SelectedIndex = 0;

            gTxtId.Text = string.Empty;
            gTxtIndice.Text = string.Empty;

        }

        private void actualizarGrid()
        {
            var librosCategorias = db.sp_selectallLibrosCategorias().ToList();
            gDgvData.DataSource = librosCategorias;

        }

        private void dataGridButtom_CellContectClick(object sender, DataGridViewCellEventArgs e)
        {
            stockSec = 0;
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                var clickedRow = senderGrid.Rows[e.RowIndex];

                int idLibro = (int)clickedRow.Cells["idLibro"].Value;
                string nombreLibro = (string)clickedRow.Cells["nombre"].Value;
                string codigo = (string)clickedRow.Cells["codigo"].Value;
                int idCategoria = (int)clickedRow.Cells["id_categoria"].Value;
                int stock = (int)clickedRow.Cells["stock"].Value;
                string nombreCategoria = (string)clickedRow.Cells["categoria"].Value;

                //Poner datos en las barras:
                fillData(idLibro, nombreLibro, codigo, idCategoria, stock, nombreCategoria);
                stockSec = stock;
                
            }
        }

        private void clearData()
        {
            gTxtId.Clear();
            gTxtIndice.Clear();
            gTxtNombre.Clear();
            gTxtCodigo.Clear();
            gTxtStock.Clear();
            gCmbCategoria.DataSource = db.sp_selectAllCatLibro().ToList();
        }

        private void fillData(int idlibro, string nombreLibro, string codigo, int idCategoria, int stock,
            string nombreCategoria)
        {
            gTxtId.Text = idlibro.ToString();
            gTxtIndice.Text = idCategoria.ToString();
            gTxtNombre.Text = nombreLibro;
            gTxtCodigo.Text= codigo;
            gTxtStock.Text = stock.ToString();

            

            // Asegúrate de que la fuente de datos del ComboBox está establecida
            if (gCmbCategoria.DataSource != null)
            {
                gCmbCategoria.SelectedValue = idCategoria; // Selecciona automáticamente el ítem que corresponde al idCategoria
            }

            
            

        }

        private void gBtnLimpiar_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void crearNuevoLibro(int stock)
        {
            Debug.WriteLine("Guardar");

            string Nombre = gTxtNombre.Text;
            string Codigo = gTxtCodigo.Text;
            int idCategoria = Convert.ToInt32(gCmbCategoria.SelectedValue);

            try
            {
                var resultado = db.sp_insertLibro(Nombre, Codigo, idCategoria, stock);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido ingresar el Libro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Se ha ingresado el nuevo libro", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        private void updateLibro(int stockRR)
        {
            int idLibro = Convert.ToInt32(gTxtId.Text);
            string Nombre = gTxtNombre.Text;
            string Codigo = gTxtCodigo.Text;
            int idCategoria = Convert.ToInt32(gCmbCategoria.SelectedValue);
            int stock = stockSec;

            DialogResult result = MessageBox.Show("¿Desea modificar el libro?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                var resultadoQ = db.sp_updateLibro(idLibro, Nombre, Codigo, idCategoria, stock);
            }
            else
            {
                return;
            }
        }
        private void gBtnGuardar_Click(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(gTxtNombre.Text) ||
                string.IsNullOrWhiteSpace(gTxtCodigo.Text) ||
                //string.IsNullOrWhiteSpace(gTxtStock.Text) ||
                gCmbCategoria.SelectedValue == null)
            {
                MessageBox.Show("Todos los datos deben ser llenados.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que el stock es un número
            int stock = 0;

            if (gTxtId.Text == string.Empty && gTxtIndice.Text == string.Empty)
            {
                crearNuevoLibro(stock);  
            }

            else
            {
                updateLibro(stock);

            }

            var librosCategorias = db.sp_selectallLibrosCategorias().ToList();
            gDgvData.DataSource = librosCategorias;
        }

        private void gCmbBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indiceSeleccionad = gCmbBusqueda.SelectedIndex;

            switch(indiceSeleccionad)
            {
                case 0:
                    modoBusqueda = 0;
                    gTxtBusqueda.Visible = true;
                    gTxtBusqueda.Clear();
                    gCmbBusquedaCategoria.Visible = false;
                    gCmbBusquedaCategoria.SelectedIndex = 0;
                    break;
                case 1: 
                    modoBusqueda = 1;
                    gTxtBusqueda.Visible = true;
                    gTxtBusqueda.Clear();
                    gCmbBusquedaCategoria.Visible = false;
                    gCmbBusquedaCategoria.SelectedIndex = 0;
                    break;
                case 2: 
                    modoBusqueda = 2;
                    gTxtBusqueda.Visible = false;
                    gTxtBusqueda.Clear();
                    gCmbBusquedaCategoria.Visible = true;
                    gCmbBusquedaCategoria.SelectedIndex = 0;
                    break;
                default:
                    gCmbBusqueda.SelectedIndex = 0; 
                break;


            }
        }

        private void busquedaCategoria()
        {
            int selectedCategoriaId = (int)gCmbBusquedaCategoria.SelectedValue;

            CurrencyManager currencyManager = (CurrencyManager)BindingContext[gDgvData.DataSource];
            currencyManager.SuspendBinding();


            foreach (DataGridViewRow row in gDgvData.Rows)
            {
                
                int rowCategoriaId = (int)row.Cells["id_categoria"].Value;

                if (rowCategoriaId == selectedCategoriaId)
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }

            currencyManager.ResumeBinding();
        }

        private void gBtnBuscar_Click(object sender, EventArgs e)
        {
           var librosCategorias = db.sp_selectallLibrosCategorias().ToList();
           gDgvData.DataSource = librosCategorias;

           string textoBusqueda = gTxtBusqueda.Text.ToLower();

           if(modoBusqueda == 0)
            {
                CurrencyManager currencyManager = (CurrencyManager)BindingContext[gDgvData.DataSource];
                currencyManager.SuspendBinding();


                foreach (DataGridViewRow row in gDgvData.Rows)
                {
                    string nombreLibro = row.Cells["nombre"].Value.ToString().ToLower();

                    if (nombreLibro.Contains(textoBusqueda))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }

                currencyManager.ResumeBinding();
            }

            if (modoBusqueda == 1)
            {
                CurrencyManager currencyManager = (CurrencyManager)BindingContext[gDgvData.DataSource];
                currencyManager.SuspendBinding();


                foreach (DataGridViewRow row in gDgvData.Rows)
                {
                    string nombreLibro = row.Cells["codigo"].Value.ToString().ToLower();

                    if (nombreLibro.Contains(textoBusqueda))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }

                currencyManager.ResumeBinding();
            }

            if(modoBusqueda == 2)
            {
                busquedaCategoria();
            }
        }

        private void gBtnLimpiarBusc_Click(object sender, EventArgs e)
        {
            modoBusqueda = 0;
            gTxtBusqueda.Visible = true;
            gTxtBusqueda.Clear();
            gCmbBusquedaCategoria.Visible = false;
            gCmbBusquedaCategoria.SelectedIndex = 0;
            gCmbBusqueda.SelectedIndex = 0;
            var librosCategorias = db.sp_selectallLibrosCategorias().ToList();
            gDgvData.DataSource = librosCategorias;
        }

        private void gBtnEliminar_Click(object sender, EventArgs e)
        {
            if( gTxtId.Text == string.Empty && gTxtIndice.Text == string.Empty)
            {
                clearData();
            }
            else
            {
                int idLibro = Convert.ToInt32(gTxtId.Text);
                string Nombre = gTxtNombre.Text;
                string Codigo = gTxtCodigo.Text;
                int idCategoria = Convert.ToInt32(gCmbCategoria.SelectedValue);

                DialogResult result = MessageBox.Show("¿Desea Eliminar el libro?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    var resultadoQ = db.sp_deleteLibro(idLibro);
                }
                else
                {
                    return;
                }
                var librosCategorias = db.sp_selectallLibrosCategorias().ToList();
                gDgvData.DataSource = librosCategorias;
            }
        }

        private void gDgvData_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Verifica que no sea una fila de encabezado
            if (e.RowIndex >= 0)
            {
                // Obtener el DataGridView y la fila actual
                DataGridView dgv = sender as DataGridView;
                DataGridViewRow row = dgv.Rows[e.RowIndex];

                // Verifica si la columna "stock" existe y tiene un valor
                if (dgv.Columns["stock"] != null && row.Cells["stock"].Value != null)
                {
                    // Obtener el valor de la celda "stock"
                    int stockValue = Convert.ToInt32(row.Cells["stock"].Value);

                    // Si el valor de "stock" es 0, colorear la fila de rojo
                    if (stockValue == 0)
                    {
                        row.DefaultCellStyle.BackColor = Color.PeachPuff;
                    }
                    else
                    {
                        // Restaurar el color de fondo predeterminado si no es 0
                        row.DefaultCellStyle.BackColor = Color.Silver;
                    }
                }
            }
        }
    }
}
