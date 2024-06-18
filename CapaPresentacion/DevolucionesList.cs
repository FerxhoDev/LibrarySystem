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
    public partial class DevolucionesList : Form
    {
        librarydbEntities db = new librarydbEntities();
        public DevolucionesList()
        {
            InitializeComponent();
            

            gCmbBusqueda.Items.Add("Nombre Libro");
            gCmbBusqueda.Items.Add("Nombre Usuario");
            gCmbBusqueda.Items.Add("Fecha Prestamo");
            gCmbBusqueda.Items.Add("Estado");

            gCmbBusquedaChild.Items.Add("Completado");
            gCmbBusquedaChild.Items.Add("En Prestamo");
            clearData();
            updateData();
        }

        private void updateData()
        {
            var devoluciones = db.sp_selectAllDetalleDevolucioneswithUserAndEstado().ToList();
            gDgvData.DataSource = devoluciones;
            gCmbBusquedaChild.DataSource = null;

        }
        private void clearData()
        {
            gTxtBusqueda.Clear();
            gDtpFecha.Value = DateTime.Now;
            gCmbBusqueda.SelectedIndex = 0;
            gCmbBusquedaChild.Visible = false;
            gTxtBusqueda.Visible = true;
            updateData();
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

        private void gBtnBuscar_Click(object sender, EventArgs e)
        {
            var devoluciones = db.sp_selectAllDetalleDevolucioneswithUserAndEstado().ToList();
            string textoBusqueda = gTxtBusqueda.Text.ToLower();

            // Filtro inicial
            var usuariosFiltrados = devoluciones.AsQueryable();

            // Determinar el criterio de búsqueda
            switch (gCmbBusqueda.SelectedItem.ToString())
            {
                case "Nombre Libro":
                    usuariosFiltrados = usuariosFiltrados.Where(u => u.nombre.ToLower().Contains(textoBusqueda));
                    break;
                case "Nombre Usuario":
                    usuariosFiltrados = usuariosFiltrados.Where(u => u.usuario.ToLower().Contains(textoBusqueda));
                    break;
                case "Fecha Prestamo":
                    if (gDtpFecha.Value != null)
                    {
                        DateTime selectedDate = gDtpFecha.Value.Date;  // Get only the date part
                        usuariosFiltrados = usuariosFiltrados.Where(u => u.fecha_prestamo.Value == selectedDate);
                    }
                    break;
                case "Estado":
                    if (gCmbBusquedaChild.SelectedItem != null)
                    {
                        string selectedEstado = gCmbBusquedaChild.SelectedItem.ToString();
                        switch (selectedEstado)
                        {
                            case "En Prestamo":
                                usuariosFiltrados = usuariosFiltrados.Where(u => u.id_estado == 1002);
                                break;
                            case "Completado":
                                usuariosFiltrados = usuariosFiltrados.Where(u => u.id_estado == 1003);
                                break;
                            default:
                                break;
                        }
                    }
                    break;

            }

            // Asignar los datos filtrados al DataGridView
            gDgvData.DataSource = usuariosFiltrados.ToList();
        }

        private void gBtnLimpiarBusc_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void gCmbBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (gCmbBusqueda.SelectedItem.ToString())
            {
                case "Nombre Libro":
                    gCmbBusquedaChild.DataSource = null;
                    gCmbBusquedaChild.Visible = false;
                    gTxtBusqueda.Visible = true;
                    gDtpFecha.Visible = false;
                    break;
                case "Nombre Usuario":
                    gCmbBusquedaChild.DataSource = null;
                    gCmbBusquedaChild.Visible = false;
                    gTxtBusqueda.Visible = true;
                    gDtpFecha.Visible = false;
                    break;
                case "Fecha Prestamo":
                    gCmbBusquedaChild.DataSource = null;
                    gCmbBusquedaChild.Visible = false;
                    gTxtBusqueda.Visible = false;
                    gDtpFecha.Visible = true;
                    break;
                case "Estado":
                   
                    gCmbBusquedaChild.Visible = true;
                    gTxtBusqueda.Visible = false;
                    gDtpFecha.Visible = false;
                    break;
                default:
                    
                    gCmbBusquedaChild.Visible = false;
                    break;
            }
        }
    }
}
