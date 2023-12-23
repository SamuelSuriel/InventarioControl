namespace ControlInventario_Presentacion.Screens.Forms
{
    partial class DashboardFrm
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
            lblTitleDashboard = new Label();
            SuspendLayout();
            // 
            // lblTitleDashboard
            // 
            lblTitleDashboard.AutoSize = true;
            lblTitleDashboard.Font = new Font("Segoe UI Variable Display", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitleDashboard.Location = new Point(545, 69);
            lblTitleDashboard.Name = "lblTitleDashboard";
            lblTitleDashboard.Size = new Size(147, 31);
            lblTitleDashboard.TabIndex = 0;
            lblTitleDashboard.Text = "DASHBOARD";
            // 
            // DashboardFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1329, 653);
            Controls.Add(lblTitleDashboard);
            Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Gainsboro;
            Name = "DashboardFrm";
            Text = "DashboardFrm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitleDashboard;
    }
}