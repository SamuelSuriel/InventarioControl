namespace ControlInventario_Presentacion.Screens.Forms
{
    partial class VentasFrm
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
            lblTitleVentas = new Label();
            SuspendLayout();
            // 
            // lblTitleVentas
            // 
            lblTitleVentas.AutoSize = true;
            lblTitleVentas.Font = new Font("Segoe UI Variable Display", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitleVentas.ForeColor = Color.Gainsboro;
            lblTitleVentas.Location = new Point(541, 39);
            lblTitleVentas.Name = "lblTitleVentas";
            lblTitleVentas.Size = new Size(94, 31);
            lblTitleVentas.TabIndex = 2;
            lblTitleVentas.Text = "VENTAS";
            // 
            // VentasFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1329, 653);
            Controls.Add(lblTitleVentas);
            Name = "VentasFrm";
            Text = "VentasFrm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitleVentas;
    }
}