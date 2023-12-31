namespace ControlInventario_Presentacion.Screens.Forms
{
    partial class ProveedoresFrm
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
            lblTitleProveedores = new Label();
            dataGridView1 = new DataGridView();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            btnEliminarProveedor = new Label();
            btnEditarProveedor = new Button();
            btnAgregarProveedor = new Button();
            label7 = new Label();
            lblLine = new Label();
            lblLimpiarProv = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label8 = new Label();
            textBox6 = new TextBox();
            Pedidos = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Proveedor = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTitleProveedores
            // 
            lblTitleProveedores.Anchor = AnchorStyles.None;
            lblTitleProveedores.AutoSize = true;
            lblTitleProveedores.Font = new Font("Segoe UI Variable Display", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitleProveedores.ForeColor = Color.Gainsboro;
            lblTitleProveedores.Location = new Point(87, 61);
            lblTitleProveedores.Name = "lblTitleProveedores";
            lblTitleProveedores.Size = new Size(164, 31);
            lblTitleProveedores.TabIndex = 2;
            lblTitleProveedores.Text = "PROVEEDORES";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Pedidos, Fecha, Proveedor });
            dataGridView1.Location = new Point(673, 194);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(569, 389);
            dataGridView1.TabIndex = 22;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(143, 380);
            label6.Name = "label6";
            label6.Size = new Size(175, 20);
            label6.TabIndex = 16;
            label6.Text = "Productos que suministra";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(143, 335);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 17;
            label5.Text = "Correo";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(143, 291);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 18;
            label4.Text = "Teléfono";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(143, 241);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 19;
            label3.Text = "Dirección";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(143, 202);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 20;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(143, 142);
            label1.Name = "label1";
            label1.Size = new Size(91, 28);
            label1.TabIndex = 21;
            label1.Text = "Registro";
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.None;
            textBox5.Location = new Point(361, 380);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(282, 27);
            textBox5.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.None;
            textBox4.Location = new Point(361, 335);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(282, 27);
            textBox4.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.None;
            textBox3.Location = new Point(361, 288);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(282, 27);
            textBox3.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Location = new Point(361, 241);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(282, 27);
            textBox2.TabIndex = 11;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(361, 195);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(282, 27);
            textBox1.TabIndex = 12;
            // 
            // btnEliminarProveedor
            // 
            btnEliminarProveedor.Anchor = AnchorStyles.None;
            btnEliminarProveedor.AutoSize = true;
            btnEliminarProveedor.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            btnEliminarProveedor.ForeColor = Color.DarkRed;
            btnEliminarProveedor.Location = new Point(459, 525);
            btnEliminarProveedor.Name = "btnEliminarProveedor";
            btnEliminarProveedor.Size = new Size(90, 28);
            btnEliminarProveedor.TabIndex = 25;
            btnEliminarProveedor.Text = "Eliminar";
            // 
            // btnEditarProveedor
            // 
            btnEditarProveedor.Anchor = AnchorStyles.None;
            btnEditarProveedor.Location = new Point(508, 469);
            btnEditarProveedor.Name = "btnEditarProveedor";
            btnEditarProveedor.Size = new Size(135, 44);
            btnEditarProveedor.TabIndex = 23;
            btnEditarProveedor.Text = "Editar";
            btnEditarProveedor.UseVisualStyleBackColor = true;
            // 
            // btnAgregarProveedor
            // 
            btnAgregarProveedor.Anchor = AnchorStyles.None;
            btnAgregarProveedor.Location = new Point(361, 469);
            btnAgregarProveedor.Name = "btnAgregarProveedor";
            btnAgregarProveedor.Size = new Size(135, 44);
            btnAgregarProveedor.TabIndex = 24;
            btnAgregarProveedor.Text = "Agregar";
            btnAgregarProveedor.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ControlDarkDark;
            label7.Location = new Point(87, 110);
            label7.Name = "label7";
            label7.Size = new Size(1155, 20);
            label7.TabIndex = 27;
            label7.Text = "_______________________________________________________________________________________________________________________________________________________________________________________________";
            // 
            // lblLine
            // 
            lblLine.Anchor = AnchorStyles.None;
            lblLine.AutoSize = true;
            lblLine.ForeColor = SystemColors.ControlDarkDark;
            lblLine.Location = new Point(87, 603);
            lblLine.Name = "lblLine";
            lblLine.Size = new Size(1155, 20);
            lblLine.TabIndex = 26;
            lblLine.Text = "_______________________________________________________________________________________________________________________________________________________________________________________________";
            // 
            // lblLimpiarProv
            // 
            lblLimpiarProv.Anchor = AnchorStyles.None;
            lblLimpiarProv.AutoSize = true;
            lblLimpiarProv.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            lblLimpiarProv.ForeColor = Color.White;
            lblLimpiarProv.Location = new Point(584, 172);
            lblLimpiarProv.Name = "lblLimpiarProv";
            lblLimpiarProv.Size = new Size(59, 20);
            lblLimpiarProv.TabIndex = 21;
            lblLimpiarProv.Text = "Limpiar";
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
            iconPictureBox1.Location = new Point(1207, 166);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(25, 26);
            iconPictureBox1.TabIndex = 43;
            iconPictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.ForeColor = Color.White;
            label8.Location = new Point(1190, 142);
            label8.Name = "label8";
            label8.Size = new Size(52, 20);
            label8.TabIndex = 42;
            label8.Text = "Buscar";
            // 
            // textBox6
            // 
            textBox6.Anchor = AnchorStyles.None;
            textBox6.Location = new Point(673, 165);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "Buscar por código o nombre del proveedor";
            textBox6.Size = new Size(569, 27);
            textBox6.TabIndex = 41;
            // 
            // Pedidos
            // 
            Pedidos.HeaderText = "Pedidos";
            Pedidos.MinimumWidth = 6;
            Pedidos.Name = "Pedidos";
            Pedidos.Width = 125;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.MinimumWidth = 6;
            Fecha.Name = "Fecha";
            Fecha.Width = 125;
            // 
            // Proveedor
            // 
            Proveedor.HeaderText = "Proveedor";
            Proveedor.MinimumWidth = 6;
            Proveedor.Name = "Proveedor";
            Proveedor.Width = 125;
            // 
            // ProveedoresFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1329, 653);
            Controls.Add(iconPictureBox1);
            Controls.Add(label8);
            Controls.Add(textBox6);
            Controls.Add(label7);
            Controls.Add(lblLine);
            Controls.Add(btnEliminarProveedor);
            Controls.Add(btnEditarProveedor);
            Controls.Add(btnAgregarProveedor);
            Controls.Add(dataGridView1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblLimpiarProv);
            Controls.Add(label1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblTitleProveedores);
            Name = "ProveedoresFrm";
            Text = "ProveedoresFrm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitleProveedores;
        private DataGridView dataGridView1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label btnEliminarProveedor;
        private Button btnEditarProveedor;
        private Button btnAgregarProveedor;
        private Label label7;
        private Label lblLine;
        private Label lblLimpiarProv;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label label8;
        private TextBox textBox6;
        private DataGridViewTextBoxColumn Pedidos;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Proveedor;
    }
}