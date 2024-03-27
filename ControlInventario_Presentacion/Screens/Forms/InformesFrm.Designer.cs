namespace ControlInventario_Presentacion.Screens.Forms
{
    partial class InformesFrm
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblTitleInformes = new Label();
            groupBoxVentas = new GroupBox();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            cbProductosInforme = new ComboBox();
            dtpFechaVenta = new DateTimePicker();
            txtCriteriosInforme = new TextBox();
            btnBuscarInforme = new Button();
            dgvInformeVentas = new DataGridView();
            btnGenerarInforme = new Button();
            groupBox1 = new GroupBox();
            label6 = new Label();
            cbTipoInforme = new ComboBox();
            groupBoxStocks = new GroupBox();
            txtCriterioStockInforme = new TextBox();
            label5 = new Label();
            label7 = new Label();
            cbStockProductos = new ComboBox();
            groupBoxProveedores = new GroupBox();
            label4 = new Label();
            label8 = new Label();
            cbProductoproveedor = new ComboBox();
            cbProveedoresInforme = new ComboBox();
            label9 = new Label();
            groupBoxVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInformeVentas).BeginInit();
            groupBox1.SuspendLayout();
            groupBoxStocks.SuspendLayout();
            groupBoxProveedores.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitleInformes
            // 
            lblTitleInformes.AutoSize = true;
            lblTitleInformes.Font = new Font("Segoe UI Variable Text", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitleInformes.ForeColor = Color.Gainsboro;
            lblTitleInformes.Location = new Point(39, 20);
            lblTitleInformes.Name = "lblTitleInformes";
            lblTitleInformes.Size = new Size(108, 26);
            lblTitleInformes.TabIndex = 1;
            lblTitleInformes.Text = "INFORMES";
            // 
            // groupBoxVentas
            // 
            groupBoxVentas.Controls.Add(label2);
            groupBoxVentas.Controls.Add(label3);
            groupBoxVentas.Controls.Add(label1);
            groupBoxVentas.Controls.Add(cbProductosInforme);
            groupBoxVentas.Controls.Add(dtpFechaVenta);
            groupBoxVentas.Controls.Add(txtCriteriosInforme);
            groupBoxVentas.ForeColor = Color.White;
            groupBoxVentas.Location = new Point(91, 103);
            groupBoxVentas.Margin = new Padding(3, 2, 3, 2);
            groupBoxVentas.Name = "groupBoxVentas";
            groupBoxVentas.Padding = new Padding(3, 2, 3, 2);
            groupBoxVentas.Size = new Size(702, 79);
            groupBoxVentas.TabIndex = 2;
            groupBoxVentas.TabStop = false;
            groupBoxVentas.Text = "Ventas";
            groupBoxVentas.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(14, 25);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 50;
            label2.Text = "Fecha Venta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(452, 24);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 50;
            label3.Text = "Criterios";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(254, 25);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 50;
            label1.Text = "Producto";
            // 
            // cbProductosInforme
            // 
            cbProductosInforme.FormattingEnabled = true;
            cbProductosInforme.Location = new Point(254, 42);
            cbProductosInforme.Margin = new Padding(3, 2, 3, 2);
            cbProductosInforme.Name = "cbProductosInforme";
            cbProductosInforme.Size = new Size(177, 23);
            cbProductosInforme.TabIndex = 49;
            // 
            // dtpFechaVenta
            // 
            dtpFechaVenta.Location = new Point(14, 41);
            dtpFechaVenta.Margin = new Padding(3, 2, 3, 2);
            dtpFechaVenta.Name = "dtpFechaVenta";
            dtpFechaVenta.Size = new Size(219, 23);
            dtpFechaVenta.TabIndex = 48;
            // 
            // txtCriteriosInforme
            // 
            txtCriteriosInforme.Location = new Point(452, 43);
            txtCriteriosInforme.Margin = new Padding(3, 2, 3, 2);
            txtCriteriosInforme.Name = "txtCriteriosInforme";
            txtCriteriosInforme.Size = new Size(239, 23);
            txtCriteriosInforme.TabIndex = 47;
            // 
            // btnBuscarInforme
            // 
            btnBuscarInforme.BackColor = Color.FromArgb(37, 36, 81);
            btnBuscarInforme.Cursor = Cursors.Hand;
            btnBuscarInforme.FlatAppearance.BorderColor = Color.FromArgb(37, 36, 81);
            btnBuscarInforme.FlatAppearance.MouseDownBackColor = Color.SteelBlue;
            btnBuscarInforme.FlatAppearance.MouseOverBackColor = Color.MidnightBlue;
            btnBuscarInforme.FlatStyle = FlatStyle.Flat;
            btnBuscarInforme.Font = new Font("Segoe UI Variable Text", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscarInforme.ForeColor = Color.White;
            btnBuscarInforme.Location = new Point(807, 146);
            btnBuscarInforme.Margin = new Padding(3, 2, 3, 2);
            btnBuscarInforme.Name = "btnBuscarInforme";
            btnBuscarInforme.Size = new Size(203, 36);
            btnBuscarInforme.TabIndex = 46;
            btnBuscarInforme.Text = "Buscar";
            btnBuscarInforme.UseVisualStyleBackColor = false;
            btnBuscarInforme.Click += btnBuscarInforme_Click;
            // 
            // dgvInformeVentas
            // 
            dgvInformeVentas.AllowUserToAddRows = false;
            dgvInformeVentas.AllowUserToDeleteRows = false;
            dgvInformeVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInformeVentas.BackgroundColor = SystemColors.Window;
            dgvInformeVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInformeVentas.Location = new Point(91, 187);
            dgvInformeVentas.Name = "dgvInformeVentas";
            dgvInformeVentas.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.MediumTurquoise;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvInformeVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvInformeVentas.RowHeadersVisible = false;
            dgvInformeVentas.RowHeadersWidth = 51;
            dgvInformeVentas.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dgvInformeVentas.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.RosyBrown;
            dgvInformeVentas.RowTemplate.Height = 25;
            dgvInformeVentas.Size = new Size(919, 286);
            dgvInformeVentas.TabIndex = 45;
            // 
            // btnGenerarInforme
            // 
            btnGenerarInforme.BackColor = Color.ForestGreen;
            btnGenerarInforme.Cursor = Cursors.Hand;
            btnGenerarInforme.FlatAppearance.BorderColor = Color.ForestGreen;
            btnGenerarInforme.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 255, 128);
            btnGenerarInforme.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 64, 0);
            btnGenerarInforme.FlatStyle = FlatStyle.Flat;
            btnGenerarInforme.Font = new Font("Segoe UI Variable Text", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnGenerarInforme.ForeColor = Color.White;
            btnGenerarInforme.Location = new Point(1044, 443);
            btnGenerarInforme.Margin = new Padding(3, 2, 3, 2);
            btnGenerarInforme.Name = "btnGenerarInforme";
            btnGenerarInforme.Size = new Size(109, 30);
            btnGenerarInforme.TabIndex = 46;
            btnGenerarInforme.Text = "Generar";
            btnGenerarInforme.UseVisualStyleBackColor = false;
            btnGenerarInforme.Click += btnGenerarInforme_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cbTipoInforme);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(833, 20);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(320, 76);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tipo Informes";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(29, 22);
            label6.Name = "label6";
            label6.Size = new Size(89, 17);
            label6.TabIndex = 50;
            label6.Text = "Tipo Informe";
            // 
            // cbTipoInforme
            // 
            cbTipoInforme.FormattingEnabled = true;
            cbTipoInforme.Items.AddRange(new object[] { "Informe de Ventas", "Informe de Stock", "Informe de Proveedores" });
            cbTipoInforme.Location = new Point(29, 40);
            cbTipoInforme.Margin = new Padding(3, 2, 3, 2);
            cbTipoInforme.Name = "cbTipoInforme";
            cbTipoInforme.Size = new Size(271, 25);
            cbTipoInforme.TabIndex = 49;
            cbTipoInforme.Text = "Seleccione el tipo de informe...";
            cbTipoInforme.SelectedIndexChanged += cbTipoInforme_SelectedIndexChanged;
            // 
            // groupBoxStocks
            // 
            groupBoxStocks.Controls.Add(txtCriterioStockInforme);
            groupBoxStocks.Controls.Add(label5);
            groupBoxStocks.Controls.Add(label7);
            groupBoxStocks.Controls.Add(cbStockProductos);
            groupBoxStocks.ForeColor = Color.White;
            groupBoxStocks.Location = new Point(91, 103);
            groupBoxStocks.Margin = new Padding(3, 2, 3, 2);
            groupBoxStocks.Name = "groupBoxStocks";
            groupBoxStocks.Padding = new Padding(3, 2, 3, 2);
            groupBoxStocks.Size = new Size(702, 74);
            groupBoxStocks.TabIndex = 2;
            groupBoxStocks.TabStop = false;
            groupBoxStocks.Text = "Stocks";
            groupBoxStocks.Visible = false;
            // 
            // txtCriterioStockInforme
            // 
            txtCriterioStockInforme.Location = new Point(265, 43);
            txtCriterioStockInforme.Margin = new Padding(3, 2, 3, 2);
            txtCriterioStockInforme.Name = "txtCriterioStockInforme";
            txtCriterioStockInforme.Size = new Size(310, 23);
            txtCriterioStockInforme.TabIndex = 47;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(265, 23);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 50;
            label5.Text = "Criterio";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(14, 23);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 50;
            label7.Text = "Producto";
            // 
            // cbStockProductos
            // 
            cbStockProductos.FormattingEnabled = true;
            cbStockProductos.Location = new Point(14, 40);
            cbStockProductos.Margin = new Padding(3, 2, 3, 2);
            cbStockProductos.Name = "cbStockProductos";
            cbStockProductos.Size = new Size(177, 23);
            cbStockProductos.TabIndex = 49;
            // 
            // groupBoxProveedores
            // 
            groupBoxProveedores.Controls.Add(label4);
            groupBoxProveedores.Controls.Add(label8);
            groupBoxProveedores.Controls.Add(cbProductoproveedor);
            groupBoxProveedores.Controls.Add(cbProveedoresInforme);
            groupBoxProveedores.Font = new Font("Segoe UI Variable Text", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxProveedores.ForeColor = Color.White;
            groupBoxProveedores.Location = new Point(91, 103);
            groupBoxProveedores.Margin = new Padding(3, 2, 3, 2);
            groupBoxProveedores.Name = "groupBoxProveedores";
            groupBoxProveedores.Padding = new Padding(3, 2, 3, 2);
            groupBoxProveedores.Size = new Size(702, 79);
            groupBoxProveedores.TabIndex = 2;
            groupBoxProveedores.TabStop = false;
            groupBoxProveedores.Text = "Proveedores";
            groupBoxProveedores.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Text", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(240, 21);
            label4.Name = "label4";
            label4.Size = new Size(152, 20);
            label4.TabIndex = 50;
            label4.Text = "Producto Suministra";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Variable Text", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(14, 21);
            label8.Name = "label8";
            label8.Size = new Size(81, 20);
            label8.TabIndex = 50;
            label8.Text = "Proveedor";
            // 
            // cbProductoproveedor
            // 
            cbProductoproveedor.FormattingEnabled = true;
            cbProductoproveedor.Location = new Point(240, 43);
            cbProductoproveedor.Margin = new Padding(3, 2, 3, 2);
            cbProductoproveedor.Name = "cbProductoproveedor";
            cbProductoproveedor.Size = new Size(204, 28);
            cbProductoproveedor.TabIndex = 49;
            // 
            // cbProveedoresInforme
            // 
            cbProveedoresInforme.FormattingEnabled = true;
            cbProveedoresInforme.Location = new Point(14, 43);
            cbProveedoresInforme.Margin = new Padding(3, 2, 3, 2);
            cbProveedoresInforme.Name = "cbProveedoresInforme";
            cbProveedoresInforme.Size = new Size(196, 28);
            cbProveedoresInforme.TabIndex = 49;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.ControlDarkDark;
            label9.Location = new Point(35, 46);
            label9.Name = "label9";
            label9.Size = new Size(792, 15);
            label9.TabIndex = 47;
            label9.Text = "_____________________________________________________________________________________________________________________________________________________________";
            // 
            // InformesFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 27, 60);
            ClientSize = new Size(1163, 490);
            Controls.Add(label9);
            Controls.Add(dgvInformeVentas);
            Controls.Add(groupBox1);
            Controls.Add(groupBoxProveedores);
            Controls.Add(groupBoxStocks);
            Controls.Add(groupBoxVentas);
            Controls.Add(lblTitleInformes);
            Controls.Add(btnGenerarInforme);
            Controls.Add(btnBuscarInforme);
            Margin = new Padding(3, 2, 3, 2);
            Name = "InformesFrm";
            Text = "InformesFrm";
            Load += InformesFrm_Load;
            groupBoxVentas.ResumeLayout(false);
            groupBoxVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInformeVentas).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBoxStocks.ResumeLayout(false);
            groupBoxStocks.PerformLayout();
            groupBoxProveedores.ResumeLayout(false);
            groupBoxProveedores.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitleInformes;
        private GroupBox groupBoxVentas;
        private TextBox txtCriteriosInforme;
        private Button btnBuscarInforme;
        private DataGridView dgvInformeVentas;
        private DateTimePicker dtpFechaVenta;
        private Label label1;
        private ComboBox cbProductosInforme;
        private Label label2;
        private Label label3;
        private Button btnGenerarInforme;
        private GroupBox groupBox1;
        private Label label6;
        private ComboBox cbTipoInforme;
        private GroupBox groupBoxStocks;
        private Label label7;
        private ComboBox cbStockProductos;
        private GroupBox groupBoxProveedores;
        private Label label4;
        private Label label8;
        private ComboBox cbProveedoresInforme;
        private ComboBox cbProductoproveedor;
        private TextBox txtCriterioStockInforme;
        private Label label5;
        private Label label9;
    }
}