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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            lblTitleVentas = new Label();
            txtCantidadProductos = new TextBox();
            label1 = new Label();
            lblCantidad = new Label();
            btnAgregarReg = new Button();
            dgvVentas = new DataGridView();
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
            Column2 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
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
            lblTitleVentas.Location = new Point(4, 4);
            lblTitleVentas.Name = "lblTitleVentas";
            lblTitleVentas.Size = new Size(79, 26);
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
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 51);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 4;
            label1.Text = "PRODUCTO:";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.ForeColor = Color.White;
            lblCantidad.Location = new Point(542, 110);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(68, 15);
            lblCantidad.TabIndex = 4;
            lblCantidad.Text = "CANTIDAD:";
            // 
            // btnAgregarReg
            // 
            btnAgregarReg.Cursor = Cursors.Hand;
            btnAgregarReg.ForeColor = Color.RoyalBlue;
            btnAgregarReg.Location = new Point(684, 120);
            btnAgregarReg.Margin = new Padding(3, 2, 3, 2);
            btnAgregarReg.Name = "btnAgregarReg";
            btnAgregarReg.Size = new Size(128, 28);
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
            dgvVentas.Location = new Point(25, 196);
            dgvVentas.Margin = new Padding(3, 2, 3, 2);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.ReadOnly = true;
            dgvVentas.RowHeadersVisible = false;
            dgvVentas.RowHeadersWidth = 51;
            dgvVentas.RowTemplate.Height = 29;
            dgvVentas.Size = new Size(830, 225);
            dgvVentas.TabIndex = 26;
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
            panelFactura.Location = new Point(877, 28);
            panelFactura.Margin = new Padding(3, 2, 3, 2);
            panelFactura.Name = "panelFactura";
            panelFactura.Size = new Size(276, 442);
            panelFactura.TabIndex = 27;
            // 
            // lblDevolucion
            // 
            lblDevolucion.AutoSize = true;
            lblDevolucion.ForeColor = Color.White;
            lblDevolucion.Location = new Point(164, 376);
            lblDevolucion.Name = "lblDevolucion";
            lblDevolucion.Size = new Size(49, 15);
            lblDevolucion.TabIndex = 32;
            lblDevolucion.Text = "RD$0.00";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.White;
            label11.Location = new Point(20, 376);
            label11.Name = "label11";
            label11.Size = new Size(80, 15);
            label11.TabIndex = 31;
            label11.Text = "DEVOLUCIÓN";
            // 
            // txtEfectivo
            // 
            txtEfectivo.Cursor = Cursors.IBeam;
            txtEfectivo.Location = new Point(107, 272);
            txtEfectivo.Margin = new Padding(3, 2, 3, 2);
            txtEfectivo.Name = "txtEfectivo";
            txtEfectivo.Size = new Size(148, 23);
            txtEfectivo.TabIndex = 30;
            txtEfectivo.TextChanged += txtEfectivo_TextChanged;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.ForeColor = Color.White;
            label18.Location = new Point(20, 274);
            label18.Name = "label18";
            label18.Size = new Size(61, 15);
            label18.TabIndex = 29;
            label18.Text = "EFECTIVO:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(21, 224);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(234, 23);
            dateTimePicker1.TabIndex = 28;
            // 
            // lblTotalaPagar
            // 
            lblTotalaPagar.AutoSize = true;
            lblTotalaPagar.ForeColor = Color.White;
            lblTotalaPagar.Location = new Point(164, 362);
            lblTotalaPagar.Name = "lblTotalaPagar";
            lblTotalaPagar.Size = new Size(49, 15);
            lblTotalaPagar.TabIndex = 5;
            lblTotalaPagar.Text = "RD$0.00";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.ForeColor = Color.White;
            lblDescuento.Location = new Point(164, 346);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(49, 15);
            lblDescuento.TabIndex = 6;
            lblDescuento.Text = "RD$0.00";
            // 
            // lblItbis
            // 
            lblItbis.AutoSize = true;
            lblItbis.ForeColor = Color.White;
            lblItbis.Location = new Point(164, 332);
            lblItbis.Name = "lblItbis";
            lblItbis.Size = new Size(49, 15);
            lblItbis.TabIndex = 7;
            lblItbis.Text = "RD$0.00";
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.ForeColor = Color.White;
            lblSubTotal.Location = new Point(164, 316);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(49, 15);
            lblSubTotal.TabIndex = 8;
            lblSubTotal.Text = "RD$0.00";
            // 
            // comboBox2
            // 
            comboBox2.DisplayMember = "CONSTRUCTORA L&R S.A";
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(20, 173);
            comboBox2.Margin = new Padding(3, 2, 3, 2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(235, 23);
            comboBox2.TabIndex = 1;
            comboBox2.ValueMember = "01";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.White;
            label9.Location = new Point(20, 362);
            label9.Name = "label9";
            label9.Size = new Size(90, 15);
            label9.TabIndex = 4;
            label9.Text = "TOTAL A PAGAR";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.White;
            label8.Location = new Point(20, 346);
            label8.Name = "label8";
            label8.Size = new Size(72, 15);
            label8.TabIndex = 4;
            label8.Text = "DESCUENTO";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(20, 332);
            label7.Name = "label7";
            label7.Size = new Size(32, 15);
            label7.TabIndex = 4;
            label7.Text = "ITBIS";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(20, 316);
            label6.Name = "label6";
            label6.Size = new Size(59, 15);
            label6.TabIndex = 4;
            label6.Text = "SUBTOTAL";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = Color.White;
            label14.Location = new Point(21, 289);
            label14.Name = "label14";
            label14.Size = new Size(222, 15);
            label14.TabIndex = 4;
            label14.Text = "___________________________________________";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(20, 206);
            label5.Name = "label5";
            label5.Size = new Size(99, 15);
            label5.TabIndex = 4;
            label5.Text = "Fecha de emisión";
            // 
            // comboBox1
            // 
            comboBox1.DisplayMember = "FACTURA";
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(20, 122);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(235, 23);
            comboBox1.TabIndex = 1;
            comboBox1.ValueMember = "1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(20, 156);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
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
            panelTotal.Size = new Size(267, 87);
            panelTotal.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gray;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(66, 34);
            label2.Name = "label2";
            label2.Size = new Size(96, 25);
            label2.TabIndex = 1;
            label2.Text = "FACTURA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(20, 104);
            label3.Name = "label3";
            label3.Size = new Size(119, 15);
            label3.TabIndex = 4;
            label3.Text = "Documento contable";
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
            label15.ForeColor = Color.White;
            label15.Location = new Point(12, 110);
            label15.Name = "label15";
            label15.Size = new Size(55, 15);
            label15.TabIndex = 29;
            label15.Text = "CÓDIGO:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ForeColor = Color.White;
            label16.Location = new Point(179, 110);
            label16.Name = "label16";
            label16.Size = new Size(59, 15);
            label16.TabIndex = 30;
            label16.Text = "NOMBRE:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.ForeColor = Color.White;
            label17.Location = new Point(382, 110);
            label17.Name = "label17";
            label17.Size = new Size(50, 15);
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
            btnEliminarProducto.Cursor = Cursors.Hand;
            btnEliminarProducto.ForeColor = Color.Red;
            btnEliminarProducto.Location = new Point(684, 75);
            btnEliminarProducto.Margin = new Padding(3, 2, 3, 2);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(128, 28);
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
            btnEjecutarVenta.Location = new Point(683, 425);
            btnEjecutarVenta.Margin = new Padding(3, 2, 3, 2);
            btnEjecutarVenta.Name = "btnEjecutarVenta";
            btnEjecutarVenta.Size = new Size(167, 44);
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
            groupBox1.Location = new Point(25, 23);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(830, 166);
            groupBox1.TabIndex = 37;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // Column2
            // 
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Column2.DefaultCellStyle = dataGridViewCellStyle1;
            Column2.HeaderText = "Código";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column1
            // 
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Column1.DefaultCellStyle = dataGridViewCellStyle2;
            Column1.HeaderText = "Producto";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Precio
            // 
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            Precio.DefaultCellStyle = dataGridViewCellStyle3;
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // Cantidad
            // 
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = null;
            Cantidad.DefaultCellStyle = dataGridViewCellStyle4;
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            // 
            // Total
            // 
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            Total.DefaultCellStyle = dataGridViewCellStyle5;
            Total.HeaderText = "Total";
            Total.MinimumWidth = 6;
            Total.Name = "Total";
            Total.ReadOnly = true;
            // 
            // VentasFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
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