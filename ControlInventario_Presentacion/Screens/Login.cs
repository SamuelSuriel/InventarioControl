using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlInventario_Presentacion.Screens
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text != "" && txtPassword.Text != "")
            {
                Form mainPage = new MainPage();
                this.Hide();
                mainPage.Show();
            }
        }

        private void lblRegistrarse_Click(object sender, EventArgs e)
        {
            Form registro = new RegistroFrm();
            this.Hide();
            registro.Show();
        }
    }
}
