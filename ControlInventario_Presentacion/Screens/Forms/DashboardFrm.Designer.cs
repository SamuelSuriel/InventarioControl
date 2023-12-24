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
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTitleDashboard
            // 
            lblTitleDashboard.Anchor = AnchorStyles.None;
            lblTitleDashboard.AutoSize = true;
            lblTitleDashboard.Font = new Font("Segoe UI Variable Display", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitleDashboard.Location = new Point(214, 9);
            lblTitleDashboard.Name = "lblTitleDashboard";
            lblTitleDashboard.Size = new Size(147, 31);
            lblTitleDashboard.TabIndex = 0;
            lblTitleDashboard.Text = "DASHBOARD";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.Dashboard;
            pictureBox1.Location = new Point(214, 69);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(934, 572);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.Anchor = AnchorStyles.None;
            iconPictureBox1.ForeColor = Color.Gainsboro;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.ChartArea;
            iconPictureBox1.IconColor = Color.Gainsboro;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 31;
            iconPictureBox1.Location = new Point(367, 9);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(37, 31);
            iconPictureBox1.TabIndex = 2;
            iconPictureBox1.TabStop = false;
            // 
            // DashboardFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1329, 653);
            Controls.Add(iconPictureBox1);
            Controls.Add(pictureBox1);
            Controls.Add(lblTitleDashboard);
            Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Gainsboro;
            Name = "DashboardFrm";
            Text = "DashboardFrm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitleDashboard;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}