using ControlInventario_Datos;
using System.Data;
using System.Data.SqlClient;

namespace ControlInventario_Negocio
{
    public class CN_Proveedores
    {
        private CD_Conexion conexion = new CD_Conexion();

        SqlDataReader leer;
        SqlCommand comando = new SqlCommand();

        public DataTable MostrarProveedores()
        {
            CD_Conexion conexion = new CD_Conexion();
            SqlCommand comando = new SqlCommand();
            DataTable tabla = new DataTable();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "prc_MostrarProveedores";
            comando.CommandType = CommandType.StoredProcedure;

            leer = comando.ExecuteReader();
            tabla.Load(leer);

            conexion.CerrarConexion();

            return tabla;

        }

        public void AgregarProveedor(Proveedores proveedor)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "prc_InsertarProveedor";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@NombreProveedor", proveedor.NombreProveedor);
            comando.Parameters.AddWithValue("@DireccionProveedor", proveedor.DireccionProveedor);
            comando.Parameters.AddWithValue("@TelefonoProveedor", proveedor.TelefonoProveedor);
            comando.Parameters.AddWithValue("@CorreoProveedor", proveedor.CorreoProveedor);
            comando.Parameters.AddWithValue("@IdProductosSuministra", proveedor.IdProductosSuministra);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void EditarProveedor(int idProveedor, Proveedores proveedor)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "prc_EditarProveedor";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idProveedor", idProveedor);
            comando.Parameters.AddWithValue("@NombreProveedor", proveedor.NombreProveedor);
            comando.Parameters.AddWithValue("@DireccionProveedor", proveedor.DireccionProveedor);
            comando.Parameters.AddWithValue("@TelefonoProveedor", proveedor.TelefonoProveedor);
            comando.Parameters.AddWithValue("@CorreoProveedor", proveedor.CorreoProveedor);
            comando.Parameters.AddWithValue("@IdProductosSuministra", proveedor.IdProductosSuministra);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void EliminarProveedor(int idProveedor)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "prc_EliminarProveedor";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idProveedor", idProveedor);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }


    }
}
