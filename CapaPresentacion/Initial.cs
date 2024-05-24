using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CapaPresentacion
{
    public partial class Initial : Form
    {
        public Initial(string nombreUsuario)
        {
            InitializeComponent();
            lblNombre.Text = nombreUsuario;
            string nombre1Letra = nombreUsuario.First().ToString();
            lblSingleLetterName.Text = nombre1Letra;
        }
        private static Form FormularioActivo = null;
        private static Guna2Button MenuActiv = null;
        private void Initial_Load(object sender, EventArgs e)
        {

            BtnDashBoard.CustomBorderColor = Color.FromArgb(255, 197, 63, 0);
            Padding newBorderThickness = BtnDashBoard.CustomBorderThickness;
            newBorderThickness.Right = 4;
            BtnDashBoard.CustomBorderThickness = newBorderThickness;
            BtnDashBoard.FillColor = Color.FromArgb(255, 33, 37, 36);

            // Asignar el botón actual a MenuActiv
            MenuActiv = BtnDashBoard;


            Dashboard dashboard = new Dashboard();
            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            FormularioActivo = dashboard;

            dashboard.TopLevel = false;
            dashboard.FormBorderStyle = FormBorderStyle.None;
            dashboard.Dock = DockStyle.Fill;

            pContainer.Controls.Add(dashboard);
            dashboard.Show();
        }
        private void AbrirFormulario(Guna2Button menu, Form formulario)
        {
            // Restablecer el estilo del botón anteriormente activo
            if (MenuActiv != null)
            {
                MenuActiv.FillColor = Color.FromArgb(1, 43, 47, 51);
                MenuActiv.CustomBorderColor = Color.FromArgb(1, 43, 47, 51);
                Padding defaultBorderThickness = new Padding(0);
                MenuActiv.CustomBorderThickness = defaultBorderThickness;
            }

            // Establecer el estilo del botón actual
            menu.CustomBorderColor = Color.FromArgb(255, 197, 63, 0);
            Padding newBorderThickness = menu.CustomBorderThickness;
            newBorderThickness.Right = 4;
            menu.CustomBorderThickness = newBorderThickness;
            menu.FillColor = Color.FromArgb(255, 33, 37, 36);

            // Asignar el botón actual a MenuActiv
            MenuActiv = menu;

            // Cerrar el formulario anterior y mostrar el nuevo formulario
            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            FormularioActivo = formulario;

            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            pContainer.Controls.Add(formulario);
            formulario.Show();
        }

        private void DashBoard_Click(object sender, EventArgs e)
        {
            AbrirFormulario((Guna2Button)sender, new Dashboard());
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AbrirFormulario((Guna2Button)sender, new UsuarioPres());
        }

        private void gunaPictureBox2_Click(object sender, EventArgs e)
        {
            UsuarioAdmin form = new UsuarioAdmin();
            form.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            AbrirFormulario((Guna2Button)sender, new Libros());
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            AbrirFormulario((Guna2Button)sender, new Mantenedor());
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
