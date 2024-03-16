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
            lblTitleInformes = new Label();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            cbProductosInforme = new ComboBox();
            dtpFechaVenta = new DateTimePicker();
            txtCriteriosInforme = new TextBox();
            btnBuscarInforme = new Button();
            dgvInformeVentas = new DataGridView();
            btnGenerarInforme = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInformeVentas).BeginInit();
            SuspendLayout();
            // 
            // lblTitleInformes
            // 
            lblTitleInformes.AutoSize = true;
            lblTitleInformes.Font = new Font("Segoe UI Variable Display", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitleInformes.ForeColor = Color.Gainsboro;
            lblTitleInformes.Location = new Point(95, 30);
            lblTitleInformes.Name = "lblTitleInformes";
            lblTitleInformes.Size = new Size(123, 31);
            lblTitleInformes.TabIndex = 1;
            lblTitleInformes.Text = "INFORMES";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cbProductosInforme);
            groupBox1.Controls.Add(dtpFechaVenta);
            groupBox1.Controls.Add(txtCriteriosInforme);
            groupBox1.Controls.Add(btnBuscarInforme);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(116, 114);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(989, 102);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtrar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(54, 29);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 50;
            label2.Text = "Fecha Venta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(554, 28);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 50;
            label3.Text = "Criterios";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(328, 29);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 50;
            label1.Text = "Producto";
            // 
            // cbProductosInforme
            // 
            cbProductosInforme.FormattingEnabled = true;
            cbProductosInforme.Location = new Point(328, 52);
            cbProductosInforme.Name = "cbProductosInforme";
            cbProductosInforme.Size = new Size(202, 28);
            cbProductosInforme.TabIndex = 49;
            // 
            // dtpFechaVenta
            // 
            dtpFechaVenta.Location = new Point(54, 51);
            dtpFechaVenta.Name = "dtpFechaVenta";
            dtpFechaVenta.Size = new Size(250, 27);
            dtpFechaVenta.TabIndex = 48;
            // 
            // txtCriteriosInforme
            // 
            txtCriteriosInforme.Location = new Point(554, 53);
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
            btnBuscarInforme.Location = new Point(845, 51);
            btnBuscarInforme.Name = "btnBuscarInforme";
            btnBuscarInforme.Size = new Size(125, 31);
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
            dgvInformeVentas.Location = new Point(95, 223);
            dgvInformeVentas.Margin = new Padding(3, 4, 3, 4);
            dgvInformeVentas.Name = "dgvInformeVentas";
            dgvInformeVentas.ReadOnly = true;
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
            btnGenerarInforme.Location = new Point(1020, 611);
            btnGenerarInforme.Name = "btnGenerarInforme";
            btnGenerarInforme.Size = new Size(125, 31);
            btnGenerarInforme.TabIndex = 46;
            btnGenerarInforme.Text = "Generar";
            btnGenerarInforme.UseVisualStyleBackColor = false;
            btnGenerarInforme.Click += btnGenerarInforme_Click;
            // 
            // InformesFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1329, 653);
            Controls.Add(dgvInformeVentas);
            Controls.Add(groupBox1);
            Controls.Add(lblTitleInformes);
            Controls.Add(btnGenerarInforme);
            Name = "InformesFrm";
            Text = "InformesFrm";
            Load += InformesFrm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInformeVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitleInformes;
        private GroupBox groupBox1;
        private TextBox txtCriteriosInforme;
        private Button btnBuscarInforme;
        private DataGridView dgvInformeVentas;
        private DateTimePicker dtpFechaVenta;
        private Label label1;
        private ComboBox cbProductosInforme;
        private Label label2;
        private Label label3;
        private Button btnGenerarInforme;
    }
}