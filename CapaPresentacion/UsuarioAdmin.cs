using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaPresentacion.Utilidades;

namespace CapaPresentacion
{
    public partial class UsuarioAdmin : Form
    {
        public UsuarioAdmin()
        {
            InitializeComponent();
        }

        private void UsuarioAdmin_Load(object sender, EventArgs e)
        {
            
            foreach (DataGridViewColumn columna in gDgvData.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnSeleccionar")
                {
                    gCmbBusqueda.Items.Add(new OpcionCombo() { text = columna.HeaderText, valor = columna.Name });
                }
            }
            gCmbBusqueda.DisplayMember = "Text";
            gCmbBusqueda.ValueMember = "valor";
            gCmbBusqueda.SelectedIndex = 0;
        }
    }
}
