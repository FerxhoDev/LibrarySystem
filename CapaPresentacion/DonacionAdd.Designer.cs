namespace CapaPresentacion
{
    partial class DonacionAdd
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtIdDn = new System.Windows.Forms.TextBox();
            this.gBtnBuscarDn = new Guna.UI.WinForms.GunaCircleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gTxtCantidad = new Guna.UI.WinForms.GunaNumeric();
            this.label10 = new System.Windows.Forms.Label();
            this.txtidLib = new System.Windows.Forms.TextBox();
            this.gBtnBuscarLib = new Guna.UI.WinForms.GunaCircleButton();
            this.txtLibro = new System.Windows.Forms.TextBox();
            this.txtCodLib = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gDgvData = new Guna.UI2.WinForms.Guna2DataGridView();
            this.gBtnAddCompra = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.gBtnAddtoCar = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.txtNombreDn = new System.Windows.Forms.TextBox();
            this.Idproducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Libro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gDgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 80;
            this.label1.Text = "Registrar Donación";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFecha);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(511, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(174, 79);
            this.groupBox1.TabIndex = 81;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información Donación";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(7, 44);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(2);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(142, 23);
            this.txtFecha.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtIdDn);
            this.groupBox2.Controls.Add(this.gBtnBuscarDn);
            this.groupBox2.Controls.Add(this.txtNombreDn);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(697, 20);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(258, 79);
            this.groupBox2.TabIndex = 82;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información Donador";
            // 
            // txtIdDn
            // 
            this.txtIdDn.Location = new System.Drawing.Point(175, 15);
            this.txtIdDn.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdDn.Name = "txtIdDn";
            this.txtIdDn.Size = new System.Drawing.Size(25, 23);
            this.txtIdDn.TabIndex = 6;
            // 
            // gBtnBuscarDn
            // 
            this.gBtnBuscarDn.AnimationHoverSpeed = 0.07F;
            this.gBtnBuscarDn.AnimationSpeed = 0.03F;
            this.gBtnBuscarDn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(63)))), ((int)(((byte)(0)))));
            this.gBtnBuscarDn.BorderColor = System.Drawing.Color.Black;
            this.gBtnBuscarDn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gBtnBuscarDn.FocusedColor = System.Drawing.Color.Empty;
            this.gBtnBuscarDn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gBtnBuscarDn.ForeColor = System.Drawing.Color.White;
            this.gBtnBuscarDn.Image = global::CapaPresentacion.Properties.Resources.búsqueda_20;
            this.gBtnBuscarDn.ImageSize = new System.Drawing.Size(28, 28);
            this.gBtnBuscarDn.Location = new System.Drawing.Point(214, 36);
            this.gBtnBuscarDn.Margin = new System.Windows.Forms.Padding(2);
            this.gBtnBuscarDn.Name = "gBtnBuscarDn";
            this.gBtnBuscarDn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(138)))), ((int)(((byte)(166)))));
            this.gBtnBuscarDn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gBtnBuscarDn.OnHoverForeColor = System.Drawing.Color.White;
            this.gBtnBuscarDn.OnHoverImage = null;
            this.gBtnBuscarDn.OnPressedColor = System.Drawing.Color.Black;
            this.gBtnBuscarDn.Size = new System.Drawing.Size(29, 28);
            this.gBtnBuscarDn.TabIndex = 5;
            this.gBtnBuscarDn.Click += new System.EventHandler(this.gBtnBuscarDn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 19);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nombre";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gTxtCantidad);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtidLib);
            this.groupBox3.Controls.Add(this.gBtnBuscarLib);
            this.groupBox3.Controls.Add(this.txtLibro);
            this.groupBox3.Controls.Add(this.txtCodLib);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(19, 111);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(818, 79);
            this.groupBox3.TabIndex = 83;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Información Libro";
            // 
            // gTxtCantidad
            // 
            this.gTxtCantidad.BackColor = System.Drawing.Color.Transparent;
            this.gTxtCantidad.BaseColor = System.Drawing.Color.White;
            this.gTxtCantidad.BorderColor = System.Drawing.Color.Silver;
            this.gTxtCantidad.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(63)))), ((int)(((byte)(0)))));
            this.gTxtCantidad.ButtonForeColor = System.Drawing.Color.White;
            this.gTxtCantidad.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gTxtCantidad.ForeColor = System.Drawing.Color.Black;
            this.gTxtCantidad.Location = new System.Drawing.Point(693, 43);
            this.gTxtCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.gTxtCantidad.Maximum = ((long)(9999999));
            this.gTxtCantidad.Minimum = ((long)(0));
            this.gTxtCantidad.Name = "gTxtCantidad";
            this.gTxtCantidad.Radius = 5;
            this.gTxtCantidad.Size = new System.Drawing.Size(54, 30);
            this.gTxtCantidad.TabIndex = 8;
            this.gTxtCantidad.Text = "gTxtCantidad";
            this.gTxtCantidad.Value = ((long)(1));
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(689, 17);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 15);
            this.label10.TabIndex = 11;
            this.label10.Text = "Cantidad";
            // 
            // txtidLib
            // 
            this.txtidLib.Location = new System.Drawing.Point(134, 17);
            this.txtidLib.Margin = new System.Windows.Forms.Padding(2);
            this.txtidLib.Name = "txtidLib";
            this.txtidLib.Size = new System.Drawing.Size(25, 23);
            this.txtidLib.TabIndex = 6;
            // 
            // gBtnBuscarLib
            // 
            this.gBtnBuscarLib.AnimationHoverSpeed = 0.07F;
            this.gBtnBuscarLib.AnimationSpeed = 0.03F;
            this.gBtnBuscarLib.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(63)))), ((int)(((byte)(0)))));
            this.gBtnBuscarLib.BorderColor = System.Drawing.Color.Black;
            this.gBtnBuscarLib.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gBtnBuscarLib.FocusedColor = System.Drawing.Color.Empty;
            this.gBtnBuscarLib.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gBtnBuscarLib.ForeColor = System.Drawing.Color.White;
            this.gBtnBuscarLib.Image = global::CapaPresentacion.Properties.Resources.búsqueda_20;
            this.gBtnBuscarLib.ImageSize = new System.Drawing.Size(28, 28);
            this.gBtnBuscarLib.Location = new System.Drawing.Point(265, 34);
            this.gBtnBuscarLib.Margin = new System.Windows.Forms.Padding(2);
            this.gBtnBuscarLib.Name = "gBtnBuscarLib";
            this.gBtnBuscarLib.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(138)))), ((int)(((byte)(166)))));
            this.gBtnBuscarLib.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gBtnBuscarLib.OnHoverForeColor = System.Drawing.Color.White;
            this.gBtnBuscarLib.OnHoverImage = null;
            this.gBtnBuscarLib.OnPressedColor = System.Drawing.Color.Black;
            this.gBtnBuscarLib.Size = new System.Drawing.Size(29, 28);
            this.gBtnBuscarLib.TabIndex = 5;
            this.gBtnBuscarLib.Click += new System.EventHandler(this.gBtnBuscarLib_Click);
            // 
            // txtLibro
            // 
            this.txtLibro.Location = new System.Drawing.Point(323, 42);
            this.txtLibro.Margin = new System.Windows.Forms.Padding(2);
            this.txtLibro.Name = "txtLibro";
            this.txtLibro.Size = new System.Drawing.Size(276, 23);
            this.txtLibro.TabIndex = 3;
            // 
            // txtCodLib
            // 
            this.txtCodLib.Location = new System.Drawing.Point(7, 42);
            this.txtCodLib.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodLib.Name = "txtCodLib";
            this.txtCodLib.Size = new System.Drawing.Size(243, 23);
            this.txtCodLib.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(320, 21);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Libro";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 19);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Cod Libro";
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
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(57)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gDgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gDgvData.ColumnHeadersHeight = 32;
            this.gDgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Idproducto,
            this.Codigo,
            this.Libro,
            this.Cantidad,
            this.btnEliminar});
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
            this.gDgvData.Location = new System.Drawing.Point(19, 205);
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
            this.gDgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gDgvData.Size = new System.Drawing.Size(811, 246);
            this.gDgvData.TabIndex = 85;
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
            // gBtnAddCompra
            // 
            this.gBtnAddCompra.BorderRadius = 10;
            this.gBtnAddCompra.CheckedState.Parent = this.gBtnAddCompra;
            this.gBtnAddCompra.CustomImages.Parent = this.gBtnAddCompra;
            this.gBtnAddCompra.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(63)))), ((int)(((byte)(0)))));
            this.gBtnAddCompra.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(63)))), ((int)(((byte)(0)))));
            this.gBtnAddCompra.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gBtnAddCompra.ForeColor = System.Drawing.Color.White;
            this.gBtnAddCompra.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(57)))), ((int)(((byte)(88)))));
            this.gBtnAddCompra.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(138)))), ((int)(((byte)(166)))));
            this.gBtnAddCompra.HoverState.Parent = this.gBtnAddCompra;
            this.gBtnAddCompra.Image = global::CapaPresentacion.Properties.Resources.etiqueta_50;
            this.gBtnAddCompra.Location = new System.Drawing.Point(849, 389);
            this.gBtnAddCompra.Margin = new System.Windows.Forms.Padding(2);
            this.gBtnAddCompra.Name = "gBtnAddCompra";
            this.gBtnAddCompra.ShadowDecoration.Parent = this.gBtnAddCompra;
            this.gBtnAddCompra.Size = new System.Drawing.Size(91, 62);
            this.gBtnAddCompra.TabIndex = 86;
            this.gBtnAddCompra.Text = "Agregar";
            this.gBtnAddCompra.Click += new System.EventHandler(this.gBtnAddCompra_Click);
            // 
            // gBtnAddtoCar
            // 
            this.gBtnAddtoCar.BorderRadius = 10;
            this.gBtnAddtoCar.CheckedState.Parent = this.gBtnAddtoCar;
            this.gBtnAddtoCar.CustomImages.Parent = this.gBtnAddtoCar;
            this.gBtnAddtoCar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(63)))), ((int)(((byte)(0)))));
            this.gBtnAddtoCar.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(63)))), ((int)(((byte)(0)))));
            this.gBtnAddtoCar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gBtnAddtoCar.ForeColor = System.Drawing.Color.White;
            this.gBtnAddtoCar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(57)))), ((int)(((byte)(88)))));
            this.gBtnAddtoCar.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(138)))), ((int)(((byte)(166)))));
            this.gBtnAddtoCar.HoverState.Parent = this.gBtnAddtoCar;
            this.gBtnAddtoCar.Image = global::CapaPresentacion.Properties.Resources.caja_50;
            this.gBtnAddtoCar.Location = new System.Drawing.Point(849, 130);
            this.gBtnAddtoCar.Margin = new System.Windows.Forms.Padding(2);
            this.gBtnAddtoCar.Name = "gBtnAddtoCar";
            this.gBtnAddtoCar.ShadowDecoration.Parent = this.gBtnAddtoCar;
            this.gBtnAddtoCar.Size = new System.Drawing.Size(91, 53);
            this.gBtnAddtoCar.TabIndex = 84;
            this.gBtnAddtoCar.Text = "Agregar";
            this.gBtnAddtoCar.Click += new System.EventHandler(this.gBtnAddtoCar_Click);
            // 
            // txtNombreDn
            // 
            this.txtNombreDn.Location = new System.Drawing.Point(7, 44);
            this.txtNombreDn.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreDn.Name = "txtNombreDn";
            this.txtNombreDn.Size = new System.Drawing.Size(142, 23);
            this.txtNombreDn.TabIndex = 2;
            // 
            // Idproducto
            // 
            this.Idproducto.DataPropertyName = "id";
            this.Idproducto.FillWeight = 79.54546F;
            this.Idproducto.HeaderText = "Id";
            this.Idproducto.MinimumWidth = 30;
            this.Idproducto.Name = "Idproducto";
            this.Idproducto.ReadOnly = true;
            this.Idproducto.Visible = false;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "codigo";
            this.Codigo.FillWeight = 355.9276F;
            this.Codigo.HeaderText = "Código";
            this.Codigo.MinimumWidth = 150;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Libro
            // 
            this.Libro.DataPropertyName = "libro";
            this.Libro.FillWeight = 204.3646F;
            this.Libro.HeaderText = "Libro";
            this.Libro.MinimumWidth = 400;
            this.Libro.Name = "Libro";
            this.Libro.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "cantidad";
            this.Cantidad.FillWeight = 31.52491F;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 200;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.FillWeight = 0.02217987F;
            this.btnEliminar.HeaderText = "";
            this.btnEliminar.MinimumWidth = 30;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ReadOnly = true;
            // 
            // DonacionAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(963, 477);
            this.Controls.Add(this.gBtnAddCompra);
            this.Controls.Add(this.gDgvData);
            this.Controls.Add(this.gBtnAddtoCar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DonacionAdd";
            this.Text = "DonacionList";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gDgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtIdDn;
        private Guna.UI.WinForms.GunaCircleButton gBtnBuscarDn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private Guna.UI.WinForms.GunaNumeric gTxtCantidad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtidLib;
        private Guna.UI.WinForms.GunaCircleButton gBtnBuscarLib;
        private System.Windows.Forms.TextBox txtLibro;
        private System.Windows.Forms.TextBox txtCodLib;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2GradientTileButton gBtnAddtoCar;
        private Guna.UI2.WinForms.Guna2DataGridView gDgvData;
        private Guna.UI2.WinForms.Guna2GradientTileButton gBtnAddCompra;
        private System.Windows.Forms.TextBox txtNombreDn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idproducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Libro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminar;
    }
}