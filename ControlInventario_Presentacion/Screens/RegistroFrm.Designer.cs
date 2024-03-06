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
            panel1.Location = new Point(0, 508);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(457, 54);
            panel1.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(88, 19);
            label3.Name = "label3";
            label3.Size = new Size(279, 21);
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
            btnRegistrarse.Location = new Point(43, 508);
            btnRegistrarse.Margin = new Padding(3, 2, 3, 2);
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.Size = new Size(358, 28);
            btnRegistrarse.TabIndex = 11;
            btnRegistrarse.Text = "Registrarse";
            btnRegistrarse.UseVisualStyleBackColor = false;
            btnRegistrarse.Click += button1_Click;
            // 
            // txtPasswordRegistro
            // 
            txtPasswordRegistro.Location = new Point(43, 399);
            txtPasswordRegistro.Margin = new Padding(3, 2, 3, 2);
            txtPasswordRegistro.Name = "txtPasswordRegistro";
            txtPasswordRegistro.PlaceholderText = "Password";
            txtPasswordRegistro.Size = new Size(358, 23);
            txtPasswordRegistro.TabIndex = 9;
            txtPasswordRegistro.UseSystemPasswordChar = true;
            // 
            // txtUserRegistro
            // 
            txtUserRegistro.Location = new Point(43, 346);
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
            label2.Location = new Point(43, 380);
            label2.Name = "label2";
            label2.Size = new Size(107, 21);
            label2.TabIndex = 7;
            label2.Text = "Contraseña:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(43, 327);
            label1.Name = "label1";
            label1.Size = new Size(70, 21);
            label1.TabIndex = 8;
            label1.Text = "Usuario:";
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(43, 176);
            label4.Name = "label4";
            label4.Size = new Size(77, 21);
            label4.TabIndex = 8;
            label4.Text = "Nombre:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(43, 228);
            label5.Name = "label5";
            label5.Size = new Size(159, 21);
            label5.TabIndex = 7;
            label5.Text = "Correo electrónico:";
            // 
            // txtNameRegistro
            // 
            txtNameRegistro.Location = new Point(43, 195);
            txtNameRegistro.Margin = new Padding(3, 2, 3, 2);
            txtNameRegistro.Name = "txtNameRegistro";
            txtNameRegistro.PlaceholderText = "Name";
            txtNameRegistro.Size = new Size(358, 23);
            txtNameRegistro.TabIndex = 10;
            // 
            // txtCorreoRegistro
            // 
            txtCorreoRegistro.Location = new Point(43, 248);
            txtCorreoRegistro.Margin = new Padding(3, 2, 3, 2);
            txtCorreoRegistro.Name = "txtCorreoRegistro";
            txtCorreoRegistro.PlaceholderText = "Email";
            txtCorreoRegistro.Size = new Size(358, 23);
            txtCorreoRegistro.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(43, 433);
            label6.Name = "label6";
            label6.Size = new Size(185, 21);
            label6.TabIndex = 7;
            label6.Text = "Confirmar contraseña:";
            // 
            // txtPasswordConfirmReg
            // 
            txtPasswordConfirmReg.Location = new Point(43, 452);
            txtPasswordConfirmReg.Margin = new Padding(3, 2, 3, 2);
            txtPasswordConfirmReg.Name = "txtPasswordConfirmReg";
            txtPasswordConfirmReg.PlaceholderText = "Confirm password";
            txtPasswordConfirmReg.Size = new Size(358, 23);
            txtPasswordConfirmReg.TabIndex = 9;
            txtPasswordConfirmReg.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(43, 277);
            label7.Name = "label7";
            label7.Size = new Size(87, 21);
            label7.TabIndex = 8;
            label7.Text = "Dirección:";
            // 
            // txtDireccionRegistro
            // 
            txtDireccionRegistro.Location = new Point(43, 296);
            txtDireccionRegistro.Margin = new Padding(3, 2, 3, 2);
            txtDireccionRegistro.Name = "txtDireccionRegistro";
            txtDireccionRegistro.PlaceholderText = "Adrees";
            txtDireccionRegistro.Size = new Size(358, 23);
            txtDireccionRegistro.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Cursor = Cursors.Hand;
            label8.ForeColor = Color.White;
            label8.Location = new Point(10, 9);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 15;
            label8.Text = "Volver";
            label8.Click += label8_Click;
            // 
            // RegistroFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Black;
            ClientSize = new Size(457, 562);
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
            Margin = new Padding(3, 2, 3, 2);
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