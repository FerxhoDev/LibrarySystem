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
    public partial class Form1 : Form
    {
        librarydbEntities db = new librarydbEntities();
        public Form1()
        {
            InitializeComponent();
        }

        public void clearTextbox()
        {
            gTxtPass.Clear();
            gTxtUser.Clear();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string usuario = gTxtUser.Text;
            string password = gTxtPass.Text;

            if(usuario == string.Empty || password == string.Empty)
            {
                MessageBox.Show("Ingrese todos los campos", "Error");
            }
            else
            {
                try
                {
                    var queUser = db.sp_selectUsuarioAdmin_byUser(usuario);
                    var ListaUsuarios = queUser.ToList();
                    
                    
                    //Si no se encuentra el usuario la lista es 0
                    if(ListaUsuarios.Count == 0) {
                        MessageBox.Show("No se ha encontrado el Usuario"); 
                    }
                    else
                    {
                        if (ListaUsuarios[0].pass != password)
                        {
                            MessageBox.Show("La contrasena ingresada es incorrecta");
                        }
                        else
                        {
                            string nombre = ListaUsuarios[0].nombre + ListaUsuarios[0].apellido;
                            Initial initial = new Initial(nombre);
                            initial.Show();
                            this.Hide();

                        }
                    }

                }catch(Exception ex)
                {
                    MessageBox.Show("No se ha podido encontrar usuarios");
                }
            }
        }

        private void guna2ToggleSwitch1_Click(object sender, EventArgs e)
        {
            if(gTxtPass.UseSystemPasswordChar == false)
            {
                gTxtPass.UseSystemPasswordChar = true;
            }
            else
            {
                gTxtPass.UseSystemPasswordChar=false;
            }
        }
    }
}
