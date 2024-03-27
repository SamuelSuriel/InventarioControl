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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            panelMenu = new Panel();
            iconBtbCerrarSesion = new FontAwesome.Sharp.IconButton();
            btnStocks = new FontAwesome.Sharp.IconButton();
            btnSettings = new FontAwesome.Sharp.IconButton();
            btnInformes = new FontAwesome.Sharp.IconButton();
            btnVentas = new FontAwesome.Sharp.IconButton();
            btnProveedores = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            btnProductos = new FontAwesome.Sharp.IconButton();
            btnPedidos = new FontAwesome.Sharp.IconButton();
            btnDashboard = new FontAwesome.Sharp.IconButton();
            panelLogo = new Panel();
            btnHome = new PictureBox();
            iconCurrentChild = new FontAwesome.Sharp.IconPictureBox();
            panelTitle = new Panel();
            iconMaxim = new FontAwesome.Sharp.IconPictureBox();
            lblMinimizeApp = new Label();
            lblCerrarApp = new Label();
            lblTitleChild = new Label();
            iconCurrentChildFrm = new FontAwesome.Sharp.IconPictureBox();
            panelShadow = new Panel();
            panelDesktop = new Panel();
            lblTipoPerfil = new Label();
            lblUltimaConexion = new Label();
            lblNombre = new Label();
            lblFechaActual = new Label();
            lblHoraActual = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            lblTitleDashboard = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChild).BeginInit();
            panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconMaxim).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildFrm).BeginInit();
            panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(37, 36, 81);
            panelMenu.Controls.Add(iconBtbCerrarSesion);
            panelMenu.Controls.Add(btnStocks);
            panelMenu.Controls.Add(btnSettings);
            panelMenu.Controls.Add(btnInformes);
            panelMenu.Controls.Add(btnVentas);
            panelMenu.Controls.Add(btnProveedores);
            panelMenu.Controls.Add(label1);
            panelMenu.Controls.Add(btnProductos);
            panelMenu.Controls.Add(btnPedidos);
            panelMenu.Controls.Add(btnDashboard);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(3, 2, 3, 2);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(219, 590);
            panelMenu.TabIndex = 0;
            // 
            // iconBtbCerrarSesion
            // 
            iconBtbCerrarSesion.BackColor = Color.FromArgb(37, 36, 81);
            iconBtbCerrarSesion.Cursor = Cursors.Hand;
            iconBtbCerrarSesion.FlatStyle = FlatStyle.Popup;
            iconBtbCerrarSesion.ForeColor = SystemColors.Desktop;
            iconBtbCerrarSesion.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            iconBtbCerrarSesion.IconColor = Color.Gainsboro;
            iconBtbCerrarSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtbCerrarSesion.IconSize = 28;
            iconBtbCerrarSesion.Location = new Point(19, 542);
            iconBtbCerrarSesion.Margin = new Padding(3, 2, 3, 2);
            iconBtbCerrarSesion.Name = "iconBtbCerrarSesion";
            iconBtbCerrarSesion.Size = new Size(45, 34);
            iconBtbCerrarSesion.TabIndex = 5;
            iconBtbCerrarSesion.UseVisualStyleBackColor = false;
            iconBtbCerrarSesion.Click += iconBtbCerrarSesion_Click;
            // 
            // btnStocks
            // 
            btnStocks.Cursor = Cursors.Hand;
            btnStocks.Dock = DockStyle.Top;
            btnStocks.FlatAppearance.BorderSize = 0;
            btnStocks.FlatStyle = FlatStyle.Flat;
            btnStocks.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnStocks.ForeColor = Color.Gainsboro;
            btnStocks.IconChar = FontAwesome.Sharp.IconChar.CubesStacked;
            btnStocks.IconColor = Color.Gainsboro;
            btnStocks.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnStocks.IconSize = 58;
            btnStocks.ImageAlign = ContentAlignment.MiddleLeft;
            btnStocks.Location = new Point(0, 433);
            btnStocks.Margin = new Padding(3, 2, 3, 2);
            btnStocks.Name = "btnStocks";
            btnStocks.Padding = new Padding(9, 0, 18, 0);
            btnStocks.Size = new Size(219, 50);
            btnStocks.TabIndex = 9;
            btnStocks.Text = "Stocks";
            btnStocks.TextAlign = ContentAlignment.MiddleLeft;
            btnStocks.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnStocks.UseVisualStyleBackColor = true;
            btnStocks.Click += btnStocks_Click;
            // 
            // btnSettings
            // 
            btnSettings.Dock = DockStyle.Top;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSettings.ForeColor = Color.Gainsboro;
            btnSettings.IconChar = FontAwesome.Sharp.IconChar.Sliders;
            btnSettings.IconColor = Color.Gainsboro;
            btnSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSettings.IconSize = 58;
            btnSettings.ImageAlign = ContentAlignment.MiddleLeft;
            btnSettings.Location = new Point(0, 383);
            btnSettings.Margin = new Padding(3, 2, 3, 2);
            btnSettings.Name = "btnSettings";
            btnSettings.Padding = new Padding(9, 0, 18, 0);
            btnSettings.Size = new Size(219, 50);
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
            btnInformes.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInformes.ForeColor = Color.Gainsboro;
            btnInformes.IconChar = FontAwesome.Sharp.IconChar.TabletAndroid;
            btnInformes.IconColor = Color.Gainsboro;
            btnInformes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnInformes.IconSize = 58;
            btnInformes.ImageAlign = ContentAlignment.MiddleLeft;
            btnInformes.Location = new Point(0, 333);
            btnInformes.Margin = new Padding(3, 2, 3, 2);
            btnInformes.Name = "btnInformes";
            btnInformes.Padding = new Padding(9, 0, 18, 0);
            btnInformes.Size = new Size(219, 50);
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
            btnVentas.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVentas.ForeColor = Color.Gainsboro;
            btnVentas.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            btnVentas.IconColor = Color.Gainsboro;
            btnVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnVentas.IconSize = 58;
            btnVentas.ImageAlign = ContentAlignment.MiddleLeft;
            btnVentas.Location = new Point(0, 283);
            btnVentas.Margin = new Padding(3, 2, 3, 2);
            btnVentas.Name = "btnVentas";
            btnVentas.Padding = new Padding(9, 0, 18, 0);
            btnVentas.Size = new Size(219, 50);
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
            btnProveedores.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnProveedores.ForeColor = Color.Gainsboro;
            btnProveedores.IconChar = FontAwesome.Sharp.IconChar.TruckFront;
            btnProveedores.IconColor = Color.Gainsboro;
            btnProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnProveedores.IconSize = 58;
            btnProveedores.ImageAlign = ContentAlignment.MiddleLeft;
            btnProveedores.Location = new Point(0, 233);
            btnProveedores.Margin = new Padding(3, 2, 3, 2);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Padding = new Padding(9, 0, 18, 0);
            btnProveedores.Size = new Size(219, 50);
            btnProveedores.TabIndex = 4;
            btnProveedores.Text = "Proveedores";
            btnProveedores.TextAlign = ContentAlignment.MiddleLeft;
            btnProveedores.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProveedores.UseVisualStyleBackColor = true;
            btnProveedores.Click += iconButton4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(70, 547);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 2;
            label1.Text = "Log out";
            // 
            // btnProductos
            // 
            btnProductos.Dock = DockStyle.Top;
            btnProductos.FlatAppearance.BorderSize = 0;
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnProductos.ForeColor = Color.Gainsboro;
            btnProductos.IconChar = FontAwesome.Sharp.IconChar.ProductHunt;
            btnProductos.IconColor = Color.Gainsboro;
            btnProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnProductos.IconSize = 58;
            btnProductos.ImageAlign = ContentAlignment.MiddleLeft;
            btnProductos.Location = new Point(0, 183);
            btnProductos.Margin = new Padding(3, 2, 3, 2);
            btnProductos.Name = "btnProductos";
            btnProductos.Padding = new Padding(9, 0, 18, 0);
            btnProductos.Size = new Size(219, 50);
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
            btnPedidos.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPedidos.ForeColor = Color.Gainsboro;
            btnPedidos.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            btnPedidos.IconColor = Color.Gainsboro;
            btnPedidos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPedidos.IconSize = 58;
            btnPedidos.ImageAlign = ContentAlignment.MiddleLeft;
            btnPedidos.Location = new Point(0, 133);
            btnPedidos.Margin = new Padding(3, 2, 3, 2);
            btnPedidos.Name = "btnPedidos";
            btnPedidos.Padding = new Padding(9, 0, 18, 0);
            btnPedidos.Size = new Size(219, 50);
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
            btnDashboard.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDashboard.ForeColor = Color.Gainsboro;
            btnDashboard.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            btnDashboard.IconColor = Color.Gainsboro;
            btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDashboard.IconSize = 58;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(0, 83);
            btnDashboard.Margin = new Padding(3, 2, 3, 2);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(9, 0, 18, 0);
            btnDashboard.Size = new Size(219, 50);
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
            panelLogo.Margin = new Padding(3, 2, 3, 2);
            panelLogo.Name = "panelLogo";
            panelLogo.Padding = new Padding(9, 0, 0, 0);
            panelLogo.Size = new Size(219, 83);
            panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.Location = new Point(58, 13);
            btnHome.Margin = new Padding(3, 2, 3, 2);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(74, 52);
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
            iconCurrentChild.IconSize = 590;
            iconCurrentChild.Location = new Point(219, 0);
            iconCurrentChild.Margin = new Padding(3, 2, 3, 2);
            iconCurrentChild.Name = "iconCurrentChild";
            iconCurrentChild.Size = new Size(1178, 590);
            iconCurrentChild.SizeMode = PictureBoxSizeMode.Zoom;
            iconCurrentChild.TabIndex = 0;
            iconCurrentChild.TabStop = false;
            // 
            // panelTitle
            // 
            panelTitle.BackColor = Color.FromArgb(37, 36, 81);
            panelTitle.Controls.Add(iconMaxim);
            panelTitle.Controls.Add(lblMinimizeApp);
            panelTitle.Controls.Add(lblCerrarApp);
            panelTitle.Controls.Add(lblTitleChild);
            panelTitle.Controls.Add(iconCurrentChildFrm);
            panelTitle.Dock = DockStyle.Top;
            panelTitle.Location = new Point(219, 0);
            panelTitle.Margin = new Padding(3, 2, 3, 2);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(1178, 58);
            panelTitle.TabIndex = 1;
            panelTitle.MouseDown += panelTitle_MouseDown;
            // 
            // iconMaxim
            // 
            iconMaxim.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconMaxim.BackColor = Color.FromArgb(37, 36, 81);
            iconMaxim.Cursor = Cursors.Hand;
            iconMaxim.ForeColor = Color.Gainsboro;
            iconMaxim.IconChar = FontAwesome.Sharp.IconChar.Square;
            iconMaxim.IconColor = Color.Gainsboro;
            iconMaxim.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMaxim.IconSize = 15;
            iconMaxim.Location = new Point(1126, 7);
            iconMaxim.Margin = new Padding(3, 2, 3, 2);
            iconMaxim.Name = "iconMaxim";
            iconMaxim.Size = new Size(18, 15);
            iconMaxim.TabIndex = 4;
            iconMaxim.TabStop = false;
            iconMaxim.Click += iconMaxim_Click;
            // 
            // lblMinimizeApp
            // 
            lblMinimizeApp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblMinimizeApp.AutoSize = true;
            lblMinimizeApp.Cursor = Cursors.Hand;
            lblMinimizeApp.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMinimizeApp.ForeColor = Color.Gainsboro;
            lblMinimizeApp.Location = new Point(1095, -1);
            lblMinimizeApp.Name = "lblMinimizeApp";
            lblMinimizeApp.Size = new Size(29, 20);
            lblMinimizeApp.TabIndex = 4;
            lblMinimizeApp.Text = "__";
            lblMinimizeApp.Click += lblMinimizeApp_Click;
            // 
            // lblCerrarApp
            // 
            lblCerrarApp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCerrarApp.AutoSize = true;
            lblCerrarApp.Cursor = Cursors.Hand;
            lblCerrarApp.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCerrarApp.ForeColor = Color.Gainsboro;
            lblCerrarApp.Location = new Point(1151, 2);
            lblCerrarApp.Name = "lblCerrarApp";
            lblCerrarApp.Size = new Size(21, 20);
            lblCerrarApp.TabIndex = 2;
            lblCerrarApp.Text = "X";
            lblCerrarApp.Click += lblCerrarApp_Click;
            // 
            // lblTitleChild
            // 
            lblTitleChild.AutoSize = true;
            lblTitleChild.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitleChild.ForeColor = Color.Gainsboro;
            lblTitleChild.Location = new Point(51, 18);
            lblTitleChild.Name = "lblTitleChild";
            lblTitleChild.Size = new Size(64, 25);
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
            iconCurrentChildFrm.IconSize = 30;
            iconCurrentChildFrm.Location = new Point(10, 14);
            iconCurrentChildFrm.Margin = new Padding(3, 2, 3, 2);
            iconCurrentChildFrm.Name = "iconCurrentChildFrm";
            iconCurrentChildFrm.Size = new Size(35, 30);
            iconCurrentChildFrm.TabIndex = 0;
            iconCurrentChildFrm.TabStop = false;
            // 
            // panelShadow
            // 
            panelShadow.BackColor = Color.Black;
            panelShadow.Dock = DockStyle.Top;
            panelShadow.Location = new Point(219, 58);
            panelShadow.Margin = new Padding(3, 2, 3, 2);
            panelShadow.Name = "panelShadow";
            panelShadow.Size = new Size(1178, 7);
            panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            panelDesktop.BackColor = Color.Black;
            panelDesktop.BorderStyle = BorderStyle.FixedSingle;
            panelDesktop.Controls.Add(lblTipoPerfil);
            panelDesktop.Controls.Add(lblUltimaConexion);
            panelDesktop.Controls.Add(lblNombre);
            panelDesktop.Controls.Add(lblFechaActual);
            panelDesktop.Controls.Add(lblHoraActual);
            panelDesktop.Controls.Add(label2);
            panelDesktop.Controls.Add(pictureBox1);
            panelDesktop.Controls.Add(lblTitleDashboard);
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.ForeColor = SystemColors.Desktop;
            panelDesktop.Location = new Point(219, 65);
            panelDesktop.Margin = new Padding(3, 2, 3, 2);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(1178, 525);
            panelDesktop.TabIndex = 3;
            // 
            // lblTipoPerfil
            // 
            lblTipoPerfil.AutoSize = true;
            lblTipoPerfil.Font = new Font("Microsoft Sans Serif", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTipoPerfil.ForeColor = Color.Gray;
            lblTipoPerfil.Location = new Point(984, 498);
            lblTipoPerfil.Name = "lblTipoPerfil";
            lblTipoPerfil.Size = new Size(46, 20);
            lblTipoPerfil.TabIndex = 6;
            lblTipoPerfil.Text = "perfil";
            // 
            // lblUltimaConexion
            // 
            lblUltimaConexion.AutoSize = true;
            lblUltimaConexion.Font = new Font("Microsoft Sans Serif", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblUltimaConexion.ForeColor = Color.Gray;
            lblUltimaConexion.Location = new Point(140, 499);
            lblUltimaConexion.Name = "lblUltimaConexion";
            lblUltimaConexion.Size = new Size(50, 20);
            lblUltimaConexion.TabIndex = 6;
            lblUltimaConexion.Text = "fecha";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Microsoft Sans Serif", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.ForeColor = Color.Gainsboro;
            lblNombre.Location = new Point(466, 58);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(68, 20);
            lblNombre.TabIndex = 6;
            lblNombre.Text = "Nombre";
            // 
            // lblFechaActual
            // 
            lblFechaActual.AutoSize = true;
            lblFechaActual.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblFechaActual.ForeColor = Color.Gainsboro;
            lblFechaActual.Location = new Point(365, 477);
            lblFechaActual.Name = "lblFechaActual";
            lblFechaActual.Size = new Size(161, 29);
            lblFechaActual.TabIndex = 5;
            lblFechaActual.Text = "Fecha actual";
            // 
            // lblHoraActual
            // 
            lblHoraActual.AutoSize = true;
            lblHoraActual.BackColor = Color.Transparent;
            lblHoraActual.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblHoraActual.ForeColor = Color.White;
            lblHoraActual.Location = new Point(396, 421);
            lblHoraActual.Name = "lblHoraActual";
            lblHoraActual.Size = new Size(281, 55);
            lblHoraActual.TabIndex = 4;
            lblHoraActual.Text = "Hora actual";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(934, 499);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 2;
            label2.Text = "Perfil:";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.Logo_SRS;
            pictureBox1.Location = new Point(365, 89);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(430, 328);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // lblTitleDashboard
            // 
            lblTitleDashboard.AutoSize = true;
            lblTitleDashboard.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitleDashboard.ForeColor = Color.Gainsboro;
            lblTitleDashboard.Location = new Point(466, 21);
            lblTitleDashboard.Name = "lblTitleDashboard";
            lblTitleDashboard.Size = new Size(124, 20);
            lblTitleDashboard.TabIndex = 2;
            lblTitleDashboard.Text = "BIENVENIDO/A";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1397, 590);
            Controls.Add(panelDesktop);
            Controls.Add(panelShadow);
            Controls.Add(panelTitle);
            Controls.Add(iconCurrentChild);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainPage";
            Load += MainPage_Load;
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChild).EndInit();
            panelTitle.ResumeLayout(false);
            panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconMaxim).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildFrm).EndInit();
            panelDesktop.ResumeLayout(false);
            panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
        private Label lblTitleDashboard;
        private Label lblMinimizeApp;
        private Label lblCerrarApp;
        private FontAwesome.Sharp.IconPictureBox iconMaxim;
        private Label lblHoraActual;
        private Label lblFechaActual;
        private System.Windows.Forms.Timer timer1;
        private FontAwesome.Sharp.IconButton btnStocks;
        private Label lblNombre;
        private Label lblUltimaConexion;
        private Label label1;
        private Label lblTipoPerfil;
        private Label label2;
        private FontAwesome.Sharp.IconButton iconBtbCerrarSesion;
    }
}