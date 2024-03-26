using ControlInventario_Datos;
using ControlInventario_Negocio;
using Microsoft.Win32;
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
    public partial class PedidosFrm : Form
    {
        CN_Pedidos pedidosCN = new CN_Pedidos();
        CN_Productos cNProductos = new CN_Productos();

        private string? idPedido_ = null;
        private bool EsEditar = false;
        public PedidosFrm()
        {
            InitializeComponent();
        }

        private void PedidosFrm_Load(object sender, EventArgs e)
        {
            CargarPedidos();
            LlenarCbProveedores();
            LlenarCbProductos();
            LimpiarControles();

        }

        private void LlenarCbProveedores()
        {
            cbProveedoresPedidos.DataSource = pedidosCN.ObtenerListaProveedores();
            cbProveedoresPedidos.DisplayMember = "NombreProveedor";
            cbProveedoresPedidos.ValueMember = "IdProveedor";

        }

        private void LlenarCbProductos()
        {
            cbProdPedidos.DataSource = cNProductos.ObtenerProductos();
            cbProdPedidos.DisplayMember = "NombreProducto";
            cbProdPedidos.ValueMember = "IdProducto";
        }

        private void LimpiarControles()
        {
            cbProveedoresPedidos.SelectedValue = 0;
            cbProveedoresPedidos.Text = "Seleccione el proveedor...";
            txtCantidadProductos.Clear();
            dtpFechaPedido.Text = string.Empty;
            dtpFechaPedido.Text = "";
            cbProdPedidos.SelectedValue = 0;
            cbProdPedidos.Text = "Seleccione un producto...";
        }

        private void CargarPedidos()
        {
            dgvPedidosProveedores.DataSource = pedidosCN.MostrarPedidos();
            this.dgvPedidosProveedores.Columns["PedidoID"].Visible = false;
            this.dgvPedidosProveedores.Columns["IdProveedor"].Visible = false;
            this.dgvPedidosProveedores.Columns["IdProducto"].Visible = false;
            this.dgvPedidosProveedores.Columns["Activo"].Visible = false;
        }

        private void btnGuardarPedido_Click(object sender, EventArgs e)
        {
            if (EsValido())
            {

                PedidosProveedores _pedido = new()
                {
                    IdProveedor = (int)cbProveedoresPedidos.SelectedValue,
                    Idproducto = (int)cbProdPedidos.SelectedValue,
                    FechaPedido = Convert.ToDateTime(dtpFechaPedido.Text),
                    CantidadProductos = Convert.ToInt32(txtCantidadProductos.Text)
                };

                if (EsEditar == false)
                {
                    try
                    {
                        pedidosCN.AgregarPedido(_pedido);
                        MessageBox.Show("SE INSERTÓ CORRECTAMENTE!");
                        LimpiarControles();
                        cbProdPedidos.Enabled = true;
                        CargarPedidos();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo realizar la operación: " + ex);
                    }
                }

                if (EsEditar == true)
                {
                    try
                    {
                        int idPedido = Convert.ToInt32(idPedido_);
                        pedidosCN.EditarPedido(idPedido, _pedido);

                        MessageBox.Show("Se editó correctamente!");
                        LimpiarControles();
                        cbProdPedidos.Enabled = true;
                        CargarPedidos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo realizar la operación: " + ex);
                    }

                }

            }
        }

        private void btnEditarPedido_Click(object sender, EventArgs e)
        {
            if (dgvPedidosProveedores.SelectedCells.Count > 0)
            {
                EsEditar = true;
                txtCantidadProductos.Text = dgvPedidosProveedores.CurrentRow.Cells["Cantidad Productos"].Value.ToString();
                dtpFechaPedido.Text = dgvPedidosProveedores.CurrentRow.Cells["Fecha Pedido"].Value.ToString();
                cbProveedoresPedidos.Text = dgvPedidosProveedores.CurrentRow.Cells["Proveedor"].Value.ToString();
                cbProdPedidos.Text = dgvPedidosProveedores.CurrentRow.Cells["Producto"].Value.ToString();

                idPedido_ = dgvPedidosProveedores.CurrentRow.Cells["PedidoID"].Value.ToString();

            }
        }

        private void btnEliminarPedido_Click(object sender, EventArgs e)
        {
            if (dgvPedidosProveedores.SelectedCells.Count > 0)
            {
                string message = "¿Estás seguro de que quieres eliminar a este registro?";
                string title = "Eliminar registro";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);

                if (result == DialogResult.Yes)
                {
                    idPedido_ = dgvPedidosProveedores.CurrentRow.Cells["PedidoID"].Value.ToString();

                    pedidosCN.EliminarPedido(Convert.ToInt32(idPedido_));
                    MessageBox.Show("Se eliminó correctamente!");
                    CargarPedidos();
                }
            }
            else
                MessageBox.Show("Seleccione una celda para eliminar!");
        }

        private void btnLimpiarCamposPedido_Click(object sender, EventArgs e)
        {
            LimpiarControles();
            cbProdPedidos.Enabled = true;
        }

        private bool EsValido()
        {
            bool Cantidad = txtCantidadProductos.Text != "";
            bool Fecha = dtpFechaPedido.Text != "";
            bool Proveedor = cbProveedoresPedidos.Text != "";
            bool producto = cbProdPedidos.Text != "";

            if (Cantidad && Fecha && Proveedor && producto)
                return true;
            else
                return false;
        }

        private void cbProveedoresPedidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProveedoresPedidos.SelectedValue is int idProveedor && idProveedor > 0)
            {
                Productos productoCN = cNProductos.GetProductosByProveedor(idProveedor);

                cbProdPedidos.SelectedValue = productoCN.IdProducto;
                cbProdPedidos.Text = productoCN.NombreProducto;

                cbProdPedidos.Enabled = false;
            }
        }
    }
}
