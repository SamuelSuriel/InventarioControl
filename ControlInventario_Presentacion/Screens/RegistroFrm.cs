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
    public partial class RegistroFrm : Form
    {
        public RegistroFrm()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Form login = new Login();
            this.Hide();
            login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPasswordRegistro.Text == txtPasswordConfirmReg.Text)
            {
                Form login = new Login();
                this.Hide();
                login.Show();
            }
        }

        private bool validarRegistro(object sender, EventArgs e)
        {
            bool result = false;
            string UserRegistro = txtUserRegistro.Text;
            string PasswordRegistro = txtPasswordRegistro.Text;
            string PasswordConfirmReg = txtPasswordConfirmReg.Text;

            if (UserRegistro.Length > 5 && PasswordRegistro.Length >= 4 && PasswordConfirmReg.Length >= 4)
            {
                result = true;
            }
            return result;
        }
    }
}
