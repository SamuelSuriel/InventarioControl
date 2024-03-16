using ControlInventario_Datos;
using System.Data;
using System.Data.SqlClient;

namespace ControlInventario_Negocio
{
    public class CN_Informes
    {
        SqlDataReader leer;
        public DataTable MostrarRegistros(string? criterio, int idProd, DateTime? fecha)
        {
            CD_Conexion conexion1 = new CD_Conexion();
            SqlCommand comando = new SqlCommand();
            DataTable tabla = new DataTable();

                comando.Connection = conexion1.AbrirConexion();
                comando.CommandText = "prc_MostrarRegistroVentas";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@criterio", criterio);
                comando.Parameters.AddWithValue("@IdProducto", idProd);
                comando.Parameters.AddWithValue("@fechaVenta", fecha);

                comando.ExecuteNonQuery();
                leer = comando.ExecuteReader();
                tabla.Load(leer);
                comando.Parameters.Clear();
                conexion1.CerrarConexion();
            return tabla;

        }

        public DataTable LlenarDgvStocks(int idProducto, string? criterio)
        {
            CD_Conexion conexion1 = new CD_Conexion();
            SqlCommand comando = new SqlCommand();
            DataTable tabla = new DataTable();

            comando.Connection = conexion1.AbrirConexion();
            comando.CommandText = "prc_MostrarInformeStocks";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idproducto", idProducto);
            comando.Parameters.AddWithValue("@criterio", criterio);
            comando.ExecuteNonQuery();
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            comando.Parameters.Clear();
            conexion1.CerrarConexion();

            return tabla;

        }

        public DataTable MostrarProveedores(int idProducto, int idproveedor)
        {
            CD_Conexion conexion = new CD_Conexion();
            SqlCommand comando = new SqlCommand();
            DataTable tabla = new DataTable();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "prc_MostrarInformeProveedores";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Idproveedor", idproveedor);
            comando.Parameters.AddWithValue("@IdProducto", idProducto);
            comando.ExecuteNonQuery();

            leer = comando.ExecuteReader();
            tabla.Load(leer);

            conexion.CerrarConexion();

            return tabla;

        }
    }
}
