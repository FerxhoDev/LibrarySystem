namespace CapaPresentacion
{
    partial class DonacionPersona
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gTxtNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.gBtnLimpiar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.gBtnEliminar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.gDgvData = new Guna.UI2.WinForms.Guna2DataGridView();
            this.gBtnGuardar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.gTxtIndice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gTxtId = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gDgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // gTxtNombre
            // 
            this.gTxtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gTxtNombre.DefaultText = "";
            this.gTxtNombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gTxtNombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gTxtNombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gTxtNombre.DisabledState.Parent = this.gTxtNombre;
            this.gTxtNombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gTxtNombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gTxtNombre.FocusedState.Parent = this.gTxtNombre;
            this.gTxtNombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gTxtNombre.HoverState.Parent = this.gTxtNombre;
            this.gTxtNombre.Location = new System.Drawing.Point(715, 205);
            this.gTxtNombre.Name = "gTxtNombre";
            this.gTxtNombre.PasswordChar = '\0';
            this.gTxtNombre.PlaceholderText = "";
            this.gTxtNombre.SelectedText = "";
            this.gTxtNombre.ShadowDecoration.Parent = this.gTxtNombre;
            this.gTxtNombre.Size = new System.Drawing.Size(200, 25);
            this.gTxtNombre.TabIndex = 94;
            // 
            // gBtnLimpiar
            // 
            this.gBtnLimpiar.BorderRadius = 3;
            this.gBtnLimpiar.CheckedState.Parent = this.gBtnLimpiar;
            this.gBtnLimpiar.CustomImages.Parent = this.gBtnLimpiar;
            this.gBtnLimpiar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(93)))), ((int)(((byte)(0)))));
            this.gBtnLimpiar.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(93)))), ((int)(((byte)(0)))));
            this.gBtnLimpiar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gBtnLimpiar.ForeColor = System.Drawing.Color.White;
            this.gBtnLimpiar.HoverState.Parent = this.gBtnLimpiar;
            this.gBtnLimpiar.Location = new System.Drawing.Point(745, 317);
            this.gBtnLimpiar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gBtnLimpiar.Name = "gBtnLimpiar";
            this.gBtnLimpiar.ShadowDecoration.Parent = this.gBtnLimpiar;
            this.gBtnLimpiar.Size = new System.Drawing.Size(136, 29);
            this.gBtnLimpiar.TabIndex = 100;
            this.gBtnLimpiar.Text = "Limpiar";
            this.gBtnLimpiar.Click += new System.EventHandler(this.gBtnLimpiar_Click);
            // 
            // gBtnEliminar
            // 
            this.gBtnEliminar.BorderRadius = 3;
            this.gBtnEliminar.CheckedState.Parent = this.gBtnEliminar;
            this.gBtnEliminar.CustomImages.Parent = this.gBtnEliminar;
            this.gBtnEliminar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(3)))), ((int)(((byte)(15)))));
            this.gBtnEliminar.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(3)))), ((int)(((byte)(15)))));
            this.gBtnEliminar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gBtnEliminar.ForeColor = System.Drawing.Color.White;
            this.gBtnEliminar.HoverState.Parent = this.gBtnEliminar;
            this.gBtnEliminar.Location = new System.Drawing.Point(745, 350);
            this.gBtnEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gBtnEliminar.Name = "gBtnEliminar";
            this.gBtnEliminar.ShadowDecoration.Parent = this.gBtnEliminar;
            this.gBtnEliminar.Size = new System.Drawing.Size(136, 29);
            this.gBtnEliminar.TabIndex = 99;
            this.gBtnEliminar.Text = "Eliminar";
            this.gBtnEliminar.Click += new System.EventHandler(this.gBtnEliminar_Click);
            // 
            // gDgvData
            // 
            this.gDgvData.AllowUserToAddRows = false;
            this.gDgvData.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.gDgvData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.gDgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gDgvData.BackgroundColor = System.Drawing.Color.Silver;
            this.gDgvData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gDgvData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gDgvData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(63)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(63)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gDgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gDgvData.ColumnHeadersHeight = 32;
            this.gDgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionar,
            this.Id,
            this.Nombre});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gDgvData.DefaultCellStyle = dataGridViewCellStyle8;
            this.gDgvData.EnableHeadersVisualStyles = false;
            this.gDgvData.GridColor = System.Drawing.Color.White;
            this.gDgvData.Location = new System.Drawing.Point(35, 83);
            this.gDgvData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gDgvData.MultiSelect = false;
            this.gDgvData.Name = "gDgvData";
            this.gDgvData.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gDgvData.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.gDgvData.RowHeadersVisible = false;
            this.gDgvData.RowHeadersWidth = 62;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Gainsboro;
            this.gDgvData.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.gDgvData.RowTemplate.Height = 28;
            this.gDgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gDgvData.Size = new System.Drawing.Size(564, 306);
            this.gDgvData.TabIndex = 93;
            this.gDgvData.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.gDgvData.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gDgvData.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gDgvData.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gDgvData.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gDgvData.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gDgvData.ThemeStyle.BackColor = System.Drawing.Color.Silver;
            this.gDgvData.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.gDgvData.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(63)))), ((int)(((byte)(0)))));
            this.gDgvData.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gDgvData.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gDgvData.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gDgvData.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gDgvData.ThemeStyle.HeaderStyle.Height = 32;
            this.gDgvData.ThemeStyle.ReadOnly = true;
            this.gDgvData.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gDgvData.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gDgvData.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gDgvData.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gDgvData.ThemeStyle.RowsStyle.Height = 28;
            this.gDgvData.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gDgvData.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gDgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gDgvData_CellContentClick);
            // 
            // gBtnGuardar
            // 
            this.gBtnGuardar.BorderRadius = 3;
            this.gBtnGuardar.CheckedState.Parent = this.gBtnGuardar;
            this.gBtnGuardar.CustomImages.Parent = this.gBtnGuardar;
            this.gBtnGuardar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(63)))), ((int)(((byte)(0)))));
            this.gBtnGuardar.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(93)))), ((int)(((byte)(0)))));
            this.gBtnGuardar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gBtnGuardar.ForeColor = System.Drawing.Color.White;
            this.gBtnGuardar.HoverState.Parent = this.gBtnGuardar;
            this.gBtnGuardar.Location = new System.Drawing.Point(745, 283);
            this.gBtnGuardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gBtnGuardar.Name = "gBtnGuardar";
            this.gBtnGuardar.ShadowDecoration.Parent = this.gBtnGuardar;
            this.gBtnGuardar.Size = new System.Drawing.Size(136, 29);
            this.gBtnGuardar.TabIndex = 98;
            this.gBtnGuardar.Text = "Guardar";
            this.gBtnGuardar.Click += new System.EventHandler(this.gBtnGuardar_Click);
            // 
            // gTxtIndice
            // 
            this.gTxtIndice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gTxtIndice.DefaultText = "-1";
            this.gTxtIndice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gTxtIndice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gTxtIndice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gTxtIndice.DisabledState.Parent = this.gTxtIndice;
            this.gTxtIndice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gTxtIndice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gTxtIndice.FocusedState.Parent = this.gTxtIndice;
            this.gTxtIndice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gTxtIndice.HoverState.Parent = this.gTxtIndice;
            this.gTxtIndice.Location = new System.Drawing.Point(877, 140);
            this.gTxtIndice.Name = "gTxtIndice";
            this.gTxtIndice.PasswordChar = '\0';
            this.gTxtIndice.PlaceholderText = "";
            this.gTxtIndice.SelectedText = "";
            this.gTxtIndice.SelectionStart = 2;
            this.gTxtIndice.ShadowDecoration.Parent = this.gTxtIndice;
            this.gTxtIndice.Size = new System.Drawing.Size(23, 21);
            this.gTxtIndice.TabIndex = 97;
            this.gTxtIndice.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(711, 185);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 15);
            this.label2.TabIndex = 95;
            this.label2.Text = "Nombre / Institución";
            // 
            // gTxtId
            // 
            this.gTxtId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gTxtId.DefaultText = "0";
            this.gTxtId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gTxtId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gTxtId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gTxtId.DisabledState.Parent = this.gTxtId;
            this.gTxtId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gTxtId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gTxtId.FocusedState.Parent = this.gTxtId;
            this.gTxtId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gTxtId.HoverState.Parent = this.gTxtId;
            this.gTxtId.Location = new System.Drawing.Point(906, 140);
            this.gTxtId.Name = "gTxtId";
            this.gTxtId.PasswordChar = '\0';
            this.gTxtId.PlaceholderText = "";
            this.gTxtId.SelectedText = "";
            this.gTxtId.SelectionStart = 1;
            this.gTxtId.ShadowDecoration.Parent = this.gTxtId;
            this.gTxtId.Size = new System.Drawing.Size(23, 21);
            this.gTxtId.TabIndex = 96;
            this.gTxtId.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(31, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 101;
            this.label1.Text = "Personas / Instituciones";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(643, 14);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(323, 30);
            this.label7.TabIndex = 113;
            this.label7.Text = "Detalle Persona / Institución";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.FillWeight = 0.02217987F;
            this.btnSeleccionar.HeaderText = "";
            this.btnSeleccionar.MinimumWidth = 50;
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.ReadOnly = true;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "idDonante";
            this.Id.FillWeight = 79.54546F;
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 30;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "nombre";
            this.Nombre.FillWeight = 355.9276F;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 150;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // DonacionPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1036, 543);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gTxtNombre);
            this.Controls.Add(this.gBtnLimpiar);
            this.Controls.Add(this.gBtnEliminar);
            this.Controls.Add(this.gDgvData);
            this.Controls.Add(this.gBtnGuardar);
            this.Controls.Add(this.gTxtIndice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gTxtId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DonacionPersona";
            this.Text = "DonacionPersona";
            ((System.ComponentModel.ISupportInitialize)(this.gDgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox gTxtNombre;
        private Guna.UI2.WinForms.Guna2GradientButton gBtnLimpiar;
        private Guna.UI2.WinForms.Guna2GradientButton gBtnEliminar;
        private Guna.UI2.WinForms.Guna2DataGridView gDgvData;
        private Guna.UI2.WinForms.Guna2GradientButton gBtnGuardar;
        private Guna.UI2.WinForms.Guna2TextBox gTxtIndice;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox gTxtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
    }
}