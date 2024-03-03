using ControlInventario_Datos;
using ControlInventario_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlInventario_Presentacion.Screens.Forms
{
    public partial class ProveedoresFrm : Form
    {
        CN_Proveedores proveedoresCN = new CN_Proveedores();

        private string? idProveedor_ = null;
        private bool EsEditar = false;
        public ProveedoresFrm()
        {
            InitializeComponent();
        }

        private void ProveedoresFrm_Load(object sender, EventArgs e)
        {
            CargarProveedores();
            LimpiarControles();
            LlenarCbProductos();
        }

        private void LlenarCbProductos()
        {
            cbProductosProveedor.DataSource = proveedoresCN.ObtenerProductos();
            cbProductosProveedor.DisplayMember = "NombreProducto";
            cbProductosProveedor.ValueMember = "IdProducto";
        }

        private void CargarProveedores()
        {
            dgvProveedores.DataSource = proveedoresCN.MostrarProveedores();
            this.dgvProveedores.Columns["Idproveedor"].Visible = false;
            this.dgvProveedores.Columns["IdProductosSuministra"].Visible = false;
            this.dgvProveedores.Columns["Activo"].Visible = false;
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            if (EsValido())
            {

                Proveedores _proveedor = new()
                {
                    NombreProveedor = txtNombreProveedor.Text,
                    DireccionProveedor = txtDireccionProveedor.Text,
                    TelefonoProveedor = txtTelefonoProveedor.Text,
                    CorreoProveedor = txtCorreoProveedor.Text,
                    IdProductosSuministra = (int)cbProductosProveedor.SelectedValue
                };

                if (EsEditar == false)
                {
                    try
                    {
                        proveedoresCN.AgregarProveedor(_proveedor);
                        MessageBox.Show("SE INSERTÓ CORRECTAMENTE!");
                        LimpiarControles();
                        CargarProveedores();

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
                        int idProducto = Convert.ToInt32(idProveedor_);
                        proveedoresCN.EditarProveedor(Convert.ToInt32(idProducto), _proveedor);

                        MessageBox.Show("Se editó correctamente!");
                        LimpiarControles();
                        CargarProveedores();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo realizar la operación: " + ex);
                    }

                }

            }
        }

        private void btnEditarProveedor_Click(object sender, EventArgs e)
        {
            if (dgvProveedores.SelectedCells.Count > 0)
            {
                EsEditar = true;
                txtNombreProveedor.Text = dgvProveedores.CurrentRow.Cells["Proveedor"].Value.ToString();
                txtDireccionProveedor.Text = dgvProveedores.CurrentRow.Cells["Dirección"].Value.ToString();
                txtTelefonoProveedor.Text = dgvProveedores.CurrentRow.Cells["Teléfono"].Value.ToString();
                txtCorreoProveedor.Text = dgvProveedores.CurrentRow.Cells["Correo Electrónico"].Value.ToString();
                //cbProductosProveedor.SelectedValue = dgvProveedores.CurrentRow.Cells["IdProductosSuministra"].Value.ToString();
                cbProductosProveedor.Text = dgvProveedores.CurrentRow.Cells["Productos Suministra"].Value.ToString();

                idProveedor_ = dgvProveedores.CurrentRow.Cells["Idproveedor"].Value.ToString();

            }
        }

        private void btnEliminarProveedor_Click(object sender, EventArgs e)
        {
            if (dgvProveedores.SelectedCells.Count > 0)
            {
                string message = "¿Estás seguro de que quieres eliminar a este registro?";
                string title = "Eliminar registro";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);

                if (result == DialogResult.Yes)
                {
                    idProveedor_ = dgvProveedores.CurrentRow.Cells["Idproveedor"].Value.ToString();

                    proveedoresCN.EliminarProveedor(Convert.ToInt32(idProveedor_));
                    MessageBox.Show("Se eliminó correctamente!");
                    CargarProveedores();
                }
            }
            else
                MessageBox.Show("Seleccione una celda para eliminar!");
        }

        private void lblLimpiarProv_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }


        private void LimpiarControles()
        {
            txtNombreProveedor.Clear();
            txtDireccionProveedor.Clear();
            txtTelefonoProveedor.Clear();
            txtCorreoProveedor.Clear();
            cbProductosProveedor.SelectedValue = 0;
        }

        private bool EsValido()
        {
            bool Nombre = txtNombreProveedor.Text != "";
            bool Direccion = txtDireccionProveedor.Text != "";
            bool Telefono = txtTelefonoProveedor.Text != "";
            bool Correo = txtCorreoProveedor.Text != "";
            bool cbProducto = cbProductosProveedor.Text != "";

            if (Nombre && Direccion && Telefono && Correo && cbProducto)
                return true;
            else
                return false;
        }

      
    }
}
