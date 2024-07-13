namespace Presentacion
{
    partial class ClientesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientesForm));
            this.tabcliente = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.flpcliente = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbnom = new System.Windows.Forms.Label();
            this.lbtipo = new System.Windows.Forms.Label();
            this.BtnNuevoCliente = new Guna.UI2.WinForms.Guna2Button();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.txtednu = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtnonu = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtcinu = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtninu = new Guna.UI2.WinForms.Guna2TextBox();
            this.BtnCancelarNuevocliente = new Guna.UI2.WinForms.Guna2Button();
            this.BtnGuardarNuevocliente = new Guna.UI2.WinForms.Guna2Button();
            this.tabPage12 = new System.Windows.Forms.TabPage();
            this.txtnied = new Guna.UI2.WinForms.Guna2TextBox();
            this.txteded = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtnoed = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtcied = new Guna.UI2.WinForms.Guna2TextBox();
            this.BtnCancelarEditcliente = new Guna.UI2.WinForms.Guna2Button();
            this.BtnActualizarcliente = new Guna.UI2.WinForms.Guna2Button();
            this.tabcliente.SuspendLayout();
            this.tabPage10.SuspendLayout();
            this.guna2ShadowPanel1.SuspendLayout();
            this.tabPage11.SuspendLayout();
            this.tabPage12.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabcliente
            // 
            this.tabcliente.Controls.Add(this.tabPage10);
            this.tabcliente.Controls.Add(this.tabPage11);
            this.tabcliente.Controls.Add(this.tabPage12);
            this.tabcliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabcliente.ItemSize = new System.Drawing.Size(180, 20);
            this.tabcliente.Location = new System.Drawing.Point(0, 0);
            this.tabcliente.Name = "tabcliente";
            this.tabcliente.SelectedIndex = 0;
            this.tabcliente.Size = new System.Drawing.Size(740, 385);
            this.tabcliente.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tabcliente.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(136)))), ((int)(((byte)(22)))));
            this.tabcliente.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabcliente.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tabcliente.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(4)))), ((int)(((byte)(3)))));
            this.tabcliente.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tabcliente.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(136)))), ((int)(((byte)(22)))));
            this.tabcliente.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabcliente.TabButtonIdleState.ForeColor = System.Drawing.Color.White;
            this.tabcliente.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(136)))), ((int)(((byte)(22)))));
            this.tabcliente.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tabcliente.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(4)))), ((int)(((byte)(3)))));
            this.tabcliente.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabcliente.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tabcliente.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(4)))), ((int)(((byte)(3)))));
            this.tabcliente.TabButtonSize = new System.Drawing.Size(180, 20);
            this.tabcliente.TabIndex = 4;
            this.tabcliente.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(136)))), ((int)(((byte)(22)))));
            this.tabcliente.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tabPage10
            // 
            this.tabPage10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(4)))), ((int)(((byte)(3)))));
            this.tabPage10.Controls.Add(this.flpcliente);
            this.tabPage10.Controls.Add(this.guna2ShadowPanel1);
            this.tabPage10.Controls.Add(this.BtnNuevoCliente);
            this.tabPage10.Location = new System.Drawing.Point(4, 24);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage10.Size = new System.Drawing.Size(732, 357);
            this.tabPage10.TabIndex = 0;
            this.tabPage10.Text = "Lista";
            // 
            // flpcliente
            // 
            this.flpcliente.AutoScroll = true;
            this.flpcliente.Location = new System.Drawing.Point(26, 108);
            this.flpcliente.Name = "flpcliente";
            this.flpcliente.Size = new System.Drawing.Size(420, 192);
            this.flpcliente.TabIndex = 11;
            this.flpcliente.Paint += new System.Windows.Forms.PaintEventHandler(this.flpcliente_Paint);
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.label1);
            this.guna2ShadowPanel1.Controls.Add(this.lbnom);
            this.guna2ShadowPanel1.Controls.Add(this.lbtipo);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(136)))), ((int)(((byte)(22)))));
            this.guna2ShadowPanel1.ForeColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(26, 75);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 2;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.guna2ShadowPanel1.ShadowShift = 0;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(420, 30);
            this.guna2ShadowPanel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(300, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 30);
            this.label1.TabIndex = 17;
            this.label1.Text = "Operaciones";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbnom
            // 
            this.lbnom.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbnom.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnom.ForeColor = System.Drawing.Color.White;
            this.lbnom.Location = new System.Drawing.Point(200, 0);
            this.lbnom.Name = "lbnom";
            this.lbnom.Size = new System.Drawing.Size(100, 30);
            this.lbnom.TabIndex = 12;
            this.lbnom.Text = "Indentificacion";
            this.lbnom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbtipo
            // 
            this.lbtipo.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbtipo.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtipo.ForeColor = System.Drawing.Color.White;
            this.lbtipo.Location = new System.Drawing.Point(0, 0);
            this.lbtipo.Name = "lbtipo";
            this.lbtipo.Size = new System.Drawing.Size(200, 30);
            this.lbtipo.TabIndex = 13;
            this.lbtipo.Text = "Nombre Completo";
            this.lbtipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnNuevoCliente
            // 
            this.BtnNuevoCliente.BorderRadius = 5;
            this.BtnNuevoCliente.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnNuevoCliente.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnNuevoCliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnNuevoCliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnNuevoCliente.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(136)))), ((int)(((byte)(22)))));
            this.BtnNuevoCliente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnNuevoCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnNuevoCliente.Image = ((System.Drawing.Image)(resources.GetObject("BtnNuevoCliente.Image")));
            this.BtnNuevoCliente.Location = new System.Drawing.Point(26, 17);
            this.BtnNuevoCliente.Name = "BtnNuevoCliente";
            this.BtnNuevoCliente.Size = new System.Drawing.Size(90, 30);
            this.BtnNuevoCliente.TabIndex = 3;
            this.BtnNuevoCliente.Text = "Agregar";
            this.BtnNuevoCliente.Click += new System.EventHandler(this.BtnNuevoCliente_Click);
            // 
            // tabPage11
            // 
            this.tabPage11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(4)))), ((int)(((byte)(3)))));
            this.tabPage11.Controls.Add(this.txtednu);
            this.tabPage11.Controls.Add(this.txtnonu);
            this.tabPage11.Controls.Add(this.txtcinu);
            this.tabPage11.Controls.Add(this.txtninu);
            this.tabPage11.Controls.Add(this.BtnCancelarNuevocliente);
            this.tabPage11.Controls.Add(this.BtnGuardarNuevocliente);
            this.tabPage11.Location = new System.Drawing.Point(4, 24);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage11.Size = new System.Drawing.Size(732, 357);
            this.tabPage11.TabIndex = 1;
            this.tabPage11.Text = "Crear";
            // 
            // txtednu
            // 
            this.txtednu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(136)))), ((int)(((byte)(22)))));
            this.txtednu.BorderRadius = 5;
            this.txtednu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtednu.DefaultText = "";
            this.txtednu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtednu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtednu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtednu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtednu.FillColor = System.Drawing.Color.Transparent;
            this.txtednu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(136)))), ((int)(((byte)(22)))));
            this.txtednu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtednu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(136)))), ((int)(((byte)(22)))));
            this.txtednu.Location = new System.Drawing.Point(100, 71);
            this.txtednu.Name = "txtednu";
            this.txtednu.PasswordChar = '\0';
            this.txtednu.PlaceholderText = "Edad";
            this.txtednu.SelectedText = "";
            this.txtednu.Size = new System.Drawing.Size(176, 36);
            this.txtednu.TabIndex = 10;
            this.txtednu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtnonu
            // 
            this.txtnonu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(136)))), ((int)(((byte)(22)))));
            this.txtnonu.BorderRadius = 5;
            this.txtnonu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnonu.DefaultText = "";
            this.txtnonu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtnonu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtnonu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnonu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnonu.FillColor = System.Drawing.Color.Transparent;
            this.txtnonu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(136)))), ((int)(((byte)(22)))));
            this.txtnonu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtnonu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(136)))), ((int)(((byte)(22)))));
            this.txtnonu.Location = new System.Drawing.Point(99, 113);
            this.txtnonu.Name = "txtnonu";
            this.txtnonu.PasswordChar = '\0';
            this.txtnonu.PlaceholderText = "Nombre Completo";
            this.txtnonu.SelectedText = "";
            this.txtnonu.Size = new System.Drawing.Size(176, 36);
            this.txtnonu.TabIndex = 9;
            this.txtnonu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtcinu
            // 
            this.txtcinu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(136)))), ((int)(((byte)(22)))));
            this.txtcinu.BorderRadius = 5;
            this.txtcinu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcinu.DefaultText = "";
            this.txtcinu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtcinu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtcinu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcinu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcinu.FillColor = System.Drawing.Color.Transparent;
            this.txtcinu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(136)))), ((int)(((byte)(22)))));
            this.txtcinu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtcinu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(136)))), ((int)(((byte)(22)))));
            this.txtcinu.Location = new System.Drawing.Point(100, 29);
            this.txtcinu.Name = "txtcinu";
            this.txtcinu.PasswordChar = '\0';
            this.txtcinu.PlaceholderText = "Cedula";
            this.txtcinu.SelectedText = "";
            this.txtcinu.Size = new System.Drawing.Size(176, 36);
            this.txtcinu.TabIndex = 8;
            this.txtcinu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtcinu.TextChanged += new System.EventHandler(this.txtcinu_TextChanged);
            // 
            // txtninu
            // 
            this.txtninu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(136)))), ((int)(((byte)(22)))));
            this.txtninu.BorderRadius = 5;
            this.txtninu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtninu.DefaultText = "";
            this.txtninu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtninu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtninu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtninu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtninu.FillColor = System.Drawing.Color.Transparent;
            this.txtninu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(136)))), ((int)(((byte)(22)))));
            this.txtninu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtninu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(136)))), ((int)(((byte)(22)))));
            this.txtninu.Location = new System.Drawing.Point(99, 155);
            this.txtninu.Name = "txtninu";
            this.txtninu.PasswordChar = '\0';
            this.txtninu.PlaceholderText = "NIT";
            this.txtninu.SelectedText = "";
            this.txtninu.Size = new System.Drawing.Size(176, 36);
            this.txtninu.TabIndex = 6;
            this.txtninu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnCancelarNuevocliente
            // 
            this.BtnCancelarNuevocliente.BorderRadius = 5;
            this.BtnCancelarNuevocliente.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnCancelarNuevocliente.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnCancelarNuevocliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnCancelarNuevocliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnCancelarNuevocliente.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(136)))), ((int)(((byte)(124)))));
            this.BtnCancelarNuevocliente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnCancelarNuevocliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnCancelarNuevocliente.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancelarNuevocliente.Image")));
            this.BtnCancelarNuevocliente.Location = new System.Drawing.Point(190, 223);
            this.BtnCancelarNuevocliente.Name = "BtnCancelarNuevocliente";
            this.BtnCancelarNuevocliente.Size = new System.Drawing.Size(90, 30);
            this.BtnCancelarNuevocliente.TabIndex = 5;
            this.BtnCancelarNuevocliente.Text = "Cancelar";
            this.BtnCancelarNuevocliente.Click += new System.EventHandler(this.BtnCancelarNuevocliente_Click);
            // 
            // BtnGuardarNuevocliente
            // 
            this.BtnGuardarNuevocliente.BorderRadius = 5;
            this.BtnGuardarNuevocliente.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnGuardarNuevocliente.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnGuardarNuevocliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnGuardarNuevocliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnGuardarNuevocliente.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(136)))), ((int)(((byte)(22)))));
            this.BtnGuardarNuevocliente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnGuardarNuevocliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnGuardarNuevocliente.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuardarNuevocliente.Image")));
            this.BtnGuardarNuevocliente.Location = new System.Drawing.Point(94, 223);
            this.BtnGuardarNuevocliente.Name = "BtnGuardarNuevocliente";
            this.BtnGuardarNuevocliente.Size = new System.Drawing.Size(90, 30);
            this.BtnGuardarNuevocliente.TabIndex = 4;
            this.BtnGuardarNuevocliente.Text = "Guardar";
            this.BtnGuardarNuevocliente.Click += new System.EventHandler(this.BtnGuardarNuevocliente_Click);
            // 
            // tabPage12
            // 
            this.tabPage12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(4)))), ((int)(((byte)(3)))));
            this.tabPage12.Controls.Add(this.txtnied);
            this.tabPage12.Controls.Add(this.txteded);
            this.tabPage12.Controls.Add(this.txtnoed);
            this.tabPage12.Controls.Add(this.txtcied);
            this.tabPage12.Controls.Add(this.BtnCancelarEditcliente);
            this.tabPage12.Controls.Add(this.BtnActualizarcliente);
            this.tabPage12.Location = new System.Drawing.Point(4, 24);
            this.tabPage12.Name = "tabPage12";
            this.tabPage12.Size = new System.Drawing.Size(732, 357);
            this.tabPage12.TabIndex = 2;
            this.tabPage12.Text = "Actualizar";
            // 
            // txtnied
            // 
            this.txtnied.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(136)))), ((int)(((byte)(22)))));
            this.txtnied.BorderRadius = 5;
            this.txtnied.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnied.DefaultText = "";
            this.txtnied.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtnied.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtnied.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnied.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnied.FillColor = System.Drawing.Color.Transparent;
            this.txtnied.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(136)))), ((int)(((byte)(22)))));
            this.txtnied.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtnied.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(136)))), ((int)(((byte)(22)))));
            this.txtnied.Location = new System.Drawing.Point(108, 155);
            this.txtnied.Name = "txtnied";
            this.txtnied.PasswordChar = '\0';
            this.txtnied.PlaceholderText = "NIT";
            this.txtnied.SelectedText = "";
            this.txtnied.Size = new System.Drawing.Size(176, 36);
            this.txtnied.TabIndex = 19;
            this.txtnied.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txteded
            // 
            this.txteded.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(136)))), ((int)(((byte)(22)))));
            this.txteded.BorderRadius = 10;
            this.txteded.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txteded.DefaultText = "";
            this.txteded.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txteded.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txteded.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txteded.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txteded.FillColor = System.Drawing.Color.Transparent;
            this.txteded.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(136)))), ((int)(((byte)(22)))));
            this.txteded.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txteded.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(136)))), ((int)(((byte)(22)))));
            this.txteded.Location = new System.Drawing.Point(108, 71);
            this.txteded.Name = "txteded";
            this.txteded.PasswordChar = '\0';
            this.txteded.PlaceholderText = "Edad";
            this.txteded.SelectedText = "";
            this.txteded.Size = new System.Drawing.Size(176, 36);
            this.txteded.TabIndex = 17;
            this.txteded.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtnoed
            // 
            this.txtnoed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(136)))), ((int)(((byte)(22)))));
            this.txtnoed.BorderRadius = 10;
            this.txtnoed.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnoed.DefaultText = "";
            this.txtnoed.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtnoed.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtnoed.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnoed.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnoed.FillColor = System.Drawing.Color.Transparent;
            this.txtnoed.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(136)))), ((int)(((byte)(22)))));
            this.txtnoed.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtnoed.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(136)))), ((int)(((byte)(22)))));
            this.txtnoed.Location = new System.Drawing.Point(108, 113);
            this.txtnoed.Name = "txtnoed";
            this.txtnoed.PasswordChar = '\0';
            this.txtnoed.PlaceholderText = "Nombre Completo";
            this.txtnoed.SelectedText = "";
            this.txtnoed.Size = new System.Drawing.Size(176, 36);
            this.txtnoed.TabIndex = 16;
            this.txtnoed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtcied
            // 
            this.txtcied.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(136)))), ((int)(((byte)(22)))));
            this.txtcied.BorderRadius = 10;
            this.txtcied.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcied.DefaultText = "";
            this.txtcied.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtcied.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtcied.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcied.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcied.FillColor = System.Drawing.Color.Transparent;
            this.txtcied.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(136)))), ((int)(((byte)(22)))));
            this.txtcied.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtcied.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(136)))), ((int)(((byte)(22)))));
            this.txtcied.Location = new System.Drawing.Point(108, 29);
            this.txtcied.Name = "txtcied";
            this.txtcied.PasswordChar = '\0';
            this.txtcied.PlaceholderText = "Cedula";
            this.txtcied.SelectedText = "";
            this.txtcied.Size = new System.Drawing.Size(176, 36);
            this.txtcied.TabIndex = 15;
            this.txtcied.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnCancelarEditcliente
            // 
            this.BtnCancelarEditcliente.BorderRadius = 5;
            this.BtnCancelarEditcliente.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnCancelarEditcliente.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnCancelarEditcliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnCancelarEditcliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnCancelarEditcliente.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(136)))), ((int)(((byte)(124)))));
            this.BtnCancelarEditcliente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnCancelarEditcliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnCancelarEditcliente.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancelarEditcliente.Image")));
            this.BtnCancelarEditcliente.Location = new System.Drawing.Point(199, 215);
            this.BtnCancelarEditcliente.Name = "BtnCancelarEditcliente";
            this.BtnCancelarEditcliente.Size = new System.Drawing.Size(90, 30);
            this.BtnCancelarEditcliente.TabIndex = 12;
            this.BtnCancelarEditcliente.Text = "Cancelar";
            // 
            // BtnActualizarcliente
            // 
            this.BtnActualizarcliente.BorderRadius = 5;
            this.BtnActualizarcliente.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnActualizarcliente.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnActualizarcliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnActualizarcliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnActualizarcliente.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(136)))), ((int)(((byte)(22)))));
            this.BtnActualizarcliente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnActualizarcliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnActualizarcliente.Image = ((System.Drawing.Image)(resources.GetObject("BtnActualizarcliente.Image")));
            this.BtnActualizarcliente.Location = new System.Drawing.Point(103, 215);
            this.BtnActualizarcliente.Name = "BtnActualizarcliente";
            this.BtnActualizarcliente.Size = new System.Drawing.Size(90, 30);
            this.BtnActualizarcliente.TabIndex = 11;
            this.BtnActualizarcliente.Text = "Actualizar";
            this.BtnActualizarcliente.Click += new System.EventHandler(this.BtnActualizarcliente_Click);
            // 
            // ClientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 385);
            this.Controls.Add(this.tabcliente);
            this.Name = "ClientesForm";
            this.Text = "ClientesForm";
            this.Load += new System.EventHandler(this.ClientesForm_Load);
            this.tabcliente.ResumeLayout(false);
            this.tabPage10.ResumeLayout(false);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.tabPage11.ResumeLayout(false);
            this.tabPage12.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl tabcliente;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.FlowLayoutPanel flpcliente;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lbnom;
        public System.Windows.Forms.Label lbtipo;
        private Guna.UI2.WinForms.Guna2Button BtnNuevoCliente;
        private System.Windows.Forms.TabPage tabPage11;
        private Guna.UI2.WinForms.Guna2TextBox txtednu;
        private Guna.UI2.WinForms.Guna2TextBox txtnonu;
        private Guna.UI2.WinForms.Guna2TextBox txtcinu;
        private Guna.UI2.WinForms.Guna2TextBox txtninu;
        private Guna.UI2.WinForms.Guna2Button BtnCancelarNuevocliente;
        private Guna.UI2.WinForms.Guna2Button BtnGuardarNuevocliente;
        private System.Windows.Forms.TabPage tabPage12;
        private Guna.UI2.WinForms.Guna2TextBox txtnied;
        private Guna.UI2.WinForms.Guna2TextBox txteded;
        private Guna.UI2.WinForms.Guna2TextBox txtnoed;
        private Guna.UI2.WinForms.Guna2TextBox txtcied;
        private Guna.UI2.WinForms.Guna2Button BtnCancelarEditcliente;
        private Guna.UI2.WinForms.Guna2Button BtnActualizarcliente;
    }
}