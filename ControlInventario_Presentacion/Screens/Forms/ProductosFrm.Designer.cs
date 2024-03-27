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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            lblTitleProducto = new Label();
            txtNombreProducto = new TextBox();
            txtCodigoProducto = new TextBox();
            txtDescripcion = new TextBox();
            txtCantidadStock = new TextBox();
            txtPrecioCompra = new TextBox();
            btnAgregarProducto = new Button();
            btnEditarProducto = new Button();
            lblLimpiarCamporProd = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dgvProductos = new DataGridView();
            productosBindingSource = new BindingSource(components);
            btnEliminarProducto = new Label();
            lblLine = new Label();
            label7 = new Label();
            label1 = new Label();
            txtPrecioVenta = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productosBindingSource).BeginInit();
            SuspendLayout();
            // 
            // lblTitleProducto
            // 
            lblTitleProducto.AutoSize = true;
            lblTitleProducto.Font = new Font("Segoe UI Variable Text", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitleProducto.ForeColor = Color.Gainsboro;
            lblTitleProducto.Location = new Point(54, 30);
            lblTitleProducto.Name = "lblTitleProducto";
            lblTitleProducto.Size = new Size(138, 28);
            lblTitleProducto.TabIndex = 2;
            lblTitleProducto.Text = "PRODUCTOS";
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Cursor = Cursors.IBeam;
            txtNombreProducto.Location = new Point(159, 133);
            txtNombreProducto.Margin = new Padding(3, 2, 3, 2);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(247, 23);
            txtNombreProducto.TabIndex = 3;
            // 
            // txtCodigoProducto
            // 
            txtCodigoProducto.Cursor = Cursors.IBeam;
            txtCodigoProducto.Location = new Point(159, 167);
            txtCodigoProducto.Margin = new Padding(3, 2, 3, 2);
            txtCodigoProducto.Name = "txtCodigoProducto";
            txtCodigoProducto.Size = new Size(247, 23);
            txtCodigoProducto.TabIndex = 3;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Cursor = Cursors.IBeam;
            txtDescripcion.Location = new Point(159, 202);
            txtDescripcion.Margin = new Padding(3, 2, 3, 2);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(247, 53);
            txtDescripcion.TabIndex = 3;
            // 
            // txtCantidadStock
            // 
            txtCantidadStock.Cursor = Cursors.IBeam;
            txtCantidadStock.Location = new Point(159, 271);
            txtCantidadStock.Margin = new Padding(3, 2, 3, 2);
            txtCantidadStock.Name = "txtCantidadStock";
            txtCantidadStock.Size = new Size(71, 23);
            txtCantidadStock.TabIndex = 3;
            // 
            // txtPrecioCompra
            // 
            txtPrecioCompra.Cursor = Cursors.IBeam;
            txtPrecioCompra.Location = new Point(159, 305);
            txtPrecioCompra.Margin = new Padding(3, 2, 3, 2);
            txtPrecioCompra.Name = "txtPrecioCompra";
            txtPrecioCompra.Size = new Size(160, 23);
            txtPrecioCompra.TabIndex = 3;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.BackColor = Color.ForestGreen;
            btnAgregarProducto.Cursor = Cursors.Hand;
            btnAgregarProducto.FlatAppearance.BorderColor = Color.ForestGreen;
            btnAgregarProducto.FlatAppearance.MouseDownBackColor = Color.MediumSeaGreen;
            btnAgregarProducto.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 64, 0);
            btnAgregarProducto.FlatStyle = FlatStyle.Flat;
            btnAgregarProducto.Font = new Font("Segoe UI Variable Text", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarProducto.ForeColor = Color.White;
            btnAgregarProducto.Location = new Point(112, 377);
            btnAgregarProducto.Margin = new Padding(3, 2, 3, 2);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(132, 33);
            btnAgregarProducto.TabIndex = 4;
            btnAgregarProducto.Text = "Guardar";
            btnAgregarProducto.UseVisualStyleBackColor = false;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // btnEditarProducto
            // 
            btnEditarProducto.BackColor = Color.DarkOrange;
            btnEditarProducto.Cursor = Cursors.Hand;
            btnEditarProducto.FlatAppearance.BorderColor = Color.DarkOrange;
            btnEditarProducto.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 128);
            btnEditarProducto.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 64, 0);
            btnEditarProducto.FlatStyle = FlatStyle.Flat;
            btnEditarProducto.Font = new Font("Segoe UI Variable Text", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditarProducto.ForeColor = Color.White;
            btnEditarProducto.Location = new Point(274, 377);
            btnEditarProducto.Margin = new Padding(3, 2, 3, 2);
            btnEditarProducto.Name = "btnEditarProducto";
            btnEditarProducto.Size = new Size(132, 33);
            btnEditarProducto.TabIndex = 4;
            btnEditarProducto.Text = "Editar";
            btnEditarProducto.UseVisualStyleBackColor = false;
            btnEditarProducto.Click += btnEditarProducto_Click;
            // 
            // lblLimpiarCamporProd
            // 
            lblLimpiarCamporProd.AutoSize = true;
            lblLimpiarCamporProd.BackColor = Color.Gray;
            lblLimpiarCamporProd.Cursor = Cursors.Hand;
            lblLimpiarCamporProd.Font = new Font("Segoe UI Variable Text", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblLimpiarCamporProd.ForeColor = Color.White;
            lblLimpiarCamporProd.Location = new Point(344, 102);
            lblLimpiarCamporProd.Name = "lblLimpiarCamporProd";
            lblLimpiarCamporProd.Size = new Size(62, 20);
            lblLimpiarCamporProd.TabIndex = 5;
            lblLimpiarCamporProd.Text = "Limpiar";
            lblLimpiarCamporProd.Click += lblLimpiarCamporProd_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(27, 137);
            label2.Name = "label2";
            label2.Size = new Size(65, 19);
            label2.TabIndex = 5;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(27, 171);
            label3.Name = "label3";
            label3.Size = new Size(56, 19);
            label3.TabIndex = 5;
            label3.Text = "Código";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(27, 218);
            label4.Name = "label4";
            label4.Size = new Size(88, 19);
            label4.TabIndex = 5;
            label4.Text = "Descripción";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(27, 271);
            label5.Name = "label5";
            label5.Size = new Size(111, 19);
            label5.TabIndex = 5;
            label5.Text = "Cantidad Stock";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(27, 305);
            label6.Name = "label6";
            label6.Size = new Size(109, 19);
            label6.TabIndex = 5;
            label6.Text = "Precio Compra";
            // 
            // dgvProductos
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 192, 128);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dgvProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.BackgroundColor = Color.White;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.GridColor = SystemColors.Window;
            dgvProductos.Location = new Point(424, 132);
            dgvProductos.Margin = new Padding(3, 2, 3, 2);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersVisible = false;
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.RowTemplate.Height = 29;
            dgvProductos.Size = new Size(684, 292);
            dgvProductos.TabIndex = 6;
            // 
            // productosBindingSource
            // 
            productosBindingSource.DataSource = typeof(ControlInventario_Datos.Productos);
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.BackColor = Color.Firebrick;
            btnEliminarProducto.Cursor = Cursors.Hand;
            btnEliminarProducto.Font = new Font("Segoe UI Variable Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminarProducto.ForeColor = Color.White;
            btnEliminarProducto.Location = new Point(212, 422);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(91, 26);
            btnEliminarProducto.TabIndex = 7;
            btnEliminarProducto.Text = "  Eliminar";
            btnEliminarProducto.Click += btnEliminarProducto_Click;
            // 
            // lblLine
            // 
            lblLine.AutoSize = true;
            lblLine.ForeColor = SystemColors.ControlDarkDark;
            lblLine.Location = new Point(54, 448);
            lblLine.Name = "lblLine";
            lblLine.Size = new Size(962, 15);
            lblLine.TabIndex = 8;
            lblLine.Text = "_______________________________________________________________________________________________________________________________________________________________________________________________";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ControlDarkDark;
            label7.Location = new Point(54, 56);
            label7.Name = "label7";
            label7.Size = new Size(962, 15);
            label7.TabIndex = 9;
            label7.Text = "_______________________________________________________________________________________________________________________________________________________________________________________________";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(27, 339);
            label1.Name = "label1";
            label1.Size = new Size(95, 19);
            label1.TabIndex = 11;
            label1.Text = "Precio Venta";
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Cursor = Cursors.IBeam;
            txtPrecioVenta.Location = new Point(159, 339);
            txtPrecioVenta.Margin = new Padding(3, 2, 3, 2);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(160, 23);
            txtPrecioVenta.TabIndex = 10;
            // 
            // ProductosFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 27, 60);
            ClientSize = new Size(1163, 490);
            Controls.Add(label1);
            Controls.Add(txtPrecioVenta);
            Controls.Add(label7);
            Controls.Add(lblLine);
            Controls.Add(btnEliminarProducto);
            Controls.Add(dgvProductos);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblLimpiarCamporProd);
            Controls.Add(btnEditarProducto);
            Controls.Add(btnAgregarProducto);
            Controls.Add(txtPrecioCompra);
            Controls.Add(txtCantidadStock);
            Controls.Add(txtDescripcion);
            Controls.Add(txtCodigoProducto);
            Controls.Add(txtNombreProducto);
            Controls.Add(lblTitleProducto);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ProductosFrm";
            Text = "ProductosFrm";
            Load += ProductosFrm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)productosBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitleProducto;
        private TextBox txtNombreProducto;
        private TextBox txtCodigoProducto;
        private TextBox txtDescripcion;
        private TextBox txtCantidadStock;
        private TextBox txtPrecioCompra;
        private Button btnAgregarProducto;
        private Button btnEditarProducto;
        private Label lblLimpiarCamporProd;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DataGridView dgvProductos;
        private Label btnEliminarProducto;
        private Label lblLine;
        private Label label7;
        private BindingSource productosBindingSource;
        private Label label1;
        private TextBox txtPrecioVenta;
    }
}