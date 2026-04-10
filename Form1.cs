namespace EstoqueSimples
{
    public partial class form1 : Form
    {
        List<Produto> listaDeProdutos = new List<Produto>();

        public form1()
        {
            InitializeComponent();
        }



        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto(txtNome.Text, (int)numQuantidade.Value);

            listaDeProdutos.Add(produto);

            AtualizarInterface();
        }

        private void AtualizarInterface()
        {
            dgvEstoque.DataSource = null;
            dgvEstoque.DataSource = listaDeProdutos;

            VerificarAlertasDeEstoque();

            txtNome.Clear();
            txtNome.Focus();
        }

        private void VerificarAlertasDeEstoque()
        {
            foreach (DataGridViewRow linha in dgvEstoque.Rows)
            {
                int qtd = (int)linha.Cells["Quantidade"].Value;

                if (qtd < 5)
                {
                    linha.DefaultCellStyle.BackColor = Color.Red;
                    linha.DefaultCellStyle.ForeColor = Color.White;
                }
                else
                {
                    linha.DefaultCellStyle.BackColor = Color.Green;
                    linha.DefaultCellStyle.ForeColor = Color.White;
                }

            }
        }
    }
}
