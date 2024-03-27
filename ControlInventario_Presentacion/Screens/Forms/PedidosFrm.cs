using ControlInventario_Datos;
using ControlInventario_Negocio;

namespace ControlInventario_Presentacion.Screens.Forms
{
    public partial class PedidosFrm : Form
    {
        CN_Pedidos pedidosCN = new CN_Pedidos();
        CN_Productos cNProductos = new CN_Productos();
        CN_Stocks _StocksCN = new CN_Stocks();

        private string? idPedido_ = null;
        private bool EsEditar = false;
        public PedidosFrm()
        {
            InitializeComponent();
            dgvPedidosProveedores.DataBindingComplete += dgvPedidosProveedores_DataBindingComplete;
        }

        private void PedidosFrm_Load(object sender, EventArgs e)
        {
            CargarPedidos();
            LlenarCbProveedores();
            LlenarCbProductos();
            LlenarEstatus();
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

        private void LlenarEstatus()
        {
            cbEstatusPedido.DataSource = pedidosCN.GetListaEstatusPedidos();
            cbEstatusPedido.DisplayMember = "Estatus";
            cbEstatusPedido.ValueMember = "IdEstatusPedido";
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
            cbEstatusPedido.SelectedValue = 0;
            cbEstatusPedido.Text = "Seleccione un estatus...";

        }

        private void CargarPedidos()
        {
            dgvPedidosProveedores.DataSource = pedidosCN.MostrarPedidos();
            this.dgvPedidosProveedores.Columns["PedidoID"].Visible = false;
            this.dgvPedidosProveedores.Columns["IdProveedor"].Visible = false;
            this.dgvPedidosProveedores.Columns["IdProducto"].Visible = false;
            this.dgvPedidosProveedores.Columns["IdEstatus"].Visible = false;
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
                    IdEstatusPedido = (int)cbEstatusPedido.SelectedValue,
                    FechaPedido = Convert.ToDateTime(dtpFechaPedido.Text),
                    CantidadProductos = Convert.ToInt32(txtCantidadProductos.Text)
                };

                if (EsEditar == false)
                {
                    try
                    {
                        pedidosCN.AgregarPedido(_pedido);
                        // Actualizando cantidad de productos
                        if (_pedido.IdEstatusPedido == 3)
                        {
                            ActualizarCantidadStockProducto(_pedido.Idproducto, (int)_pedido.CantidadProductos);
                        }
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
                        // Actualizando cantidad de productos
                        if (_pedido.IdEstatusPedido == 3)
                        {
                            ActualizarCantidadStockProducto(_pedido.Idproducto, (int)_pedido.CantidadProductos);
                        }
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

        private void ActualizarCantidadStockProducto(int idProducto, int Cantproductos)
        {
            Productos producto = cNProductos.GetProductoById(idProducto);
            Stocks stocks = new Stocks
            {
                CodigoProducto = producto.CodigoProducto,
                NombreProducto = producto.NombreProducto,
                CantidadStock = (int)(producto.CantidadStock + Cantproductos)
            };
            _StocksCN.EditarCantidadRegStock(stocks);
            cNProductos.EditarCantidadProducto(stocks);
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
                cbEstatusPedido.Text = dgvPedidosProveedores.CurrentRow.Cells["Estatus"].Value.ToString();

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
            
            private void dgvPedidosProveedores_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
            {

            dgvPedidosProveedores.DefaultCellStyle.BackColor = Color.SkyBlue;


            dgvPedidosProveedores.DefaultCellStyle.ForeColor = Color.Black;


            dgvPedidosProveedores.DefaultCellStyle.Font = new Font("Arial", 10);


            dgvPedidosProveedores.CellBorderStyle = DataGridViewCellBorderStyle.Single;


            dgvPedidosProveedores.RowsDefaultCellStyle.SelectionBackColor = Color.Orange;


            dgvPedidosProveedores.RowsDefaultCellStyle.SelectionForeColor = Color.White;
            }
        }
    }

