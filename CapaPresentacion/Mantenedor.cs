﻿using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CapaPresentacion
{
    public partial class Mantenedor : Form
    {
        int Administrador_id;
        public Mantenedor(int id_admin)
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
            }

            // Establecer el estilo del botón actual
            menu.FillColor = Color.FromArgb(255, 33, 37, 36);
            menu.FillColor2 = Color.FromArgb(255, 33, 37, 36);

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

            pContainerM.Controls.Add(formulario);
            formulario.Show();
        }

        private void gBtnCategoria_Click(object sender, EventArgs e)
        {
            AbrirFormulario((Guna2GradientButton)sender, new Donaciones(Administrador_id));
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            AbrirFormulario((Guna2GradientButton)sender, new Responsables());
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            AbrirFormulario((Guna2GradientButton)sender, new CentrosEducativos());
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            AbrirFormulario((Guna2GradientButton)sender, new Direcciones());
        }

        private void Mantenedor_Load(object sender, EventArgs e)
        {
            
            gBtnDonaciones.FillColor = Color.FromArgb(255, 33, 37, 36);
            gBtnDonaciones.FillColor2 = Color.FromArgb(255, 33, 37, 36);

            // Asignar el botón actual a MenuActiv
            MenuActiv = gBtnDonaciones;

            Donaciones donaciones = new Donaciones(Administrador_id);

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            FormularioActivo = donaciones;

            donaciones.TopLevel = false;
            donaciones.FormBorderStyle = FormBorderStyle.None;
            donaciones.Dock = DockStyle.Fill;

            pContainerM.Controls.Add(donaciones);
            donaciones.Show();

        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            AbrirFormulario((Guna2GradientButton)sender, new CategoriasL());
        }
    }
}
