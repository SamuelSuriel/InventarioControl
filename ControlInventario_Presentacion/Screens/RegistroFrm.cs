using ControlInventario_Datos;
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
    public partial class RegistroFrm : Form
    {

        CN_Registro RegistroCN = new CN_Registro();
        public RegistroFrm()
        {
            InitializeComponent();
        }







        private bool validarRegistro()
        {
            bool result = false;
            string UserRegistro = txtUserRegistro.Text;
            string PasswordRegistro = txtPasswordRegistro.Text;
            string PasswordConfirmReg = txtPasswordConfirmReg.Text;

            if (PasswordConfirmReg == PasswordRegistro)
            {


                if (UserRegistro.Length >= 4 && PasswordRegistro.Length >= 4 && PasswordConfirmReg.Length >= 4)
                {
                    result = true;
                }
                return result;
            }
            else
                return result;

        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            if (validarRegistro())
            {

                Capa_Entidades_login _productos = new()
                {
                    NombreUsuario = txtUserRegistro.Text,
                    PasswordUsuario = txtPasswordRegistro.Text,
                    PerfilID = (int)cbxPerfil.SelectedValue,

                };


                try
                {
                    RegistroCN.Registro_usu(_productos);
                    MessageBox.Show("SE INSERTÓ CORRECTAMENTE!");
                    LimpiarControles();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo realizar la operación: " + ex);
                }


            }
            else
                MessageBox.Show("ingrese datos validos");
        }

        private void LlenarCbPerfiles()
        {
            cbxPerfil.DataSource = RegistroCN.ObtenerPerfiles();
            cbxPerfil.DisplayMember = "Perfil";
            cbxPerfil.ValueMember = "PerfilID";

        }

        private void LimpiarControles()
        {
            txtUserRegistro.Clear();
            txtPasswordConfirmReg.Clear();
            txtPasswordRegistro.Clear();

        }

        private void RegistroFrm_Load(object sender, EventArgs e)
        {
            LlenarCbPerfiles();
        }

        private void btnAcultarcontraseña_Click(object sender, EventArgs e)
        {
            btnMostrarcontra.BringToFront();
            txtPasswordRegistro.PasswordChar = '*';
            txtPasswordConfirmReg.PasswordChar = '*';
        }

        private void btnMostrarcontra_Click(object sender, EventArgs e)
        {
            btnAcultarcontraseña.BringToFront();
            txtPasswordRegistro.PasswordChar = '\0';
            txtPasswordConfirmReg.PasswordChar = '\0';
        }
    }


}
