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
    public partial class ModDetalleDonacion : Form
    {
        librarydbEntities db = new librarydbEntities();
        public ModDetalleDonacion(int id)
        {
            InitializeComponent();
            setData(id);
        }

        public void setData(int id)
        {
            var detalleDonacionesId = db.sp_selectAllDetalleDonacionbyIDwithBooks(id);
            gDgvData.DataSource = detalleDonacionesId.ToList();

            var donacion = db.sp_selectAllDonacioneswithDonanteAdmin(id).ToList(); ;
            txtBusqueda.Text = donacion.FirstOrDefault().idDonacion.ToString();

            txtFecha.Text = donacion.FirstOrDefault().fecha.ToShortDateString();

            txtNomDonan.Text = donacion.FirstOrDefault().nombre.ToString();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
