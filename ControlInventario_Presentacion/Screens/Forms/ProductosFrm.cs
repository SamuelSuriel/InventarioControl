using ControlInventario_Datos;
using ControlInventario_Negocio;

namespace ControlInventario_Presentacion.Screens.Forms
{
    public partial class ProductosFrm : Form
    {
        CN_Productos productosCN = new CN_Productos();

        private string? idProducto_ = null;
        private bool EsEditar = false;

        public ProductosFrm()
        {
            InitializeComponent();
        }

        private void ProductosFrm_Load(object sender, EventArgs e)
        {
            CargarProductos();
            LimpiarControles();

        }

        private void LimpiarControles()
        {
            txtNombreProducto.Clear();
            txtCodigoProducto.Clear();
            txtDescripcion.Clear();
            txtCantidadStock.Clear();
            txtPrecioCompra.Clear();
            txtPrecioVenta.Clear();
        }

        private void CargarProductos()
        {
            dgvProductos.DataSource = productosCN.MostrarProductos();
            this.dgvProductos.Columns["IdProducto"].Visible = false;
            this.dgvProductos.Columns["Activo"].Visible = false;
        }

        private void lblLimpiarCamporProd_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (EsValido())
            {

                Productos _productos = new()
                {
                    NombreProducto = txtNombreProducto.Text,
                    Descripcion = txtDescripcion.Text,
                    CantidadStock = Convert.ToInt32(txtCantidadStock.Text),
                    CodigoProducto = txtCodigoProducto.Text,
                    PrecioVenta = Convert.ToDouble(txtPrecioVenta.Text),
                    PrecioCompra = Convert.ToDouble(txtPrecioCompra.Text)
                };

                if (EsEditar == false)
                {
                    try
                    {
                        productosCN.Agregarproducto(_productos);
                        MessageBox.Show("SE INSERTÓ CORRECTAMENTE!");
                        LimpiarControles();
                        CargarProductos();

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
                        int idProducto = Convert.ToInt32(idProducto_);
                        productosCN.EditarProducto(Convert.ToInt32(idProducto), _productos);

                        MessageBox.Show("Se editó correctamente!");
                        LimpiarControles();
                        CargarProductos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo realizar la operación: " + ex);
                    }

                }

            }
        }

        private bool EsValido()
        {
            bool producto = txtNombreProducto.Text != "";
            bool descripcion = txtDescripcion.Text != "";
            bool cantidadStock = txtCantidadStock.Text != "";
            bool codigoProducto = txtCodigoProducto.Text != "";
            bool precioVenta = txtPrecioVenta.Text != "";
            bool precioCompra = txtPrecioCompra.Text != "";

            if (producto && descripcion && cantidadStock && codigoProducto && precioVenta && precioCompra)
                return true;
            else
                return false;
        }

        private void btnEditarProducto_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedCells.Count > 0)
            {
                EsEditar = true;
                txtNombreProducto.Text = dgvProductos.CurrentRow.Cells["Producto"].Value.ToString();
                txtDescripcion.Text = dgvProductos.CurrentRow.Cells["Descripcion"].Value.ToString();
                txtCantidadStock.Text = dgvProductos.CurrentRow.Cells["Cantidad en Stock"].Value.ToString();
                txtCodigoProducto.Text = dgvProductos.CurrentRow.Cells["Código"].Value.ToString();
                txtPrecioVenta.Text = dgvProductos.CurrentRow.Cells["Precio Venta"].Value.ToString();
                txtPrecioCompra.Text = dgvProductos.CurrentRow.Cells["Precio Compra"].Value.ToString();

                idProducto_ = dgvProductos.CurrentRow.Cells["IdProducto"].Value.ToString();

            }
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedCells.Count > 0)
            {
                string message = "¿Estás seguro de que quieres eliminar a este registro?";
                string title = "Eliminar registro";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);

                if (result == DialogResult.Yes)
                {
                    idProducto_ = dgvProductos.CurrentRow.Cells["IdProducto"].Value.ToString();

                    productosCN.EliminarProducto(Convert.ToInt32(idProducto_));
                    MessageBox.Show("Se eliminó correctamente!");
                    CargarProductos();
                }
            }
            else
                MessageBox.Show("Seleccione una celda para eliminar!");
        }
    }
}
