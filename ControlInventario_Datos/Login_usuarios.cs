using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlInventario_Datos
{
    public class Login_usuarios
    {

        private CD_Conexion conexion = new CD_Conexion();
        SqlCommand comando = new SqlCommand();


        public DataTable D_login( Capa_Entidades_login obje)

        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "prc_GetUsuariosLogin";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@user", obje.NombreUsuario);
                comando.Parameters.AddWithValue("@password", obje.PasswordUsuario);
                SqlDataAdapter da = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comando.Parameters.Clear();
                return dt;

            }
            catch (Exception ex)
            {

                throw;
            }
           

        }

    }
}
