using CapaPresentacion.BaseDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class UsuarioPres : Form
    {
        librarydbEntities db = new librarydbEntities();
        private List<sector> sectores;
        public UsuarioPres()
        {
            InitializeComponent();
            updateData();
            gCmbGenero.Items.Add("Masculino");
            gCmbGenero.Items.Add("Femenino");

            gCmbBusqueda.Items.Add("Nombre");
            gCmbBusqueda.Items.Add("Apellido");
            gCmbBusqueda.Items.Add("Aldea");
            gCmbBusqueda.Items.Add("Sector");
            gCmbBusqueda.Items.Add("Centro Educativo");
            gCmbBusqueda.Items.Add("Genero");
            

            clearData();
        }


        public void clearBusqueda()
        {
            gTxtBusqueda.Clear();
            gCmbBusqueda.SelectedIndex = 0;
            gCmbBusquedaChild.DataSource = null;
        }
        public void clearData()
        {
            gTxtApellido.Clear();
            gTxtId.Clear();
            gTxtIndice.Clear();
            gTxtNombre.Clear();
            gtxtDireccion.Clear();
            gDtpNacimiento.Value = DateTime.Now;
            //gCmbBusqueda.SelectedIndex = 0;
            if (gCmbCentroEd.DataSource != null && gCmbCentroEd.Items.Count > 0)
            {
                gCmbCentroEd.SelectedIndex = 0;
            }

            if (gCmbGenero.DataSource != null && gCmbGenero.Items.Count > 0)
            {
                gCmbGenero.SelectedIndex = 0;
            }

            if (gCmbResponsable.DataSource != null && gCmbResponsable.Items.Count > 0)
            {
                gCmbResponsable.SelectedIndex = 0;
            }

        }

        private void fillData(int idUsuario, string nombreUsuario, string apellido,
            DateTime FechaNacimiento, bool genero, int id_centro, int id_direccion,
            string descripcion, int id_sector, int id_responsable, int id_aldea)
        {

            gTxtNombre.Text = nombreUsuario;
            gTxtApellido.Text = apellido;
            gtxtDireccion.Text = descripcion;
            gTxtId.Text = idUsuario.ToString();
            gTxtIndice.Text = id_direccion.ToString();

            gCmbAldea.SelectedValue = id_aldea;
            gCmbGenero.SelectedIndex = genero ? 0 : 1;
            gCmbResponsable.SelectedValue = id_responsable;
            gCmbCentroEd.SelectedValue = id_centro;
            gCmbSector.SelectedValue = id_sector;

            gDtpNacimiento.Value = FechaNacimiento;

        }

        public void updateData()
        {
            var usuarios = db.sp_selectAllUsuariosPrestamistasJoints().ToList();
            gDgvData.DataSource = usuarios;
            gDgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            var sectoresResult = db.sp_selectAllSectores().ToList();
            sectores = sectoresResult.Select(s => new sector
            {
                idSector = s.idSector,
                Nombre = s.Nombre,
                id_aldea = s.id_aldea
            }).ToList();

            var aldeas = db.sp_SelectAllAldeas().ToList();
            var centroEduc = db.sp_selectAllCentroEduca().ToList();
            var responsables = db.sp_selectAllResponsables().ToList();

            gCmbCentroEd.DataSource = centroEduc;
            gCmbCentroEd.DisplayMember = "nombreCentroEducativo";
            gCmbCentroEd.ValueMember = "idCentroEducativo";

            gCmbResponsable.DataSource = responsables;
            gCmbResponsable.DisplayMember = "nombreResponsable";
            gCmbResponsable.ValueMember = "idResponsable";

            gCmbSector.DataSource = null;
            gCmbSector.Enabled = false;

            gCmbAldea.DataSource = aldeas;
            gCmbAldea.DisplayMember = "Nombre";
            gCmbAldea.ValueMember = "idAldea";
            
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void gDgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {

                var clickedRow = senderGrid.Rows[e.RowIndex];

                int idUsuario = (int)clickedRow.Cells["idUsuario"].Value;
                string nombreUsuario = (string)clickedRow.Cells["NombreUsuario"].Value;
                string apellido = (string)clickedRow.Cells["apellido"].Value;
                DateTime FechaNacimiento = (DateTime)clickedRow.Cells["FechaNacimiento"].Value;
                bool genero = (bool)clickedRow.Cells["genero"].Value;
                int id_centro = (int)clickedRow.Cells["id_centro"].Value;
                int id_direccion = (int)clickedRow.Cells["id_direccion"].Value;
                string descripcion = (string)clickedRow.Cells["descripcion"].Value;
                int id_sector = (int)clickedRow.Cells["id_sector"].Value;
                int id_aldea = (int)clickedRow.Cells["id_aldea"].Value;
                int id_responsable = (int)clickedRow.Cells["id_responsable"].Value;

                //Poner datos en las barras:
                fillData(idUsuario, nombreUsuario, apellido, FechaNacimiento, genero,
                    id_centro, id_direccion, descripcion, id_sector, id_responsable, id_aldea);

            }
        }

        public void updateUsuario() 
        {
            int idUsuario = Convert.ToInt32(gTxtId.Text);
            string nombre = gTxtNombre.Text;
            string apellido = gTxtApellido.Text;
            int id_sector = Convert.ToInt32(gCmbSector.SelectedValue);
            string descripcion = gtxtDireccion.Text;
            int id_direccion = Convert.ToInt32(gTxtIndice.Text);

            try//update a la cosa de direccion
            {
                var resultado = db.sp_updateDireccion(id_direccion, id_sector, descripcion);
            }catch (Exception ex)
            {
                MessageBox.Show("No se ha podido actualizar la direccion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int id_centro = Convert.ToInt32(gCmbCentroEd.SelectedValue);
            DateTime nacimiento = gDtpNacimiento.Value.Date;
            bool genero = gCmbGenero.SelectedIndex == 0;
            int id_responsable = (int)gCmbResponsable.SelectedValue;
            try
            {
                var resultado = db.sp_updateUsuarioPrestamista(idUsuario, nombre, apellido, id_direccion, id_centro
                    , nacimiento, genero, id_responsable);
            }catch (Exception ex)
            {
                MessageBox.Show("No se ha podido actualizar el Usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Se ha actualizado el nuevo usuario", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public void createUsuario()
        {
            string nombre = gTxtNombre.Text;
            string apellido = gTxtApellido.Text;
            int id_sector = Convert.ToInt32(gCmbSector.SelectedValue);
            string descripcion = gtxtDireccion.Text;
            //si esto llega a fallar me voy a uganda.
            ObjectParameter idDireccionParam = new ObjectParameter("idDireccion", typeof(int));

            db.sp_createDireccionReturnID(id_sector, descripcion, idDireccionParam);


            int id_direccion = (int)idDireccionParam.Value;
            int id_centro = Convert.ToInt32(gCmbCentroEd.SelectedValue);
            DateTime nacimiento = gDtpNacimiento.Value.Date;
            bool genero = gCmbGenero.SelectedIndex == 0;
            int id_responsable = (int)gCmbResponsable.SelectedValue;
            try
            {
                var resultado = db.sp_insertUsuario_Prestamista(nombre, apellido, id_direccion, id_centro,
                    nacimiento, genero, id_responsable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido ingresar el Usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Se ha ingresado el nuevo usuario", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void gDgvData_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in gDgvData.Rows)
            {
                var generoBit = (bool)row.Cells["genero"].Value;
                row.Cells["GeneroNombre"].Value = generoBit ? "Masculino" : "Femenino";
            }
        }

        private void gCmbAldea_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Esto puede parecer algo random pero ES INEGRAL DEJAR ESTO ASI NO TOCAR
            try
            {
                if ((int)gCmbAldea.SelectedValue == 0)
                {
                    return;
                }
            }catch { 
                return; 
            }
            //lo demas lo que sea, se buscan los valores de la lista y se agregan al combo.
            int selectedAldeaId = (int)gCmbAldea.SelectedValue;

            var SectoresFiltrados = sectores.Where(s => s.id_aldea == selectedAldeaId).ToList();
            
            gCmbSector.DataSource = SectoresFiltrados;
            gCmbSector.DisplayMember = "Nombre";
            gCmbSector.ValueMember = "idSector";
            gCmbSector.Enabled = true;

        }

        public void deleteUser()
        {
            if (gTxtId.Text == string.Empty)
            {
                MessageBox.Show("No se ha seleccionado ningun usuario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                DialogResult result = MessageBox.Show("¿Desea eliminar al usuario?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    int idElim = Convert.ToInt32(gTxtId.Text);
                    try
                    {
                        db.sp_deleteUsuarios_Prestamista(idElim);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se ha podido Eliminar al usaurio. El usuario esta ligado " +
                            "a otros datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                }
                else
                {
                    return;
                }


            }
            MessageBox.Show("Se ha eliminado al usuario", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            updateData();
            clearData();
        }

        private void gBtnLimpiar_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void gBtnGuardar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(gTxtNombre.Text) ||
                string.IsNullOrWhiteSpace(gtxtDireccion.Text) ||
                string.IsNullOrWhiteSpace(gTxtApellido.Text) ||
                gCmbSector.SelectedIndex == -1)
            {
                MessageBox.Show("Todos los datos deben ser llenados.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(gTxtId.Text == string.Empty)
            {
                //metodo crear nuevo
                createUsuario();
            }
            else
            {
                //metodo de Actualizar (matenme)
                updateUsuario();
            }

            updateData();
            clearData();
        }

        private void gCmbBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            switch (gCmbBusqueda.SelectedItem.ToString())
            {
                case "Aldea":
                    var aldeas = db.sp_SelectAllAldeas().ToList();
                    gCmbBusquedaChild.DataSource = aldeas;
                    gCmbBusquedaChild.DisplayMember = "Nombre";
                    gCmbBusquedaChild.ValueMember = "idAldea";
                    gCmbBusquedaChild.Visible = true;
                    break;
                case "Sector":
                    var sectores = db.sp_selectAllSectores().ToList();
                    gCmbBusquedaChild.DataSource = sectores;
                    gCmbBusquedaChild.DisplayMember = "Nombre";
                    gCmbBusquedaChild.ValueMember = "idSector";
                    gCmbBusquedaChild.Visible = true;
                    break;
                case "Centro Educativo":
                    var centros = db.sp_selectAllCentroEduca().ToList();
                    gCmbBusquedaChild.DataSource = centros;
                    gCmbBusquedaChild.DisplayMember = "nombreCentroEducativo";
                    gCmbBusquedaChild.ValueMember = "idCentroEducativo";
                    gCmbBusquedaChild.Visible = true;
                    break;
                case "Genero":
                    gCmbBusquedaChild.DataSource = new List<string> { "Masculino", "Femenino" };
                    gCmbBusquedaChild.Visible = true;
                    break;
                default:
                    gCmbBusquedaChild.DataSource = null;
                    gCmbBusquedaChild.Visible = false;
                    break;
            }
        }

        private void gBtnBuscar_Click(object sender, EventArgs e)
        {
            // Obtener todos los usuarios prestamistas
            var usuarios = db.sp_selectAllUsuariosPrestamistasJoints().ToList();
            string textoBusqueda = gTxtBusqueda.Text.ToLower();

            // Filtro inicial
            var usuariosFiltrados = usuarios.AsQueryable();

            // Determinar el criterio de búsqueda
            switch (gCmbBusqueda.SelectedItem.ToString())
            {
                case "Nombre":
                    usuariosFiltrados = usuariosFiltrados.Where(u => u.NombreUsuario.ToLower().Contains(textoBusqueda));
                    break;
                case "Apellido":
                    usuariosFiltrados = usuariosFiltrados.Where(u => u.apellido.ToLower().Contains(textoBusqueda));
                    break;
                case "Aldea":
                    if (gCmbBusquedaChild.SelectedValue != null)
                    {
                        int idAldea = (int)gCmbBusquedaChild.SelectedValue;
                        usuariosFiltrados = usuariosFiltrados.Where(u => u.idAldea == idAldea);
                    }
                    break;
                case "Sector":
                    if (gCmbBusquedaChild.SelectedValue != null)
                    {
                        int idSector = (int)gCmbBusquedaChild.SelectedValue;
                        usuariosFiltrados = usuariosFiltrados.Where(u => u.idSector == idSector);
                    }
                    break;
                case "Centro Educativo":
                    if (gCmbBusquedaChild.SelectedValue != null)
                    {
                        int idCentro = (int)gCmbBusquedaChild.SelectedValue;
                        usuariosFiltrados = usuariosFiltrados.Where(u => u.idCentroEducativo == idCentro);
                    }
                    break;
                case "Genero":
                    if (gCmbBusquedaChild.SelectedItem != null)
                    {
                        bool esMasculino = gCmbBusquedaChild.SelectedItem.ToString() == "Masculino";
                        usuariosFiltrados = usuariosFiltrados.Where(u => u.genero == esMasculino);
                    }
                    break;
                default:
                    break;
            }

            // Asignar los datos filtrados al DataGridView
            gDgvData.DataSource = usuariosFiltrados.ToList();
        }
    }
}
