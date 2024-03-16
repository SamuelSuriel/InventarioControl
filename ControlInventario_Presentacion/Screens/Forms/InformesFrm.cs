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

            CargarDgvInforme();
        }

        private void LlenarCbProductos()
        {
            cbProductosInforme.DataSource = productos.ObtenerProductos();
            cbProductosInforme.DisplayMember = "NombreProducto";
            cbProductosInforme.ValueMember = "IdProducto";
        }

        private void LlenarCbProveedorProductos()
        {
            cbProductoproveedor.DataSource = productos.ObtenerProductos();
            cbProductoproveedor.DisplayMember = "NombreProducto";
            cbProductoproveedor.ValueMember = "IdProducto";
        }

        private void LlenarCbStocksProductos()
        {
            cbStockProductos.DataSource = productos.ObtenerProductos();
            cbStockProductos.DisplayMember = "NombreProducto";
            cbStockProductos.ValueMember = "IdProducto";
        }

        private void InformesFrm_Load(object sender, EventArgs e)
        {
            LlenarCbProductos();
            cbProductosInforme.SelectedValue = 0;
            cbProductosInforme.Text = "Seleccione un producto...";
            LlenarCbProveedores();
            cbProveedoresInforme.SelectedValue = 0;
            cbProveedoresInforme.Text = "Seleccione un proveedor...";
            LlenarCbProveedorProductos();
            cbProductoproveedor.SelectedValue = 0;
            cbProductoproveedor.Text = "Seleccione un producto...";
            LlenarCbStocksProductos();
            cbStockProductos.SelectedValue = 0;
            cbStockProductos.Text = "Seleccione un producto...";
        }

        private void LlenarCbProveedores()
        {
            cbProveedoresInforme.DataSource = cNInformes.ObtenerListaProveedores();
            cbProveedoresInforme.DisplayMember = "NombreProveedor";
            cbProveedoresInforme.ValueMember = "IdProveedor";

        }

        private void CargarDgvInforme()
        {
            if (cbTipoInforme.SelectedIndex == 0)
            {
                string crt = txtCriteriosInforme.Text;
                int id = 0;
                DateTime date = Convert.ToDateTime(dtpFechaVenta.Text);
                if (cbProductosInforme.SelectedValue != null)
                {
                    id = (int)cbProductosInforme.SelectedValue;
                }
                dgvInformeVentas.Columns.Clear();
                CargarDgvVentas(crt, id, date);
            }
            else if (cbTipoInforme.SelectedIndex == 1)
            {
                string crt = txtCriterioStockInforme.Text;
                int id = 0;
                if (cbProductosInforme.SelectedValue != null)
                {
                    id = (int)cbProductoproveedor.SelectedValue;
                }
                dgvInformeVentas.Columns.Clear();
                CargarDgvStocks(id, crt);
            }
            else if (cbTipoInforme.SelectedIndex == 2)
            {
                int idprod = 0;
                if (cbProductoproveedor.SelectedValue != null)
                {
                    idprod = (int)cbProductoproveedor.SelectedValue;
                }
                int idprove = 0;
                if (cbProveedoresInforme.SelectedValue != null)
                {
                    idprove = (int)cbProveedoresInforme.SelectedValue;
                }
                dgvInformeVentas.Columns.Clear();
                CargarProveedores(idprod, idprove);
            }

        }

        private void CargarDgvVentas(string? cr, int idProd, DateTime? fecha)
        {
            dgvInformeVentas.DataSource = cNInformes.MostrarRegistros(cr, idProd, fecha);
            this.dgvInformeVentas.Columns["IdRegistroVenta"].Visible = false;
            this.dgvInformeVentas.Columns["IdProducto"].Visible = false;
            this.dgvInformeVentas.Columns["Activo"].Visible = false;

        }

        private void CargarDgvStocks(int IdProducto, string? cr)
        {
            dgvInformeVentas.DataSource = cNInformes.LlenarDgvStocks(IdProducto, cr);
            this.dgvInformeVentas.Columns["IdStock"].Visible = false;
            this.dgvInformeVentas.Columns["Activo"].Visible = false;

        }

        private void CargarProveedores(int idProducto, int idProveedor)
        {
            dgvInformeVentas.DataSource = cNInformes.MostrarProveedores(idProducto, idProveedor);
            this.dgvInformeVentas.Columns["Idproveedor"].Visible = false;
            this.dgvInformeVentas.Columns["IdProductosSuministra"].Visible = false;
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
            txtCriterioStockInforme.Text = "";
            cbProductosInforme.SelectedValue = 0;
            cbProductosInforme.Text = "Seleccione un producto...";
            cbProductoproveedor.SelectedValue = 0;
            cbProductoproveedor.Text = "Seleccione un producto...";
            dgvInformeVentas.Columns.Clear();
        }

        private void cbTipoInforme_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvInformeVentas.Columns.Clear();
            if (cbTipoInforme.SelectedIndex == 0)
            {
                groupBoxStocks.Visible = false;
                groupBoxProveedores.Visible = false;
                groupBoxVentas.Visible = true;
            }
            else if (cbTipoInforme.SelectedIndex == 1)
            {
                groupBoxProveedores.Visible = false;
                groupBoxVentas.Visible = false;
                groupBoxStocks.Visible = true;
            }
            else if (cbTipoInforme.SelectedIndex == 2)
            {
                groupBoxVentas.Visible = false;
                groupBoxStocks.Visible = false;
                groupBoxProveedores.Visible = true;
            }
            else
            {
                MessageBox.Show("Seleccione un tipo de informe..!");
            }
        }
    }
}
