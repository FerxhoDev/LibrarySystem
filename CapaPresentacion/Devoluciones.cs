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

namespace CapaPresentacion
{
    public partial class Devoluciones : Form
    {
        int Administrador_id;
        public Devoluciones(int id_admin)
        {
            InitializeComponent();
            Administrador_id = id_admin;
        }
        private static Form FormularioActivo = null;
        private static Guna2GradientButton MenuActiv = null;
        private void AbrirFormulario(Guna2GradientButton menu, Form formulario)
        {
            // Restablecer el estilo del botón anteriormente activo
            if (MenuActiv != null)
            {
                MenuActiv.FillColor = Color.FromArgb(255, 43, 47, 51);
                MenuActiv.FillColor2 = Color.FromArgb(255, 43, 47, 51);
                //MenuActiv.FillColor = Color.Aqua;
                //MenuActiv.FillColor2 = Color.Aquamarine;
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

        private void gBtnAddPres_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            AbrirFormulario((Guna2GradientButton)sender, new DevolucionesList());
        }

        private void Devoluciones_Load(object sender, EventArgs e)
        {
            gBtnListDev.CustomBorderColor = Color.FromArgb(255, 197, 63, 0);
            Padding newBorderThickness = gBtnListDev.CustomBorderThickness;
            newBorderThickness.Right = 4;
            gBtnListDev.CustomBorderThickness = newBorderThickness;
            gBtnListDev.FillColor = Color.FromArgb(255, 33, 37, 36);

            // Asignar el botón actual a MenuActiv
            MenuActiv = gBtnListDev;

            DevolucionesList PrestamoAd = new DevolucionesList();

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            FormularioActivo = PrestamoAd;

            PrestamoAd.TopLevel = false;
            PrestamoAd.FormBorderStyle = FormBorderStyle.None;
            PrestamoAd.Dock = DockStyle.Fill;

            pContainer.Controls.Add(PrestamoAd);
            PrestamoAd.Show();
        }
    }
}
