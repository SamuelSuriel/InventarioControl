namespace ControlInventario_Presentacion.Screens.Forms
{
    partial class ProveedoresFrm
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
            lblTitleProveedores = new Label();
            dgvProveedores = new DataGridView();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtCorreoProveedor = new TextBox();
            txtTelefonoProveedor = new TextBox();
            txtDireccionProveedor = new TextBox();
            txtNombreProveedor = new TextBox();
            btnEliminarProveedor = new Label();
            btnEditarProveedor = new Button();
            btnAgregarProveedor = new Button();
            label7 = new Label();
            lblLine = new Label();
            lblLimpiarProv = new Label();
            cbProductosProveedor = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).BeginInit();
            SuspendLayout();
            // 
            // lblTitleProveedores
            // 
            lblTitleProveedores.AutoSize = true;
            lblTitleProveedores.Font = new Font("Segoe UI Variable Display", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitleProveedores.ForeColor = Color.Gainsboro;
            lblTitleProveedores.Location = new Point(76, 46);
            lblTitleProveedores.Name = "lblTitleProveedores";
            lblTitleProveedores.Size = new Size(135, 26);
            lblTitleProveedores.TabIndex = 2;
            lblTitleProveedores.Text = "PROVEEDORES";
            // 
            // dgvProveedores
            // 
            dgvProveedores.BackgroundColor = Color.White;
            dgvProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedores.Location = new Point(402, 146);
            dgvProveedores.Margin = new Padding(3, 2, 3, 2);
            dgvProveedores.Name = "dgvProveedores";
            dgvProveedores.RowHeadersWidth = 51;
            dgvProveedores.RowTemplate.Height = 29;
            dgvProveedores.Size = new Size(649, 292);
            dgvProveedores.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(12, 312);
            label6.Name = "label6";
            label6.Size = new Size(115, 15);
            label6.TabIndex = 16;
            label6.Text = "Producto Suministra";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(12, 278);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 17;
            label5.Text = "Correo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(12, 245);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 18;
            label4.Text = "Teléfono";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 184);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 19;
            label3.Text = "Dirección";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 155);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 20;
            label2.Text = "Nombre";
            // 
            // txtCorreoProveedor
            // 
            txtCorreoProveedor.Cursor = Cursors.IBeam;
            txtCorreoProveedor.Location = new Point(133, 275);
            txtCorreoProveedor.Margin = new Padding(3, 2, 3, 2);
            txtCorreoProveedor.Name = "txtCorreoProveedor";
            txtCorreoProveedor.Size = new Size(239, 23);
            txtCorreoProveedor.TabIndex = 9;
            // 
            // txtTelefonoProveedor
            // 
            txtTelefonoProveedor.Cursor = Cursors.IBeam;
            txtTelefonoProveedor.Location = new Point(133, 240);
            txtTelefonoProveedor.Margin = new Padding(3, 2, 3, 2);
            txtTelefonoProveedor.Name = "txtTelefonoProveedor";
            txtTelefonoProveedor.Size = new Size(168, 23);
            txtTelefonoProveedor.TabIndex = 10;
            // 
            // txtDireccionProveedor
            // 
            txtDireccionProveedor.Cursor = Cursors.IBeam;
            txtDireccionProveedor.Location = new Point(133, 182);
            txtDireccionProveedor.Margin = new Padding(3, 2, 3, 2);
            txtDireccionProveedor.Multiline = true;
            txtDireccionProveedor.Name = "txtDireccionProveedor";
            txtDireccionProveedor.Size = new Size(239, 44);
            txtDireccionProveedor.TabIndex = 11;
            // 
            // txtNombreProveedor
            // 
            txtNombreProveedor.Cursor = Cursors.IBeam;
            txtNombreProveedor.Location = new Point(133, 146);
            txtNombreProveedor.Margin = new Padding(3, 2, 3, 2);
            txtNombreProveedor.Name = "txtNombreProveedor";
            txtNombreProveedor.Size = new Size(239, 23);
            txtNombreProveedor.TabIndex = 12;
            // 
            // btnEliminarProveedor
            // 
            btnEliminarProveedor.AutoSize = true;
            btnEliminarProveedor.Cursor = Cursors.Hand;
            btnEliminarProveedor.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            btnEliminarProveedor.ForeColor = Color.Red;
            btnEliminarProveedor.Location = new Point(211, 413);
            btnEliminarProveedor.Name = "btnEliminarProveedor";
            btnEliminarProveedor.Size = new Size(74, 21);
            btnEliminarProveedor.TabIndex = 25;
            btnEliminarProveedor.Text = "Eliminar";
            btnEliminarProveedor.Click += btnEliminarProveedor_Click;
            // 
            // btnEditarProveedor
            // 
            btnEditarProveedor.BackColor = Color.DarkOrange;
            btnEditarProveedor.Cursor = Cursors.Hand;
            btnEditarProveedor.ForeColor = Color.White;
            btnEditarProveedor.Location = new Point(254, 368);
            btnEditarProveedor.Margin = new Padding(3, 2, 3, 2);
            btnEditarProveedor.Name = "btnEditarProveedor";
            btnEditarProveedor.Size = new Size(118, 33);
            btnEditarProveedor.TabIndex = 23;
            btnEditarProveedor.Text = "Editar";
            btnEditarProveedor.UseVisualStyleBackColor = false;
            btnEditarProveedor.Click += btnEditarProveedor_Click;
            // 
            // btnAgregarProveedor
            // 
            btnAgregarProveedor.BackColor = Color.ForestGreen;
            btnAgregarProveedor.Cursor = Cursors.Hand;
            btnAgregarProveedor.ForeColor = Color.White;
            btnAgregarProveedor.Location = new Point(125, 368);
            btnAgregarProveedor.Margin = new Padding(3, 2, 3, 2);
            btnAgregarProveedor.Name = "btnAgregarProveedor";
            btnAgregarProveedor.Size = new Size(118, 33);
            btnAgregarProveedor.TabIndex = 24;
            btnAgregarProveedor.Text = "Agregar";
            btnAgregarProveedor.UseVisualStyleBackColor = false;
            btnAgregarProveedor.Click += btnAgregarProveedor_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ControlDarkDark;
            label7.Location = new Point(76, 90);
            label7.Name = "label7";
            label7.Size = new Size(962, 15);
            label7.TabIndex = 27;
            label7.Text = "_______________________________________________________________________________________________________________________________________________________________________________________________";
            // 
            // lblLine
            // 
            lblLine.AutoSize = true;
            lblLine.ForeColor = SystemColors.ControlDarkDark;
            lblLine.Location = new Point(76, 452);
            lblLine.Name = "lblLine";
            lblLine.Size = new Size(962, 15);
            lblLine.TabIndex = 26;
            lblLine.Text = "_______________________________________________________________________________________________________________________________________________________________________________________________";
            // 
            // lblLimpiarProv
            // 
            lblLimpiarProv.AutoSize = true;
            lblLimpiarProv.Cursor = Cursors.Hand;
            lblLimpiarProv.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            lblLimpiarProv.ForeColor = Color.White;
            lblLimpiarProv.Location = new Point(325, 119);
            lblLimpiarProv.Name = "lblLimpiarProv";
            lblLimpiarProv.Size = new Size(47, 15);
            lblLimpiarProv.TabIndex = 21;
            lblLimpiarProv.Text = "Limpiar";
            lblLimpiarProv.Click += lblLimpiarProv_Click;
            // 
            // cbProductosProveedor
            // 
            cbProductosProveedor.Cursor = Cursors.IBeam;
            cbProductosProveedor.FormattingEnabled = true;
            cbProductosProveedor.Location = new Point(133, 312);
            cbProductosProveedor.Name = "cbProductosProveedor";
            cbProductosProveedor.Size = new Size(239, 23);
            cbProductosProveedor.TabIndex = 28;
            // 
            // ProveedoresFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1163, 490);
            Controls.Add(cbProductosProveedor);
            Controls.Add(label7);
            Controls.Add(lblLine);
            Controls.Add(btnEliminarProveedor);
            Controls.Add(btnEditarProveedor);
            Controls.Add(btnAgregarProveedor);
            Controls.Add(dgvProveedores);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblLimpiarProv);
            Controls.Add(txtCorreoProveedor);
            Controls.Add(txtTelefonoProveedor);
            Controls.Add(txtDireccionProveedor);
            Controls.Add(txtNombreProveedor);
            Controls.Add(lblTitleProveedores);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ProveedoresFrm";
            Text = "ProveedoresFrm";
            Load += ProveedoresFrm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitleProveedores;
        private DataGridView dgvProveedores;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtCorreoProveedor;
        private TextBox txtTelefonoProveedor;
        private TextBox txtDireccionProveedor;
        private TextBox txtNombreProveedor;
        private Label btnEliminarProveedor;
        private Button btnEditarProveedor;
        private Button btnAgregarProveedor;
        private Label label7;
        private Label lblLine;
        private Label lblLimpiarProv;
        private ComboBox cbProductosProveedor;
    }
}