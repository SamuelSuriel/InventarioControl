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
            dgvusuario.DataBindingComplete += dgvusuario_DataBindingComplete;

        }


        SqlDataReader leer;
        public bool EsEditar = false;

        CN_Registro RegistroCN = new CN_Registro();

        public string IDusu;
        public string IDcuenta;






        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (EsValido())
            {

                Capa_Entidades_login entidadlogin = new()
                {
                    UsuarioID = Convert.ToInt32(IDcuenta),
                    NombreUsuario = txtNombreUsu.Text,
                    PasswordUsuario = txtContraUsu.Text,
                    PerfilID = (int)cbxPerfil.SelectedValue,

                };

                if (EsEditar == true)
                {
                    try
                    {
                        RegistroCN.editar_usu(entidadlogin);
                        MessageBox.Show("Se editó correctamente!");
                        limpiartxt();
                        CargarUsuarios();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo realizar la operación: " + ex);
                    }

                }

                else
                    MessageBox.Show("Seleccione un Usuario");

            }

            bool EsValido()
            {
                bool NombreUsu = txtNombreUsu.Text != "";
                bool PasswordUsu = txtContraUsu.Text != "";
                bool IDUsu = IDcuenta != "";
                bool perfil = cbxPerfil.Text != "";


                if (NombreUsu && PasswordUsu && IDUsu && perfil)
                    return true;
                else
                    return false;
            }
        }
        private void btnEditarusu_Click_1(object sender, EventArgs e)
        {

            if (dgvusuario.SelectedCells.Count > 0)
            {

                EsEditar = true;
                IDcuenta = dgvusuario.CurrentRow.Cells["UsuarioID"].Value.ToString();
                txtNombreUsu.Text = dgvusuario.CurrentRow.Cells["NombreUsuario"].Value.ToString();
                txtContraUsu.Text = dgvusuario.CurrentRow.Cells["PasswordUsuario"].Value.ToString();
                cbxPerfil.Text = dgvusuario.CurrentRow.Cells["Perfil"].Value.ToString();


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
            this.dgvusuario.Columns["UsuarioID"].Visible = false;
            this.dgvusuario.Columns["Activo"].Visible = false;

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
            IDcuenta = "";
            txtContraUsu.Clear();

            cbxPerfil.SelectedIndex = 0;
        }

        private void btnEliminareliminarusu_Click(object sender, EventArgs e)
        {
            if (dgvusuario.SelectedCells.Count > 0)
            {
                string message = "¿Estás seguro de que quieres eliminar a este registro?";
                string title = "Eliminar registro";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);

                if (result == DialogResult.Yes)
                {
                    IDusu = dgvusuario.CurrentRow.Cells["UsuarioID"].Value.ToString();

                    RegistroCN.Eliminar_Usuario(Convert.ToInt32(IDusu));
                    MessageBox.Show("Se eliminó correctamente!");
                    CargarUsuarios();
                }
            }
            else
                MessageBox.Show("Seleccione una celda para eliminar!");
        }

        private void btnMostrarcontra_Click(object sender, EventArgs e)
        {
            btnAcultarcontraseña.BringToFront();
            txtContraUsu.PasswordChar = '\0';

        }

        private void btnAcultarcontraseña_Click(object sender, EventArgs e)
        {
            btnMostrarcontra.BringToFront();
            txtContraUsu.PasswordChar = '*';
        }

        private void dgvusuario_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {


            dgvusuario.DefaultCellStyle.BackColor = Color.MidnightBlue;


            dgvusuario.DefaultCellStyle.ForeColor = Color.White;


            dgvusuario.DefaultCellStyle.Font = new Font("Arial", 10);


            dgvusuario.CellBorderStyle = DataGridViewCellBorderStyle.Single;


            dgvusuario.RowsDefaultCellStyle.SelectionBackColor = Color.Red;


            dgvusuario.RowsDefaultCellStyle.SelectionForeColor = Color.White;
        }
    }
}