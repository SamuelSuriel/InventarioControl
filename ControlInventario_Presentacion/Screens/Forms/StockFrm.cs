using ControlInventario_Negocio;

namespace ControlInventario_Presentacion.Screens.Forms
{
    public partial class StockFrm : Form
    {
        CN_Stocks stocksCN = new CN_Stocks();
        public StockFrm()
        {
            InitializeComponent();
            dgvStocks.DataBindingComplete += dgvStocks_DataBindingComplete;
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

        private void dgvStocks_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

            dgvStocks.DefaultCellStyle.BackColor = Color.SkyBlue;

            dgvStocks.DefaultCellStyle.ForeColor = Color.White;

            dgvStocks.DefaultCellStyle.Font = new Font("Arial", 10);

            dgvStocks.CellBorderStyle = DataGridViewCellBorderStyle.Single;

            dgvStocks.RowsDefaultCellStyle.SelectionBackColor = Color.LightGreen;

            dgvStocks.RowsDefaultCellStyle.SelectionForeColor = Color.White;
        }

    }
}
