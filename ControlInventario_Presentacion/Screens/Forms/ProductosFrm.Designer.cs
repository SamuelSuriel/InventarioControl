namespace ControlInventario_Presentacion.Screens.Forms
{
    partial class ProductosFrm
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
            lblTitleProducto = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            btnAgregarProducto = new Button();
            btnEditarProducto = new Button();
            lblLimpiarCamporProd = new Label();
            lblNombreProducto = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            codigo = new DataGridViewTextBoxColumn();
            descripcion = new DataGridViewTextBoxColumn();
            stock = new DataGridViewTextBoxColumn();
            precioCompra = new DataGridViewTextBoxColumn();
            precioVenta = new DataGridViewTextBoxColumn();
            btnEliminarProducto = new Label();
            lblLine = new Label();
            label7 = new Label();
            label1 = new Label();
            textBox6 = new TextBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            textBox7 = new TextBox();
            label2 = new Label();
            richTextBox1 = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTitleProducto
            // 
            lblTitleProducto.Anchor = AnchorStyles.None;
            lblTitleProducto.AutoSize = true;
            lblTitleProducto.Font = new Font("Segoe UI Variable Display", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitleProducto.ForeColor = Color.Gainsboro;
            lblTitleProducto.Location = new Point(112, 43);
            lblTitleProducto.Name = "lblTitleProducto";
            lblTitleProducto.Size = new Size(147, 31);
            lblTitleProducto.TabIndex = 2;
            lblTitleProducto.Text = "PRODUCTOS";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(183, 155);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(282, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Location = new Point(183, 201);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(282, 27);
            textBox2.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.None;
            textBox4.Location = new Point(179, 347);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(282, 27);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.None;
            textBox5.Location = new Point(179, 392);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(282, 27);
            textBox5.TabIndex = 3;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Anchor = AnchorStyles.None;
            btnAgregarProducto.Location = new Point(179, 478);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(135, 44);
            btnAgregarProducto.TabIndex = 4;
            btnAgregarProducto.Text = "Agregar";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            // 
            // btnEditarProducto
            // 
            btnEditarProducto.Anchor = AnchorStyles.None;
            btnEditarProducto.Location = new Point(326, 478);
            btnEditarProducto.Name = "btnEditarProducto";
            btnEditarProducto.Size = new Size(135, 44);
            btnEditarProducto.TabIndex = 4;
            btnEditarProducto.Text = "Editar";
            btnEditarProducto.UseVisualStyleBackColor = true;
            // 
            // lblLimpiarCamporProd
            // 
            lblLimpiarCamporProd.Anchor = AnchorStyles.None;
            lblLimpiarCamporProd.AutoSize = true;
            lblLimpiarCamporProd.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            lblLimpiarCamporProd.ForeColor = Color.White;
            lblLimpiarCamporProd.Location = new Point(406, 118);
            lblLimpiarCamporProd.Name = "lblLimpiarCamporProd";
            lblLimpiarCamporProd.Size = new Size(59, 20);
            lblLimpiarCamporProd.TabIndex = 5;
            lblLimpiarCamporProd.Text = "Limpiar";
            // 
            // lblNombreProducto
            // 
            lblNombreProducto.Anchor = AnchorStyles.None;
            lblNombreProducto.AutoSize = true;
            lblNombreProducto.ForeColor = Color.White;
            lblNombreProducto.Location = new Point(72, 154);
            lblNombreProducto.Name = "lblNombreProducto";
            lblNombreProducto.Size = new Size(64, 20);
            lblNombreProducto.TabIndex = 5;
            lblNombreProducto.Text = "Nombre";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(72, 201);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 5;
            label3.Text = "Código";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(72, 260);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 5;
            label4.Text = "Descripción";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(68, 347);
            label5.Name = "label5";
            label5.Size = new Size(109, 20);
            label5.TabIndex = 5;
            label5.Text = "Cantidad Stock";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(68, 392);
            label6.Name = "label6";
            label6.Size = new Size(105, 20);
            label6.TabIndex = 5;
            label6.Text = "Precio compra";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nombre, codigo, descripcion, stock, precioCompra, precioVenta });
            dataGridView1.Location = new Point(485, 176);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(782, 389);
            dataGridView1.TabIndex = 6;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.Width = 125;
            // 
            // codigo
            // 
            codigo.HeaderText = "Código";
            codigo.MinimumWidth = 6;
            codigo.Name = "codigo";
            codigo.Width = 125;
            // 
            // descripcion
            // 
            descripcion.HeaderText = "Descripción";
            descripcion.MinimumWidth = 6;
            descripcion.Name = "descripcion";
            descripcion.Width = 125;
            // 
            // stock
            // 
            stock.HeaderText = "Stock";
            stock.MinimumWidth = 6;
            stock.Name = "stock";
            stock.Width = 125;
            // 
            // precioCompra
            // 
            precioCompra.HeaderText = "Precio Compra";
            precioCompra.MinimumWidth = 6;
            precioCompra.Name = "precioCompra";
            precioCompra.Width = 125;
            // 
            // precioVenta
            // 
            precioVenta.HeaderText = "Precio venta";
            precioVenta.MinimumWidth = 6;
            precioVenta.Name = "precioVenta";
            precioVenta.Width = 125;
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.Anchor = AnchorStyles.None;
            btnEliminarProducto.AutoSize = true;
            btnEliminarProducto.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            btnEliminarProducto.ForeColor = Color.DarkRed;
            btnEliminarProducto.Location = new Point(277, 525);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(90, 28);
            btnEliminarProducto.TabIndex = 7;
            btnEliminarProducto.Text = "Eliminar";
            // 
            // lblLine
            // 
            lblLine.Anchor = AnchorStyles.None;
            lblLine.AutoSize = true;
            lblLine.ForeColor = SystemColors.ControlDarkDark;
            lblLine.Location = new Point(122, 573);
            lblLine.Name = "lblLine";
            lblLine.Size = new Size(1155, 20);
            lblLine.TabIndex = 8;
            lblLine.Text = "_______________________________________________________________________________________________________________________________________________________________________________________________";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ControlDarkDark;
            label7.Location = new Point(112, 84);
            label7.Name = "label7";
            label7.Size = new Size(1155, 20);
            label7.TabIndex = 9;
            label7.Text = "_______________________________________________________________________________________________________________________________________________________________________________________________";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(1215, 118);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 39;
            label1.Text = "Buscar";
            // 
            // textBox6
            // 
            textBox6.Anchor = AnchorStyles.None;
            textBox6.Location = new Point(698, 141);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "Buscar por código o nombre del producto";
            textBox6.Size = new Size(569, 27);
            textBox6.TabIndex = 38;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.Anchor = AnchorStyles.None;
            iconPictureBox1.BackColor = Color.White;
            iconPictureBox1.Cursor = Cursors.Hand;
            iconPictureBox1.ForeColor = Color.Black;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            iconPictureBox1.IconColor = Color.Black;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 25;
            iconPictureBox1.Location = new Point(1232, 142);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(25, 26);
            iconPictureBox1.TabIndex = 40;
            iconPictureBox1.TabStop = false;
            // 
            // textBox7
            // 
            textBox7.Anchor = AnchorStyles.None;
            textBox7.Location = new Point(179, 436);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(282, 27);
            textBox7.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(68, 439);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 5;
            label2.Text = "Precio Venta";
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.None;
            richTextBox1.Location = new Point(183, 257);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(282, 68);
            richTextBox1.TabIndex = 41;
            richTextBox1.Text = "";
            // 
            // ProductosFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1329, 653);
            Controls.Add(richTextBox1);
            Controls.Add(iconPictureBox1);
            Controls.Add(label1);
            Controls.Add(textBox6);
            Controls.Add(label7);
            Controls.Add(lblLine);
            Controls.Add(btnEliminarProducto);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblNombreProducto);
            Controls.Add(lblLimpiarCamporProd);
            Controls.Add(btnEditarProducto);
            Controls.Add(btnAgregarProducto);
            Controls.Add(textBox7);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblTitleProducto);
            Name = "ProductosFrm";
            Text = "ProductosFrm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitleProducto;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button btnAgregarProducto;
        private Button btnEditarProducto;
        private Label lblLimpiarCamporProd;
        private Label lblNombreProducto;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DataGridView dataGridView1;
        private Label btnEliminarProducto;
        private Label lblLine;
        private Label label7;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn codigo;
        private DataGridViewTextBoxColumn descripcion;
        private DataGridViewTextBoxColumn stock;
        private DataGridViewTextBoxColumn precioCompra;
        private DataGridViewTextBoxColumn precioVenta;
        private Label label1;
        private TextBox textBox6;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private TextBox textBox7;
        private Label label2;
        private RichTextBox richTextBox1;
    }
}