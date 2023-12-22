namespace ControlInventario_Presentacion.Screens.Forms
{
    partial class ProductosFrm
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
            lblTitleProducto = new Label();
            SuspendLayout();
            // 
            // lblTitleProducto
            // 
            lblTitleProducto.AutoSize = true;
            lblTitleProducto.Font = new Font("Segoe UI Variable Display", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitleProducto.ForeColor = Color.Gainsboro;
            lblTitleProducto.Location = new Point(551, 41);
            lblTitleProducto.Name = "lblTitleProducto";
            lblTitleProducto.Size = new Size(134, 31);
            lblTitleProducto.TabIndex = 2;
            lblTitleProducto.Text = "PRODUCTO";
            // 
            // ProductosFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(1329, 653);
            Controls.Add(lblTitleProducto);
            Name = "ProductosFrm";
            Text = "ProductosFrm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitleProducto;
    }
}