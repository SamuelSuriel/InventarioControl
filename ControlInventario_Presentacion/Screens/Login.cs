using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlInventario_Datos;
using ControlInventario_Negocio;

namespace ControlInventario_Presentacion.Screens
{
    public partial class Login : Form
    {

        ControlInventario_Datos.Capa_Entidades_login obje = new ControlInventario_Datos.Capa_Entidades_login();
        ControlInventario_Negocio.CN_Login objn = new ControlInventario_Negocio.CN_Login();
        public static int Perfil;
        public static string NombreUsu;

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
                obje.NombreUsuario = dt.Rows[0][1].ToString();
                NombreUsu = dt.Rows[0][1].ToString();
                obje.PasswordUsuario = dt.Rows[0][2].ToString();
                Perfil = int.Parse(dt.Rows[0][3].ToString());
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


       

       
    
