namespace CapaPresentacion
{
    partial class Devoluciones
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
            this.pContainer = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.gBtnListDev = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SuspendLayout();
            // 
            // pContainer
            // 
            this.pContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.pContainer.Location = new System.Drawing.Point(92, 73);
            this.pContainer.Name = "pContainer";
            this.pContainer.Size = new System.Drawing.Size(1444, 807);
            this.pContainer.TabIndex = 89;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 45);
            this.label1.TabIndex = 88;
            this.label1.Text = "Devoluciones";
            // 
            // gBtnListDev
            // 
            this.gBtnListDev.BorderRadius = 5;
            this.gBtnListDev.CheckedState.Parent = this.gBtnListDev;
            this.gBtnListDev.CustomImages.Parent = this.gBtnListDev;
            this.gBtnListDev.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.gBtnListDev.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.gBtnListDev.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBtnListDev.ForeColor = System.Drawing.Color.LightGray;
            this.gBtnListDev.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(36)))));
            this.gBtnListDev.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(36)))));
            this.gBtnListDev.HoverState.Parent = this.gBtnListDev;
            this.gBtnListDev.Image = global::CapaPresentacion.Properties.Resources.lista_40;
            this.gBtnListDev.ImageSize = new System.Drawing.Size(35, 35);
            this.gBtnListDev.Location = new System.Drawing.Point(18, 808);
            this.gBtnListDev.Name = "gBtnListDev";
            this.gBtnListDev.ShadowDecoration.Parent = this.gBtnListDev;
            this.gBtnListDev.Size = new System.Drawing.Size(75, 74);
            this.gBtnListDev.TabIndex = 90;
            this.gBtnListDev.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gBtnListDev.Click += new System.EventHandler(this.guna2GradientButton4_Click);
            // 
            // Devoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1554, 900);
            this.Controls.Add(this.pContainer);
            this.Controls.Add(this.gBtnListDev);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Devoluciones";
            this.Text = "Devoluciones";
            this.Load += new System.EventHandler(this.Devoluciones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pContainer;
        private Guna.UI2.WinForms.Guna2GradientButton gBtnListDev;
        private System.Windows.Forms.Label label1;
    }
}