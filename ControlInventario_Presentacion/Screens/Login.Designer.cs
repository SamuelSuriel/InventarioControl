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
            pictureBox1.Location = new Point(180, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(214, 203);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(114, 285);
            label1.Name = "label1";
            label1.Size = new Size(84, 23);
            label1.TabIndex = 1;
            label1.Text = "Usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(114, 355);
            label2.Name = "label2";
            label2.Size = new Size(130, 23);
            label2.TabIndex = 1;
            label2.Text = "Contraseña:";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(114, 311);
            txtUserName.Name = "txtUserName";
            txtUserName.PlaceholderText = "Username";
            txtUserName.Size = new Size(334, 27);
            txtUserName.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(114, 381);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(334, 27);
            txtPassword.TabIndex = 2;
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.BackColor = Color.DarkSlateBlue;
            btnIniciarSesion.Cursor = Cursors.Hand;
            btnIniciarSesion.FlatAppearance.BorderSize = 0;
            btnIniciarSesion.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnIniciarSesion.ForeColor = Color.White;
            btnIniciarSesion.Location = new Point(114, 451);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(334, 48);
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
            lblOlvideContrasena.Location = new Point(207, 415);
            lblOlvideContrasena.Name = "lblOlvideContrasena";
            lblOlvideContrasena.Size = new Size(144, 20);
            lblOlvideContrasena.TabIndex = 4;
            lblOlvideContrasena.Text = "Ovlidé la contraseña";
            lblOlvideContrasena.Click += lblOlvideContrasena_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateBlue;
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Bottom;
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(0, 558);
            panel1.Name = "panel1";
            panel1.Size = new Size(574, 69);
            panel1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(129, 9);
            label3.Name = "label3";
            label3.Size = new Size(291, 69);
            label3.TabIndex = 1;
            label3.Text = "Desarrollado por el equipo 5\r\nProgramacion lll\r\n\r\n";
            // 
            // btnMostrarcontra
            // 
            btnMostrarcontra.BackColor = Color.White;
            btnMostrarcontra.Image = Properties.Resources.ojo;
            btnMostrarcontra.Location = new Point(470, 381);
            btnMostrarcontra.Name = "btnMostrarcontra";
            btnMostrarcontra.Size = new Size(27, 31);
            btnMostrarcontra.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMostrarcontra.TabIndex = 6;
            btnMostrarcontra.TabStop = false;
            btnMostrarcontra.Click += btnMostrarcontra_Click;
            // 
            // btnAcultarcontraseña
            // 
            btnAcultarcontraseña.BackColor = Color.White;
            btnAcultarcontraseña.Image = Properties.Resources.invisible__1_;
            btnAcultarcontraseña.Location = new Point(470, 381);
            btnAcultarcontraseña.Name = "btnAcultarcontraseña";
            btnAcultarcontraseña.Size = new Size(27, 31);
            btnAcultarcontraseña.SizeMode = PictureBoxSizeMode.StretchImage;
            btnAcultarcontraseña.TabIndex = 7;
            btnAcultarcontraseña.TabStop = false;
            btnAcultarcontraseña.Click += btnAcultarcontraseña_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(574, 627);
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