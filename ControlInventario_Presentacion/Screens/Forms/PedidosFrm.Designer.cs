namespace ControlInventario_Presentacion.Screens.Forms
{
    partial class PedidosFrm
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
            lblTitlePedidos = new Label();
            SuspendLayout();
            // 
            // lblTitlePedidos
            // 
            lblTitlePedidos.AutoSize = true;
            lblTitlePedidos.Font = new Font("Segoe UI Variable Display", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitlePedidos.ForeColor = Color.Gainsboro;
            lblTitlePedidos.Location = new Point(557, 50);
            lblTitlePedidos.Name = "lblTitlePedidos";
            lblTitlePedidos.Size = new Size(106, 31);
            lblTitlePedidos.TabIndex = 2;
            lblTitlePedidos.Text = "PEDIDOS";
            // 
            // PedidosFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(1329, 653);
            Controls.Add(lblTitlePedidos);
            Name = "PedidosFrm";
            Text = "PedidosFrm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitlePedidos;
    }
}