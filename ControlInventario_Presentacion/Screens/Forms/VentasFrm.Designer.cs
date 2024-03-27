namespace ControlInventario_Presentacion.Screens.Forms
{
    partial class VentasFrm
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            lblTitleVentas = new Label();
            txtCantidadProductos = new TextBox();
            label1 = new Label();
            lblCantidad = new Label();
            btnAgregarReg = new Button();
            dgvVentas = new DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            panelFactura = new Panel();
            txtClienteVenta = new TextBox();
            lblDevolucion = new Label();
            label11 = new Label();
            txtEfectivo = new TextBox();
            label18 = new Label();
            dateTimePicker1 = new DateTimePicker();
            lblTotalaPagar = new Label();
            lblDescuento = new Label();
            lblItbis = new Label();
            lblSubTotal = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label14 = new Label();
            label5 = new Label();
            label4 = new Label();
            panelTotal = new Panel();
            label2 = new Label();
            cbProductosVenta = new ComboBox();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            lblPrecioProducto = new Label();
            lblNombreProducto = new Label();
            lblCodigoProducto = new Label();
            btnEliminarProducto = new Button();
            btnEjecutarVenta = new Button();
            groupBox1 = new GroupBox();
            lblIdProducto = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            panelFactura.SuspendLayout();
            panelTotal.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitleVentas
            // 
            lblTitleVentas.AutoSize = true;
            lblTitleVentas.Font = new Font("Segoe UI Variable Text", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitleVentas.ForeColor = Color.Gainsboro;
            lblTitleVentas.Location = new Point(4, 4);
            lblTitleVentas.Name = "lblTitleVentas";
            lblTitleVentas.Size = new Size(84, 26);
            lblTitleVentas.TabIndex = 2;
            lblTitleVentas.Text = "VENTAS";
            // 
            // txtCantidadProductos
            // 
            txtCantidadProductos.Cursor = Cursors.IBeam;
            txtCantidadProductos.Location = new Point(542, 128);
            txtCantidadProductos.Margin = new Padding(3, 2, 3, 2);
            txtCantidadProductos.Name = "txtCantidadProductos";
            txtCantidadProductos.Size = new Size(98, 23);
            txtCantidadProductos.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Text", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 51);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 4;
            label1.Text = "PRODUCTO:";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI Variable Text", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCantidad.ForeColor = Color.White;
            lblCantidad.Location = new Point(542, 105);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(92, 20);
            lblCantidad.TabIndex = 4;
            lblCantidad.Text = "CANTIDAD:";
            // 
            // btnAgregarReg
            // 
            btnAgregarReg.BackColor = Color.MidnightBlue;
            btnAgregarReg.Cursor = Cursors.Hand;
            btnAgregarReg.FlatAppearance.BorderColor = Color.MidnightBlue;
            btnAgregarReg.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            btnAgregarReg.FlatAppearance.MouseOverBackColor = Color.Navy;
            btnAgregarReg.FlatStyle = FlatStyle.Flat;
            btnAgregarReg.Font = new Font("Segoe UI Variable Text", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarReg.ForeColor = Color.White;
            btnAgregarReg.Location = new Point(684, 120);
            btnAgregarReg.Margin = new Padding(3, 2, 3, 2);
            btnAgregarReg.Name = "btnAgregarReg";
            btnAgregarReg.Size = new Size(128, 28);
            btnAgregarReg.TabIndex = 25;
            btnAgregarReg.Text = "AGREGAR";
            btnAgregarReg.UseVisualStyleBackColor = false;
            btnAgregarReg.Click += btnAgregarProveedor_Click;
            // 
            // dgvVentas
            // 
            dgvVentas.AllowUserToAddRows = false;
            dgvVentas.AllowUserToDeleteRows = false;
            dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVentas.BackgroundColor = Color.White;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Columns.AddRange(new DataGridViewColumn[] { Column2, Column1, Precio, Cantidad, Total, Column3 });
            dgvVentas.Location = new Point(25, 196);
            dgvVentas.Margin = new Padding(3, 2, 3, 2);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.ReadOnly = true;
            dgvVentas.RowHeadersVisible = false;
            dgvVentas.RowHeadersWidth = 51;
            dgvVentas.RowTemplate.Height = 29;
            dgvVentas.Size = new Size(830, 285);
            dgvVentas.TabIndex = 26;
            // 
            // Column2
            // 
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Column2.DefaultCellStyle = dataGridViewCellStyle6;
            Column2.HeaderText = "Código";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column1
            // 
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Column1.DefaultCellStyle = dataGridViewCellStyle7;
            Column1.HeaderText = "Producto";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Precio
            // 
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.Format = "C2";
            dataGridViewCellStyle8.NullValue = null;
            Precio.DefaultCellStyle = dataGridViewCellStyle8;
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // Cantidad
            // 
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.Format = "N0";
            dataGridViewCellStyle9.NullValue = null;
            Cantidad.DefaultCellStyle = dataGridViewCellStyle9;
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            // 
            // Total
            // 
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle10.Format = "C2";
            dataGridViewCellStyle10.NullValue = null;
            Total.DefaultCellStyle = dataGridViewCellStyle10;
            Total.HeaderText = "Total";
            Total.MinimumWidth = 6;
            Total.Name = "Total";
            Total.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "ID";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Visible = false;
            // 
            // panelFactura
            // 
            panelFactura.Anchor = AnchorStyles.None;
            panelFactura.BorderStyle = BorderStyle.Fixed3D;
            panelFactura.Controls.Add(txtClienteVenta);
            panelFactura.Controls.Add(lblDevolucion);
            panelFactura.Controls.Add(label11);
            panelFactura.Controls.Add(txtEfectivo);
            panelFactura.Controls.Add(label18);
            panelFactura.Controls.Add(dateTimePicker1);
            panelFactura.Controls.Add(lblTotalaPagar);
            panelFactura.Controls.Add(lblDescuento);
            panelFactura.Controls.Add(lblItbis);
            panelFactura.Controls.Add(lblSubTotal);
            panelFactura.Controls.Add(label9);
            panelFactura.Controls.Add(label8);
            panelFactura.Controls.Add(label7);
            panelFactura.Controls.Add(label6);
            panelFactura.Controls.Add(label14);
            panelFactura.Controls.Add(label5);
            panelFactura.Controls.Add(label4);
            panelFactura.Controls.Add(panelTotal);
            panelFactura.Location = new Point(877, 28);
            panelFactura.Margin = new Padding(3, 2, 3, 2);
            panelFactura.Name = "panelFactura";
            panelFactura.Size = new Size(276, 379);
            panelFactura.TabIndex = 27;
            // 
            // txtClienteVenta
            // 
            txtClienteVenta.Cursor = Cursors.IBeam;
            txtClienteVenta.Location = new Point(20, 126);
            txtClienteVenta.Margin = new Padding(3, 2, 3, 2);
            txtClienteVenta.Name = "txtClienteVenta";
            txtClienteVenta.Size = new Size(235, 23);
            txtClienteVenta.TabIndex = 33;
            // 
            // lblDevolucion
            // 
            lblDevolucion.AutoSize = true;
            lblDevolucion.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDevolucion.ForeColor = Color.White;
            lblDevolucion.Location = new Point(165, 340);
            lblDevolucion.Name = "lblDevolucion";
            lblDevolucion.Size = new Size(53, 21);
            lblDevolucion.TabIndex = 32;
            lblDevolucion.Text = "$ 0.00";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(21, 340);
            label11.Name = "label11";
            label11.Size = new Size(108, 21);
            label11.TabIndex = 31;
            label11.Text = "DEVOLUCIÓN";
            // 
            // txtEfectivo
            // 
            txtEfectivo.Cursor = Cursors.IBeam;
            txtEfectivo.Location = new Point(107, 218);
            txtEfectivo.Margin = new Padding(3, 2, 3, 2);
            txtEfectivo.Name = "txtEfectivo";
            txtEfectivo.Size = new Size(148, 23);
            txtEfectivo.TabIndex = 30;
            txtEfectivo.TextChanged += txtEfectivo_TextChanged;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Variable Text Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label18.ForeColor = Color.White;
            label18.Location = new Point(19, 221);
            label18.Name = "label18";
            label18.Size = new Size(79, 20);
            label18.TabIndex = 29;
            label18.Text = "EFECTIVO:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(21, 171);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(234, 23);
            dateTimePicker1.TabIndex = 28;
            // 
            // lblTotalaPagar
            // 
            lblTotalaPagar.AutoSize = true;
            lblTotalaPagar.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalaPagar.ForeColor = Color.White;
            lblTotalaPagar.Location = new Point(165, 319);
            lblTotalaPagar.Name = "lblTotalaPagar";
            lblTotalaPagar.Size = new Size(53, 21);
            lblTotalaPagar.TabIndex = 5;
            lblTotalaPagar.Text = "$ 0.00";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescuento.ForeColor = Color.White;
            lblDescuento.Location = new Point(164, 298);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(53, 21);
            lblDescuento.TabIndex = 6;
            lblDescuento.Text = "$ 0.00";
            // 
            // lblItbis
            // 
            lblItbis.AutoSize = true;
            lblItbis.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblItbis.ForeColor = Color.White;
            lblItbis.Location = new Point(164, 278);
            lblItbis.Name = "lblItbis";
            lblItbis.Size = new Size(53, 21);
            lblItbis.TabIndex = 7;
            lblItbis.Text = "$ 0.00";
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSubTotal.ForeColor = Color.White;
            lblSubTotal.Location = new Point(164, 257);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(53, 21);
            lblSubTotal.TabIndex = 8;
            lblSubTotal.Text = "$ 0.00";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(21, 319);
            label9.Name = "label9";
            label9.Size = new Size(118, 21);
            label9.TabIndex = 4;
            label9.Text = "TOTAL A PAGAR";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(20, 298);
            label8.Name = "label8";
            label8.Size = new Size(99, 21);
            label8.TabIndex = 4;
            label8.Text = "DESCUENTO";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(20, 278);
            label7.Name = "label7";
            label7.Size = new Size(44, 21);
            label7.TabIndex = 4;
            label7.Text = "ITBIS";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(20, 257);
            label6.Name = "label6";
            label6.Size = new Size(80, 21);
            label6.TabIndex = 4;
            label6.Text = "SUBTOTAL";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = Color.White;
            label14.Location = new Point(21, 235);
            label14.Name = "label14";
            label14.Size = new Size(222, 15);
            label14.TabIndex = 4;
            label14.Text = "___________________________________________";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Variable Text Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(20, 152);
            label5.Name = "label5";
            label5.Size = new Size(113, 17);
            label5.TabIndex = 4;
            label5.Text = "Fecha de emisión";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Text Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(19, 101);
            label4.Name = "label4";
            label4.Size = new Size(49, 17);
            label4.TabIndex = 4;
            label4.Text = "Cliente";
            // 
            // panelTotal
            // 
            panelTotal.BackColor = Color.Gray;
            panelTotal.Controls.Add(label2);
            panelTotal.ForeColor = Color.Gray;
            panelTotal.Location = new Point(3, 2);
            panelTotal.Margin = new Padding(3, 2, 3, 2);
            panelTotal.Name = "panelTotal";
            panelTotal.Size = new Size(267, 58);
            panelTotal.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gray;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(88, 16);
            label2.Name = "label2";
            label2.Size = new Size(96, 25);
            label2.TabIndex = 1;
            label2.Text = "FACTURA";
            // 
            // cbProductosVenta
            // 
            cbProductosVenta.FormattingEnabled = true;
            cbProductosVenta.Location = new Point(12, 75);
            cbProductosVenta.Margin = new Padding(3, 2, 3, 2);
            cbProductosVenta.Name = "cbProductosVenta";
            cbProductosVenta.Size = new Size(232, 23);
            cbProductosVenta.TabIndex = 28;
            cbProductosVenta.SelectedIndexChanged += cbProductosVenta_SelectedIndexChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Variable Text", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.White;
            label15.Location = new Point(12, 105);
            label15.Name = "label15";
            label15.Size = new Size(71, 20);
            label15.TabIndex = 29;
            label15.Text = "CÓDIGO:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Variable Text", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.White;
            label16.Location = new Point(179, 105);
            label16.Name = "label16";
            label16.Size = new Size(78, 20);
            label16.TabIndex = 30;
            label16.Text = "NOMBRE:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Variable Text", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = Color.White;
            label17.Location = new Point(382, 105);
            label17.Name = "label17";
            label17.Size = new Size(65, 20);
            label17.TabIndex = 31;
            label17.Text = "PRECIO:";
            // 
            // lblPrecioProducto
            // 
            lblPrecioProducto.AutoSize = true;
            lblPrecioProducto.ForeColor = Color.White;
            lblPrecioProducto.Location = new Point(382, 134);
            lblPrecioProducto.Name = "lblPrecioProducto";
            lblPrecioProducto.Size = new Size(12, 15);
            lblPrecioProducto.TabIndex = 34;
            lblPrecioProducto.Text = "-";
            // 
            // lblNombreProducto
            // 
            lblNombreProducto.AutoSize = true;
            lblNombreProducto.ForeColor = Color.White;
            lblNombreProducto.Location = new Point(179, 134);
            lblNombreProducto.Name = "lblNombreProducto";
            lblNombreProducto.Size = new Size(12, 15);
            lblNombreProducto.TabIndex = 33;
            lblNombreProducto.Text = "-";
            // 
            // lblCodigoProducto
            // 
            lblCodigoProducto.AutoSize = true;
            lblCodigoProducto.ForeColor = Color.White;
            lblCodigoProducto.Location = new Point(12, 134);
            lblCodigoProducto.Name = "lblCodigoProducto";
            lblCodigoProducto.Size = new Size(12, 15);
            lblCodigoProducto.TabIndex = 32;
            lblCodigoProducto.Text = "-";
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.BackColor = Color.Firebrick;
            btnEliminarProducto.Cursor = Cursors.Hand;
            btnEliminarProducto.FlatAppearance.BorderColor = Color.Firebrick;
            btnEliminarProducto.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            btnEliminarProducto.FlatAppearance.MouseOverBackColor = Color.Maroon;
            btnEliminarProducto.FlatStyle = FlatStyle.Flat;
            btnEliminarProducto.Font = new Font("Segoe UI Variable Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminarProducto.ForeColor = Color.White;
            btnEliminarProducto.Location = new Point(684, 75);
            btnEliminarProducto.Margin = new Padding(3, 2, 3, 2);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(128, 28);
            btnEliminarProducto.TabIndex = 35;
            btnEliminarProducto.Text = "ELIMINAR";
            btnEliminarProducto.UseVisualStyleBackColor = false;
            btnEliminarProducto.Click += btnEliminarProducto_Click;
            // 
            // btnEjecutarVenta
            // 
            btnEjecutarVenta.BackColor = Color.Teal;
            btnEjecutarVenta.Cursor = Cursors.Hand;
            btnEjecutarVenta.FlatAppearance.BorderColor = Color.Teal;
            btnEjecutarVenta.FlatAppearance.MouseDownBackColor = Color.DarkTurquoise;
            btnEjecutarVenta.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 64, 64);
            btnEjecutarVenta.FlatStyle = FlatStyle.Flat;
            btnEjecutarVenta.Font = new Font("Segoe UI Variable Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEjecutarVenta.ForeColor = Color.White;
            btnEjecutarVenta.Location = new Point(877, 436);
            btnEjecutarVenta.Margin = new Padding(3, 2, 3, 2);
            btnEjecutarVenta.Name = "btnEjecutarVenta";
            btnEjecutarVenta.Size = new Size(276, 44);
            btnEjecutarVenta.TabIndex = 36;
            btnEjecutarVenta.Text = "EJECUTAR";
            btnEjecutarVenta.UseVisualStyleBackColor = false;
            btnEjecutarVenta.Click += btnEjecutarVenta_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Teal;
            groupBox1.Controls.Add(lblIdProducto);
            groupBox1.Controls.Add(btnEliminarProducto);
            groupBox1.Controls.Add(lblPrecioProducto);
            groupBox1.Controls.Add(lblNombreProducto);
            groupBox1.Controls.Add(lblCodigoProducto);
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(cbProductosVenta);
            groupBox1.Controls.Add(btnAgregarReg);
            groupBox1.Controls.Add(lblCantidad);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtCantidadProductos);
            groupBox1.Controls.Add(lblTitleVentas);
            groupBox1.Location = new Point(25, 23);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(830, 166);
            groupBox1.TabIndex = 37;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // lblIdProducto
            // 
            lblIdProducto.AutoSize = true;
            lblIdProducto.ForeColor = Color.White;
            lblIdProducto.Location = new Point(290, 75);
            lblIdProducto.Name = "lblIdProducto";
            lblIdProducto.Size = new Size(12, 15);
            lblIdProducto.TabIndex = 36;
            lblIdProducto.Text = "-";
            lblIdProducto.Visible = false;
            // 
            // VentasFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 27, 60);
            ClientSize = new Size(1163, 490);
            Controls.Add(groupBox1);
            Controls.Add(btnEjecutarVenta);
            Controls.Add(panelFactura);
            Controls.Add(dgvVentas);
            Margin = new Padding(3, 2, 3, 2);
            Name = "VentasFrm";
            Text = "VentasFrm";
            Load += VentasFrm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            panelFactura.ResumeLayout(false);
            panelFactura.PerformLayout();
            panelTotal.ResumeLayout(false);
            panelTotal.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitleVentas;
        private TextBox txtCantidadProductos;
        private Label label1;
        private Label lblCantidad;
        private Button btnAgregarReg;
        private DataGridView dgvVentas;
        private Panel panelFactura;
        private Label label5;
        private Label label4;
        private Panel panelTotal;
        private Label label2;
        private Label lblTotalaPagar;
        private Label lblDescuento;
        private Label lblItbis;
        private Label lblSubTotal;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label14;
        private DateTimePicker dateTimePicker1;
        private ComboBox cbProductosVenta;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label lblPrecioProducto;
        private Label lblNombreProducto;
        private Label lblCodigoProducto;
        private Button btnEliminarProducto;
        private Button btnEjecutarVenta;
        private TextBox txtEfectivo;
        private Label label18;
        private Label lblDevolucion;
        private Label label11;
        private GroupBox groupBox1;
        private TextBox txtClienteVenta;
        private Label lblIdProducto;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewTextBoxColumn Column3;
    }
}