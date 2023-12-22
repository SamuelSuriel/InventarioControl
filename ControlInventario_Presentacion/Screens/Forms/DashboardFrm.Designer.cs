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
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTitleDashboard
            // 
            lblTitleDashboard.AutoSize = true;
            lblTitleDashboard.Font = new Font("Segoe UI Variable Display", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitleDashboard.Location = new Point(298, 22);
            lblTitleDashboard.Name = "lblTitleDashboard";
            lblTitleDashboard.Size = new Size(193, 31);
            lblTitleDashboard.TabIndex = 0;
            lblTitleDashboard.Text = "BIENVENIDOS/AS";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo_SRS;
            pictureBox1.Location = new Point(140, 86);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(504, 288);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // DashboardFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(lblTitleDashboard);
            Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Gainsboro;
            Name = "DashboardFrm";
            Text = "DashboardFrm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitleDashboard;
        private PictureBox pictureBox1;
    }
}