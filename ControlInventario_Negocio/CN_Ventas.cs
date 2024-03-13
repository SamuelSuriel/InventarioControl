using ControlInventario_Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlInventario_Negocio
{
    public class CN_Ventas
    {
        private CD_Conexion conexion = new CD_Conexion();

        SqlDataReader leer;
        SqlCommand comando = new SqlCommand();

        public Productos TraerProductosPorId(int id)
        {
            Productos oListaProductos = new Productos();
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "ObtenerProductoById";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id", id);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();

                try
                {
                    leer = comando.ExecuteReader();

                    while (leer.Read())
                    {
                        oListaProductos = new Productos()
                        {
                            //IdProducto = Convert.ToInt32(leer["IdProducto"]),
                            NombreProducto = leer["NombreProducto"].ToString(),
                            CodigoProducto = leer["CodigoProducto"].ToString(),
                            PrecioVenta = float.Parse((string)leer["PrecioVenta"]),
                            CantidadStock = (int)leer["CantidadStock"]

                        };
                    }
                    leer.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener los productos: " + ex.Message, ex);
                }

            }
            return oListaProductos;

        }

        public void EjecutarVenta(RegistroVentas registroVentas)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "prc_AgregarRegistroVentas";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idProducto", registroVentas.IdProducto);
                comando.Parameters.AddWithValue("@codigoProducto", registroVentas.CodigoProducto);
                comando.Parameters.AddWithValue("@cantidadVendida", registroVentas.CantidadVendida);
                comando.Parameters.AddWithValue("@precioVenta", registroVentas.PrecioVenta);
                comando.Parameters.AddWithValue("@clienteVenta", registroVentas.ClienteVenta);
                comando.Parameters.AddWithValue("@idUsuarioCreacion", registroVentas.IdUsuarioCreacion);

                comando.ExecuteNonQuery();

                comando.Parameters.Clear();
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al ejecutar la venta: " + ex.Message);
            }

        }

    }
}
