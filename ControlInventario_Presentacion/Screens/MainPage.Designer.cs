namespace ControlInventario_Presentacion.Screens
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            panelMenu = new Panel();
            btnSettings = new FontAwesome.Sharp.IconButton();
            btnInformes = new FontAwesome.Sharp.IconButton();
            btnVentas = new FontAwesome.Sharp.IconButton();
            btnProveedores = new FontAwesome.Sharp.IconButton();
            btnProductos = new FontAwesome.Sharp.IconButton();
            btnPedidos = new FontAwesome.Sharp.IconButton();
            btnDashboard = new FontAwesome.Sharp.IconButton();
            panelLogo = new Panel();
            btnHome = new PictureBox();
            iconCurrentChild = new FontAwesome.Sharp.IconPictureBox();
            panelTitle = new Panel();
            lblTitleChild = new Label();
            iconCurrentChildFrm = new FontAwesome.Sharp.IconPictureBox();
            panelShadow = new Panel();
            panelDesktop = new Panel();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChild).BeginInit();
            panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildFrm).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(37, 36, 81);
            panelMenu.Controls.Add(btnSettings);
            panelMenu.Controls.Add(btnInformes);
            panelMenu.Controls.Add(btnVentas);
            panelMenu.Controls.Add(btnProveedores);
            panelMenu.Controls.Add(btnProductos);
            panelMenu.Controls.Add(btnPedidos);
            panelMenu.Controls.Add(btnDashboard);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(250, 786);
            panelMenu.TabIndex = 0;
            // 
            // btnSettings
            // 
            btnSettings.Dock = DockStyle.Top;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.ForeColor = Color.Gainsboro;
            btnSettings.IconChar = FontAwesome.Sharp.IconChar.Sliders;
            btnSettings.IconColor = Color.Gainsboro;
            btnSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSettings.IconSize = 68;
            btnSettings.ImageAlign = ContentAlignment.MiddleLeft;
            btnSettings.Location = new Point(0, 500);
            btnSettings.Name = "btnSettings";
            btnSettings.Padding = new Padding(10, 0, 20, 0);
            btnSettings.Size = new Size(250, 60);
            btnSettings.TabIndex = 7;
            btnSettings.Text = "Settings";
            btnSettings.TextAlign = ContentAlignment.MiddleLeft;
            btnSettings.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += iconButton7_Click;
            // 
            // btnInformes
            // 
            btnInformes.Dock = DockStyle.Top;
            btnInformes.FlatAppearance.BorderSize = 0;
            btnInformes.FlatStyle = FlatStyle.Flat;
            btnInformes.ForeColor = Color.Gainsboro;
            btnInformes.IconChar = FontAwesome.Sharp.IconChar.TabletAndroid;
            btnInformes.IconColor = Color.Gainsboro;
            btnInformes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnInformes.IconSize = 68;
            btnInformes.ImageAlign = ContentAlignment.MiddleLeft;
            btnInformes.Location = new Point(0, 440);
            btnInformes.Name = "btnInformes";
            btnInformes.Padding = new Padding(10, 0, 20, 0);
            btnInformes.Size = new Size(250, 60);
            btnInformes.TabIndex = 6;
            btnInformes.Text = "Informes";
            btnInformes.TextAlign = ContentAlignment.MiddleLeft;
            btnInformes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInformes.UseVisualStyleBackColor = true;
            btnInformes.Click += iconButton6_Click;
            // 
            // btnVentas
            // 
            btnVentas.Dock = DockStyle.Top;
            btnVentas.FlatAppearance.BorderSize = 0;
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.ForeColor = Color.Gainsboro;
            btnVentas.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            btnVentas.IconColor = Color.Gainsboro;
            btnVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnVentas.IconSize = 68;
            btnVentas.ImageAlign = ContentAlignment.MiddleLeft;
            btnVentas.Location = new Point(0, 380);
            btnVentas.Name = "btnVentas";
            btnVentas.Padding = new Padding(10, 0, 20, 0);
            btnVentas.Size = new Size(250, 60);
            btnVentas.TabIndex = 5;
            btnVentas.Text = "Ventas";
            btnVentas.TextAlign = ContentAlignment.MiddleLeft;
            btnVentas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += iconButton5_Click;
            // 
            // btnProveedores
            // 
            btnProveedores.Dock = DockStyle.Top;
            btnProveedores.FlatAppearance.BorderSize = 0;
            btnProveedores.FlatStyle = FlatStyle.Flat;
            btnProveedores.ForeColor = Color.Gainsboro;
            btnProveedores.IconChar = FontAwesome.Sharp.IconChar.TruckFront;
            btnProveedores.IconColor = Color.Gainsboro;
            btnProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnProveedores.IconSize = 68;
            btnProveedores.ImageAlign = ContentAlignment.MiddleLeft;
            btnProveedores.Location = new Point(0, 320);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Padding = new Padding(10, 0, 20, 0);
            btnProveedores.Size = new Size(250, 60);
            btnProveedores.TabIndex = 4;
            btnProveedores.Text = "Proveedores";
            btnProveedores.TextAlign = ContentAlignment.MiddleLeft;
            btnProveedores.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProveedores.UseVisualStyleBackColor = true;
            btnProveedores.Click += iconButton4_Click;
            // 
            // btnProductos
            // 
            btnProductos.Dock = DockStyle.Top;
            btnProductos.FlatAppearance.BorderSize = 0;
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.ForeColor = Color.Gainsboro;
            btnProductos.IconChar = FontAwesome.Sharp.IconChar.ProductHunt;
            btnProductos.IconColor = Color.Gainsboro;
            btnProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnProductos.IconSize = 68;
            btnProductos.ImageAlign = ContentAlignment.MiddleLeft;
            btnProductos.Location = new Point(0, 260);
            btnProductos.Name = "btnProductos";
            btnProductos.Padding = new Padding(10, 0, 20, 0);
            btnProductos.Size = new Size(250, 60);
            btnProductos.TabIndex = 3;
            btnProductos.Text = "Productos";
            btnProductos.TextAlign = ContentAlignment.MiddleLeft;
            btnProductos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += iconButton3_Click;
            // 
            // btnPedidos
            // 
            btnPedidos.Dock = DockStyle.Top;
            btnPedidos.FlatAppearance.BorderSize = 0;
            btnPedidos.FlatStyle = FlatStyle.Flat;
            btnPedidos.ForeColor = Color.Gainsboro;
            btnPedidos.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            btnPedidos.IconColor = Color.Gainsboro;
            btnPedidos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPedidos.IconSize = 68;
            btnPedidos.ImageAlign = ContentAlignment.MiddleLeft;
            btnPedidos.Location = new Point(0, 200);
            btnPedidos.Name = "btnPedidos";
            btnPedidos.Padding = new Padding(10, 0, 20, 0);
            btnPedidos.Size = new Size(250, 60);
            btnPedidos.TabIndex = 2;
            btnPedidos.Text = "Pedidos";
            btnPedidos.TextAlign = ContentAlignment.MiddleLeft;
            btnPedidos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPedidos.UseVisualStyleBackColor = true;
            btnPedidos.Click += iconButton2_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.ForeColor = Color.Gainsboro;
            btnDashboard.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            btnDashboard.IconColor = Color.Gainsboro;
            btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDashboard.IconSize = 68;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(0, 140);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(10, 0, 20, 0);
            btnDashboard.Size = new Size(250, 60);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += iconButton1_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(btnHome);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Padding = new Padding(10, 0, 0, 0);
            panelLogo.Size = new Size(250, 140);
            panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.Location = new Point(51, 9);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(129, 122);
            btnHome.SizeMode = PictureBoxSizeMode.Zoom;
            btnHome.TabIndex = 0;
            btnHome.TabStop = false;
            btnHome.Click += btnHome_Click;
            // 
            // iconCurrentChild
            // 
            iconCurrentChild.BackColor = SystemColors.Control;
            iconCurrentChild.Dock = DockStyle.Fill;
            iconCurrentChild.ForeColor = SystemColors.ControlText;
            iconCurrentChild.IconChar = FontAwesome.Sharp.IconChar.None;
            iconCurrentChild.IconColor = SystemColors.ControlText;
            iconCurrentChild.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCurrentChild.IconSize = 786;
            iconCurrentChild.Location = new Point(250, 0);
            iconCurrentChild.Name = "iconCurrentChild";
            iconCurrentChild.Size = new Size(1347, 786);
            iconCurrentChild.SizeMode = PictureBoxSizeMode.Zoom;
            iconCurrentChild.TabIndex = 0;
            iconCurrentChild.TabStop = false;
            // 
            // panelTitle
            // 
            panelTitle.BackColor = Color.FromArgb(37, 36, 81);
            panelTitle.Controls.Add(lblTitleChild);
            panelTitle.Controls.Add(iconCurrentChildFrm);
            panelTitle.Dock = DockStyle.Top;
            panelTitle.Location = new Point(250, 0);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(1347, 77);
            panelTitle.TabIndex = 1;
            panelTitle.MouseDown += panelTitle_MouseDown;
            // 
            // lblTitleChild
            // 
            lblTitleChild.AutoSize = true;
            lblTitleChild.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitleChild.ForeColor = Color.Gainsboro;
            lblTitleChild.Location = new Point(79, 28);
            lblTitleChild.Name = "lblTitleChild";
            lblTitleChild.Size = new Size(68, 27);
            lblTitleChild.TabIndex = 1;
            lblTitleChild.Text = "Home";
            // 
            // iconCurrentChildFrm
            // 
            iconCurrentChildFrm.BackColor = Color.FromArgb(37, 36, 81);
            iconCurrentChildFrm.ForeColor = Color.Gainsboro;
            iconCurrentChildFrm.IconChar = FontAwesome.Sharp.IconChar.House;
            iconCurrentChildFrm.IconColor = Color.Gainsboro;
            iconCurrentChildFrm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCurrentChildFrm.IconSize = 40;
            iconCurrentChildFrm.Location = new Point(12, 19);
            iconCurrentChildFrm.Name = "iconCurrentChildFrm";
            iconCurrentChildFrm.Size = new Size(40, 40);
            iconCurrentChildFrm.TabIndex = 0;
            iconCurrentChildFrm.TabStop = false;
            // 
            // panelShadow
            // 
            panelShadow.BackColor = Color.FromArgb(37, 36, 81);
            panelShadow.Dock = DockStyle.Top;
            panelShadow.Location = new Point(250, 77);
            panelShadow.Name = "panelShadow";
            panelShadow.Size = new Size(1347, 9);
            panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            panelDesktop.BackColor = Color.DarkSlateBlue;
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(250, 86);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(1347, 700);
            panelDesktop.TabIndex = 3;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1597, 786);
            Controls.Add(panelDesktop);
            Controls.Add(panelShadow);
            Controls.Add(panelTitle);
            Controls.Add(iconCurrentChild);
            Controls.Add(panelMenu);
            Name = "MainPage";
            Text = "MainPage";
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChild).EndInit();
            panelTitle.ResumeLayout(false);
            panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildFrm).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnSettings;
        private FontAwesome.Sharp.IconButton btnInformes;
        private FontAwesome.Sharp.IconButton btnVentas;
        private FontAwesome.Sharp.IconButton btnProveedores;
        private FontAwesome.Sharp.IconButton btnProductos;
        private FontAwesome.Sharp.IconButton btnPedidos;
        private PictureBox btnHome;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChild;
        private Panel panelTitle;
        private Label lblTitleChild;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildFrm;
        private Panel panelShadow;
        private Panel panelDesktop;
    }
}