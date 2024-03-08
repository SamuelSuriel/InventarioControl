using ControlInventario_Datos;
using ControlInventario_Negocio;
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
    public partial class StockFrm : Form
    {
        CN_Stocks stocksCN = new CN_Stocks();
        public StockFrm()
        {
            InitializeComponent();
        }

        private void StockFrm_Load(object sender, EventArgs e)
        {
            CargarDgvStocks();
        }

        private void CargarDgvStocks()
        {
            dgvStocks.DataSource = stocksCN.LlenarDgvStocks("");
            this.dgvStocks.Columns["IdStock"].Visible = false;
            this.dgvStocks.Columns["Activo"].Visible = false;

            //string crt = txtMateriaBuscar.Text;
            //LlenarDgvStocks(crt);
        }
    }
}
