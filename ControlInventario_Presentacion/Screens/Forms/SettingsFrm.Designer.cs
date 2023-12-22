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
            SuspendLayout();
            // 
            // lblTitleSettings
            // 
            lblTitleSettings.AutoSize = true;
            lblTitleSettings.Font = new Font("Segoe UI Variable Display", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitleSettings.ForeColor = Color.Gainsboro;
            lblTitleSettings.Location = new Point(538, 41);
            lblTitleSettings.Name = "lblTitleSettings";
            lblTitleSettings.Size = new Size(114, 31);
            lblTitleSettings.TabIndex = 2;
            lblTitleSettings.Text = "SETTINGS";
            // 
            // SettingsFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(1329, 653);
            Controls.Add(lblTitleSettings);
            Name = "SettingsFrm";
            Text = "SettingsFrm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitleSettings;
    }
}