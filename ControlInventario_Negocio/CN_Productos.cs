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
    }
}
