namespace ControlInventario_Presentacion.Screens.Forms
{
    partial class SettingsFrm
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
            lblTitleSettings = new Label();
            groupBox1 = new GroupBox();
            btnRegistrarUsu = new Button();
            btnAjcuentas = new Button();
            paneldesktop = new Panel();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitleSettings
            // 
            lblTitleSettings.AutoSize = true;
            lblTitleSettings.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitleSettings.ForeColor = Color.Gainsboro;
            lblTitleSettings.Location = new Point(12, 9);
            lblTitleSettings.Name = "lblTitleSettings";
            lblTitleSettings.Size = new Size(103, 24);
            lblTitleSettings.TabIndex = 2;
            lblTitleSettings.Text = "SETTINGS";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(37, 36, 81);
            groupBox1.Controls.Add(btnRegistrarUsu);
            groupBox1.Controls.Add(btnAjcuentas);
            groupBox1.Location = new Point(28, 68);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(233, 383);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // btnRegistrarUsu
            // 
            btnRegistrarUsu.BackColor = Color.Transparent;
            btnRegistrarUsu.FlatStyle = FlatStyle.Popup;
            btnRegistrarUsu.ForeColor = SystemColors.ButtonFace;
            btnRegistrarUsu.Location = new Point(6, 60);
            btnRegistrarUsu.Name = "btnRegistrarUsu";
            btnRegistrarUsu.Size = new Size(221, 23);
            btnRegistrarUsu.TabIndex = 1;
            btnRegistrarUsu.Text = "Registro de Cuentas";
            btnRegistrarUsu.UseVisualStyleBackColor = false;
            btnRegistrarUsu.Click += btnRegistrarUsu_Click;
            // 
            // btnAjcuentas
            // 
            btnAjcuentas.BackColor = Color.Transparent;
            btnAjcuentas.FlatStyle = FlatStyle.Popup;
            btnAjcuentas.ForeColor = SystemColors.ButtonFace;
            btnAjcuentas.Location = new Point(6, 22);
            btnAjcuentas.Name = "btnAjcuentas";
            btnAjcuentas.Size = new Size(221, 23);
            btnAjcuentas.TabIndex = 0;
            btnAjcuentas.Text = "Ajuste de Cuentas";
            btnAjcuentas.UseVisualStyleBackColor = false;
            btnAjcuentas.Click += btnAjcuentas_Click;
            // 
            // paneldesktop
            // 
            paneldesktop.Location = new Point(296, 68);
            paneldesktop.Name = "paneldesktop";
            paneldesktop.Size = new Size(1043, 429);
            paneldesktop.TabIndex = 4;
            // 
            // SettingsFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1381, 551);
            Controls.Add(paneldesktop);
            Controls.Add(groupBox1);
            Controls.Add(lblTitleSettings);
            Margin = new Padding(3, 2, 3, 2);
            Name = "SettingsFrm";
            Text = "SettingsFrm";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitleSettings;
        private GroupBox groupBox1;
        private Button btnAjcuentas;
        private Panel paneldesktop;
        private Button btnRegistrarUsu;
    }
}