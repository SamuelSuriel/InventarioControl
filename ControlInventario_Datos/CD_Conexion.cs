using System.Data;
using System.Data.SqlClient;

namespace ControlInventario_Datos
{
    public class CD_Conexion
    {
        //public SqlConnection Conexion = new SqlConnection(@"server=SRSDELLI5; Database=InventariosControlDb; integrated security =True; TrustServerCertificate=True");
        public SqlConnection Conexion = new SqlConnection(@"server=DBInventariosControl.mssql.somee.com; Database=DBInventariosControl; user id=ramirezssamuel_SQLLogin_1; pwd=zjkrtws5rc;");

        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }

        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }

        public string queryBuscarUsuario(int idUsuario)
        {
            string query = "";
            if (idUsuario > 0)
                //Query que trae los datos desde la base de datos
                query = "SELECT u.Usuario_Id, u.Usuario_Nombre, u.Clave, u.IdPerfil, p.Perfil FROM Usuarios u INNER JOIN Perfiles p on u.IdPerfil = p.IdPerfil WHERE u.Usuario_Id = " + idUsuario;
            return query;
        }
    }
}
