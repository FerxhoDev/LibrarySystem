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
    public partial class DonacionList : Form
    {
        librarydbEntities db = new librarydbEntities();
        public DonacionList()
        {
            InitializeComponent();
            clearData();
            updateData();
            gDgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        public void clearData()
        {
            gTxtDonante.Clear();
            gTxtFecha.Clear();
            gTxtId.Clear();
            gTxtIndice.Clear();
        }

        public void updateData()
        {
            var Donaciones = db.sp_selectAllDonacioneswithDonanteAdminnoID();
            gDgvData.DataSource = Donaciones;
        }

        public void fillData(int id, DateTime fecha, string donante)
        {
            gTxtId.Text = id.ToString();
            gTxtFecha.Text = fecha.ToShortDateString();
            gTxtDonante.Text = donante.ToString();
        }

        private void gBtnDetalle_Click(object sender, EventArgs e)
        {
            updateData();
            if (string.IsNullOrWhiteSpace(gTxtId.Text))
            {
                MessageBox.Show("Debe Seleccionar una Donacion", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(gTxtId.Text);
            ModDetalleDonacion detalledon = new ModDetalleDonacion(id);
            detalledon.Show();
        }

        private void gBtnLimpiar_Click(object sender, EventArgs e)
        {
            clearData();
            updateData();
        }

        private void gDgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                var clickedRow = senderGrid.Rows[e.RowIndex];

                int idDonacion = (int)clickedRow.Cells["id"].Value;
                string nombreDonador = (string)clickedRow.Cells["Donante"].Value;
                DateTime donacion = (DateTime)clickedRow.Cells["Fecha"].Value;

                fillData(idDonacion, donacion, nombreDonador);


            }
        }
    }
}
