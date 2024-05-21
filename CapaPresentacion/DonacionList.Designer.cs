namespace CapaPresentacion
{
    partial class DonacionList
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
            this.txtIdPr = new System.Windows.Forms.TextBox();
            this.gBtnBuscarPr = new Guna.UI.WinForms.GunaCircleButton();
            this.txtNombrePr = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gTxtCantidad = new Guna.UI.WinForms.GunaNumeric();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.txtidProd = new System.Windows.Forms.TextBox();
            this.gBtnBuscarProd = new Guna.UI.WinForms.GunaCircleButton();
            this.txtProd = new System.Windows.Forms.TextBox();
            this.txtCodProd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gBtnAddtoCar = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.gDgvData = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Idproducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gBtnAddCompra = new Guna.UI2.WinForms.Guna2GradientTileButton();
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
            this.groupBox1.Text = "Información Compra";
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
            this.groupBox2.Controls.Add(this.txtIdPr);
            this.groupBox2.Controls.Add(this.gBtnBuscarPr);
            this.groupBox2.Controls.Add(this.txtNombrePr);
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
            // txtIdPr
            // 
            this.txtIdPr.Location = new System.Drawing.Point(263, 23);
            this.txtIdPr.Name = "txtIdPr";
            this.txtIdPr.Size = new System.Drawing.Size(36, 31);
            this.txtIdPr.TabIndex = 6;
            // 
            // gBtnBuscarPr
            // 
            this.gBtnBuscarPr.AnimationHoverSpeed = 0.07F;
            this.gBtnBuscarPr.AnimationSpeed = 0.03F;
            this.gBtnBuscarPr.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(63)))), ((int)(((byte)(0)))));
            this.gBtnBuscarPr.BorderColor = System.Drawing.Color.Black;
            this.gBtnBuscarPr.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gBtnBuscarPr.FocusedColor = System.Drawing.Color.Empty;
            this.gBtnBuscarPr.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gBtnBuscarPr.ForeColor = System.Drawing.Color.White;
            this.gBtnBuscarPr.Image = null;
            this.gBtnBuscarPr.ImageSize = new System.Drawing.Size(28, 28);
            this.gBtnBuscarPr.Location = new System.Drawing.Point(321, 55);
            this.gBtnBuscarPr.Name = "gBtnBuscarPr";
            this.gBtnBuscarPr.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(138)))), ((int)(((byte)(166)))));
            this.gBtnBuscarPr.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gBtnBuscarPr.OnHoverForeColor = System.Drawing.Color.White;
            this.gBtnBuscarPr.OnHoverImage = null;
            this.gBtnBuscarPr.OnPressedColor = System.Drawing.Color.Black;
            this.gBtnBuscarPr.Size = new System.Drawing.Size(43, 43);
            this.gBtnBuscarPr.TabIndex = 5;
            // 
            // txtNombrePr
            // 
            this.txtNombrePr.Location = new System.Drawing.Point(11, 67);
            this.txtNombrePr.Name = "txtNombrePr";
            this.txtNombrePr.Size = new System.Drawing.Size(211, 31);
            this.txtNombrePr.TabIndex = 2;
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
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtPrecio);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtCosto);
            this.groupBox3.Controls.Add(this.txtidProd);
            this.groupBox3.Controls.Add(this.gBtnBuscarProd);
            this.groupBox3.Controls.Add(this.txtProd);
            this.groupBox3.Controls.Add(this.txtCodProd);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(28, 171);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1227, 122);
            this.groupBox3.TabIndex = 83;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Información Producto";
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
            this.gTxtCantidad.Location = new System.Drawing.Point(952, 67);
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
            this.label10.Location = new System.Drawing.Point(947, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 25);
            this.label10.TabIndex = 11;
            this.label10.Text = "Cantidad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(762, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 25);
            this.label9.TabIndex = 10;
            this.label9.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(767, 67);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(102, 31);
            this.txtPrecio.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(633, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "Costo";
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(638, 67);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(102, 31);
            this.txtCosto.TabIndex = 7;
            // 
            // txtidProd
            // 
            this.txtidProd.Location = new System.Drawing.Point(201, 26);
            this.txtidProd.Name = "txtidProd";
            this.txtidProd.Size = new System.Drawing.Size(36, 31);
            this.txtidProd.TabIndex = 6;
            // 
            // gBtnBuscarProd
            // 
            this.gBtnBuscarProd.AnimationHoverSpeed = 0.07F;
            this.gBtnBuscarProd.AnimationSpeed = 0.03F;
            this.gBtnBuscarProd.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(63)))), ((int)(((byte)(0)))));
            this.gBtnBuscarProd.BorderColor = System.Drawing.Color.Black;
            this.gBtnBuscarProd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gBtnBuscarProd.FocusedColor = System.Drawing.Color.Empty;
            this.gBtnBuscarProd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gBtnBuscarProd.ForeColor = System.Drawing.Color.White;
            this.gBtnBuscarProd.Image = null;
            this.gBtnBuscarProd.ImageSize = new System.Drawing.Size(28, 28);
            this.gBtnBuscarProd.Location = new System.Drawing.Point(243, 58);
            this.gBtnBuscarProd.Name = "gBtnBuscarProd";
            this.gBtnBuscarProd.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(138)))), ((int)(((byte)(166)))));
            this.gBtnBuscarProd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gBtnBuscarProd.OnHoverForeColor = System.Drawing.Color.White;
            this.gBtnBuscarProd.OnHoverImage = null;
            this.gBtnBuscarProd.OnPressedColor = System.Drawing.Color.Black;
            this.gBtnBuscarProd.Size = new System.Drawing.Size(43, 43);
            this.gBtnBuscarProd.TabIndex = 5;
            // 
            // txtProd
            // 
            this.txtProd.Location = new System.Drawing.Point(313, 70);
            this.txtProd.Name = "txtProd";
            this.txtProd.Size = new System.Drawing.Size(283, 31);
            this.txtProd.TabIndex = 3;
            // 
            // txtCodProd
            // 
            this.txtCodProd.Location = new System.Drawing.Point(11, 67);
            this.txtCodProd.Name = "txtCodProd";
            this.txtCodProd.Size = new System.Drawing.Size(211, 31);
            this.txtCodProd.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(312, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Producto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Cod Producto";
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
            this.gBtnAddtoCar.Location = new System.Drawing.Point(1273, 200);
            this.gBtnAddtoCar.Name = "gBtnAddtoCar";
            this.gBtnAddtoCar.ShadowDecoration.Parent = this.gBtnAddtoCar;
            this.gBtnAddtoCar.Size = new System.Drawing.Size(136, 81);
            this.gBtnAddtoCar.TabIndex = 84;
            this.gBtnAddtoCar.Text = "Agregar";
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
            this.Producto,
            this.Costo,
            this.Precio,
            this.Cantidad,
            this.SubTotal,
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
            // Producto
            // 
            this.Producto.FillWeight = 355.9276F;
            this.Producto.HeaderText = "Producto";
            this.Producto.MinimumWidth = 150;
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // Costo
            // 
            this.Costo.FillWeight = 204.3646F;
            this.Costo.HeaderText = "Costo";
            this.Costo.MinimumWidth = 80;
            this.Costo.Name = "Costo";
            this.Costo.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.FillWeight = 10.32773F;
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 300;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.FillWeight = 31.52491F;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 200;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "Sub Total";
            this.SubTotal.MinimumWidth = 200;
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
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
            this.gBtnAddCompra.Location = new System.Drawing.Point(1273, 576);
            this.gBtnAddCompra.Name = "gBtnAddCompra";
            this.gBtnAddCompra.ShadowDecoration.Parent = this.gBtnAddCompra;
            this.gBtnAddCompra.Size = new System.Drawing.Size(136, 96);
            this.gBtnAddCompra.TabIndex = 86;
            this.gBtnAddCompra.Text = "Agregar";
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
        private System.Windows.Forms.TextBox txtIdPr;
        private Guna.UI.WinForms.GunaCircleButton gBtnBuscarPr;
        private System.Windows.Forms.TextBox txtNombrePr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private Guna.UI.WinForms.GunaNumeric gTxtCantidad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.TextBox txtidProd;
        private Guna.UI.WinForms.GunaCircleButton gBtnBuscarProd;
        private System.Windows.Forms.TextBox txtProd;
        private System.Windows.Forms.TextBox txtCodProd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2GradientTileButton gBtnAddtoCar;
        private Guna.UI2.WinForms.Guna2DataGridView gDgvData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idproducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminar;
        private Guna.UI2.WinForms.Guna2GradientTileButton gBtnAddCompra;
    }
}