using MySql.Data.MySqlClient;
using SistemaEstoque;
using SistemaMelhorado.Cadastro_Produtos;
using SistemaMelhorado.Cliente;
using SistemaMelhorado.FormDados;

namespace SistemaMelhorado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void BtnDados_Click(object sender, EventArgs e)
        {
            Dados FormDados = new Dados();
            FormDados.ShowDialog();
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            Cliente_Forms FormClientes = new Cliente_Forms();
            FormClientes.Show();
            /*Implementar logica 
             * 
             * Se o botão estiver selecionado retorne um travamento para o botao.
             Caso não deixe ele livre*/

        }

        private bool ValidacaoExclusaoProdutos(Produtos cadastro)
        {
            if (txtNome.Text.IsNotNull())
                return true;
            return false;
        }



        private bool ValidacaoCadastrodeProdutos(Produtos cadastro)
        {
            if (txtNome.Text.IsNotNull() && txtCusto.Text.IsNotNull() && txtPreco.Text.IsNotNull() && txtQuantidade.Text.IsNotNull() && txtFornecedor.Text.IsNotNull() && txtDatadaCompra.Text.IsNotNull())
                return true;
            return false;
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Produtos Produtos = new Produtos();

                if (ValidacaoCadastrodeProdutos(Produtos))
                {
                    Produtos.Nome = txtNome.Text;
                    Produtos.Categoria = txtCategoria.Text;
                    Produtos.Custo = decimal.Parse(txtCusto.Text);
                    Produtos.Preco = decimal.Parse(txtPreco.Text);
                    Produtos.Quantidade = int.Parse(txtQuantidade.Text);
                    Produtos.Fornecedor = txtFornecedor.Text;
                    Produtos.DataDaCompra = DateTime.Parse(txtDatadaCompra.Text);

                    if (Produtos.CadastrarProdutos())
                    {
                        MessageBox.Show($"O produto {Produtos.Nome} foi cadastrado com sucesso!");
                        txtNome.Clear();
                        txtCategoria.Clear();
                        txtCusto.Clear();
                        txtPreco.Clear();
                        txtQuantidade.Clear();
                        txtFornecedor.Clear();
                        txtDatadaCompra.Clear();
                        txtNome.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível cadastrar Produto");
                    }
                }

                else
                {
                    MessageBox.Show("Favor preecher todos os campos corretamente");
                    txtNome.Clear();
                    txtCategoria.Clear();
                    txtCusto.Clear();
                    txtPreco.Clear();
                    txtQuantidade.Clear();
                    txtFornecedor.Clear();
                    txtDatadaCompra.Clear();
                    txtNome.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ao cadastrar produto: " + ex.Message);
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtCategoria.Clear();
            txtCusto.Clear();
            txtPreco.Clear();
            txtQuantidade.Clear();
            txtFornecedor.Clear();
            txtDatadaCompra.Clear();
            txtNome.Focus();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                Produtos Produtos = new Produtos();

                if (ValidacaoExclusaoProdutos(Produtos))
                {
                    if (txtId.Text.IsNotNull())
                    {
                        Produtos produtos = new Produtos();
                        int id = int.Parse(txtId.Text);
                        if (produtos.DeletarProdutos(id))
                        {
                            MessageBox.Show("O produto foi excluído com sucesso!");
                            LimparCamposProdutoForm();
                        }
                        else
                        {
                            MessageBox.Show("Não foi possível excluir o produto. Verifique o ID.");
                            LimparCamposProdutoForm();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Favor preecher todos os campos corretamente");
                    txtNome.Clear();
                    txtCategoria.Clear();
                    txtCusto.Clear();
                    txtPreco.Clear();
                    txtQuantidade.Clear();
                    txtFornecedor.Clear();
                    txtDatadaCompra.Clear();
                    txtNome.Focus();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Favor preecher todos os campos corretamente" + ex.Message);
                txtNome.Focus();
            }
        }

        public void LimparCamposProdutoForm()
        {
            txtNome.Clear();
            txtCategoria.Clear();
            txtCusto.Clear();
            txtPreco.Clear();
            txtQuantidade.Clear();
            txtFornecedor.Clear();
            txtDatadaCompra.Clear();
            txtId.Text = null;
            txtNome.Focus();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtNome.Text.Equals(""))
                {
                    Produtos produtos = new Produtos();
                    produtos.Nome = txtNome.Text;
                    MySqlDataReader reader = produtos.LocalizarProdutos();

                    if (reader != null)
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            txtId.Text = reader["id"].ToString();
                            int quantidade = reader["quantidade"] != DBNull.Value ? Convert.ToInt32(reader["quantidade"]) : 0;
                            txtQuantidade.Text = quantidade.ToString();
                            txtCategoria.Text = reader["categoria"].ToString();
                            txtFornecedor.Text = reader["fornecedor"].ToString();

                        }
                        else
                        {
                            MessageBox.Show("Produto não encontrado");
                            txtCategoria.Clear();
                            txtFornecedor.Clear();
                            txtQuantidade.Clear();
                            txtNome.Focus();
                            txtId.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Produto não encontrado");
                        txtCategoria.Clear();
                        txtFornecedor.Clear();
                        txtQuantidade.Clear();
                        txtNome.Focus();
                        txtId.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Favor preecher o campo Nome para realizar a pesquisa!");
                    txtNome.Clear();
                    txtQuantidade.Clear();
                    txtCategoria.Clear();
                    txtFornecedor.Clear();
                    txtNome.Focus();
                    txtId.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ao encontrar produto: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}
