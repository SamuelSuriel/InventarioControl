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
            dgvStocks = new DataGridView();
            lblTitlePedidos = new Label();
            txtBuscarStock = new TextBox();
            btnBuscarStock = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStocks).BeginInit();
            SuspendLayout();
            // 
            // dgvStocks
            // 
            dgvStocks.AllowUserToAddRows = false;
            dgvStocks.AllowUserToDeleteRows = false;
            dgvStocks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStocks.BackgroundColor = SystemColors.Window;
            dgvStocks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStocks.Location = new Point(36, 161);
            dgvStocks.Name = "dgvStocks";
            dgvStocks.ReadOnly = true;
            dgvStocks.RowHeadersVisible = false;
            dgvStocks.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dgvStocks.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.RosyBrown;
            dgvStocks.RowTemplate.Height = 25;
            dgvStocks.Size = new Size(1012, 347);
            dgvStocks.TabIndex = 37;
            // 
            // lblTitlePedidos
            // 
            lblTitlePedidos.AutoSize = true;
            lblTitlePedidos.Font = new Font("Segoe UI Variable Display", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitlePedidos.ForeColor = Color.Gainsboro;
            lblTitlePedidos.Location = new Point(36, 31);
            lblTitlePedidos.Name = "lblTitlePedidos";
            lblTitlePedidos.Size = new Size(81, 26);
            lblTitlePedidos.TabIndex = 30;
            lblTitlePedidos.Text = "STOCKS";
            // 
            // txtBuscarStock
            // 
            txtBuscarStock.Location = new Point(36, 128);
            txtBuscarStock.Margin = new Padding(3, 2, 3, 2);
            txtBuscarStock.Name = "txtBuscarStock";
            txtBuscarStock.Size = new Size(936, 23);
            txtBuscarStock.TabIndex = 44;
            // 
            // btnBuscarStock
            // 
            btnBuscarStock.Cursor = Cursors.Hand;
            btnBuscarStock.ForeColor = SystemColors.ActiveCaption;
            btnBuscarStock.Location = new Point(978, 128);
            btnBuscarStock.Margin = new Padding(3, 2, 3, 2);
            btnBuscarStock.Name = "btnBuscarStock";
            btnBuscarStock.Size = new Size(70, 23);
            btnBuscarStock.TabIndex = 43;
            btnBuscarStock.Text = "Buscar";
            btnBuscarStock.UseVisualStyleBackColor = true;
            btnBuscarStock.Click += btnBuscarStock_Click;
            // 
            // StockFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1084, 520);
            Controls.Add(txtBuscarStock);
            Controls.Add(btnBuscarStock);
            Controls.Add(dgvStocks);
            Controls.Add(lblTitlePedidos);
            Name = "StockFrm";
            Text = "StockFrm";
            Load += StockFrm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStocks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvStocks;
        private Label lblTitlePedidos;
        private TextBox txtBuscarStock;
        private Button btnBuscarStock;
    }
}