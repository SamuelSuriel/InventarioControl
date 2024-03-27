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
            btnEliminareliminarusu = new Label();
            btnEditarusu = new Button();
            lblLimpiarCampousu = new Label();
            btnBuscarusu = new Button();
            txtBuscarusu = new TextBox();
            btnAgregar = new Button();
            btnMostrarcontra = new PictureBox();
            btnAcultarcontraseña = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvusuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMostrarcontra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnAcultarcontraseña).BeginInit();
            SuspendLayout();
            // 
            // dgvusuario
            // 
            dgvusuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvusuario.Location = new Point(12, 252);
            dgvusuario.Name = "dgvusuario";
            dgvusuario.RowTemplate.Height = 25;
            dgvusuario.Size = new Size(525, 179);
            dgvusuario.TabIndex = 0;
            // 
            // lblTitleSettings
            // 
            lblTitleSettings.AutoSize = true;
            lblTitleSettings.Font = new Font("Segoe UI Variable Text", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitleSettings.ForeColor = Color.Gainsboro;
            lblTitleSettings.Location = new Point(12, 9);
            lblTitleSettings.Name = "lblTitleSettings";
            lblTitleSettings.Size = new Size(204, 26);
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
            Label.BackColor = Color.Transparent;
            Label.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Label.ForeColor = Color.Gainsboro;
            Label.Location = new Point(22, 102);
            Label.Name = "Label";
            Label.Size = new Size(65, 19);
            Label.TabIndex = 6;
            Label.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(22, 140);
            label1.Name = "label1";
            label1.Size = new Size(86, 19);
            label1.TabIndex = 8;
            label1.Text = "Contraseña";
            // 
            // txtContraUsu
            // 
            txtContraUsu.Location = new Point(113, 137);
            txtContraUsu.Name = "txtContraUsu";
            txtContraUsu.PasswordChar = '*';
            txtContraUsu.Size = new Size(171, 23);
            txtContraUsu.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(22, 176);
            label2.Name = "label2";
            label2.Size = new Size(45, 19);
            label2.TabIndex = 10;
            label2.Text = "Perfil";
            // 
            // btnEliminareliminarusu
            // 
            btnEliminareliminarusu.AutoSize = true;
            btnEliminareliminarusu.BackColor = Color.Firebrick;
            btnEliminareliminarusu.Cursor = Cursors.Hand;
            btnEliminareliminarusu.Font = new Font("Segoe UI Variable Text", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminareliminarusu.ForeColor = Color.White;
            btnEliminareliminarusu.Location = new Point(299, 60);
            btnEliminareliminarusu.Name = "btnEliminareliminarusu";
            btnEliminareliminarusu.Size = new Size(66, 20);
            btnEliminareliminarusu.TabIndex = 16;
            btnEliminareliminarusu.Text = "Eliminar";
            btnEliminareliminarusu.Click += btnEliminareliminarusu_Click;
            // 
            // btnEditarusu
            // 
            btnEditarusu.BackColor = Color.DarkOrange;
            btnEditarusu.Cursor = Cursors.Hand;
            btnEditarusu.FlatAppearance.BorderColor = Color.DarkOrange;
            btnEditarusu.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 128);
            btnEditarusu.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 64, 0);
            btnEditarusu.FlatStyle = FlatStyle.Flat;
            btnEditarusu.Font = new Font("Segoe UI Variable Text", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditarusu.ForeColor = Color.White;
            btnEditarusu.Location = new Point(166, 48);
            btnEditarusu.Margin = new Padding(3, 2, 3, 2);
            btnEditarusu.Name = "btnEditarusu";
            btnEditarusu.Size = new Size(118, 33);
            btnEditarusu.TabIndex = 14;
            btnEditarusu.Text = "Editar";
            btnEditarusu.UseVisualStyleBackColor = false;
            btnEditarusu.Click += btnEditarusu_Click_1;
            // 
            // lblLimpiarCampousu
            // 
            lblLimpiarCampousu.AutoSize = true;
            lblLimpiarCampousu.BackColor = Color.Gray;
            lblLimpiarCampousu.Cursor = Cursors.Hand;
            lblLimpiarCampousu.Font = new Font("Segoe UI Variable Text", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblLimpiarCampousu.ForeColor = Color.White;
            lblLimpiarCampousu.Location = new Point(380, 61);
            lblLimpiarCampousu.Name = "lblLimpiarCampousu";
            lblLimpiarCampousu.Size = new Size(62, 20);
            lblLimpiarCampousu.TabIndex = 17;
            lblLimpiarCampousu.Text = "Limpiar";
            lblLimpiarCampousu.Click += lblLimpiarCampousu_Click;
            // 
            // btnBuscarusu
            // 
            btnBuscarusu.BackColor = Color.White;
            btnBuscarusu.FlatAppearance.BorderColor = Color.White;
            btnBuscarusu.FlatStyle = FlatStyle.Flat;
            btnBuscarusu.Font = new Font("Segoe UI Variable Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscarusu.Location = new Point(22, 217);
            btnBuscarusu.Name = "btnBuscarusu";
            btnBuscarusu.Size = new Size(75, 31);
            btnBuscarusu.TabIndex = 18;
            btnBuscarusu.Text = "Buscar";
            btnBuscarusu.UseVisualStyleBackColor = false;
            // 
            // txtBuscarusu
            // 
            txtBuscarusu.Location = new Point(113, 223);
            txtBuscarusu.Name = "txtBuscarusu";
            txtBuscarusu.Size = new Size(424, 23);
            txtBuscarusu.TabIndex = 19;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.ForestGreen;
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.FlatAppearance.BorderColor = Color.ForestGreen;
            btnAgregar.FlatAppearance.MouseDownBackColor = Color.MediumSeaGreen;
            btnAgregar.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 64, 0);
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI Variable Text", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(22, 48);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(118, 33);
            btnAgregar.TabIndex = 20;
            btnAgregar.Text = "Guardar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnMostrarcontra
            // 
            btnMostrarcontra.BackColor = Color.White;
            btnMostrarcontra.Image = Properties.Resources.ojo;
            btnMostrarcontra.Location = new Point(290, 137);
            btnMostrarcontra.Margin = new Padding(3, 2, 3, 2);
            btnMostrarcontra.Name = "btnMostrarcontra";
            btnMostrarcontra.Size = new Size(24, 23);
            btnMostrarcontra.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMostrarcontra.TabIndex = 21;
            btnMostrarcontra.TabStop = false;
            btnMostrarcontra.Click += btnMostrarcontra_Click;
            // 
            // btnAcultarcontraseña
            // 
            btnAcultarcontraseña.BackColor = Color.White;
            btnAcultarcontraseña.Image = Properties.Resources.invisible__1_;
            btnAcultarcontraseña.Location = new Point(290, 137);
            btnAcultarcontraseña.Margin = new Padding(3, 2, 3, 2);
            btnAcultarcontraseña.Name = "btnAcultarcontraseña";
            btnAcultarcontraseña.Size = new Size(24, 23);
            btnAcultarcontraseña.SizeMode = PictureBoxSizeMode.StretchImage;
            btnAcultarcontraseña.TabIndex = 22;
            btnAcultarcontraseña.TabStop = false;
            btnAcultarcontraseña.Click += btnAcultarcontraseña_Click;
            // 
            // AjustecuentasFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 27, 60);
            ClientSize = new Size(568, 443);
            Controls.Add(btnMostrarcontra);
            Controls.Add(btnAcultarcontraseña);
            Controls.Add(btnAgregar);
            Controls.Add(txtBuscarusu);
            Controls.Add(btnBuscarusu);
            Controls.Add(lblLimpiarCampousu);
            Controls.Add(btnEliminareliminarusu);
            Controls.Add(btnEditarusu);
            Controls.Add(label2);
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
            ((System.ComponentModel.ISupportInitialize)btnMostrarcontra).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnAcultarcontraseña).EndInit();
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
        private Label btnEliminareliminarusu;
        private Button btnEditarusu;
        private Label lblLimpiarCampousu;
        private Button btnBuscarusu;
        private TextBox txtBuscarusu;
        private Button btnAgregar;
        private PictureBox btnMostrarcontra;
        private PictureBox btnAcultarcontraseña;
    }
}