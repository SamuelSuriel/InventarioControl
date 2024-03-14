using ControlInventario_Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlInventario_Datos;
using Microsoft.Win32;

namespace ControlInventario_Negocio
{
    

    public class CN_Login
    {

        private CD_Conexion conexion = new CD_Conexion();
        SqlCommand comando = new SqlCommand();

        ControlInventario_Datos.Login_usuarios objd = new ControlInventario_Datos.Login_usuarios();

        public DataTable N_login(ControlInventario_Datos.Capa_Entidades_login obje)
        {
            return objd.D_login(obje);
        }
        public void UltimaACT(Capa_Entidades_login Usu)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "prc_RegLogUser";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@usuarioID", Usu.UsuarioID);
            


            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }

    
}
