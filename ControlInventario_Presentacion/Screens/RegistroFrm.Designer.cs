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
            panel1 = new Panel();
            label3 = new Label();
            btnRegistrarse = new Button();
            txtPasswordRegistro = new TextBox();
            txtUserRegistro = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            txtNameRegistro = new TextBox();
            txtCorreoRegistro = new TextBox();
            label6 = new Label();
            txtPasswordConfirmReg = new TextBox();
            label7 = new Label();
            txtDireccionRegistro = new TextBox();
            label8 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateBlue;
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Bottom;
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(0, 770);
            panel1.Name = "panel1";
            panel1.Size = new Size(522, 70);
            panel1.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(101, 25);
            label3.Name = "label3";
            label3.Size = new Size(357, 23);
            label3.TabIndex = 1;
            label3.Text = "Desarrollado por Samuel Ramirez S.";
            // 
            // btnRegistrarse
            // 
            btnRegistrarse.BackColor = Color.DarkSlateBlue;
            btnRegistrarse.Cursor = Cursors.Hand;
            btnRegistrarse.FlatAppearance.BorderSize = 0;
            btnRegistrarse.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegistrarse.ForeColor = Color.White;
            btnRegistrarse.Location = new Point(49, 678);
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.Size = new Size(409, 37);
            btnRegistrarse.TabIndex = 11;
            btnRegistrarse.Text = "Registrarse";
            btnRegistrarse.UseVisualStyleBackColor = false;
            btnRegistrarse.Click += button1_Click;
            // 
            // txtPasswordRegistro
            // 
            txtPasswordRegistro.Location = new Point(49, 532);
            txtPasswordRegistro.Name = "txtPasswordRegistro";
            txtPasswordRegistro.PlaceholderText = "Password";
            txtPasswordRegistro.Size = new Size(409, 27);
            txtPasswordRegistro.TabIndex = 9;
            txtPasswordRegistro.UseSystemPasswordChar = true;
            // 
            // txtUserRegistro
            // 
            txtUserRegistro.Location = new Point(49, 462);
            txtUserRegistro.Name = "txtUserRegistro";
            txtUserRegistro.PlaceholderText = "Username";
            txtUserRegistro.Size = new Size(409, 27);
            txtUserRegistro.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(49, 506);
            label2.Name = "label2";
            label2.Size = new Size(130, 23);
            label2.TabIndex = 7;
            label2.Text = "Contraseña:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(49, 436);
            label1.Name = "label1";
            label1.Size = new Size(84, 23);
            label1.TabIndex = 8;
            label1.Text = "Usuario:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo_SRS;
            pictureBox1.Location = new Point(186, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(161, 170);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(49, 234);
            label4.Name = "label4";
            label4.Size = new Size(95, 23);
            label4.TabIndex = 8;
            label4.Text = "Nombre:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(49, 304);
            label5.Name = "label5";
            label5.Size = new Size(199, 23);
            label5.TabIndex = 7;
            label5.Text = "Correo electrónico:";
            // 
            // txtNameRegistro
            // 
            txtNameRegistro.Location = new Point(49, 260);
            txtNameRegistro.Name = "txtNameRegistro";
            txtNameRegistro.PlaceholderText = "Name";
            txtNameRegistro.Size = new Size(409, 27);
            txtNameRegistro.TabIndex = 10;
            // 
            // txtCorreoRegistro
            // 
            txtCorreoRegistro.Location = new Point(49, 330);
            txtCorreoRegistro.Name = "txtCorreoRegistro";
            txtCorreoRegistro.PlaceholderText = "Email";
            txtCorreoRegistro.Size = new Size(409, 27);
            txtCorreoRegistro.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(49, 577);
            label6.Name = "label6";
            label6.Size = new Size(228, 23);
            label6.TabIndex = 7;
            label6.Text = "Confirmar contraseña:";
            // 
            // txtPasswordConfirmReg
            // 
            txtPasswordConfirmReg.Location = new Point(49, 603);
            txtPasswordConfirmReg.Name = "txtPasswordConfirmReg";
            txtPasswordConfirmReg.PlaceholderText = "Confirm password";
            txtPasswordConfirmReg.Size = new Size(409, 27);
            txtPasswordConfirmReg.TabIndex = 9;
            txtPasswordConfirmReg.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(49, 369);
            label7.Name = "label7";
            label7.Size = new Size(106, 23);
            label7.TabIndex = 8;
            label7.Text = "Dirección:";
            // 
            // txtDireccionRegistro
            // 
            txtDireccionRegistro.Location = new Point(49, 395);
            txtDireccionRegistro.Name = "txtDireccionRegistro";
            txtDireccionRegistro.PlaceholderText = "Adrees";
            txtDireccionRegistro.Size = new Size(409, 27);
            txtDireccionRegistro.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Cursor = Cursors.Hand;
            label8.ForeColor = Color.White;
            label8.Location = new Point(12, 12);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 15;
            label8.Text = "Volver";
            label8.Click += label8_Click;
            // 
            // RegistroFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Black;
            ClientSize = new Size(522, 840);
            Controls.Add(label8);
            Controls.Add(panel1);
            Controls.Add(btnRegistrarse);
            Controls.Add(txtCorreoRegistro);
            Controls.Add(txtPasswordConfirmReg);
            Controls.Add(txtPasswordRegistro);
            Controls.Add(txtDireccionRegistro);
            Controls.Add(txtNameRegistro);
            Controls.Add(label5);
            Controls.Add(txtUserRegistro);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            Name = "RegistroFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegistroFrm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Button btnRegistrarse;
        private TextBox txtPasswordRegistro;
        private TextBox txtUserRegistro;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label5;
        private TextBox txtNameRegistro;
        private TextBox txtCorreoRegistro;
        private Label label6;
        private TextBox txtPasswordConfirmReg;
        private Label label7;
        private TextBox txtDireccionRegistro;
        private Label label8;
    }
}