namespace Presentacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PicLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.txtuser = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtpass = new Guna.UI2.WinForms.Guna2TextBox();
            this.BtnIniciaSesion = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // PicLogo
            // 
            this.PicLogo.Image = ((System.Drawing.Image)(resources.GetObject("PicLogo.Image")));
            this.PicLogo.ImageRotate = 0F;
            this.PicLogo.Location = new System.Drawing.Point(0, 34);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(200, 205);
            this.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicLogo.TabIndex = 0;
            this.PicLogo.TabStop = false;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(136)))), ((int)(((byte)(22)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.WhiteSmoke;
            this.guna2ControlBox1.Location = new System.Drawing.Point(170, -1);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(30, 29);
            this.guna2ControlBox1.TabIndex = 1;
            // 
            // txtuser
            // 
            this.txtuser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(136)))), ((int)(((byte)(22)))));
            this.txtuser.BorderRadius = 10;
            this.txtuser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtuser.DefaultText = "";
            this.txtuser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtuser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtuser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtuser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtuser.FillColor = System.Drawing.Color.Transparent;
            this.txtuser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(136)))), ((int)(((byte)(22)))));
            this.txtuser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtuser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(136)))), ((int)(((byte)(22)))));
            this.txtuser.Location = new System.Drawing.Point(12, 245);
            this.txtuser.Name = "txtuser";
            this.txtuser.PasswordChar = '\0';
            this.txtuser.PlaceholderText = "Usuario";
            this.txtuser.SelectedText = "";
            this.txtuser.Size = new System.Drawing.Size(176, 36);
            this.txtuser.TabIndex = 2;
            this.txtuser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtpass
            // 
            this.txtpass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(136)))), ((int)(((byte)(22)))));
            this.txtpass.BorderRadius = 10;
            this.txtpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpass.DefaultText = "";
            this.txtpass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtpass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtpass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpass.FillColor = System.Drawing.Color.Transparent;
            this.txtpass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(136)))), ((int)(((byte)(22)))));
            this.txtpass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtpass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(136)))), ((int)(((byte)(22)))));
            this.txtpass.Location = new System.Drawing.Point(12, 287);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '●';
            this.txtpass.PlaceholderText = "Contraseña";
            this.txtpass.SelectedText = "";
            this.txtpass.Size = new System.Drawing.Size(176, 36);
            this.txtpass.TabIndex = 3;
            this.txtpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtpass.UseSystemPasswordChar = true;
            // 
            // BtnIniciaSesion
            // 
            this.BtnIniciaSesion.BorderRadius = 10;
            this.BtnIniciaSesion.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnIniciaSesion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnIniciaSesion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnIniciaSesion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnIniciaSesion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(136)))), ((int)(((byte)(22)))));
            this.BtnIniciaSesion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIniciaSesion.ForeColor = System.Drawing.Color.White;
            this.BtnIniciaSesion.Location = new System.Drawing.Point(12, 355);
            this.BtnIniciaSesion.Name = "BtnIniciaSesion";
            this.BtnIniciaSesion.Size = new System.Drawing.Size(180, 33);
            this.BtnIniciaSesion.TabIndex = 4;
            this.BtnIniciaSesion.Text = "Iniciar Sesion";
            this.BtnIniciaSesion.Click += new System.EventHandler(this.BtnIniciaSesion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(4)))), ((int)(((byte)(3)))));
            this.ClientSize = new System.Drawing.Size(200, 400);
            this.Controls.Add(this.BtnIniciaSesion);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.PicLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox PicLogo;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtuser;
        private Guna.UI2.WinForms.Guna2TextBox txtpass;
        private Guna.UI2.WinForms.Guna2Button BtnIniciaSesion;
    }
}

