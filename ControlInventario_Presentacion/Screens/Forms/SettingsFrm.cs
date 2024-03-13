using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlInventario_Presentacion.Screens.Forms
{
    public partial class SettingsFrm : Form
    {
        public SettingsFrm()
        {
            InitializeComponent();
        }

        private Form currentChildForm;

        public void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                //open only form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            paneldesktop.Controls.Add(childForm);
            paneldesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //lblTitleChild.Text = childForm.Text;

        }

        private void btnAjcuentas_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AjustecuentasFrm());
        }
    }
}
