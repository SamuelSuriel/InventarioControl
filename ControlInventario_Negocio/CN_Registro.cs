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
        SqlDataReader leer;

         public DataTable MostrarUsuarios()
         {
             CD_Conexion conexion = new CD_Conexion();
             SqlCommand comando = new SqlCommand();
             DataTable tablaFromDB = new DataTable();

             comando.Connection = conexion.AbrirConexion();
             comando.CommandText = "prc_GetUsuariosAll";
             comando.CommandType = CommandType.StoredProcedure;

             leer = comando.ExecuteReader();
             tablaFromDB.Load(leer);

             conexion.CerrarConexion();

             return tablaFromDB;
         }

        public void editar_usu(Capa_Entidades_login registro)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "prc_EditarUsuario";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@usuario", registro.NombreUsuario);
            comando.Parameters.AddWithValue("@password", registro.PasswordUsuario);
            

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }


        public List<Tipo_Perfil> ObtenerPerfiles()
        {
            List<Tipo_Perfil> oListaPerfiles = new List<Tipo_Perfil>();
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "prc_GetPerfiles";
                comando.CommandType = CommandType.StoredProcedure;

                try
                {
                    leer = comando.ExecuteReader();

                    while (leer.Read())
                    {
                        oListaPerfiles.Add(new Tipo_Perfil
                        {
                            Perfil = leer["Perfil"].ToString(),
                            PerfilID = Convert.ToInt32(leer["PerfilID"]),
                            
                        });
                    }
                    leer.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener los perfiles: " + ex.Message, ex);
                }

            }
            return oListaPerfiles;

        }


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
