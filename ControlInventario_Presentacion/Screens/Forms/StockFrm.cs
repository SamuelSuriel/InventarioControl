using ControlInventario_Negocio;

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
            CargarDgvStocks("");
        }

        private void CargarDgvStocks(string? cr)
        {
            dgvStocks.DataSource = stocksCN.LlenarDgvStocks(cr);
            this.dgvStocks.Columns["IdStock"].Visible = false;
            this.dgvStocks.Columns["Activo"].Visible = false;

        }

        private void btnBuscarStock_Click(object sender, EventArgs e)
        {
            string crt = txtBuscarStock.Text;
            CargarDgvStocks(crt);
        }
    }
}
