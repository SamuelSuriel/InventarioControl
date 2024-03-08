using ControlInventario_Datos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlInventario_Negocio
{
    public  class CN_Stocks
    {
        private CD_Conexion conexion = new CD_Conexion();

        SqlDataReader leer;
        SqlCommand comando = new SqlCommand();

        public DataTable LlenarDgvStocks(string? criterio)
        {           
                CD_Conexion conexion1 = new CD_Conexion();
                SqlCommand comando = new SqlCommand();
                DataTable tabla = new DataTable();

                comando.Connection = conexion1.AbrirConexion();
                comando.CommandText = "prc_MostrarStocks";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@criterio", criterio);
                comando.ExecuteNonQuery();
                leer = comando.ExecuteReader();
                tabla.Load(leer);
                comando.Parameters.Clear();
                conexion1.CerrarConexion();

                return tabla;
           
        }

        public void AgregarStock(Stocks stocks)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "prc_AgregarStock";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@codigoProd", stocks.CodigoProducto);
            comando.Parameters.AddWithValue("@nombreProd", stocks.NombreProducto);
            comando.Parameters.AddWithValue("@descripcionProd", stocks.DescripcionProducto);
            comando.Parameters.AddWithValue("@cantidadStock", stocks.CantidadStock);
            comando.Parameters.AddWithValue("@precioCompra", stocks.PrecioCompra);
            comando.Parameters.AddWithValue("@precioVenta", stocks.PrecioVenta);
                        
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void EditarRegStock(Stocks stocks)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "prc_EditarRegStock";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@codigoProducto", stocks.CodigoProducto);
            comando.Parameters.AddWithValue("@nombreProducto", stocks.NombreProducto);
            comando.Parameters.AddWithValue("@descripcion", stocks.DescripcionProducto);
            comando.Parameters.AddWithValue("@cantidadStock", stocks.CantidadStock);
            comando.Parameters.AddWithValue("@precioCompra", stocks.PrecioCompra);
            comando.Parameters.AddWithValue("@precioVenta", stocks.PrecioVenta);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}
