namespace CapaPresentacion
{
    partial class PrestamosList
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
            this.gTxtFecha = new Guna.UI2.WinForms.Guna2TextBox();
            this.gTxtDonante = new Guna.UI2.WinForms.Guna2TextBox();
            this.gTxtIndice = new Guna.UI2.WinForms.Guna2TextBox();
            this.gTxtId = new Guna.UI2.WinForms.Guna2TextBox();
            this.gBtnLimpiar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label7 = new System.Windows.Forms.Label();
            this.gBtnDetalle = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gDgvData = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaPrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Devolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAdmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Administrador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.gBtnDevolucion = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.gDgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // gTxtFecha
            // 
            this.gTxtFecha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gTxtFecha.DefaultText = "";
            this.gTxtFecha.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gTxtFecha.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gTxtFecha.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gTxtFecha.DisabledState.Parent = this.gTxtFecha;
            this.gTxtFecha.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gTxtFecha.Enabled = false;
            this.gTxtFecha.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gTxtFecha.FocusedState.Parent = this.gTxtFecha;
            this.gTxtFecha.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gTxtFecha.HoverState.Parent = this.gTxtFecha;
            this.gTxtFecha.Location = new System.Drawing.Point(663, 148);
            this.gTxtFecha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gTxtFecha.Name = "gTxtFecha";
            this.gTxtFecha.PasswordChar = '\0';
            this.gTxtFecha.PlaceholderText = "";
            this.gTxtFecha.SelectedText = "";
            this.gTxtFecha.ShadowDecoration.Parent = this.gTxtFecha;
            this.gTxtFecha.Size = new System.Drawing.Size(200, 25);
            this.gTxtFecha.TabIndex = 119;
            // 
            // gTxtDonante
            // 
            this.gTxtDonante.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gTxtDonante.DefaultText = "";
            this.gTxtDonante.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gTxtDonante.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gTxtDonante.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gTxtDonante.DisabledState.Parent = this.gTxtDonante;
            this.gTxtDonante.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gTxtDonante.Enabled = false;
            this.gTxtDonante.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gTxtDonante.FocusedState.Parent = this.gTxtDonante;
            this.gTxtDonante.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gTxtDonante.HoverState.Parent = this.gTxtDonante;
            this.gTxtDonante.Location = new System.Drawing.Point(663, 196);
            this.gTxtDonante.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gTxtDonante.Name = "gTxtDonante";
            this.gTxtDonante.PasswordChar = '\0';
            this.gTxtDonante.PlaceholderText = "";
            this.gTxtDonante.SelectedText = "";
            this.gTxtDonante.ShadowDecoration.Parent = this.gTxtDonante;
            this.gTxtDonante.Size = new System.Drawing.Size(200, 25);
            this.gTxtDonante.TabIndex = 121;
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
            this.gTxtIndice.Location = new System.Drawing.Point(842, 99);
            this.gTxtIndice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gTxtIndice.Name = "gTxtIndice";
            this.gTxtIndice.PasswordChar = '\0';
            this.gTxtIndice.PlaceholderText = "";
            this.gTxtIndice.SelectedText = "";
            this.gTxtIndice.SelectionStart = 2;
            this.gTxtIndice.ShadowDecoration.Parent = this.gTxtIndice;
            this.gTxtIndice.Size = new System.Drawing.Size(23, 21);
            this.gTxtIndice.TabIndex = 127;
            this.gTxtIndice.Visible = false;
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
            this.gTxtId.Location = new System.Drawing.Point(871, 99);
            this.gTxtId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gTxtId.Name = "gTxtId";
            this.gTxtId.PasswordChar = '\0';
            this.gTxtId.PlaceholderText = "";
            this.gTxtId.SelectedText = "";
            this.gTxtId.SelectionStart = 1;
            this.gTxtId.ShadowDecoration.Parent = this.gTxtId;
            this.gTxtId.Size = new System.Drawing.Size(23, 21);
            this.gTxtId.TabIndex = 126;
            this.gTxtId.Visible = false;
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
            this.gBtnLimpiar.Location = new System.Drawing.Point(703, 346);
            this.gBtnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.gBtnLimpiar.Name = "gBtnLimpiar";
            this.gBtnLimpiar.ShadowDecoration.Parent = this.gBtnLimpiar;
            this.gBtnLimpiar.Size = new System.Drawing.Size(136, 29);
            this.gBtnLimpiar.TabIndex = 125;
            this.gBtnLimpiar.Text = "Limpiar";
            this.gBtnLimpiar.Click += new System.EventHandler(this.gBtnLimpiar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(679, 46);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 25);
            this.label7.TabIndex = 124;
            this.label7.Text = "Detalle Prestamo";
            // 
            // gBtnDetalle
            // 
            this.gBtnDetalle.BorderRadius = 3;
            this.gBtnDetalle.CheckedState.Parent = this.gBtnDetalle;
            this.gBtnDetalle.CustomImages.Parent = this.gBtnDetalle;
            this.gBtnDetalle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(63)))), ((int)(((byte)(0)))));
            this.gBtnDetalle.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(93)))), ((int)(((byte)(0)))));
            this.gBtnDetalle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gBtnDetalle.ForeColor = System.Drawing.Color.White;
            this.gBtnDetalle.HoverState.Parent = this.gBtnDetalle;
            this.gBtnDetalle.Location = new System.Drawing.Point(703, 305);
            this.gBtnDetalle.Margin = new System.Windows.Forms.Padding(2);
            this.gBtnDetalle.Name = "gBtnDetalle";
            this.gBtnDetalle.ShadowDecoration.Parent = this.gBtnDetalle;
            this.gBtnDetalle.Size = new System.Drawing.Size(136, 29);
            this.gBtnDetalle.TabIndex = 123;
            this.gBtnDetalle.Text = "Detalle";
            this.gBtnDetalle.Click += new System.EventHandler(this.gBtnDetalle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(658, 176);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 122;
            this.label3.Text = "Donacion Por";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(659, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 120;
            this.label2.Text = "Fecha";
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
            this.idUsuario,
            this.Usuario,
            this.FechaPrestamo,
            this.Devolucion,
            this.idEstado,
            this.Estado,
            this.idAdmin,
            this.Administrador});
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
            this.gDgvData.Location = new System.Drawing.Point(21, 75);
            this.gDgvData.Margin = new System.Windows.Forms.Padding(2);
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
            this.gDgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gDgvData.Size = new System.Drawing.Size(607, 325);
            this.gDgvData.TabIndex = 117;
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
            this.gDgvData.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gDgvData_CellFormatting);
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
            this.Id.DataPropertyName = "idPrestamo";
            this.Id.FillWeight = 79.54546F;
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 30;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // idUsuario
            // 
            this.idUsuario.DataPropertyName = "id_usuario";
            this.idUsuario.HeaderText = "idUsuario";
            this.idUsuario.Name = "idUsuario";
            this.idUsuario.ReadOnly = true;
            this.idUsuario.Visible = false;
            // 
            // Usuario
            // 
            this.Usuario.DataPropertyName = "nombre";
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
            // idEstado
            // 
            this.idEstado.DataPropertyName = "id_estado";
            this.idEstado.HeaderText = "idEstado";
            this.idEstado.Name = "idEstado";
            this.idEstado.ReadOnly = true;
            this.idEstado.Visible = false;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 8;
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // idAdmin
            // 
            this.idAdmin.DataPropertyName = "id_admin";
            this.idAdmin.HeaderText = "idAdmin";
            this.idAdmin.Name = "idAdmin";
            this.idAdmin.ReadOnly = true;
            this.idAdmin.Visible = false;
            // 
            // Administrador
            // 
            this.Administrador.DataPropertyName = "nombreAdmin";
            this.Administrador.HeaderText = "Administrador";
            this.Administrador.Name = "Administrador";
            this.Administrador.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(23, 29);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 25);
            this.label4.TabIndex = 128;
            this.label4.Text = "Lista de Prestamo";
            // 
            // gBtnDevolucion
            // 
            this.gBtnDevolucion.BorderRadius = 3;
            this.gBtnDevolucion.CheckedState.Parent = this.gBtnDevolucion;
            this.gBtnDevolucion.CustomImages.Parent = this.gBtnDevolucion;
            this.gBtnDevolucion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(63)))), ((int)(((byte)(0)))));
            this.gBtnDevolucion.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(93)))), ((int)(((byte)(0)))));
            this.gBtnDevolucion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gBtnDevolucion.ForeColor = System.Drawing.Color.White;
            this.gBtnDevolucion.HoverState.Parent = this.gBtnDevolucion;
            this.gBtnDevolucion.Location = new System.Drawing.Point(702, 263);
            this.gBtnDevolucion.Margin = new System.Windows.Forms.Padding(2);
            this.gBtnDevolucion.Name = "gBtnDevolucion";
            this.gBtnDevolucion.ShadowDecoration.Parent = this.gBtnDevolucion;
            this.gBtnDevolucion.Size = new System.Drawing.Size(136, 29);
            this.gBtnDevolucion.TabIndex = 129;
            this.gBtnDevolucion.Text = "Devolucion";
            this.gBtnDevolucion.Click += new System.EventHandler(this.gBtnDevolucion_Click);
            // 
            // PrestamosList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(963, 525);
            this.Controls.Add(this.gBtnDevolucion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gTxtFecha);
            this.Controls.Add(this.gTxtDonante);
            this.Controls.Add(this.gTxtIndice);
            this.Controls.Add(this.gTxtId);
            this.Controls.Add(this.gBtnLimpiar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gBtnDetalle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gDgvData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PrestamosList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrestamosList";
            ((System.ComponentModel.ISupportInitialize)(this.gDgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox gTxtFecha;
        private Guna.UI2.WinForms.Guna2TextBox gTxtDonante;
        private Guna.UI2.WinForms.Guna2TextBox gTxtIndice;
        private Guna.UI2.WinForms.Guna2TextBox gTxtId;
        private Guna.UI2.WinForms.Guna2GradientButton gBtnLimpiar;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2GradientButton gBtnDetalle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView gDgvData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaPrestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Devolucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Administrador;
        private Guna.UI2.WinForms.Guna2GradientButton gBtnDevolucion;
    }
}