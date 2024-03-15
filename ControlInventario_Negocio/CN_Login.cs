using ControlInventario_Datos;
using System.Data;
using System.Data.SqlClient;

namespace ControlInventario_Negocio
{


    public class CN_Login
    {

        private CD_Conexion conexion = new CD_Conexion();
        SqlCommand comando = new SqlCommand();

        Login_usuarios objd = new Login_usuarios();

        public DataTable N_login(Capa_Entidades_login obje)
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
