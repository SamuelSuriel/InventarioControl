using ControlInventario_Datos;
using ControlInventario_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlInventario_Presentacion.Screens.Forms
{
    public partial class InformesFrm : Form
    {
        CN_Productos productos = new CN_Productos();
        CN_Informes cNInformes = new CN_Informes();
        public InformesFrm()
        {
            InitializeComponent();
        }

        private void btnBuscarInforme_Click(object sender, EventArgs e)
        {
            string crt = txtCriteriosInforme.Text;
            int id = 0;
            string date = Convert.ToDateTime(dtpFechaVenta.Text).ToString();
            if (cbProductosInforme.SelectedValue != null)
            {
                id = (int)cbProductosInforme.SelectedValue;
            }
            CargarDgvInforme(crt, id, date);
        }

        private void LlenarCbProductos()
        {
            cbProductosInforme.DataSource = productos.ObtenerProductos();
            cbProductosInforme.DisplayMember = "NombreProducto";
            cbProductosInforme.ValueMember = "IdProducto";
        }

        private void InformesFrm_Load(object sender, EventArgs e)
        {
            LlenarCbProductos();
            cbProductosInforme.SelectedValue = 0;
            cbProductosInforme.Text = "Seleccione un producto...";

        }

        private void CargarDgvInforme(string? cr, int idProd, string? fecha)
        {
            dgvInformeVentas.DataSource = cNInformes.MostrarRegistros(cr, idProd, fecha);
            this.dgvInformeVentas.Columns["IdRegistroVenta"].Visible = false;
            this.dgvInformeVentas.Columns["IdProducto"].Visible = false;
            this.dgvInformeVentas.Columns["Activo"].Visible = false;

        }

        private void btnGenerarInforme_Click(object sender, EventArgs e)
        {
            LimpiarFiltros();

            MessageBox.Show("Gracias por generar el informe!");
        }

        private void LimpiarFiltros()
        {
            dtpFechaVenta.Text = string.Empty;
            dtpFechaVenta.Text = "";
            txtCriteriosInforme.Text = "";
            cbProductosInforme.SelectedValue = 0;
            cbProductosInforme.Text = "Seleccione un producto...";
        }
    }
}
