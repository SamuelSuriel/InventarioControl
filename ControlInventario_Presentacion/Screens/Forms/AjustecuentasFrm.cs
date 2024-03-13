using ControlInventario_Datos;
using ControlInventario_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlInventario_Datos;
using ControlInventario_Negocio;

namespace ControlInventario_Presentacion.Screens.Forms
{
    public partial class AjustecuentasFrm : Form
    {
        public AjustecuentasFrm()
        {
            InitializeComponent();
        }


        SqlDataReader leer;
        public bool EsEditar = false;

        CN_Registro RegistroCN = new CN_Registro();






        private void btnEditarusu_Click(object sender, EventArgs e)
        {
            Capa_Entidades_login registrousu = new()
            {
                NombreUsuario = txtNombreUsu.Text,
                PasswordUsuario = txtContraUsu.Text,
                UsuarioID = int.Parse(txtIdCuenta.Text),
                PerfilID = cbxPerfil.SelectedIndex,

            };

            if (EsEditar = false)
            {




                if (dgvusuario.SelectedCells.Count > 0)
                {
                    EsEditar = true;
                    txtIdCuenta.Text = dgvusuario.CurrentRow.Cells["UsuarioID"].Value.ToString();
                    txtNombreUsu.Text = dgvusuario.CurrentRow.Cells["NombreUsuario"].Value.ToString();
                    txtContraUsu.Text = dgvusuario.CurrentRow.Cells["PasswordUsuario"].Value.ToString();
                    cbxPerfil.Text = dgvusuario.CurrentRow.Cells["Perfil"].Value.ToString();

                }
            }

            else
            {

                RegistroCN.Registro_usu(registrousu);

            }




        }



        private void AjustecuentasFrm_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
            LlenarCbPerfiles();

            cbxPerfil.SelectedIndex = 0;

        }

        private void lblLimpiarCampousu_Click(object sender, EventArgs e)
        {
            limpiartxt();

        }
        private void CargarUsuarios()
        {
            dgvusuario.DataSource = RegistroCN.MostrarUsuarios();
            this.dgvusuario.Columns["PerfilID"].Visible = false;

        }
        private void LlenarCbPerfiles()
        {
            cbxPerfil.DataSource = RegistroCN.ObtenerPerfiles();
            cbxPerfil.DisplayMember = "Perfil";
            cbxPerfil.ValueMember = "PerfilID";

        }
        private void limpiartxt()
        {
            txtBuscarusu.Clear();
            txtNombreUsu.Clear();
            txtIdCuenta.Clear();
            txtContraUsu.Clear();
            cbxEstado.SelectedIndex = 0;
            cbxPerfil.SelectedIndex = 0;
        }

        private void cbxPerfil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
