namespace ControlInventario_Presentacion.Screens.Forms
{
    partial class StockFrm
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
            btnLimpiarCamposPedido = new Label();
            btnEliminarPedido = new Label();
            btnEditarPedido = new Button();
            btnGuardarPedido = new Button();
            dgvStocks = new DataGridView();
            dtpFechaPedido = new DateTimePicker();
            cbProveedoresPedidos = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblTitlePedidos = new Label();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dgvStocks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // btnLimpiarCamposPedido
            // 
            btnLimpiarCamposPedido.AutoSize = true;
            btnLimpiarCamposPedido.Cursor = Cursors.Hand;
            btnLimpiarCamposPedido.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            btnLimpiarCamposPedido.ForeColor = Color.White;
            btnLimpiarCamposPedido.Location = new Point(1001, 128);
            btnLimpiarCamposPedido.Name = "btnLimpiarCamposPedido";
            btnLimpiarCamposPedido.Size = new Size(47, 15);
            btnLimpiarCamposPedido.TabIndex = 41;
            btnLimpiarCamposPedido.Text = "Limpiar";
            // 
            // btnEliminarPedido
            // 
            btnEliminarPedido.AutoSize = true;
            btnEliminarPedido.Cursor = Cursors.Hand;
            btnEliminarPedido.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            btnEliminarPedido.ForeColor = Color.Red;
            btnEliminarPedido.Location = new Point(294, 475);
            btnEliminarPedido.Name = "btnEliminarPedido";
            btnEliminarPedido.Size = new Size(74, 21);
            btnEliminarPedido.TabIndex = 40;
            btnEliminarPedido.Text = "Eliminar";
            // 
            // btnEditarPedido
            // 
            btnEditarPedido.BackColor = Color.DarkOrange;
            btnEditarPedido.Cursor = Cursors.Hand;
            btnEditarPedido.ForeColor = Color.White;
            btnEditarPedido.Location = new Point(151, 463);
            btnEditarPedido.Margin = new Padding(3, 2, 3, 2);
            btnEditarPedido.Name = "btnEditarPedido";
            btnEditarPedido.Size = new Size(118, 33);
            btnEditarPedido.TabIndex = 38;
            btnEditarPedido.Text = "Editar";
            btnEditarPedido.UseVisualStyleBackColor = false;
            // 
            // btnGuardarPedido
            // 
            btnGuardarPedido.BackColor = Color.ForestGreen;
            btnGuardarPedido.Cursor = Cursors.Hand;
            btnGuardarPedido.ForeColor = Color.White;
            btnGuardarPedido.Location = new Point(23, 463);
            btnGuardarPedido.Margin = new Padding(3, 2, 3, 2);
            btnGuardarPedido.Name = "btnGuardarPedido";
            btnGuardarPedido.Size = new Size(118, 33);
            btnGuardarPedido.TabIndex = 39;
            btnGuardarPedido.Text = "Guardar";
            btnGuardarPedido.UseVisualStyleBackColor = false;
            // 
            // dgvStocks
            // 
            dgvStocks.AllowUserToAddRows = false;
            dgvStocks.AllowUserToDeleteRows = false;
            dgvStocks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStocks.BackgroundColor = SystemColors.Window;
            dgvStocks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStocks.ColumnHeadersVisible = false;
            dgvStocks.Location = new Point(275, 161);
            dgvStocks.Name = "dgvStocks";
            dgvStocks.ReadOnly = true;
            dgvStocks.RowHeadersVisible = false;
            dgvStocks.RowTemplate.Height = 25;
            dgvStocks.Size = new Size(773, 303);
            dgvStocks.TabIndex = 37;
            // 
            // dtpFechaPedido
            // 
            dtpFechaPedido.Location = new Point(648, 72);
            dtpFechaPedido.Name = "dtpFechaPedido";
            dtpFechaPedido.Size = new Size(200, 23);
            dtpFechaPedido.TabIndex = 35;
            // 
            // cbProveedoresPedidos
            // 
            cbProveedoresPedidos.FormattingEnabled = true;
            cbProveedoresPedidos.Location = new Point(275, 72);
            cbProveedoresPedidos.Margin = new Padding(3, 2, 3, 2);
            cbProveedoresPedidos.Name = "cbProveedoresPedidos";
            cbProveedoresPedidos.Size = new Size(234, 23);
            cbProveedoresPedidos.TabIndex = 34;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.ForeColor = Color.White;
            label3.Location = new Point(148, 120);
            label3.Name = "label3";
            label3.Size = new Size(112, 15);
            label3.TabIndex = 31;
            label3.Text = "Cantidad Productos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.ForeColor = Color.White;
            label2.Location = new Point(521, 72);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 32;
            label2.Text = "Fecha Pedido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.ForeColor = Color.White;
            label1.Location = new Point(148, 72);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 33;
            label1.Text = "Proveedor";
            // 
            // lblTitlePedidos
            // 
            lblTitlePedidos.AutoSize = true;
            lblTitlePedidos.Font = new Font("Segoe UI Variable Display", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitlePedidos.ForeColor = Color.Gainsboro;
            lblTitlePedidos.Location = new Point(36, 56);
            lblTitlePedidos.Name = "lblTitlePedidos";
            lblTitlePedidos.Size = new Size(81, 26);
            lblTitlePedidos.TabIndex = 30;
            lblTitlePedidos.Text = "STOCKS";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(288, 120);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(80, 23);
            numericUpDown1.TabIndex = 42;
            // 
            // StockFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1084, 520);
            Controls.Add(numericUpDown1);
            Controls.Add(btnLimpiarCamposPedido);
            Controls.Add(btnEliminarPedido);
            Controls.Add(btnEditarPedido);
            Controls.Add(btnGuardarPedido);
            Controls.Add(dgvStocks);
            Controls.Add(dtpFechaPedido);
            Controls.Add(cbProveedoresPedidos);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblTitlePedidos);
            Name = "StockFrm";
            Text = "StockFrm";
            Load += StockFrm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStocks).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label btnLimpiarCamposPedido;
        private Label btnEliminarPedido;
        private Button btnEditarPedido;
        private Button btnGuardarPedido;
        private DataGridView dgvStocks;
        private DateTimePicker dtpFechaPedido;
        private ComboBox cbProveedoresPedidos;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblTitlePedidos;
        private NumericUpDown numericUpDown1;
    }
}