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
            lblTitleVentas = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            lblCantidad = new Label();
            btnAgregarProveedor = new Button();
            dataGridView1 = new DataGridView();
            Item = new DataGridViewTextBoxColumn();
            Unidad = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            Descuento = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            panelFactura = new Panel();
            dateTimePicker1 = new DateTimePicker();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelFactura.SuspendLayout();
            panelTotal.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitleVentas
            // 
            lblTitleVentas.AutoSize = true;
            lblTitleVentas.Font = new Font("Segoe UI Variable Display", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitleVentas.ForeColor = Color.Gainsboro;
            lblTitleVentas.Location = new Point(34, 37);
            lblTitleVentas.Name = "lblTitleVentas";
            lblTitleVentas.Size = new Size(94, 31);
            lblTitleVentas.TabIndex = 2;
            lblTitleVentas.Text = "VENTAS";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(34, 131);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Buscar por código o nombre del producto";
            textBox1.Size = new Size(569, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(622, 131);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(111, 27);
            textBox2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(34, 108);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 4;
            label1.Text = "Producto";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.ForeColor = Color.White;
            lblCantidad.Location = new Point(622, 108);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(69, 20);
            lblCantidad.TabIndex = 4;
            lblCantidad.Text = "Cantidad";
            // 
            // btnAgregarProveedor
            // 
            btnAgregarProveedor.Location = new Point(761, 118);
            btnAgregarProveedor.Name = "btnAgregarProveedor";
            btnAgregarProveedor.Size = new Size(235, 40);
            btnAgregarProveedor.TabIndex = 25;
            btnAgregarProveedor.Text = "Agregar al carrito";
            btnAgregarProveedor.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Item, Unidad, Cantidad, Precio, Subtotal, Descuento, Total });
            dataGridView1.Location = new Point(34, 164);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(962, 461);
            dataGridView1.TabIndex = 26;
            // 
            // Item
            // 
            Item.HeaderText = "Item";
            Item.MinimumWidth = 6;
            Item.Name = "Item";
            Item.Width = 125;
            // 
            // Unidad
            // 
            Unidad.HeaderText = "Unidad";
            Unidad.MinimumWidth = 6;
            Unidad.Name = "Unidad";
            Unidad.Width = 125;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.Width = 125;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            Precio.Width = 125;
            // 
            // Subtotal
            // 
            Subtotal.HeaderText = "Subtotal";
            Subtotal.MinimumWidth = 6;
            Subtotal.Name = "Subtotal";
            Subtotal.Width = 125;
            // 
            // Descuento
            // 
            Descuento.HeaderText = "Descuento";
            Descuento.MinimumWidth = 6;
            Descuento.Name = "Descuento";
            Descuento.Width = 125;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.MinimumWidth = 6;
            Total.Name = "Total";
            Total.Width = 125;
            // 
            // panelFactura
            // 
            panelFactura.Anchor = AnchorStyles.None;
            panelFactura.BorderStyle = BorderStyle.Fixed3D;
            panelFactura.Controls.Add(dateTimePicker1);
            panelFactura.Controls.Add(label10);
            panelFactura.Controls.Add(label11);
            panelFactura.Controls.Add(label12);
            panelFactura.Controls.Add(label13);
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
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(24, 319);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(267, 27);
            dateTimePicker1.TabIndex = 28;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.White;
            label10.Location = new Point(222, 482);
            label10.Name = "label10";
            label10.Size = new Size(64, 20);
            label10.TabIndex = 5;
            label10.Text = "RD$0.00";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.White;
            label11.Location = new Point(222, 462);
            label11.Name = "label11";
            label11.Size = new Size(64, 20);
            label11.TabIndex = 6;
            label11.Text = "RD$0.00";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.White;
            label12.Location = new Point(222, 442);
            label12.Name = "label12";
            label12.Size = new Size(64, 20);
            label12.TabIndex = 7;
            label12.Text = "RD$0.00";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.White;
            label13.Location = new Point(222, 422);
            label13.Name = "label13";
            label13.Size = new Size(64, 20);
            label13.TabIndex = 8;
            label13.Text = "RD$0.00";
            // 
            // comboBox2
            // 
            comboBox2.DisplayMember = "CONSTRUCTORA L&R S.A";
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(23, 238);
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
            label9.Size = new Size(50, 20);
            label9.TabIndex = 4;
            label9.Text = "TOTAL";
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
            label5.Location = new Point(23, 296);
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
            label4.Location = new Point(23, 215);
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
            label2.Size = new Size(151, 31);
            label2.TabIndex = 1;
            label2.Text = "Total Factura";
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
            // VentasFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1329, 653);
            Controls.Add(panelFactura);
            Controls.Add(dataGridView1);
            Controls.Add(btnAgregarProveedor);
            Controls.Add(lblCantidad);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblTitleVentas);
            Name = "VentasFrm";
            Text = "VentasFrm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelFactura.ResumeLayout(false);
            panelFactura.PerformLayout();
            panelTotal.ResumeLayout(false);
            panelTotal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitleVentas;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label lblCantidad;
        private Button btnAgregarProveedor;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Item;
        private DataGridViewTextBoxColumn Unidad;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Subtotal;
        private DataGridViewTextBoxColumn Descuento;
        private DataGridViewTextBoxColumn Total;
        private Panel panelFactura;
        private ComboBox comboBox2;
        private Label label5;
        private ComboBox comboBox1;
        private Label label4;
        private Panel panelTotal;
        private Label label2;
        private Label label3;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label14;
        private DateTimePicker dateTimePicker1;
    }
}