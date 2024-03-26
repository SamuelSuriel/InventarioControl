namespace ControlInventario_Presentacion.Screens.Forms
{
    partial class PedidosFrm
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
            lblTitlePedidos = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cbProveedoresPedidos = new ComboBox();
            dtpFechaPedido = new DateTimePicker();
            txtCantidadProductos = new TextBox();
            dgvPedidosProveedores = new DataGridView();
            btnEliminarPedido = new Label();
            btnEditarPedido = new Button();
            btnGuardarPedido = new Button();
            btnLimpiarCamposPedido = new Label();
            label4 = new Label();
            cbProdPedidos = new ComboBox();
            label5 = new Label();
            cbEstatusPedido = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvPedidosProveedores).BeginInit();
            SuspendLayout();
            // 
            // lblTitlePedidos
            // 
            lblTitlePedidos.AutoSize = true;
            lblTitlePedidos.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitlePedidos.ForeColor = Color.Gainsboro;
            lblTitlePedidos.Location = new Point(60, 39);
            lblTitlePedidos.Name = "lblTitlePedidos";
            lblTitlePedidos.Size = new Size(92, 24);
            lblTitlePedidos.TabIndex = 2;
            lblTitlePedidos.Text = "PEDIDOS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.ForeColor = Color.White;
            label3.Location = new Point(56, 308);
            label3.Name = "label3";
            label3.Size = new Size(135, 15);
            label3.TabIndex = 7;
            label3.Text = "CANTIDAD PRODUCTOS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.ForeColor = Color.White;
            label2.Location = new Point(56, 265);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 8;
            label2.Text = "FECHA PEDIDO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.ForeColor = Color.White;
            label1.Location = new Point(56, 143);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 9;
            label1.Text = "PROVEEDOR";
            // 
            // cbProveedoresPedidos
            // 
            cbProveedoresPedidos.FormattingEnabled = true;
            cbProveedoresPedidos.Location = new Point(201, 143);
            cbProveedoresPedidos.Margin = new Padding(3, 2, 3, 2);
            cbProveedoresPedidos.Name = "cbProveedoresPedidos";
            cbProveedoresPedidos.Size = new Size(234, 23);
            cbProveedoresPedidos.TabIndex = 17;
            cbProveedoresPedidos.SelectedIndexChanged += cbProveedoresPedidos_SelectedIndexChanged;
            // 
            // dtpFechaPedido
            // 
            dtpFechaPedido.Location = new Point(201, 265);
            dtpFechaPedido.Name = "dtpFechaPedido";
            dtpFechaPedido.Size = new Size(200, 23);
            dtpFechaPedido.TabIndex = 18;
            // 
            // txtCantidadProductos
            // 
            txtCantidadProductos.Location = new Point(201, 308);
            txtCantidadProductos.Name = "txtCantidadProductos";
            txtCantidadProductos.Size = new Size(93, 23);
            txtCantidadProductos.TabIndex = 19;
            // 
            // dgvPedidosProveedores
            // 
            dgvPedidosProveedores.AllowUserToAddRows = false;
            dgvPedidosProveedores.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 192, 255);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dgvPedidosProveedores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvPedidosProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPedidosProveedores.BackgroundColor = SystemColors.Window;
            dgvPedidosProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedidosProveedores.Location = new Point(473, 103);
            dgvPedidosProveedores.Name = "dgvPedidosProveedores";
            dgvPedidosProveedores.ReadOnly = true;
            dgvPedidosProveedores.RowHeadersVisible = false;
            dgvPedidosProveedores.RowTemplate.Height = 25;
            dgvPedidosProveedores.Size = new Size(630, 344);
            dgvPedidosProveedores.TabIndex = 20;
            // 
            // btnEliminarPedido
            // 
            btnEliminarPedido.AutoSize = true;
            btnEliminarPedido.Cursor = Cursors.Hand;
            btnEliminarPedido.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            btnEliminarPedido.ForeColor = Color.Red;
            btnEliminarPedido.Location = new Point(263, 418);
            btnEliminarPedido.Name = "btnEliminarPedido";
            btnEliminarPedido.Size = new Size(74, 21);
            btnEliminarPedido.TabIndex = 28;
            btnEliminarPedido.Text = "Eliminar";
            btnEliminarPedido.Click += btnEliminarPedido_Click;
            // 
            // btnEditarPedido
            // 
            btnEditarPedido.BackColor = Color.DarkOrange;
            btnEditarPedido.Cursor = Cursors.Hand;
            btnEditarPedido.ForeColor = Color.White;
            btnEditarPedido.Location = new Point(317, 355);
            btnEditarPedido.Margin = new Padding(3, 2, 3, 2);
            btnEditarPedido.Name = "btnEditarPedido";
            btnEditarPedido.Size = new Size(118, 33);
            btnEditarPedido.TabIndex = 26;
            btnEditarPedido.Text = "Editar";
            btnEditarPedido.UseVisualStyleBackColor = false;
            btnEditarPedido.Click += btnEditarPedido_Click;
            // 
            // btnGuardarPedido
            // 
            btnGuardarPedido.BackColor = Color.ForestGreen;
            btnGuardarPedido.Cursor = Cursors.Hand;
            btnGuardarPedido.ForeColor = Color.White;
            btnGuardarPedido.Location = new Point(163, 355);
            btnGuardarPedido.Margin = new Padding(3, 2, 3, 2);
            btnGuardarPedido.Name = "btnGuardarPedido";
            btnGuardarPedido.Size = new Size(118, 33);
            btnGuardarPedido.TabIndex = 27;
            btnGuardarPedido.Text = "Guardar";
            btnGuardarPedido.UseVisualStyleBackColor = false;
            btnGuardarPedido.Click += btnGuardarPedido_Click;
            // 
            // btnLimpiarCamposPedido
            // 
            btnLimpiarCamposPedido.AutoSize = true;
            btnLimpiarCamposPedido.Cursor = Cursors.Hand;
            btnLimpiarCamposPedido.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            btnLimpiarCamposPedido.ForeColor = Color.White;
            btnLimpiarCamposPedido.Location = new Point(370, 103);
            btnLimpiarCamposPedido.Name = "btnLimpiarCamposPedido";
            btnLimpiarCamposPedido.Size = new Size(47, 15);
            btnLimpiarCamposPedido.TabIndex = 29;
            btnLimpiarCamposPedido.Text = "Limpiar";
            btnLimpiarCamposPedido.Click += btnLimpiarCamposPedido_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Black;
            label4.ForeColor = Color.White;
            label4.Location = new Point(56, 184);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 9;
            label4.Text = "PRODUCTO";
            // 
            // cbProdPedidos
            // 
            cbProdPedidos.FormattingEnabled = true;
            cbProdPedidos.Location = new Point(201, 184);
            cbProdPedidos.Margin = new Padding(3, 2, 3, 2);
            cbProdPedidos.Name = "cbProdPedidos";
            cbProdPedidos.Size = new Size(234, 23);
            cbProdPedidos.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Black;
            label5.ForeColor = Color.White;
            label5.Location = new Point(56, 225);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 9;
            label5.Text = "ESTATUS";
            // 
            // cbEstatusPedido
            // 
            cbEstatusPedido.FormattingEnabled = true;
            cbEstatusPedido.Location = new Point(201, 225);
            cbEstatusPedido.Margin = new Padding(3, 2, 3, 2);
            cbEstatusPedido.Name = "cbEstatusPedido";
            cbEstatusPedido.Size = new Size(234, 23);
            cbEstatusPedido.TabIndex = 17;
            // 
            // PedidosFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1015, 490);
            Controls.Add(btnLimpiarCamposPedido);
            Controls.Add(btnEliminarPedido);
            Controls.Add(btnEditarPedido);
            Controls.Add(btnGuardarPedido);
            Controls.Add(dgvPedidosProveedores);
            Controls.Add(txtCantidadProductos);
            Controls.Add(dtpFechaPedido);
            Controls.Add(cbEstatusPedido);
            Controls.Add(cbProdPedidos);
            Controls.Add(cbProveedoresPedidos);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblTitlePedidos);
            Margin = new Padding(3, 2, 3, 2);
            Name = "PedidosFrm";
            Text = "PedidosFrm";
            Load += PedidosFrm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPedidosProveedores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitlePedidos;
        private DataGridView dataGridView1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cbProveedoresPedidos;
        private DateTimePicker dtpFechaPedido;
        private TextBox txtCantidadProductos;
        private DataGridView dgvPedidosProveedores;
        private Label btnEliminarPedido;
        private Button btnEditarPedido;
        private Button btnGuardarPedido;
        private Label btnLimpiarCamposPedido;
        private Label label4;
        private ComboBox cbProdPedidos;
        private Label label5;
        private ComboBox cbEstatusPedido;
    }
}