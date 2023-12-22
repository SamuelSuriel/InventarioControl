namespace ControlInventario_Presentacion.Screens.Forms
{
    partial class InformesFrm
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
            lblTitleInformes = new Label();
            SuspendLayout();
            // 
            // lblTitleInformes
            // 
            lblTitleInformes.AutoSize = true;
            lblTitleInformes.Font = new Font("Segoe UI Variable Display", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitleInformes.ForeColor = Color.Gainsboro;
            lblTitleInformes.Location = new Point(552, 51);
            lblTitleInformes.Name = "lblTitleInformes";
            lblTitleInformes.Size = new Size(123, 31);
            lblTitleInformes.TabIndex = 1;
            lblTitleInformes.Text = "INFORMES";
            // 
            // InformesFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(1329, 653);
            Controls.Add(lblTitleInformes);
            Name = "InformesFrm";
            Text = "InformesFrm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitleInformes;
    }
}