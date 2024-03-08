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

    }
}
