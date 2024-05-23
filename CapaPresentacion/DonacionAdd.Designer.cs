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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtIdDn = new System.Windows.Forms.TextBox();
            this.txtNombreDn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gTxtCantidad = new Guna.UI.WinForms.GunaNumeric();
            this.label10 = new System.Windows.Forms.Label();
            this.txtidLib = new System.Windows.Forms.TextBox();
            this.txtLibro = new System.Windows.Forms.TextBox();
            this.txtCodLib = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gDgvData = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Idproducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Libro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gBtnAddCompra = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.gBtnAddtoCar = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.gBtnBuscarLib = new Guna.UI.WinForms.GunaCircleButton();
            this.gBtnBuscarDn = new Guna.UI.WinForms.GunaCircleButton();
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
            this.label1.Location = new System.Drawing.Point(23, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 30);
            this.label1.TabIndex = 80;
            this.label1.Text = "Registrar Donación";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFecha);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(766, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 122);
            this.groupBox1.TabIndex = 81;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información Donación";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(11, 67);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(211, 31);
            this.txtFecha.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
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
            this.groupBox2.Location = new System.Drawing.Point(1045, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(387, 122);
            this.groupBox2.TabIndex = 82;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información Donador";
            // 
            // txtIdDn
            // 
            this.txtIdDn.Location = new System.Drawing.Point(263, 23);
            this.txtIdDn.Name = "txtIdDn";
            this.txtIdDn.Size = new System.Drawing.Size(36, 31);
            this.txtIdDn.TabIndex = 6;
            // 
            // txtNombreDn
            // 
            this.txtNombreDn.Location = new System.Drawing.Point(11, 67);
            this.txtNombreDn.Name = "txtNombreDn";
            this.txtNombreDn.Size = new System.Drawing.Size(211, 31);
            this.txtNombreDn.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 25);
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
            this.groupBox3.Location = new System.Drawing.Point(28, 171);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1227, 122);
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
            this.gTxtCantidad.Location = new System.Drawing.Point(1039, 66);
            this.gTxtCantidad.Maximum = ((long)(9999999));
            this.gTxtCantidad.Minimum = ((long)(0));
            this.gTxtCantidad.Name = "gTxtCantidad";
            this.gTxtCantidad.Radius = 5;
            this.gTxtCantidad.Size = new System.Drawing.Size(81, 30);
            this.gTxtCantidad.TabIndex = 8;
            this.gTxtCantidad.Text = "gTxtCantidad";
            this.gTxtCantidad.Value = ((long)(1));
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1034, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 25);
            this.label10.TabIndex = 11;
            this.label10.Text = "Cantidad";
            // 
            // txtidLib
            // 
            this.txtidLib.Location = new System.Drawing.Point(201, 26);
            this.txtidLib.Name = "txtidLib";
            this.txtidLib.Size = new System.Drawing.Size(36, 31);
            this.txtidLib.TabIndex = 6;
            // 
            // txtLibro
            // 
            this.txtLibro.Location = new System.Drawing.Point(485, 65);
            this.txtLibro.Name = "txtLibro";
            this.txtLibro.Size = new System.Drawing.Size(412, 31);
            this.txtLibro.TabIndex = 3;
            // 
            // txtCodLib
            // 
            this.txtCodLib.Location = new System.Drawing.Point(11, 65);
            this.txtCodLib.Name = "txtCodLib";
            this.txtCodLib.Size = new System.Drawing.Size(362, 31);
            this.txtCodLib.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(480, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Libro";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Cod Libro";
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
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(57)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gDgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gDgvData.ColumnHeadersHeight = 32;
            this.gDgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Idproducto,
            this.Codigo,
            this.Libro,
            this.Cantidad,
            this.btnEliminar});
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
            this.gDgvData.Location = new System.Drawing.Point(29, 315);
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
            this.gDgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gDgvData.Size = new System.Drawing.Size(1216, 379);
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
            // 
            // Idproducto
            // 
            this.Idproducto.FillWeight = 79.54546F;
            this.Idproducto.HeaderText = "Id";
            this.Idproducto.MinimumWidth = 30;
            this.Idproducto.Name = "Idproducto";
            this.Idproducto.ReadOnly = true;
            this.Idproducto.Visible = false;
            // 
            // Codigo
            // 
            this.Codigo.FillWeight = 355.9276F;
            this.Codigo.HeaderText = "Código";
            this.Codigo.MinimumWidth = 150;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Libro
            // 
            this.Libro.FillWeight = 204.3646F;
            this.Libro.HeaderText = "Libro";
            this.Libro.MinimumWidth = 400;
            this.Libro.Name = "Libro";
            this.Libro.ReadOnly = true;
            // 
            // Cantidad
            // 
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
            this.gBtnAddCompra.Location = new System.Drawing.Point(1273, 598);
            this.gBtnAddCompra.Name = "gBtnAddCompra";
            this.gBtnAddCompra.ShadowDecoration.Parent = this.gBtnAddCompra;
            this.gBtnAddCompra.Size = new System.Drawing.Size(136, 96);
            this.gBtnAddCompra.TabIndex = 86;
            this.gBtnAddCompra.Text = "Agregar";
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
            this.gBtnAddtoCar.Location = new System.Drawing.Point(1273, 200);
            this.gBtnAddtoCar.Name = "gBtnAddtoCar";
            this.gBtnAddtoCar.ShadowDecoration.Parent = this.gBtnAddtoCar;
            this.gBtnAddtoCar.Size = new System.Drawing.Size(136, 81);
            this.gBtnAddtoCar.TabIndex = 84;
            this.gBtnAddtoCar.Text = "Agregar";
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
            this.gBtnBuscarLib.Location = new System.Drawing.Point(397, 53);
            this.gBtnBuscarLib.Name = "gBtnBuscarLib";
            this.gBtnBuscarLib.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(138)))), ((int)(((byte)(166)))));
            this.gBtnBuscarLib.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gBtnBuscarLib.OnHoverForeColor = System.Drawing.Color.White;
            this.gBtnBuscarLib.OnHoverImage = null;
            this.gBtnBuscarLib.OnPressedColor = System.Drawing.Color.Black;
            this.gBtnBuscarLib.Size = new System.Drawing.Size(43, 43);
            this.gBtnBuscarLib.TabIndex = 5;
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
            this.gBtnBuscarDn.Location = new System.Drawing.Point(321, 55);
            this.gBtnBuscarDn.Name = "gBtnBuscarDn";
            this.gBtnBuscarDn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(138)))), ((int)(((byte)(166)))));
            this.gBtnBuscarDn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gBtnBuscarDn.OnHoverForeColor = System.Drawing.Color.White;
            this.gBtnBuscarDn.OnHoverImage = null;
            this.gBtnBuscarDn.OnPressedColor = System.Drawing.Color.Black;
            this.gBtnBuscarDn.Size = new System.Drawing.Size(43, 43);
            this.gBtnBuscarDn.TabIndex = 5;
            // 
            // DonacionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1444, 734);
            this.Controls.Add(this.gBtnAddCompra);
            this.Controls.Add(this.gDgvData);
            this.Controls.Add(this.gBtnAddtoCar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DonacionList";
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
        private System.Windows.Forms.TextBox txtNombreDn;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Idproducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Libro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminar;
    }
}