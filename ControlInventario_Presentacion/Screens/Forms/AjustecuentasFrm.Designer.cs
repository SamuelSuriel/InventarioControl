namespace ControlInventario_Presentacion.Screens.Forms
{
    partial class AjustecuentasFrm
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
            dgvusuario = new DataGridView();
            lblTitleSettings = new Label();
            cbxPerfil = new ComboBox();
            txtNombreUsu = new TextBox();
            Label = new Label();
            label1 = new Label();
            txtContraUsu = new TextBox();
            label2 = new Label();
            txtIdCuenta = new TextBox();
            label3 = new Label();
            cbxEstado = new ComboBox();
            label4 = new Label();
            btnEliminareliminarusu = new Label();
            btnEditarusu = new Button();
            lblLimpiarCampousu = new Label();
            btnBuscarusu = new Button();
            txtBuscarusu = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvusuario).BeginInit();
            SuspendLayout();
            // 
            // dgvusuario
            // 
            dgvusuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvusuario.Location = new Point(12, 252);
            dgvusuario.Name = "dgvusuario";
            dgvusuario.RowTemplate.Height = 25;
            dgvusuario.Size = new Size(801, 179);
            dgvusuario.TabIndex = 0;
            // 
            // lblTitleSettings
            // 
            lblTitleSettings.AutoSize = true;
            lblTitleSettings.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitleSettings.ForeColor = Color.Gainsboro;
            lblTitleSettings.Location = new Point(12, 9);
            lblTitleSettings.Name = "lblTitleSettings";
            lblTitleSettings.Size = new Size(213, 24);
            lblTitleSettings.TabIndex = 3;
            lblTitleSettings.Text = "AJUSTE DE CUENTAS ";
            // 
            // cbxPerfil
            // 
            cbxPerfil.FormattingEnabled = true;
            cbxPerfil.Location = new Point(113, 173);
            cbxPerfil.Name = "cbxPerfil";
            cbxPerfil.Size = new Size(171, 23);
            cbxPerfil.TabIndex = 4;
            cbxPerfil.SelectedIndexChanged += cbxPerfil_SelectedIndexChanged;
            // 
            // txtNombreUsu
            // 
            txtNombreUsu.Location = new Point(113, 99);
            txtNombreUsu.Name = "txtNombreUsu";
            txtNombreUsu.Size = new Size(171, 23);
            txtNombreUsu.TabIndex = 5;
            // 
            // Label
            // 
            Label.AutoSize = true;
            Label.BackColor = SystemColors.ActiveCaptionText;
            Label.ForeColor = Color.Gainsboro;
            Label.Location = new Point(22, 102);
            Label.Name = "Label";
            Label.Size = new Size(51, 15);
            Label.TabIndex = 6;
            Label.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(22, 140);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 8;
            label1.Text = "Contraseña";
            // 
            // txtContraUsu
            // 
            txtContraUsu.Location = new Point(113, 137);
            txtContraUsu.Name = "txtContraUsu";
            txtContraUsu.Size = new Size(171, 23);
            txtContraUsu.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(22, 176);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 10;
            label2.Text = "Perfil";
            // 
            // txtIdCuenta
            // 
            txtIdCuenta.Location = new Point(113, 60);
            txtIdCuenta.Name = "txtIdCuenta";
            txtIdCuenta.Size = new Size(171, 23);
            txtIdCuenta.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(22, 214);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 12;
            label3.Text = "Estado";
            // 
            // cbxEstado
            // 
            cbxEstado.FormattingEnabled = true;
            cbxEstado.Location = new Point(113, 211);
            cbxEstado.Name = "cbxEstado";
            cbxEstado.Size = new Size(171, 23);
            cbxEstado.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.ForeColor = Color.Gainsboro;
            label4.Location = new Point(22, 63);
            label4.Name = "label4";
            label4.Size = new Size(85, 15);
            label4.TabIndex = 13;
            label4.Text = "ID de la cuenta";
            // 
            // btnEliminareliminarusu
            // 
            btnEliminareliminarusu.AutoSize = true;
            btnEliminareliminarusu.Cursor = Cursors.Hand;
            btnEliminareliminarusu.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            btnEliminareliminarusu.ForeColor = Color.Red;
            btnEliminareliminarusu.Location = new Point(432, 66);
            btnEliminareliminarusu.Name = "btnEliminareliminarusu";
            btnEliminareliminarusu.Size = new Size(74, 21);
            btnEliminareliminarusu.TabIndex = 16;
            btnEliminareliminarusu.Text = "Eliminar";
            // 
            // btnEditarusu
            // 
            btnEditarusu.BackColor = Color.DarkOrange;
            btnEditarusu.Cursor = Cursors.Hand;
            btnEditarusu.ForeColor = Color.White;
            btnEditarusu.Location = new Point(308, 54);
            btnEditarusu.Margin = new Padding(3, 2, 3, 2);
            btnEditarusu.Name = "btnEditarusu";
            btnEditarusu.Size = new Size(118, 33);
            btnEditarusu.TabIndex = 14;
            btnEditarusu.Text = "Editar";
            btnEditarusu.UseVisualStyleBackColor = false;
            // 
            // lblLimpiarCampousu
            // 
            lblLimpiarCampousu.AutoSize = true;
            lblLimpiarCampousu.Cursor = Cursors.Hand;
            lblLimpiarCampousu.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            lblLimpiarCampousu.ForeColor = Color.White;
            lblLimpiarCampousu.Location = new Point(524, 72);
            lblLimpiarCampousu.Name = "lblLimpiarCampousu";
            lblLimpiarCampousu.Size = new Size(47, 15);
            lblLimpiarCampousu.TabIndex = 17;
            lblLimpiarCampousu.Text = "Limpiar";
            lblLimpiarCampousu.Click += lblLimpiarCampousu_Click;
            // 
            // btnBuscarusu
            // 
            btnBuscarusu.Location = new Point(738, 211);
            btnBuscarusu.Name = "btnBuscarusu";
            btnBuscarusu.Size = new Size(75, 23);
            btnBuscarusu.TabIndex = 18;
            btnBuscarusu.Text = "Buscar";
            btnBuscarusu.UseVisualStyleBackColor = true;
            // 
            // txtBuscarusu
            // 
            txtBuscarusu.Location = new Point(308, 211);
            txtBuscarusu.Name = "txtBuscarusu";
            txtBuscarusu.Size = new Size(424, 23);
            txtBuscarusu.TabIndex = 19;
            // 
            // AjustecuentasFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(825, 443);
            Controls.Add(txtBuscarusu);
            Controls.Add(btnBuscarusu);
            Controls.Add(lblLimpiarCampousu);
            Controls.Add(btnEliminareliminarusu);
            Controls.Add(btnEditarusu);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cbxEstado);
            Controls.Add(label2);
            Controls.Add(txtIdCuenta);
            Controls.Add(label1);
            Controls.Add(txtContraUsu);
            Controls.Add(Label);
            Controls.Add(txtNombreUsu);
            Controls.Add(cbxPerfil);
            Controls.Add(lblTitleSettings);
            Controls.Add(dgvusuario);
            Name = "AjustecuentasFrm";
            Text = "AjustecuentasFrm";
            Load += AjustecuentasFrm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvusuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvusuario;
        private Label lblTitleSettings;
        private ComboBox cbxPerfil;
        private TextBox txtNombreUsu;
        private Label Label;
        private Label label1;
        private TextBox txtContraUsu;
        private Label label2;
        private TextBox txtIdCuenta;
        private Label label3;
        private ComboBox cbxEstado;
        private Label label4;
        private Label btnEliminareliminarusu;
        private Button btnEditarusu;
        private Label lblLimpiarCampousu;
        private Button btnBuscarusu;
        private TextBox txtBuscarusu;
    }
}