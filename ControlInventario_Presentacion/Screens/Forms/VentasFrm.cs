using ControlInventario_Datos;
using ControlInventario_Negocio;
using ControlInventario_Presentacion.Clases;
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
    public partial class VentasFrm : Form
    {
        CD_Conexion conexion = new CD_Conexion();
        CN_Proveedores proveedoresCN = new CN_Proveedores();
        CN_Ventas _Ventas = new CN_Ventas();
        CN_Stocks _StocksCN = new CN_Stocks();
        CN_Productos _cNProductos = new CN_Productos();

        public VentasFrm()
        {
            InitializeComponent();
        }

        private void txtEfectivo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lblDevolucion.Text = (float.Parse(txtEfectivo.Text) - float.Parse(lblTotalaPagar.Text)).ToString();

            }
            catch { }

            if (txtEfectivo.Text == "")
            {
                lblDevolucion.Text = "";
            }
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            DataGridViewRow file = new DataGridViewRow();

            if (txtCantidadProductos.Text != "")
            {
                file.CreateCells(dgvVentas);

                file.Cells[0].Value = lblCodigoProducto.Text;
                file.Cells[1].Value = lblNombreProducto.Text;
                file.Cells[2].Value = lblPrecioProducto.Text;
                file.Cells[3].Value = txtCantidadProductos.Text;
                file.Cells[4].Value = (float.Parse(lblPrecioProducto.Text) * float.Parse(txtCantidadProductos.Text)).ToString();
                file.Cells[5].Value = lblIdProducto.Text;

                dgvVentas.Rows.Add(file);
            }
            else
            {
                MessageBox.Show("Ingrese la cantidad!");
            }

            lblCodigoProducto.Text = lblNombreProducto.Text = lblPrecioProducto.Text = txtCantidadProductos.Text = "";
            cbProductosVenta.Text = "";
            obtenerTotal();

        }

        private void VentasFrm_Load(object sender, EventArgs e)
        {
            LlenarCbProductos();
            cbProductosVenta.SelectedValue = 0;
            cbProductosVenta.Text = "Seleccione un producto...";
        }

        private void LlenarCbProductos()
        {
            cbProductosVenta.DataSource = _cNProductos.ObtenerProductos();
            cbProductosVenta.DisplayMember = "NombreProducto";
            cbProductosVenta.ValueMember = "IdProducto";

        }

        private void cbProductosVenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cod = 0;
            if (cbProductosVenta.SelectedItem != null)
            {
                cod = ((Productos)cbProductosVenta.SelectedItem).IdProducto;
            }
            try
            {
                using (SqlCommand cmd = new SqlCommand("ObtenerProductoById", conexion.Conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", cod);
                    conexion.AbrirConexion();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        lblIdProducto.Text = "";
                        lblCodigoProducto.Text = "";
                        lblNombreProducto.Text = "";
                        lblPrecioProducto.Text = "";

                        while (dr.Read())
                        {
                            lblIdProducto.Text = dr["IdProducto"].ToString();
                            lblCodigoProducto.Text = dr["CodigoProducto"].ToString();
                            lblNombreProducto.Text = dr["NombreProducto"].ToString();
                            lblPrecioProducto.Text = dr["PrecioVenta"].ToString();
                        }
                        dr.Close();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo realizar la operación: " + ex);
            }

        }

        public void obtenerTotal()
        {
            float costot = 0;
            double totalitbis = 0;
            double totalaPagar = 0;
            int contador = 0;

            contador = dgvVentas.RowCount;

            for (int i = 0; i < contador; i++)
            {
                costot += float.Parse(dgvVentas.Rows[i].Cells[4].Value.ToString());
            }

            totalitbis = costot * 0.18;
            totalaPagar = totalitbis + costot;

            lblSubTotal.Text = costot.ToString();
            lblItbis.Text = totalitbis.ToString();
            lblTotalaPagar.Text = totalaPagar.ToString();
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult rpta = MessageBox.Show("¿Desea eliminar el producto?",
                    "Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (rpta == DialogResult.Yes)
                {
                    dgvVentas.Rows.Remove(dgvVentas.CurrentRow);
                }
            }
            catch { }
            obtenerTotal();
        }

        private void btnEjecutarVenta_Click(object sender, EventArgs e)
        {
            clsFactura.CreaTicket Ticket1 = new clsFactura.CreaTicket();
            if (txtEfectivo.Text != "")
            {


                Ticket1.TextoCentro("Empresa xxxxx "); //imprime una linea de descripcion
                Ticket1.TextoCentro("**********************************");

                Ticket1.TextoIzquierda("");
                Ticket1.TextoCentro("Factura de Venta"); //imprime una linea de descripcion
                Ticket1.TextoIzquierda("No Fac: 0120102");
                Ticket1.TextoIzquierda("Fecha:" + DateTime.Now.ToShortDateString() + " Hora:" + DateTime.Now.ToShortTimeString());
                Ticket1.TextoIzquierda("Le Atendio: xxxx");
                Ticket1.TextoIzquierda("");
                clsFactura.CreaTicket.LineasGuion();

                clsFactura.CreaTicket.EncabezadoVenta();
                clsFactura.CreaTicket.LineasGuion();
                foreach (DataGridViewRow r in dgvVentas.Rows)
                {
                    // PROD                     //PrECIO                                    CANT                         TOTAL
                    Ticket1.AgregaArticulo(r.Cells[1].Value.ToString(), double.Parse(r.Cells[2].Value.ToString()), int.Parse(r.Cells[3].Value.ToString()), double.Parse(r.Cells[4].Value.ToString())); //imprime una linea de descripcion
                }


                clsFactura.CreaTicket.LineasGuion();
                Ticket1.TextoIzquierda(" ");
                Ticket1.AgregaTotales("Total", double.Parse(lblTotalaPagar.Text)); // imprime linea con total
                Ticket1.TextoIzquierda(" ");
                Ticket1.AgregaTotales("Efectivo Entregado:", double.Parse(txtEfectivo.Text));
                Ticket1.AgregaTotales("Efectivo Devuelto:", double.Parse(lblDevolucion.Text));


                // Ticket1.LineasTotales(); // imprime linea 

                Ticket1.TextoIzquierda(" ");
                Ticket1.TextoCentro("**********************************");
                Ticket1.TextoCentro("*     Gracias por preferirnos    *");

                Ticket1.TextoCentro("**********************************");
                Ticket1.TextoIzquierda(" ");
                string impresora = "Microsoft XPS Document Writer";
                Ticket1.ImprimirTiket(impresora);

                MessageBox.Show("Gracias por preferirnos");

                //this.Close();

                EjecutarVenta();
            }
            else
            {
                MessageBox.Show("Por favor ingresa el efectivo!");
            }

        }

        public void EjecutarVenta()
        {
            try
            {
                RegistroVentas registro = new RegistroVentas();
                int contador = dgvVentas.RowCount;

                for (int i = 0; i < contador; i++)
                {
                    registro.CodigoProducto = dgvVentas.Rows[i].Cells[0].Value?.ToString();
                    registro.PrecioVenta = float.Parse(dgvVentas.Rows[i].Cells[2].Value?.ToString());
                    registro.CantidadVendida = Int32.Parse(dgvVentas.Rows[i].Cells[3].Value?.ToString());
                    registro.IdProducto = Int32.Parse(dgvVentas.Rows[i].Cells[5].Value?.ToString());
                    registro.ClienteVenta = txtClienteVenta.Text;
                    registro.IdUsuarioCreacion = Login.IdUsuario;

                    // Validar que la cantidad a vender no exceda el stock del producto.
                    Productos producto = _cNProductos.GetProductoById(registro.IdProducto);
                    if (producto != null && registro.CantidadVendida <= producto.CantidadStock)
                    {
                        _Ventas.EjecutarVenta(registro);

                        Stocks stocks = new Stocks
                        {
                            CodigoProducto = registro.CodigoProducto,
                            NombreProducto = dgvVentas.Rows[i].Cells[1].Value?.ToString(),
                            CantidadStock = (int)(producto.CantidadStock - registro.CantidadVendida)
                        };

                        _StocksCN.EditarCantidadRegStock(stocks);
                        _cNProductos.EditarCantidadProducto(stocks);
                        MessageBox.Show("Se registró correctamente!");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo ejecutar la venta. Verifica el stock o el producto.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar la venta: " + ex.Message);
            }
        }
    }
}
