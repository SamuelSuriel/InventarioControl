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
    public class CN_Registro
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlCommand comando = new SqlCommand();


        public void Registro_usu(Capa_Entidades_login registro)
        {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "prc_RegistrarUsuario";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@usuario ", registro.NombreUsuario);
                comando.Parameters.AddWithValue("@password", registro.PasswordUsuario);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                conexion.CerrarConexion();
        }
    }
}
