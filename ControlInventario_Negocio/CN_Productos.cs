using ControlInventario_Datos;
using System.Data;
using System.Data.SqlClient;

namespace ControlInventario_Negocio
{
    public class CN_Productos
    {
        private CD_Conexion conexion = new CD_Conexion();

        SqlDataReader leer;
        SqlCommand comando = new SqlCommand();

        public DataTable MostrarProductos()
        {
            CD_Conexion conexion = new CD_Conexion();
            SqlCommand comando = new SqlCommand();
            DataTable tablaFromDB = new DataTable();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "prc_MostrarProductos";
            comando.CommandType = CommandType.StoredProcedure;

            leer = comando.ExecuteReader();
            tablaFromDB.Load(leer);

            conexion.CerrarConexion();

            return tablaFromDB;

        }

        public void Agregarproducto(Productos productos)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "prc_InsertarProducto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@NombreProducto", productos.NombreProducto);
            comando.Parameters.AddWithValue("@Descripcion", productos.Descripcion);
            comando.Parameters.AddWithValue("@CodigoProducto", productos.CodigoProducto);
            comando.Parameters.AddWithValue("@CantidadStock", productos.CantidadStock);
            comando.Parameters.AddWithValue("@PrecioCompra", productos.PrecioCompra);
            comando.Parameters.AddWithValue("@PrecioVenta", productos.PrecioVenta);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void EditarProducto(int idProducto, Productos productos)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "prc_EditarProducto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idProducto", idProducto);
            comando.Parameters.AddWithValue("@NombreProducto", productos.NombreProducto);
            comando.Parameters.AddWithValue("@Descripcion", productos.Descripcion);
            comando.Parameters.AddWithValue("@CodigoProducto", productos.CodigoProducto);
            comando.Parameters.AddWithValue("@CantidadStock", productos.CantidadStock);
            comando.Parameters.AddWithValue("@PrecioCompra", productos.PrecioCompra);
            comando.Parameters.AddWithValue("@PrecioVenta", productos.PrecioVenta);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void EliminarProducto(int idProducto)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "prc_EliminarProducto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idProducto", idProducto);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void EditarCantidadProducto(Stocks stocks)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "prc_UpdateCantidadStockProducto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@codigoProducto", stocks.CodigoProducto);
            comando.Parameters.AddWithValue("@cantidadStock", stocks.CantidadStock);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public List<Productos> ObtenerProductos()
        {
            List<Productos> oListaProductos = new List<Productos>();
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "prc_GetProductos";
                comando.CommandType = CommandType.StoredProcedure;

                try
                {
                    leer = comando.ExecuteReader();

                    while (leer.Read())
                    {
                        oListaProductos.Add(new Productos
                        {
                            IdProducto = Convert.ToInt32(leer["IdProducto"]),
                            NombreProducto = leer["NombreProducto"].ToString()
                        });
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

        public Productos GetProductoById(int id)
        {
            var productoFromDB = new Productos();
            CD_Conexion conexion2 = new CD_Conexion();
            using (var _conexion = conexion2.Conexion)
            using (var comando = new SqlCommand())
            {
                comando.Connection = _conexion;
                comando.CommandText = "ObtenerProductoById";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id", id);

                try
                {
                    conexion2.AbrirConexion();
                    using (var leer = comando.ExecuteReader())
                    {
                        if (leer.Read())
                        {
                            productoFromDB.IdProducto = Convert.ToInt32(leer["IdProducto"]);
                            productoFromDB.CodigoProducto = leer["CodigoProducto"].ToString();
                            productoFromDB.NombreProducto = leer["NombreProducto"].ToString();
                            float precioVenta;
                            if (float.TryParse(leer["PrecioVenta"].ToString(), out precioVenta))
                            {
                                productoFromDB.PrecioVenta = precioVenta;
                            }
                            productoFromDB.CantidadStock = (int)leer["CantidadStock"];
                        }
                    }
                    comando.Parameters.Clear();
                    conexion2.CerrarConexion();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al obtener el producto: " + ex.Message);
                }
            }

            return productoFromDB;

        }

        public Productos GetProductosByProveedor(int idproveedor)
        {
            CD_Conexion conexion1 = new CD_Conexion();
            var producto = new Productos();

            using (var _conexion = conexion1.Conexion)
            using (var comando = new SqlCommand())
            {
                comando.Connection = _conexion;
                comando.CommandText = "prc_GetProductosByProveedor";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idProveedor", idproveedor);

                try
                {
                    conexion1.AbrirConexion();
                    using (var leer = comando.ExecuteReader())
                    {
                        if (leer.Read())
                        {
                            producto.IdProducto = Convert.ToInt32(leer["IdProducto"]);
                            producto.NombreProducto = leer["Producto"].ToString();                            
                        }
                    }
                    comando.Parameters.Clear();
                    conexion1.CerrarConexion();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al obtener el producto: " + ex.Message);
                }
            }
            return producto;

        }
    }
}
