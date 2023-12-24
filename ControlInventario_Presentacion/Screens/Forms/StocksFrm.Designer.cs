namespace ControlInventario_Presentacion.Screens.Forms
{
    partial class StocksFrm
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
            dataGridView1 = new DataGridView();
            Item = new DataGridViewTextBoxColumn();
            Unidad = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Niveles = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            Alerta = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            btnImprimirInforme = new Button();
            lblTitleStocks = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label1 = new Label();
            textBox6 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Item, Unidad, Cantidad, Niveles, Estado, Alerta, Total });
            dataGridView1.Location = new Point(138, 173);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(962, 461);
            dataGridView1.TabIndex = 39;
            // 
            // Item
            // 
            Item.HeaderText = "Item";
            Item.MinimumWidth = 6;
            Item.Name = "Item";
            Item.Width = 125;
            // 
            // Unidad
            // 
            Unidad.HeaderText = "Unidad";
            Unidad.MinimumWidth = 6;
            Unidad.Name = "Unidad";
            Unidad.Width = 125;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.Width = 125;
            // 
            // Niveles
            // 
            Niveles.HeaderText = "Niveles";
            Niveles.MinimumWidth = 6;
            Niveles.Name = "Niveles";
            Niveles.Width = 125;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 6;
            Estado.Name = "Estado";
            Estado.Width = 125;
            // 
            // Alerta
            // 
            Alerta.HeaderText = "Alerta";
            Alerta.MinimumWidth = 6;
            Alerta.Name = "Alerta";
            Alerta.Width = 125;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.MinimumWidth = 6;
            Total.Name = "Total";
            Total.Width = 125;
            // 
            // btnImprimirInforme
            // 
            btnImprimirInforme.Anchor = AnchorStyles.None;
            btnImprimirInforme.Location = new Point(865, 127);
            btnImprimirInforme.Name = "btnImprimirInforme";
            btnImprimirInforme.Size = new Size(235, 40);
            btnImprimirInforme.TabIndex = 38;
            btnImprimirInforme.Text = "Generar reporte";
            btnImprimirInforme.UseVisualStyleBackColor = true;
            // 
            // lblTitleStocks
            // 
            lblTitleStocks.Anchor = AnchorStyles.None;
            lblTitleStocks.AutoSize = true;
            lblTitleStocks.Font = new Font("Segoe UI Variable Display", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitleStocks.ForeColor = Color.Gainsboro;
            lblTitleStocks.Location = new Point(138, 59);
            lblTitleStocks.Name = "lblTitleStocks";
            lblTitleStocks.Size = new Size(97, 31);
            lblTitleStocks.TabIndex = 33;
            lblTitleStocks.Text = "STOCKS";
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
            iconPictureBox1.Location = new Point(672, 141);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(25, 26);
            iconPictureBox1.TabIndex = 43;
            iconPictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(138, 117);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 42;
            label1.Text = "Buscar";
            // 
            // textBox6
            // 
            textBox6.Anchor = AnchorStyles.None;
            textBox6.Location = new Point(138, 140);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "Buscar por código o nombre del producto";
            textBox6.Size = new Size(569, 27);
            textBox6.TabIndex = 41;
            // 
            // StocksFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1239, 693);
            Controls.Add(iconPictureBox1);
            Controls.Add(label1);
            Controls.Add(textBox6);
            Controls.Add(dataGridView1);
            Controls.Add(btnImprimirInforme);
            Controls.Add(lblTitleStocks);
            Name = "StocksFrm";
            Text = "StocksFrm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnImprimirInforme;
        private Label lblTitleStocks;
        private DataGridViewTextBoxColumn Item;
        private DataGridViewTextBoxColumn Unidad;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Niveles;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Alerta;
        private DataGridViewTextBoxColumn Total;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label label1;
        private TextBox textBox6;
    }
}