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
    public class CN_Pedidos
    {
        private CD_Conexion conexion = new CD_Conexion();

        SqlDataReader leer;
        SqlCommand comando = new SqlCommand();

        public DataTable MostrarPedidos()
        {
            CD_Conexion conexion = new CD_Conexion();
            SqlCommand comando = new SqlCommand();
            DataTable tabla = new DataTable();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "prc_MostrarPedidos";
            comando.CommandType = CommandType.StoredProcedure;

            leer = comando.ExecuteReader();
            tabla.Load(leer);

            conexion.CerrarConexion();

            return tabla;
        }

        public void AgregarPedido(PedidosProveedores pedidos)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "prc_InsertarPedido";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IdProveedor", pedidos.IdProveedor);
            comando.Parameters.AddWithValue("@FechaPedido", pedidos.FechaPedido);
            comando.Parameters.AddWithValue("@CantidadProductos", pedidos.CantidadProductos);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void EditarPedido(int idPedido, PedidosProveedores pedidos)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "prc_EditarPedido";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@pedidoId", idPedido);
            comando.Parameters.AddWithValue("@IdProveedor", pedidos.IdProveedor);
            comando.Parameters.AddWithValue("@FechaPedido", pedidos.FechaPedido);
            comando.Parameters.AddWithValue("@CantidadProductos", pedidos.CantidadProductos);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void EliminarPedido(int idPedido)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "prc_EliminarPedido";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@pedidoId", idPedido);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }


        public List<Proveedores> ObtenerListaProveedores()
        {
            List<Proveedores> oListaProveedores = new List<Proveedores>();
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "prc_GetProveedores";
                comando.CommandType = CommandType.StoredProcedure;

                try
                {
                    leer = comando.ExecuteReader();

                    while (leer.Read())
                    {
                        oListaProveedores.Add(new Proveedores
                        {
                            IdProveedor = Convert.ToInt32(leer["IdProveedor"]),
                            NombreProveedor = leer["NombreProveedor"].ToString()
                        });
                    }
                    leer.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener los proveedores: " + ex.Message, ex);
                }

            }
            return oListaProveedores;

        }
    }
}
