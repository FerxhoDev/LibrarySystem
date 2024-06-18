namespace CapaPresentacion
{
    partial class DevolucionesList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.gDgvData = new Guna.UI2.WinForms.Guna2DataGridView();
            this.gBtnLimpiarBusc = new Guna.UI2.WinForms.Guna2GradientButton();
            this.gBtnBuscar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.gTxtBusqueda = new Guna.UI2.WinForms.Guna2TextBox();
            this.gCmbBusqueda = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.gCmbBusquedaChild = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gDtpFecha = new Guna.UI.WinForms.GunaDateTimePicker();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_prestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_libro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Libro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaPrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Devolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gDgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(44, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(300, 38);
            this.label4.TabIndex = 130;
            this.label4.Text = "Lista de Devoluciones";
            // 
            // gDgvData
            // 
            this.gDgvData.AllowUserToAddRows = false;
            this.gDgvData.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gDgvData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gDgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gDgvData.BackgroundColor = System.Drawing.Color.Silver;
            this.gDgvData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gDgvData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gDgvData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(63)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(63)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gDgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gDgvData.ColumnHeadersHeight = 32;
            this.gDgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.id_prestamo,
            this.id_libro,
            this.Libro,
            this.id_usuario,
            this.Usuario,
            this.FechaPrestamo,
            this.Devolucion,
            this.id_estado,
            this.Estado});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gDgvData.DefaultCellStyle = dataGridViewCellStyle3;
            this.gDgvData.EnableHeadersVisualStyles = false;
            this.gDgvData.GridColor = System.Drawing.Color.White;
            this.gDgvData.Location = new System.Drawing.Point(51, 132);
            this.gDgvData.MultiSelect = false;
            this.gDgvData.Name = "gDgvData";
            this.gDgvData.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gDgvData.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gDgvData.RowHeadersVisible = false;
            this.gDgvData.RowHeadersWidth = 62;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gainsboro;
            this.gDgvData.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gDgvData.RowTemplate.Height = 28;
            this.gDgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gDgvData.Size = new System.Drawing.Size(1334, 500);
            this.gDgvData.TabIndex = 129;
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
            this.gDgvData.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gDgvData_CellFormatting);
            // 
            // gBtnLimpiarBusc
            // 
            this.gBtnLimpiarBusc.BorderRadius = 3;
            this.gBtnLimpiarBusc.CheckedState.Parent = this.gBtnLimpiarBusc;
            this.gBtnLimpiarBusc.CustomImages.Parent = this.gBtnLimpiarBusc;
            this.gBtnLimpiarBusc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(93)))), ((int)(((byte)(0)))));
            this.gBtnLimpiarBusc.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(93)))), ((int)(((byte)(0)))));
            this.gBtnLimpiarBusc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gBtnLimpiarBusc.ForeColor = System.Drawing.Color.White;
            this.gBtnLimpiarBusc.HoverState.Parent = this.gBtnLimpiarBusc;
            this.gBtnLimpiarBusc.Location = new System.Drawing.Point(1026, 698);
            this.gBtnLimpiarBusc.Name = "gBtnLimpiarBusc";
            this.gBtnLimpiarBusc.ShadowDecoration.Parent = this.gBtnLimpiarBusc;
            this.gBtnLimpiarBusc.Size = new System.Drawing.Size(112, 45);
            this.gBtnLimpiarBusc.TabIndex = 135;
            this.gBtnLimpiarBusc.Text = "Limpiar";
            this.gBtnLimpiarBusc.Click += new System.EventHandler(this.gBtnLimpiarBusc_Click);
            // 
            // gBtnBuscar
            // 
            this.gBtnBuscar.BorderRadius = 3;
            this.gBtnBuscar.CheckedState.Parent = this.gBtnBuscar;
            this.gBtnBuscar.CustomImages.Parent = this.gBtnBuscar;
            this.gBtnBuscar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(63)))), ((int)(((byte)(0)))));
            this.gBtnBuscar.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(93)))), ((int)(((byte)(0)))));
            this.gBtnBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gBtnBuscar.ForeColor = System.Drawing.Color.White;
            this.gBtnBuscar.HoverState.Parent = this.gBtnBuscar;
            this.gBtnBuscar.Location = new System.Drawing.Point(880, 698);
            this.gBtnBuscar.Name = "gBtnBuscar";
            this.gBtnBuscar.ShadowDecoration.Parent = this.gBtnBuscar;
            this.gBtnBuscar.Size = new System.Drawing.Size(130, 45);
            this.gBtnBuscar.TabIndex = 134;
            this.gBtnBuscar.Text = "Buscar";
            this.gBtnBuscar.Click += new System.EventHandler(this.gBtnBuscar_Click);
            // 
            // gTxtBusqueda
            // 
            this.gTxtBusqueda.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gTxtBusqueda.DefaultText = "";
            this.gTxtBusqueda.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gTxtBusqueda.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gTxtBusqueda.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gTxtBusqueda.DisabledState.Parent = this.gTxtBusqueda;
            this.gTxtBusqueda.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gTxtBusqueda.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gTxtBusqueda.FocusedState.Parent = this.gTxtBusqueda;
            this.gTxtBusqueda.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gTxtBusqueda.HoverState.Parent = this.gTxtBusqueda;
            this.gTxtBusqueda.Location = new System.Drawing.Point(570, 698);
            this.gTxtBusqueda.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.gTxtBusqueda.Name = "gTxtBusqueda";
            this.gTxtBusqueda.PasswordChar = '\0';
            this.gTxtBusqueda.PlaceholderText = "";
            this.gTxtBusqueda.SelectedText = "";
            this.gTxtBusqueda.ShadowDecoration.Parent = this.gTxtBusqueda;
            this.gTxtBusqueda.Size = new System.Drawing.Size(273, 38);
            this.gTxtBusqueda.TabIndex = 133;
            // 
            // gCmbBusqueda
            // 
            this.gCmbBusqueda.Animated = true;
            this.gCmbBusqueda.BackColor = System.Drawing.Color.Transparent;
            this.gCmbBusqueda.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gCmbBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gCmbBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gCmbBusqueda.FocusedColor = System.Drawing.Color.Empty;
            this.gCmbBusqueda.FocusedState.Parent = this.gCmbBusqueda;
            this.gCmbBusqueda.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gCmbBusqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.gCmbBusqueda.FormattingEnabled = true;
            this.gCmbBusqueda.HoverState.Parent = this.gCmbBusqueda;
            this.gCmbBusqueda.ItemHeight = 30;
            this.gCmbBusqueda.ItemsAppearance.Parent = this.gCmbBusqueda;
            this.gCmbBusqueda.Location = new System.Drawing.Point(298, 702);
            this.gCmbBusqueda.Name = "gCmbBusqueda";
            this.gCmbBusqueda.ShadowDecoration.Parent = this.gCmbBusqueda;
            this.gCmbBusqueda.Size = new System.Drawing.Size(226, 36);
            this.gCmbBusqueda.TabIndex = 132;
            this.gCmbBusqueda.SelectedIndexChanged += new System.EventHandler(this.gCmbBusqueda_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(148, 703);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(145, 32);
            this.label12.TabIndex = 131;
            this.label12.Text = "Buscar por:";
            // 
            // gCmbBusquedaChild
            // 
            this.gCmbBusquedaChild.Animated = true;
            this.gCmbBusquedaChild.BackColor = System.Drawing.Color.Transparent;
            this.gCmbBusquedaChild.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gCmbBusquedaChild.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gCmbBusquedaChild.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gCmbBusquedaChild.FocusedColor = System.Drawing.Color.Empty;
            this.gCmbBusquedaChild.FocusedState.Parent = this.gCmbBusquedaChild;
            this.gCmbBusquedaChild.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gCmbBusquedaChild.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.gCmbBusquedaChild.FormattingEnabled = true;
            this.gCmbBusquedaChild.HoverState.Parent = this.gCmbBusquedaChild;
            this.gCmbBusquedaChild.ItemHeight = 30;
            this.gCmbBusquedaChild.ItemsAppearance.Parent = this.gCmbBusquedaChild;
            this.gCmbBusquedaChild.Location = new System.Drawing.Point(594, 698);
            this.gCmbBusquedaChild.Name = "gCmbBusquedaChild";
            this.gCmbBusquedaChild.ShadowDecoration.Parent = this.gCmbBusquedaChild;
            this.gCmbBusquedaChild.Size = new System.Drawing.Size(226, 36);
            this.gCmbBusquedaChild.TabIndex = 136;
            // 
            // gDtpFecha
            // 
            this.gDtpFecha.BaseColor = System.Drawing.Color.White;
            this.gDtpFecha.BorderColor = System.Drawing.Color.Silver;
            this.gDtpFecha.CustomFormat = null;
            this.gDtpFecha.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.gDtpFecha.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gDtpFecha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gDtpFecha.ForeColor = System.Drawing.Color.Black;
            this.gDtpFecha.Location = new System.Drawing.Point(550, 712);
            this.gDtpFecha.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.gDtpFecha.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.gDtpFecha.Name = "gDtpFecha";
            this.gDtpFecha.OnHoverBaseColor = System.Drawing.Color.White;
            this.gDtpFecha.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gDtpFecha.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gDtpFecha.OnPressedColor = System.Drawing.Color.Black;
            this.gDtpFecha.Size = new System.Drawing.Size(306, 31);
            this.gDtpFecha.TabIndex = 137;
            this.gDtpFecha.Text = "miércoles, 15 de mayo de 2024";
            this.gDtpFecha.Value = new System.DateTime(2024, 5, 15, 13, 12, 42, 121);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "idPrestamoDetalle";
            this.Id.FillWeight = 79.54546F;
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 30;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // id_prestamo
            // 
            this.id_prestamo.DataPropertyName = "id_prestamo";
            this.id_prestamo.HeaderText = "id_prestamo";
            this.id_prestamo.MinimumWidth = 8;
            this.id_prestamo.Name = "id_prestamo";
            this.id_prestamo.ReadOnly = true;
            this.id_prestamo.Visible = false;
            // 
            // id_libro
            // 
            this.id_libro.DataPropertyName = "id_libro";
            this.id_libro.HeaderText = "id_libro";
            this.id_libro.MinimumWidth = 8;
            this.id_libro.Name = "id_libro";
            this.id_libro.ReadOnly = true;
            this.id_libro.Visible = false;
            // 
            // Libro
            // 
            this.Libro.DataPropertyName = "nombre";
            this.Libro.HeaderText = "Libro";
            this.Libro.MinimumWidth = 8;
            this.Libro.Name = "Libro";
            this.Libro.ReadOnly = true;
            // 
            // id_usuario
            // 
            this.id_usuario.DataPropertyName = "id_usuario";
            this.id_usuario.HeaderText = "id_usuario";
            this.id_usuario.MinimumWidth = 8;
            this.id_usuario.Name = "id_usuario";
            this.id_usuario.ReadOnly = true;
            this.id_usuario.Visible = false;
            // 
            // Usuario
            // 
            this.Usuario.DataPropertyName = "usuario";
            this.Usuario.FillWeight = 10.32773F;
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.MinimumWidth = 300;
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            // 
            // FechaPrestamo
            // 
            this.FechaPrestamo.DataPropertyName = "fecha_prestamo";
            this.FechaPrestamo.HeaderText = "Fecha Prestam";
            this.FechaPrestamo.MinimumWidth = 8;
            this.FechaPrestamo.Name = "FechaPrestamo";
            this.FechaPrestamo.ReadOnly = true;
            // 
            // Devolucion
            // 
            this.Devolucion.DataPropertyName = "fecha_devolucion";
            this.Devolucion.HeaderText = "Devolucion Sugerida";
            this.Devolucion.MinimumWidth = 150;
            this.Devolucion.Name = "Devolucion";
            this.Devolucion.ReadOnly = true;
            // 
            // id_estado
            // 
            this.id_estado.DataPropertyName = "id_estado";
            this.id_estado.HeaderText = "id_estado";
            this.id_estado.MinimumWidth = 8;
            this.id_estado.Name = "id_estado";
            this.id_estado.ReadOnly = true;
            this.id_estado.Visible = false;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "nombreEstado";
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 8;
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // DevolucionesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1444, 806);
            this.Controls.Add(this.gDtpFecha);
            this.Controls.Add(this.gCmbBusquedaChild);
            this.Controls.Add(this.gBtnLimpiarBusc);
            this.Controls.Add(this.gBtnBuscar);
            this.Controls.Add(this.gTxtBusqueda);
            this.Controls.Add(this.gCmbBusqueda);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gDgvData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DevolucionesList";
            this.Text = "DevolucionesList";
            ((System.ComponentModel.ISupportInitialize)(this.gDgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DataGridView gDgvData;
        private Guna.UI2.WinForms.Guna2GradientButton gBtnLimpiarBusc;
        private Guna.UI2.WinForms.Guna2GradientButton gBtnBuscar;
        private Guna.UI2.WinForms.Guna2TextBox gTxtBusqueda;
        private Guna.UI2.WinForms.Guna2ComboBox gCmbBusqueda;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2ComboBox gCmbBusquedaChild;
        private Guna.UI.WinForms.GunaDateTimePicker gDtpFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_prestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_libro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Libro;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaPrestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Devolucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}