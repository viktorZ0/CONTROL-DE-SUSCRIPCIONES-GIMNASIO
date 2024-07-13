namespace Presentacion
{
    partial class ListaUsuarios
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaUsuarios));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbrol = new System.Windows.Forms.Label();
            this.BtnEditar = new Guna.UI2.WinForms.Guna2Button();
            this.BtnEliminar = new Guna.UI2.WinForms.Guna2Button();
            this.lbuse = new System.Windows.Forms.Label();
            this.lbnom = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(4)))), ((int)(((byte)(3)))));
            this.panel1.Controls.Add(this.lbrol);
            this.panel1.Controls.Add(this.BtnEditar);
            this.panel1.Controls.Add(this.BtnEliminar);
            this.panel1.Controls.Add(this.lbuse);
            this.panel1.Controls.Add(this.lbnom);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(510, 25);
            this.panel1.TabIndex = 2;
            // 
            // lbrol
            // 
            this.lbrol.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbrol.ForeColor = System.Drawing.Color.DarkGray;
            this.lbrol.Location = new System.Drawing.Point(300, 0);
            this.lbrol.MaximumSize = new System.Drawing.Size(200, 50);
            this.lbrol.Name = "lbrol";
            this.lbrol.Size = new System.Drawing.Size(100, 25);
            this.lbrol.TabIndex = 15;
            this.lbrol.Text = "Rol";
            this.lbrol.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnEditar
            // 
            this.BtnEditar.BorderRadius = 5;
            this.BtnEditar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnEditar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnEditar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnEditar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnEditar.FillColor = System.Drawing.Color.Transparent;
            this.BtnEditar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnEditar.ForeColor = System.Drawing.Color.White;
            this.BtnEditar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(136)))), ((int)(((byte)(22)))));
            this.BtnEditar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEditar.Image")));
            this.BtnEditar.Location = new System.Drawing.Point(406, 0);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(35, 25);
            this.BtnEditar.TabIndex = 14;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BorderRadius = 5;
            this.BtnEliminar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnEliminar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnEliminar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnEliminar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnEliminar.FillColor = System.Drawing.Color.Transparent;
            this.BtnEliminar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(136)))), ((int)(((byte)(124)))));
            this.BtnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEliminar.Image")));
            this.BtnEliminar.ImageSize = new System.Drawing.Size(15, 20);
            this.BtnEliminar.Location = new System.Drawing.Point(447, 0);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(30, 25);
            this.BtnEliminar.TabIndex = 13;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // lbuse
            // 
            this.lbuse.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbuse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbuse.ForeColor = System.Drawing.Color.DarkGray;
            this.lbuse.Location = new System.Drawing.Point(200, 0);
            this.lbuse.MaximumSize = new System.Drawing.Size(200, 50);
            this.lbuse.Name = "lbuse";
            this.lbuse.Size = new System.Drawing.Size(100, 25);
            this.lbuse.TabIndex = 12;
            this.lbuse.Text = "Usuario";
            this.lbuse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbnom
            // 
            this.lbnom.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbnom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnom.ForeColor = System.Drawing.Color.DarkGray;
            this.lbnom.Location = new System.Drawing.Point(0, 0);
            this.lbnom.MaximumSize = new System.Drawing.Size(200, 50);
            this.lbnom.Name = "lbnom";
            this.lbnom.Size = new System.Drawing.Size(200, 25);
            this.lbnom.TabIndex = 11;
            this.lbnom.Text = "Nombre Real";
            this.lbnom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ListaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ListaUsuarios";
            this.Size = new System.Drawing.Size(510, 25);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbrol;
        public Guna.UI2.WinForms.Guna2Button BtnEditar;
        public Guna.UI2.WinForms.Guna2Button BtnEliminar;
        private System.Windows.Forms.Label lbuse;
        private System.Windows.Forms.Label lbnom;
    }
}
