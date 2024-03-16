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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
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
            groupBoxProveedores = new GroupBox();
            label4 = new Label();
            label8 = new Label();
            cbProductoproveedor = new ComboBox();
            cbProveedoresInforme = new ComboBox();
            label7 = new Label();
            comboBox1 = new ComboBox();
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
            lblTitleInformes.Font = new Font("Segoe UI Variable Display", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitleInformes.ForeColor = Color.Gainsboro;
            lblTitleInformes.Location = new Point(45, 26);
            lblTitleInformes.Name = "lblTitleInformes";
            lblTitleInformes.Size = new Size(123, 31);
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
            groupBoxVentas.Location = new Point(104, 137);
            groupBoxVentas.Name = "groupBoxVentas";
            groupBoxVentas.Size = new Size(802, 105);
            groupBoxVentas.TabIndex = 2;
            groupBoxVentas.TabStop = false;
            groupBoxVentas.Text = "Ventas";
            groupBoxVentas.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(16, 33);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 50;
            label2.Text = "Fecha Venta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(516, 32);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 50;
            label3.Text = "Criterios";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(290, 33);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 50;
            label1.Text = "Producto";
            // 
            // cbProductosInforme
            // 
            cbProductosInforme.FormattingEnabled = true;
            cbProductosInforme.Location = new Point(290, 56);
            cbProductosInforme.Name = "cbProductosInforme";
            cbProductosInforme.Size = new Size(202, 28);
            cbProductosInforme.TabIndex = 49;
            // 
            // dtpFechaVenta
            // 
            dtpFechaVenta.Location = new Point(16, 55);
            dtpFechaVenta.Name = "dtpFechaVenta";
            dtpFechaVenta.Size = new Size(250, 27);
            dtpFechaVenta.TabIndex = 48;
            // 
            // txtCriteriosInforme
            // 
            txtCriteriosInforme.Location = new Point(516, 57);
            txtCriteriosInforme.Name = "txtCriteriosInforme";
            txtCriteriosInforme.Size = new Size(273, 27);
            txtCriteriosInforme.TabIndex = 47;
            // 
            // btnBuscarInforme
            // 
            btnBuscarInforme.BackColor = Color.FromArgb(37, 36, 81);
            btnBuscarInforme.Cursor = Cursors.Hand;
            btnBuscarInforme.FlatStyle = FlatStyle.Flat;
            btnBuscarInforme.ForeColor = Color.White;
            btnBuscarInforme.Location = new Point(922, 194);
            btnBuscarInforme.Name = "btnBuscarInforme";
            btnBuscarInforme.Size = new Size(232, 48);
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
            dgvInformeVentas.Location = new Point(104, 249);
            dgvInformeVentas.Margin = new Padding(3, 4, 3, 4);
            dgvInformeVentas.Name = "dgvInformeVentas";
            dgvInformeVentas.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.MediumTurquoise;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvInformeVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvInformeVentas.RowHeadersVisible = false;
            dgvInformeVentas.RowHeadersWidth = 51;
            dgvInformeVentas.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dgvInformeVentas.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.RosyBrown;
            dgvInformeVentas.RowTemplate.Height = 25;
            dgvInformeVentas.Size = new Size(1050, 381);
            dgvInformeVentas.TabIndex = 45;
            // 
            // btnGenerarInforme
            // 
            btnGenerarInforme.BackColor = Color.FromArgb(0, 192, 0);
            btnGenerarInforme.Cursor = Cursors.Hand;
            btnGenerarInforme.FlatStyle = FlatStyle.Flat;
            btnGenerarInforme.ForeColor = Color.White;
            btnGenerarInforme.Location = new Point(1192, 599);
            btnGenerarInforme.Name = "btnGenerarInforme";
            btnGenerarInforme.Size = new Size(125, 31);
            btnGenerarInforme.TabIndex = 46;
            btnGenerarInforme.Text = "Generar";
            btnGenerarInforme.UseVisualStyleBackColor = false;
            btnGenerarInforme.Click += btnGenerarInforme_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cbTipoInforme);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(952, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(366, 102);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tipo Informes";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(33, 30);
            label6.Name = "label6";
            label6.Size = new Size(95, 20);
            label6.TabIndex = 50;
            label6.Text = "Tipo Informe";
            // 
            // cbTipoInforme
            // 
            cbTipoInforme.FormattingEnabled = true;
            cbTipoInforme.Items.AddRange(new object[] { "Informe de Ventas", "Informe de Stock", "Informe de Proveedores" });
            cbTipoInforme.Location = new Point(33, 53);
            cbTipoInforme.Name = "cbTipoInforme";
            cbTipoInforme.Size = new Size(309, 28);
            cbTipoInforme.TabIndex = 49;
            cbTipoInforme.Text = "Seleccione el tipo de informe...";
            cbTipoInforme.SelectedIndexChanged += cbTipoInforme_SelectedIndexChanged;
            // 
            // groupBoxStocks
            // 
            groupBoxStocks.Controls.Add(txtCriterioStockInforme);
            groupBoxStocks.Controls.Add(label5);
            groupBoxStocks.Controls.Add(label7);
            groupBoxStocks.Controls.Add(comboBox1);
            groupBoxStocks.ForeColor = Color.White;
            groupBoxStocks.Location = new Point(104, 137);
            groupBoxStocks.Name = "groupBoxStocks";
            groupBoxStocks.Size = new Size(802, 99);
            groupBoxStocks.TabIndex = 2;
            groupBoxStocks.TabStop = false;
            groupBoxStocks.Text = "Stocks";
            groupBoxStocks.Visible = false;
            // 
            // txtCriterioStockInforme
            // 
            txtCriterioStockInforme.Location = new Point(303, 57);
            txtCriterioStockInforme.Name = "txtCriterioStockInforme";
            txtCriterioStockInforme.Size = new Size(354, 27);
            txtCriterioStockInforme.TabIndex = 47;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(303, 31);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 50;
            label5.Text = "Criterio";
            // 
            // groupBoxProveedores
            // 
            groupBoxProveedores.Controls.Add(label4);
            groupBoxProveedores.Controls.Add(label8);
            groupBoxProveedores.Controls.Add(cbProductoproveedor);
            groupBoxProveedores.Controls.Add(cbProveedoresInforme);
            groupBoxProveedores.ForeColor = Color.White;
            groupBoxProveedores.Location = new Point(104, 125);
            groupBoxProveedores.Name = "groupBoxProveedores";
            groupBoxProveedores.Size = new Size(802, 105);
            groupBoxProveedores.TabIndex = 2;
            groupBoxProveedores.TabStop = false;
            groupBoxProveedores.Text = "Proveedores";
            groupBoxProveedores.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(274, 34);
            label4.Name = "label4";
            label4.Size = new Size(142, 20);
            label4.TabIndex = 50;
            label4.Text = "Producto Suministra";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.White;
            label8.Location = new Point(16, 34);
            label8.Name = "label8";
            label8.Size = new Size(77, 20);
            label8.TabIndex = 50;
            label8.Text = "Proveedor";
            // 
            // cbProductoproveedor
            // 
            cbProductoproveedor.FormattingEnabled = true;
            cbProductoproveedor.Location = new Point(274, 57);
            cbProductoproveedor.Name = "cbProductoproveedor";
            cbProductoproveedor.Size = new Size(232, 28);
            cbProductoproveedor.TabIndex = 49;
            // 
            // cbProveedoresInforme
            // 
            cbProveedoresInforme.FormattingEnabled = true;
            cbProveedoresInforme.Location = new Point(16, 57);
            cbProveedoresInforme.Name = "cbProveedoresInforme";
            cbProveedoresInforme.Size = new Size(223, 28);
            cbProveedoresInforme.TabIndex = 49;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(16, 31);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 50;
            label7.Text = "Producto";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(16, 54);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(202, 28);
            comboBox1.TabIndex = 49;
            // 
            // InformesFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1329, 653);
            Controls.Add(dgvInformeVentas);
            Controls.Add(groupBox1);
            Controls.Add(groupBoxProveedores);
            Controls.Add(groupBoxStocks);
            Controls.Add(groupBoxVentas);
            Controls.Add(lblTitleInformes);
            Controls.Add(btnGenerarInforme);
            Controls.Add(btnBuscarInforme);
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
        private ComboBox comboBox1;
        private GroupBox groupBoxProveedores;
        private Label label4;
        private Label label8;
        private ComboBox cbProveedoresInforme;
        private ComboBox cbProductoproveedor;
        private TextBox txtCriterioStockInforme;
        private Label label5;
    }
}