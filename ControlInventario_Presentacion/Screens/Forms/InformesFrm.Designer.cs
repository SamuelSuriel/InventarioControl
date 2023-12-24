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
            dataGridView1 = new DataGridView();
            Item = new DataGridViewTextBoxColumn();
            Unidad = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            Descuento = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            btnImprimirInforme = new Button();
            lblCantidad = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblTitleInformes
            // 
            lblTitleInformes.Anchor = AnchorStyles.None;
            lblTitleInformes.AutoSize = true;
            lblTitleInformes.Font = new Font("Segoe UI Variable Display", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitleInformes.ForeColor = Color.Gainsboro;
            lblTitleInformes.Location = new Point(171, 43);
            lblTitleInformes.Name = "lblTitleInformes";
            lblTitleInformes.Size = new Size(123, 31);
            lblTitleInformes.TabIndex = 1;
            lblTitleInformes.Text = "INFORMES";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Item, Unidad, Cantidad, Precio, Subtotal, Descuento, Total });
            dataGridView1.Location = new Point(171, 157);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(962, 461);
            dataGridView1.TabIndex = 32;
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
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            Precio.Width = 125;
            // 
            // Subtotal
            // 
            Subtotal.HeaderText = "Subtotal";
            Subtotal.MinimumWidth = 6;
            Subtotal.Name = "Subtotal";
            Subtotal.Width = 125;
            // 
            // Descuento
            // 
            Descuento.HeaderText = "Descuento";
            Descuento.MinimumWidth = 6;
            Descuento.Name = "Descuento";
            Descuento.Width = 125;
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
            btnImprimirInforme.Location = new Point(898, 111);
            btnImprimirInforme.Name = "btnImprimirInforme";
            btnImprimirInforme.Size = new Size(235, 40);
            btnImprimirInforme.TabIndex = 31;
            btnImprimirInforme.Text = "Imprimir";
            btnImprimirInforme.UseVisualStyleBackColor = true;
            // 
            // lblCantidad
            // 
            lblCantidad.Anchor = AnchorStyles.None;
            lblCantidad.AutoSize = true;
            lblCantidad.ForeColor = Color.White;
            lblCantidad.Location = new Point(759, 101);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(69, 20);
            lblCantidad.TabIndex = 29;
            lblCantidad.Text = "Cantidad";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(171, 101);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 30;
            label1.Text = "Producto";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Location = new Point(759, 124);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(111, 27);
            textBox2.TabIndex = 27;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(171, 124);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Buscar por código o nombre del producto";
            textBox1.Size = new Size(569, 27);
            textBox1.TabIndex = 28;
            // 
            // InformesFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1329, 653);
            Controls.Add(dataGridView1);
            Controls.Add(btnImprimirInforme);
            Controls.Add(lblCantidad);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblTitleInformes);
            Name = "InformesFrm";
            Text = "InformesFrm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitleInformes;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Item;
        private DataGridViewTextBoxColumn Unidad;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Subtotal;
        private DataGridViewTextBoxColumn Descuento;
        private DataGridViewTextBoxColumn Total;
        private Button btnImprimirInforme;
        private Label lblCantidad;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}