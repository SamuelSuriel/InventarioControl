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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
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
            panelFactura = new Panel();
            lblDevolucion = new Label();
            label11 = new Label();
            txtEfectivo = new TextBox();
            label18 = new Label();
            dateTimePicker1 = new DateTimePicker();
            lblTotalaPagar = new Label();
            lblDescuento = new Label();
            lblItbis = new Label();
            lblSubTotal = new Label();
            comboBox2 = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label14 = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            panelTotal = new Panel();
            label2 = new Label();
            label3 = new Label();
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
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            panelFactura.SuspendLayout();
            panelTotal.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitleVentas
            // 
            lblTitleVentas.AutoSize = true;
            lblTitleVentas.Font = new Font("Segoe UI Variable Display", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitleVentas.ForeColor = Color.Gainsboro;
            lblTitleVentas.Location = new Point(5, 6);
            lblTitleVentas.Name = "lblTitleVentas";
            lblTitleVentas.Size = new Size(94, 31);
            lblTitleVentas.TabIndex = 2;
            lblTitleVentas.Text = "VENTAS";
            // 
            // txtCantidadProductos
            // 
            txtCantidadProductos.Cursor = Cursors.IBeam;
            txtCantidadProductos.Location = new Point(619, 171);
            txtCantidadProductos.Name = "txtCantidadProductos";
            txtCantidadProductos.Size = new Size(111, 27);
            txtCantidadProductos.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(14, 68);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 4;
            label1.Text = "PRODUCTO:";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.ForeColor = Color.White;
            lblCantidad.Location = new Point(619, 147);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(86, 20);
            lblCantidad.TabIndex = 4;
            lblCantidad.Text = "CANTIDAD:";
            // 
            // btnAgregarReg
            // 
            btnAgregarReg.Cursor = Cursors.Hand;
            btnAgregarReg.ForeColor = Color.RoyalBlue;
            btnAgregarReg.Location = new Point(782, 160);
            btnAgregarReg.Name = "btnAgregarReg";
            btnAgregarReg.Size = new Size(146, 38);
            btnAgregarReg.TabIndex = 25;
            btnAgregarReg.Text = "AGREGAR";
            btnAgregarReg.UseVisualStyleBackColor = true;
            btnAgregarReg.Click += btnAgregarProveedor_Click;
            // 
            // dgvVentas
            // 
            dgvVentas.AllowUserToAddRows = false;
            dgvVentas.AllowUserToDeleteRows = false;
            dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVentas.BackgroundColor = Color.White;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Columns.AddRange(new DataGridViewColumn[] { Column2, Column1, Precio, Cantidad, Total });
            dgvVentas.Location = new Point(29, 261);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.ReadOnly = true;
            dgvVentas.RowHeadersVisible = false;
            dgvVentas.RowHeadersWidth = 51;
            dgvVentas.RowTemplate.Height = 29;
            dgvVentas.Size = new Size(948, 300);
            dgvVentas.TabIndex = 26;
            // 
            // Column2
            // 
            Column2.HeaderText = "Código";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.HeaderText = "Producto";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Precio
            // 
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            Precio.DefaultCellStyle = dataGridViewCellStyle1;
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // Cantidad
            // 
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            Cantidad.DefaultCellStyle = dataGridViewCellStyle2;
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            // 
            // Total
            // 
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            Total.DefaultCellStyle = dataGridViewCellStyle3;
            Total.HeaderText = "Total";
            Total.MinimumWidth = 6;
            Total.Name = "Total";
            Total.ReadOnly = true;
            // 
            // panelFactura
            // 
            panelFactura.Anchor = AnchorStyles.None;
            panelFactura.BorderStyle = BorderStyle.Fixed3D;
            panelFactura.Controls.Add(lblDevolucion);
            panelFactura.Controls.Add(label11);
            panelFactura.Controls.Add(txtEfectivo);
            panelFactura.Controls.Add(label18);
            panelFactura.Controls.Add(dateTimePicker1);
            panelFactura.Controls.Add(lblTotalaPagar);
            panelFactura.Controls.Add(lblDescuento);
            panelFactura.Controls.Add(lblItbis);
            panelFactura.Controls.Add(lblSubTotal);
            panelFactura.Controls.Add(comboBox2);
            panelFactura.Controls.Add(label9);
            panelFactura.Controls.Add(label8);
            panelFactura.Controls.Add(label7);
            panelFactura.Controls.Add(label6);
            panelFactura.Controls.Add(label14);
            panelFactura.Controls.Add(label5);
            panelFactura.Controls.Add(comboBox1);
            panelFactura.Controls.Add(label4);
            panelFactura.Controls.Add(panelTotal);
            panelFactura.Controls.Add(label3);
            panelFactura.Location = new Point(1002, 37);
            panelFactura.Name = "panelFactura";
            panelFactura.Size = new Size(315, 588);
            panelFactura.TabIndex = 27;
            // 
            // lblDevolucion
            // 
            lblDevolucion.AutoSize = true;
            lblDevolucion.ForeColor = Color.White;
            lblDevolucion.Location = new Point(188, 502);
            lblDevolucion.Name = "lblDevolucion";
            lblDevolucion.Size = new Size(64, 20);
            lblDevolucion.TabIndex = 32;
            lblDevolucion.Text = "RD$0.00";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.White;
            label11.Location = new Point(23, 502);
            label11.Name = "label11";
            label11.Size = new Size(100, 20);
            label11.TabIndex = 31;
            label11.Text = "DEVOLUCIÓN";
            // 
            // txtEfectivo
            // 
            txtEfectivo.Cursor = Cursors.IBeam;
            txtEfectivo.Location = new Point(122, 363);
            txtEfectivo.Name = "txtEfectivo";
            txtEfectivo.Size = new Size(169, 27);
            txtEfectivo.TabIndex = 30;
            txtEfectivo.TextChanged += txtEfectivo_TextChanged;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.ForeColor = Color.White;
            label18.Location = new Point(23, 365);
            label18.Name = "label18";
            label18.Size = new Size(76, 20);
            label18.TabIndex = 29;
            label18.Text = "EFECTIVO:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(24, 298);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(267, 27);
            dateTimePicker1.TabIndex = 28;
            // 
            // lblTotalaPagar
            // 
            lblTotalaPagar.AutoSize = true;
            lblTotalaPagar.ForeColor = Color.White;
            lblTotalaPagar.Location = new Point(188, 482);
            lblTotalaPagar.Name = "lblTotalaPagar";
            lblTotalaPagar.Size = new Size(64, 20);
            lblTotalaPagar.TabIndex = 5;
            lblTotalaPagar.Text = "RD$0.00";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.ForeColor = Color.White;
            lblDescuento.Location = new Point(188, 462);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(64, 20);
            lblDescuento.TabIndex = 6;
            lblDescuento.Text = "RD$0.00";
            // 
            // lblItbis
            // 
            lblItbis.AutoSize = true;
            lblItbis.ForeColor = Color.White;
            lblItbis.Location = new Point(188, 442);
            lblItbis.Name = "lblItbis";
            lblItbis.Size = new Size(64, 20);
            lblItbis.TabIndex = 7;
            lblItbis.Text = "RD$0.00";
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.ForeColor = Color.White;
            lblSubTotal.Location = new Point(188, 422);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(64, 20);
            lblSubTotal.TabIndex = 8;
            lblSubTotal.Text = "RD$0.00";
            // 
            // comboBox2
            // 
            comboBox2.DisplayMember = "CONSTRUCTORA L&R S.A";
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(23, 231);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(268, 28);
            comboBox2.TabIndex = 1;
            comboBox2.ValueMember = "01";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.White;
            label9.Location = new Point(23, 482);
            label9.Name = "label9";
            label9.Size = new Size(114, 20);
            label9.TabIndex = 4;
            label9.Text = "TOTAL A PAGAR";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.White;
            label8.Location = new Point(23, 462);
            label8.Name = "label8";
            label8.Size = new Size(92, 20);
            label8.TabIndex = 4;
            label8.Text = "DESCUENTO";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(23, 442);
            label7.Name = "label7";
            label7.Size = new Size(42, 20);
            label7.TabIndex = 4;
            label7.Text = "ITBIS";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(23, 422);
            label6.Name = "label6";
            label6.Size = new Size(76, 20);
            label6.TabIndex = 4;
            label6.Text = "SUBTOTAL";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = Color.White;
            label14.Location = new Point(24, 385);
            label14.Name = "label14";
            label14.Size = new Size(267, 20);
            label14.TabIndex = 4;
            label14.Text = "___________________________________________";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(23, 275);
            label5.Name = "label5";
            label5.Size = new Size(124, 20);
            label5.TabIndex = 4;
            label5.Text = "Fecha de emisión";
            // 
            // comboBox1
            // 
            comboBox1.DisplayMember = "FACTURA";
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(23, 162);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(268, 28);
            comboBox1.TabIndex = 1;
            comboBox1.ValueMember = "1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(23, 208);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 4;
            label4.Text = "Cliente";
            // 
            // panelTotal
            // 
            panelTotal.BackColor = Color.Gray;
            panelTotal.Controls.Add(label2);
            panelTotal.ForeColor = Color.Gray;
            panelTotal.Location = new Point(3, 3);
            panelTotal.Name = "panelTotal";
            panelTotal.Size = new Size(305, 116);
            panelTotal.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gray;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(76, 45);
            label2.Name = "label2";
            label2.Size = new Size(116, 31);
            label2.TabIndex = 1;
            label2.Text = "FACTURA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(23, 139);
            label3.Name = "label3";
            label3.Size = new Size(149, 20);
            label3.TabIndex = 4;
            label3.Text = "Documento contable";
            // 
            // cbProductosVenta
            // 
            cbProductosVenta.FormattingEnabled = true;
            cbProductosVenta.Location = new Point(14, 100);
            cbProductosVenta.Name = "cbProductosVenta";
            cbProductosVenta.Size = new Size(264, 28);
            cbProductosVenta.TabIndex = 28;
            cbProductosVenta.SelectedIndexChanged += cbProductosVenta_SelectedIndexChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = Color.White;
            label15.Location = new Point(14, 147);
            label15.Name = "label15";
            label15.Size = new Size(68, 20);
            label15.TabIndex = 29;
            label15.Text = "CÓDIGO:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ForeColor = Color.White;
            label16.Location = new Point(205, 147);
            label16.Name = "label16";
            label16.Size = new Size(73, 20);
            label16.TabIndex = 30;
            label16.Text = "NOMBRE:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.ForeColor = Color.White;
            label17.Location = new Point(437, 147);
            label17.Name = "label17";
            label17.Size = new Size(61, 20);
            label17.TabIndex = 31;
            label17.Text = "PRECIO:";
            // 
            // lblPrecioProducto
            // 
            lblPrecioProducto.AutoSize = true;
            lblPrecioProducto.ForeColor = Color.White;
            lblPrecioProducto.Location = new Point(437, 178);
            lblPrecioProducto.Name = "lblPrecioProducto";
            lblPrecioProducto.Size = new Size(15, 20);
            lblPrecioProducto.TabIndex = 34;
            lblPrecioProducto.Text = "-";
            // 
            // lblNombreProducto
            // 
            lblNombreProducto.AutoSize = true;
            lblNombreProducto.ForeColor = Color.White;
            lblNombreProducto.Location = new Point(205, 178);
            lblNombreProducto.Name = "lblNombreProducto";
            lblNombreProducto.Size = new Size(15, 20);
            lblNombreProducto.TabIndex = 33;
            lblNombreProducto.Text = "-";
            // 
            // lblCodigoProducto
            // 
            lblCodigoProducto.AutoSize = true;
            lblCodigoProducto.ForeColor = Color.White;
            lblCodigoProducto.Location = new Point(14, 178);
            lblCodigoProducto.Name = "lblCodigoProducto";
            lblCodigoProducto.Size = new Size(15, 20);
            lblCodigoProducto.TabIndex = 32;
            lblCodigoProducto.Text = "-";
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.Cursor = Cursors.Hand;
            btnEliminarProducto.ForeColor = Color.Red;
            btnEliminarProducto.Location = new Point(782, 100);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(146, 38);
            btnEliminarProducto.TabIndex = 35;
            btnEliminarProducto.Text = "ELIMINAR";
            btnEliminarProducto.UseVisualStyleBackColor = true;
            btnEliminarProducto.Click += btnEliminarProducto_Click;
            // 
            // btnEjecutarVenta
            // 
            btnEjecutarVenta.BackColor = Color.Teal;
            btnEjecutarVenta.Cursor = Cursors.Hand;
            btnEjecutarVenta.ForeColor = Color.White;
            btnEjecutarVenta.Location = new Point(781, 567);
            btnEjecutarVenta.Name = "btnEjecutarVenta";
            btnEjecutarVenta.Size = new Size(191, 58);
            btnEjecutarVenta.TabIndex = 36;
            btnEjecutarVenta.Text = "EJECUTAR";
            btnEjecutarVenta.UseVisualStyleBackColor = false;
            btnEjecutarVenta.Click += btnEjecutarVenta_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Teal;
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
            groupBox1.Location = new Point(29, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(948, 222);
            groupBox1.TabIndex = 37;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // VentasFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1329, 653);
            Controls.Add(groupBox1);
            Controls.Add(btnEjecutarVenta);
            Controls.Add(panelFactura);
            Controls.Add(dgvVentas);
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
        private ComboBox comboBox2;
        private Label label5;
        private ComboBox comboBox1;
        private Label label4;
        private Panel panelTotal;
        private Label label2;
        private Label label3;
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
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Total;
    }
}