using ControlInventario_Datos;
using ControlInventario_Negocio;
using System.Data;

namespace ControlInventario_Presentacion.Screens
{
    public partial class Login : Form
    {

        Capa_Entidades_login obje = new Capa_Entidades_login();
        CN_Login objn = new CN_Login();
        public static int IdPerfil;
        public static int IdUsuario;
        public static string? Perfil;
        public static string? NombreUsu;
        public static DateTime? UltimaConexion;

        public Login()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            Usu_Login();
        }

        public void Usu_Login()
        {
            DataTable dt = new DataTable();
            obje.NombreUsuario = txtUserName.Text;
            obje.PasswordUsuario = txtPassword.Text;
            dt = objn.N_login(obje);

            if (dt.Rows.Count > 0)
            {
                obje.UsuarioID = int.Parse(dt.Rows[0][0].ToString());
                IdUsuario = obje.UsuarioID;
                obje.NombreUsuario = dt.Rows[0][1].ToString();
                NombreUsu = dt.Rows[0][1].ToString();
                obje.PasswordUsuario = dt.Rows[0][2].ToString();
                obje.PerfilID = int.Parse(dt.Rows[0][3].ToString());
                IdPerfil = int.Parse(dt.Rows[0][3].ToString());
                obje.Perfil = dt.Rows[0][5].ToString();
                Perfil = obje.Perfil;

                obje.UltimaConexion = dt.Rows[0][4].ToString();
                UltimaConexion = DateTime.Parse(dt.Rows[0][4].ToString());
                objn.UltimaACT(obje);

                MessageBox.Show("Bienvenido " + obje.NombreUsuario);

                Form mainPage = new MainPage();
                this.Hide();
                mainPage.Show();
            }
            else
                MessageBox.Show("Usuario no encontrada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }

}






