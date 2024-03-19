namespace ControlInventario_Presentacion.Screens
{
    partial class RegistroFrm
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
            btnRegistrarse = new Button();
            txtPasswordRegistro = new TextBox();
            txtUserRegistro = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            txtPasswordConfirmReg = new TextBox();
            label1 = new Label();
            label3 = new Label();
            cbxPerfil = new ComboBox();
            btnAcultarcontraseña = new PictureBox();
            btnMostrarcontra = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnAcultarcontraseña).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMostrarcontra).BeginInit();
            SuspendLayout();
            // 
            // btnRegistrarse
            // 
            btnRegistrarse.BackColor = Color.DarkSlateBlue;
            btnRegistrarse.Cursor = Cursors.Hand;
            btnRegistrarse.FlatAppearance.BorderSize = 0;
            btnRegistrarse.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegistrarse.ForeColor = Color.White;
            btnRegistrarse.Location = new Point(47, 378);
            btnRegistrarse.Margin = new Padding(3, 2, 3, 2);
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.Size = new Size(107, 28);
            btnRegistrarse.TabIndex = 11;
            btnRegistrarse.Text = "Registrarse";
            btnRegistrarse.UseVisualStyleBackColor = false;
            btnRegistrarse.Click += btnRegistrarse_Click;
            // 
            // txtPasswordRegistro
            // 
            txtPasswordRegistro.Location = new Point(47, 230);
            txtPasswordRegistro.Margin = new Padding(3, 2, 3, 2);
            txtPasswordRegistro.Name = "txtPasswordRegistro";
            txtPasswordRegistro.PasswordChar = '*';
            txtPasswordRegistro.PlaceholderText = "Password";
            txtPasswordRegistro.Size = new Size(358, 23);
            txtPasswordRegistro.TabIndex = 9;
            // 
            // txtUserRegistro
            // 
            txtUserRegistro.Location = new Point(47, 177);
            txtUserRegistro.Margin = new Padding(3, 2, 3, 2);
            txtUserRegistro.Name = "txtUserRegistro";
            txtUserRegistro.PlaceholderText = "Username";
            txtUserRegistro.Size = new Size(358, 23);
            txtUserRegistro.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(47, 211);
            label2.Name = "label2";
            label2.Size = new Size(107, 21);
            label2.TabIndex = 7;
            label2.Text = "Contraseña:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo_SRS;
            pictureBox1.Location = new Point(163, 9);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(141, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(47, 264);
            label6.Name = "label6";
            label6.Size = new Size(185, 21);
            label6.TabIndex = 7;
            label6.Text = "Confirmar contraseña:";
            // 
            // txtPasswordConfirmReg
            // 
            txtPasswordConfirmReg.Location = new Point(47, 283);
            txtPasswordConfirmReg.Margin = new Padding(3, 2, 3, 2);
            txtPasswordConfirmReg.Name = "txtPasswordConfirmReg";
            txtPasswordConfirmReg.PasswordChar = '*';
            txtPasswordConfirmReg.PlaceholderText = "Confirm password";
            txtPasswordConfirmReg.Size = new Size(358, 23);
            txtPasswordConfirmReg.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(47, 158);
            label1.Name = "label1";
            label1.Size = new Size(70, 21);
            label1.TabIndex = 8;
            label1.Text = "Usuario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(47, 314);
            label3.Name = "label3";
            label3.Size = new Size(45, 21);
            label3.TabIndex = 13;
            label3.Text = "Perfil";
            // 
            // cbxPerfil
            // 
            cbxPerfil.FormattingEnabled = true;
            cbxPerfil.Location = new Point(47, 335);
            cbxPerfil.Name = "cbxPerfil";
            cbxPerfil.Size = new Size(358, 23);
            cbxPerfil.TabIndex = 12;
            // 
            // btnAcultarcontraseña
            // 
            btnAcultarcontraseña.BackColor = Color.White;
            btnAcultarcontraseña.Image = Properties.Resources.invisible__1_;
            btnAcultarcontraseña.Location = new Point(424, 230);
            btnAcultarcontraseña.Margin = new Padding(3, 2, 3, 2);
            btnAcultarcontraseña.Name = "btnAcultarcontraseña";
            btnAcultarcontraseña.Size = new Size(24, 23);
            btnAcultarcontraseña.SizeMode = PictureBoxSizeMode.StretchImage;
            btnAcultarcontraseña.TabIndex = 15;
            btnAcultarcontraseña.TabStop = false;
            btnAcultarcontraseña.Click += btnAcultarcontraseña_Click;
            // 
            // btnMostrarcontra
            // 
            btnMostrarcontra.BackColor = Color.White;
            btnMostrarcontra.Image = Properties.Resources.ojo;
            btnMostrarcontra.Location = new Point(424, 230);
            btnMostrarcontra.Margin = new Padding(3, 2, 3, 2);
            btnMostrarcontra.Name = "btnMostrarcontra";
            btnMostrarcontra.Size = new Size(24, 23);
            btnMostrarcontra.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMostrarcontra.TabIndex = 14;
            btnMostrarcontra.TabStop = false;
            btnMostrarcontra.Click += btnMostrarcontra_Click;
            // 
            // RegistroFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Black;
            ClientSize = new Size(825, 443);
            Controls.Add(btnMostrarcontra);
            Controls.Add(label3);
            Controls.Add(cbxPerfil);
            Controls.Add(btnRegistrarse);
            Controls.Add(txtPasswordConfirmReg);
            Controls.Add(txtPasswordRegistro);
            Controls.Add(txtUserRegistro);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnAcultarcontraseña);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "RegistroFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegistroFrm";
            Load += RegistroFrm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnAcultarcontraseña).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMostrarcontra).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnRegistrarse;
        private TextBox txtPasswordRegistro;
        private TextBox txtUserRegistro;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label6;
        private TextBox txtPasswordConfirmReg;
        private Label label1;
        private Label label3;
        private ComboBox cbxPerfil;
        private PictureBox btnAcultarcontraseña;
        private PictureBox btnMostrarcontra;
    }
}