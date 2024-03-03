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
    public partial class PedidosFrm : Form
    {
        CN_Pedidos pedidosCN = new CN_Pedidos();

        private string? idPedido_ = null;
        private bool EsEditar = false;
        public PedidosFrm()
        {
            InitializeComponent();
        }

        private void PedidosFrm_Load(object sender, EventArgs e)
        {
            CargarPedidos();
            LimpiarControles();
            LlenarCbProveedores();
        }

        private void LlenarCbProveedores()
        {
            cbProveedoresPedidos.DataSource = pedidosCN.ObtenerListaProveedores();
            cbProveedoresPedidos.DisplayMember = "NombreProveedor";
            cbProveedoresPedidos.ValueMember = "IdProveedor";

        }

        private void LimpiarControles()
        {
            cbProveedoresPedidos.SelectedValue = 0;
            txtCantidadProductos.Clear();
            dtpFechaPedido.Text = string.Empty;

            //dtpFechaPedido.CustomFormat = " ";
            //dtpFechaPedido.Format = DateTimePickerFormat.Custom;
        }

        private void CargarPedidos()
        {
            dgvPedidosProveedores.DataSource = pedidosCN.MostrarPedidos();
            this.dgvPedidosProveedores.Columns["PedidoID"].Visible = false;
            this.dgvPedidosProveedores.Columns["IdProveedor"].Visible = false;
            this.dgvPedidosProveedores.Columns["Activo"].Visible = false;
        }

        private void btnGuardarPedido_Click(object sender, EventArgs e)
        {
            if (EsValido())
            {

                PedidosProveedores _pedido = new()
                {
                    IdProveedor = (int)cbProveedoresPedidos.SelectedValue,
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
                //cbProductosProveedor.SelectedValue = dgvProveedores.CurrentRow.Cells["IdProductosSuministra"].Value.ToString();
                cbProveedoresPedidos.Text = dgvPedidosProveedores.CurrentRow.Cells["Proveedor"].Value.ToString();

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
        }

        private bool EsValido()
        {
            bool Cantidad = txtCantidadProductos.Text != "";
            bool Fecha = dtpFechaPedido.Text != "";
            bool Proveedor = cbProveedoresPedidos.Text != "";

            if (Cantidad && Fecha && Proveedor)
                return true;
            else
                return false;
        }
    }
}
