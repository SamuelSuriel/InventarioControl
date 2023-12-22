namespace ControlInventario_Presentacion.Screens.Forms
{
    partial class ProveedoresFrm
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
            lblTitleProveedores = new Label();
            SuspendLayout();
            // 
            // lblTitleProveedores
            // 
            lblTitleProveedores.AutoSize = true;
            lblTitleProveedores.Font = new Font("Segoe UI Variable Display", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitleProveedores.ForeColor = Color.Gainsboro;
            lblTitleProveedores.Location = new Point(287, 34);
            lblTitleProveedores.Name = "lblTitleProveedores";
            lblTitleProveedores.Size = new Size(164, 31);
            lblTitleProveedores.TabIndex = 2;
            lblTitleProveedores.Text = "PROVEEDORES";
            // 
            // ProveedoresFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTitleProveedores);
            Name = "ProveedoresFrm";
            Text = "ProveedoresFrm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitleProveedores;
    }
}