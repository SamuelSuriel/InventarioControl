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
            label7 = new Label();
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
            lblTitlePedidos.Font = new Font("Segoe UI Variable Text", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitlePedidos.ForeColor = Color.Gainsboro;
            lblTitlePedidos.Location = new Point(36, 31);
            lblTitlePedidos.Name = "lblTitlePedidos";
            lblTitlePedidos.Size = new Size(82, 26);
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
            btnBuscarStock.BackColor = Color.RoyalBlue;
            btnBuscarStock.Cursor = Cursors.Hand;
            btnBuscarStock.FlatAppearance.BorderColor = Color.RoyalBlue;
            btnBuscarStock.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            btnBuscarStock.FlatAppearance.MouseOverBackColor = Color.Navy;
            btnBuscarStock.FlatStyle = FlatStyle.Flat;
            btnBuscarStock.Font = new Font("Segoe UI Variable Text", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscarStock.ForeColor = Color.White;
            btnBuscarStock.Location = new Point(978, 124);
            btnBuscarStock.Margin = new Padding(3, 2, 3, 2);
            btnBuscarStock.Name = "btnBuscarStock";
            btnBuscarStock.Size = new Size(70, 28);
            btnBuscarStock.TabIndex = 43;
            btnBuscarStock.Text = "Buscar";
            btnBuscarStock.UseVisualStyleBackColor = false;
            btnBuscarStock.Click += btnBuscarStock_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ControlDarkDark;
            label7.Location = new Point(36, 57);
            label7.Name = "label7";
            label7.Size = new Size(962, 15);
            label7.TabIndex = 45;
            label7.Text = "_______________________________________________________________________________________________________________________________________________________________________________________________";
            // 
            // StockFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 27, 60);
            ClientSize = new Size(1084, 520);
            Controls.Add(label7);
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
        private Label label7;
    }
}