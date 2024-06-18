using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.BaseDatos;
using CapaPresentacion.Utilidades;

namespace CapaPresentacion
{
    public partial class UsuarioAdmin : Form
    {
        librarydbEntities db = new librarydbEntities();
        public UsuarioAdmin()
        {
            InitializeComponent();

            var AdminUsers = db.sp_selectAllUsuarios_Admin().ToList();
            gDgvData.DataSource = AdminUsers;
            gDgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;



            gTxtId.Clear();
            gTxtIndice.Clear();

        }


        private void actualizarGrid()
        {
            var AdminUsers = db.sp_selectAllUsuarios_Admin().ToList();
            gDgvData.DataSource = AdminUsers;

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

        private void gDgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                var clickedRow = senderGrid.Rows[e.RowIndex];

                int idUsuario = (int)clickedRow.Cells["id"].Value;
                string nombreUsuario = (string)clickedRow.Cells["Nombre"].Value;
                string apellidoUsuario = (string)clickedRow.Cells["Apellido"].Value;
                string pass = (string)clickedRow.Cells["Pass"].Value;
                string usuario = (string)clickedRow.Cells["Usuario"].Value;
                int telefono = (int)clickedRow.Cells["Telefono"].Value;

                fillData(idUsuario, nombreUsuario, apellidoUsuario, usuario, telefono, pass);
            }
        }

        private void fillData(int IdUsiario, string Nombre, string Apellido, string Usuario, int telefono, string pass)
        {
            clearData();
            gTxtId.Text = IdUsiario.ToString();
            gTxtNombre.Text = Nombre;
            gTxtApellido.Text = Apellido;
            gTxtUsuario.Text = Usuario;
            gTxtTelefono.Text = telefono.ToString();

        }

        private void clearData()
        {
            gTxtId.Clear();
            gTxtNombre.Clear();
            gTxtApellido.Clear();
            gTxtUsuario.Clear();
            gTxtTelefono.Clear();
            gTxtIndice.Clear();
            gTxtPass.Clear();
            gTxtConfPass.Clear();
        }

        private void gBtnLimpiar_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void gBtnGuardar_Click(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(gTxtNombre.Text) ||
                string.IsNullOrWhiteSpace(gTxtApellido.Text) ||
                string.IsNullOrWhiteSpace(gTxtUsuario.Text) ||
                string.IsNullOrWhiteSpace(gTxtTelefono.Text))
            {
                MessageBox.Show("Todos los datos deben ser llenados.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Aquí puedes agregar cualquier lógica adicional que necesites para tu aplicación
            // Por ejemplo, si necesitas validar que el teléfono sea un número válido:
            if (!long.TryParse(gTxtTelefono.Text, out long telefono))
            {
                MessageBox.Show("El teléfono debe ser un número válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Aquí puedes agregar la lógica para crear o actualizar datos
            if (gTxtId.Text == string.Empty && gTxtIndice.Text == string.Empty)
            {
                crearNuevoUsuario();
            }
            else
            {
                updateUsuario();
            }

            // Si tienes alguna operación para actualizar un DataGridView u otro control, colócala aquí
            actualizarGrid();
        }

        private void updateUsuario()
        {
            string nombreUp = gTxtNombre.Text;
            string apellido = gTxtApellido.Text;
            string usuario = gTxtUsuario.Text;
            int telefono = Convert.ToInt32(gTxtTelefono.Text);
            int idCambio = Convert.ToInt32(gTxtId.Text);
            string pass;
            if(gTxtPass.Text == string.Empty)
            {
                var userobj = db.usuarios_admin.FirstOrDefault(x => x.idUsuario_Admin == idCambio);
                pass = userobj.pass;

            }
            else
            {
                if (gTxtPass.Text != gTxtConfPass.Text)
                {
                    MessageBox.Show("Las contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    pass = gTxtPass.Text;
                }
                
            }

            DialogResult result = MessageBox.Show("¿Desea modificar el Usuario?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                var resulQ = db.sp_updateUsuarioAdmin(idCambio, nombreUp, apellido, pass, usuario, telefono);
            }
            else
            {
                return;
            }

            clearData();
            actualizarGrid();
        }

        private void crearNuevoUsuario()
        {
            string nombreUp = gTxtNombre.Text;
            string apellido = gTxtApellido.Text;
            string usuario = gTxtUsuario.Text;
            string telefono = gTxtTelefono.Text;

            string pass;
            if (gTxtPass.Text == string.Empty)
            {
                MessageBox.Show("Todos los datos deben ser llenados.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            else
            {
                if (gTxtPass.Text != gTxtConfPass.Text)
                {
                    MessageBox.Show("Las contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    pass = gTxtPass.Text;

                    try
                    {
                        db.sp_insertUsuario_Admin(nombreUp, apellido, pass, usuario, telefono);
                    }catch (Exception ex)
                    {
                        MessageBox.Show("No se ha podido ingresar al usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    clearData();
                    MessageBox.Show("Se ha ingresado al nuevo usuario", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void gBtnLimpiarBusc_Click(object sender, EventArgs e)
        {
            gCmbBusqueda.SelectedIndex = 0;
            gTxtBusqueda.Clear();
        }

        private void gBtnBuscar_Click(object sender, EventArgs e)
        {
            string textoBusqueda = gTxtBusqueda.Text;
            if(gCmbBusqueda.SelectedIndex == 0)
            {//Modo Nombre
                CurrencyManager currencyManager = (CurrencyManager)BindingContext[gDgvData.DataSource];
                currencyManager.SuspendBinding();


                foreach (DataGridViewRow row in gDgvData.Rows)
                {
                    string nombre = row.Cells["Nombre"].Value.ToString().ToLower();

                    if (nombre.Contains(textoBusqueda))
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
            if (gCmbBusqueda.SelectedIndex == 1)
            {//Modo Apellido
                CurrencyManager currencyManager = (CurrencyManager)BindingContext[gDgvData.DataSource];
                currencyManager.SuspendBinding();


                foreach (DataGridViewRow row in gDgvData.Rows)
                {
                    string apellido = row.Cells["Apellido"].Value.ToString().ToLower();

                    if (apellido.Contains(textoBusqueda))
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
            if (gCmbBusqueda.SelectedIndex == 2)
            {//Modo Usuario
                CurrencyManager currencyManager = (CurrencyManager)BindingContext[gDgvData.DataSource];
                currencyManager.SuspendBinding();


                foreach (DataGridViewRow row in gDgvData.Rows)
                {
                    string Usuario = row.Cells["Usuario"].Value.ToString().ToLower();

                    if (Usuario.Contains(textoBusqueda))
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
            if (gCmbBusqueda.SelectedIndex == 3)
            {//Modo Telefono
                CurrencyManager currencyManager = (CurrencyManager)BindingContext[gDgvData.DataSource];
                currencyManager.SuspendBinding();


                foreach (DataGridViewRow row in gDgvData.Rows)
                {
                    string Telefono = row.Cells["Telefono"].Value.ToString().ToLower();

                    if (Telefono.Contains(textoBusqueda))
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
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
