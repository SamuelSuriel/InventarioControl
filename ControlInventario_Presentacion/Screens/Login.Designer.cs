﻿namespace ControlInventario_Presentacion.Screens
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
            lblRegistrarse = new Label();
            panel1 = new Panel();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
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
            label1.Location = new Point(218, 214);
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
            label2.Location = new Point(193, 266);
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
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(293, 23);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
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
            lblOlvideContrasena.Location = new Point(100, 308);
            lblOlvideContrasena.Name = "lblOlvideContrasena";
            lblOlvideContrasena.Size = new Size(114, 15);
            lblOlvideContrasena.TabIndex = 4;
            lblOlvideContrasena.Text = "Ovlidé la contraseña";
            // 
            // lblRegistrarse
            // 
            lblRegistrarse.AutoSize = true;
            lblRegistrarse.Cursor = Cursors.Hand;
            lblRegistrarse.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            lblRegistrarse.ForeColor = Color.DodgerBlue;
            lblRegistrarse.Location = new Point(320, 308);
            lblRegistrarse.Name = "lblRegistrarse";
            lblRegistrarse.Size = new Size(64, 15);
            lblRegistrarse.TabIndex = 4;
            lblRegistrarse.Text = "Registrarse";
            lblRegistrarse.Click += lblRegistrarse_Click;
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
            panel1.Size = new Size(522, 52);
            panel1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(131, 0);
            label3.Name = "label3";
            label3.Size = new Size(226, 63);
            label3.TabIndex = 1;
            label3.Text = "Desarrollado por el equipo 5\r\nProgramacion lll\r\n\r\n";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Black;
            ClientSize = new Size(522, 470);
            Controls.Add(panel1);
            Controls.Add(lblRegistrarse);
            Controls.Add(lblOlvideContrasena);
            Controls.Add(btnIniciarSesion);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Label lblRegistrarse;
        private Panel panel1;
        private Label label3;
    }
}