namespace ControlInventario_Presentacion.Screens
{
    partial class Login
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            btnIniciarSesion = new Button();
            lblOlvideContrasena = new Label();
            panel1 = new Panel();
            label3 = new Label();
            btnMostrarcontra = new PictureBox();
            btnAcultarcontraseña = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMostrarcontra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnAcultarcontraseña).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo_SRS;
            pictureBox1.Location = new Point(150, 9);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(207, 186);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(100, 214);
            label1.Name = "label1";
            label1.Size = new Size(70, 21);
            label1.TabIndex = 1;
            label1.Text = "Usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(100, 266);
            label2.Name = "label2";
            label2.Size = new Size(107, 21);
            label2.TabIndex = 1;
            label2.Text = "Contraseña:";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(100, 233);
            txtUserName.Margin = new Padding(3, 2, 3, 2);
            txtUserName.Name = "txtUserName";
            txtUserName.PlaceholderText = "Username";
            txtUserName.Size = new Size(293, 23);
            txtUserName.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(100, 286);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(293, 23);
            txtPassword.TabIndex = 2;
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.BackColor = Color.DarkSlateBlue;
            btnIniciarSesion.Cursor = Cursors.Hand;
            btnIniciarSesion.FlatAppearance.BorderSize = 0;
            btnIniciarSesion.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnIniciarSesion.ForeColor = Color.White;
            btnIniciarSesion.Location = new Point(100, 338);
            btnIniciarSesion.Margin = new Padding(3, 2, 3, 2);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(292, 28);
            btnIniciarSesion.TabIndex = 3;
            btnIniciarSesion.Text = "Iniciar sesión";
            btnIniciarSesion.UseVisualStyleBackColor = false;
            btnIniciarSesion.Click += button1_Click;
            // 
            // lblOlvideContrasena
            // 
            lblOlvideContrasena.AutoSize = true;
            lblOlvideContrasena.Cursor = Cursors.Hand;
            lblOlvideContrasena.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            lblOlvideContrasena.ForeColor = Color.DodgerBlue;
            lblOlvideContrasena.Location = new Point(181, 311);
            lblOlvideContrasena.Name = "lblOlvideContrasena";
            lblOlvideContrasena.Size = new Size(114, 15);
            lblOlvideContrasena.TabIndex = 4;
            lblOlvideContrasena.Text = "Ovlidé la contraseña";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateBlue;
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Bottom;
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(0, 418);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(502, 52);
            panel1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(113, 7);
            label3.Name = "label3";
            label3.Size = new Size(226, 63);
            label3.TabIndex = 1;
            label3.Text = "Desarrollado por el equipo 5\r\nProgramacion lll\r\n\r\n";
            // 
            // btnMostrarcontra
            // 
            btnMostrarcontra.BackColor = Color.White;
            btnMostrarcontra.Image = Properties.Resources.ojo;
            btnMostrarcontra.Location = new Point(411, 286);
            btnMostrarcontra.Margin = new Padding(3, 2, 3, 2);
            btnMostrarcontra.Name = "btnMostrarcontra";
            btnMostrarcontra.Size = new Size(24, 23);
            btnMostrarcontra.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMostrarcontra.TabIndex = 6;
            btnMostrarcontra.TabStop = false;
            btnMostrarcontra.Click += btnMostrarcontra_Click;
            // 
            // btnAcultarcontraseña
            // 
            btnAcultarcontraseña.BackColor = Color.White;
            btnAcultarcontraseña.Image = Properties.Resources.invisible__1_;
            btnAcultarcontraseña.Location = new Point(411, 286);
            btnAcultarcontraseña.Margin = new Padding(3, 2, 3, 2);
            btnAcultarcontraseña.Name = "btnAcultarcontraseña";
            btnAcultarcontraseña.Size = new Size(24, 23);
            btnAcultarcontraseña.SizeMode = PictureBoxSizeMode.StretchImage;
            btnAcultarcontraseña.TabIndex = 7;
            btnAcultarcontraseña.TabStop = false;
            btnAcultarcontraseña.Click += btnAcultarcontraseña_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(502, 470);
            Controls.Add(btnMostrarcontra);
            Controls.Add(panel1);
            Controls.Add(lblOlvideContrasena);
            Controls.Add(btnIniciarSesion);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnAcultarcontraseña);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnMostrarcontra).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnAcultarcontraseña).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Button btnIniciarSesion;
        private Label lblOlvideContrasena;
        private Panel panel1;
        private Label label3;
        private PictureBox btnMostrarcontra;
        private PictureBox btnAcultarcontraseña;
    }
}