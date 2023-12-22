using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using ControlInventario_Presentacion.Screens.Forms;
using FontAwesome.Sharp;
using Color = System.Drawing.Color;

namespace ControlInventario_Presentacion.Screens
{
    public partial class MainPage : Form
    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        //Constructor
        public MainPage()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        //Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color color7 = Color.FromArgb(26, 82, 64);
        }

        //Methods
        private void ActivarBoton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DeshabilitarBoton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Icon Current Child Form
                iconCurrentChildFrm.IconChar = currentBtn.IconChar;
                iconCurrentChildFrm.IconColor = color;
                lblTitleChild.Text = currentBtn.Text;

            }
        }
        private void DeshabilitarBoton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;

            }
        }

        private void OpenChildForm(Form childForm)
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
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //lblTitleChild.Text = childForm.Text;

        }
        //btnDashboard
        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColors.color1);
            OpenChildForm(new DashboardFrm());

        }
        //btnPedidos
        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColors.color2);
            OpenChildForm(new PedidosFrm());
        }
        //btnProductos
        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColors.color3);
            OpenChildForm(new ProductosFrm());
        }
        //btnProveedores
        private void iconButton4_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColors.color4);
            OpenChildForm(new ProveedoresFrm());
        }
        //btnVentas
        private void iconButton5_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColors.color5);
            OpenChildForm(new VentasFrm());
        }
        //btnInformes
        private void iconButton6_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColors.color6);
            OpenChildForm(new InformesFrm());
        }
        //btnSettings
        private void iconButton7_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColors.color7);
            OpenChildForm(new SettingsFrm());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();

        }

        private void Reset()
        {
            DeshabilitarBoton();
            leftBorderBtn.Visible = false;
            iconCurrentChildFrm.IconChar = IconChar.Home;
            iconCurrentChildFrm.IconColor = Color.Gainsboro;
            lblTitleChild.Text = "Home";

        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lblCerrarApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconMaxim_Click(object sender, EventArgs e)
        {
            //if (WindowState == FormWindowState.Normal)
            //{
            //    WindowState = FormWindowState.Maximized;
            //}
            //else
            //{
            //    WindowState = FormWindowState.Normal;
            //}
        }

        private void lblMinimizeApp_Click(object sender, EventArgs e)
        {
            //WindowState = FormWindowState.Minimized;

        }
    }
}
