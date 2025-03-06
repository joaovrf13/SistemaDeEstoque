using MySql.Data.MySqlClient;
using SistemaEstoque;
using SistemaMelhorado.Cliente.DadosClientes;
using SistemaMelhorado.FormDados;


namespace SistemaMelhorado.Cliente
{
    public partial class Cliente_Forms : Form

    {
        public Cliente_Forms()
        {
            InitializeComponent();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Clientes CadClientes = new Clientes();

                if (ValidacaoCadastroClientes(CadClientes))
                {
                    CadClientes.nome = txtNomeCliente.Text;
                    CadClientes.cpf = txtCpf.Text;
                    CadClientes.datadenascimento = DateTime.Parse(txtDatadeNascimento.Text);

                    if (CadClientes.CadastrarCliente())
                    {
                        MessageBox.Show($"O(A) Cliente {CadClientes.nome} foi cadastrado com sucesso!");
                        txtNomeCliente.Clear();
                        txtCpf.Clear();
                        txtDatadeNascimento.Clear();
                        txtNomeCliente.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível cadastrar o Cliente");
                    }
                }
                else
                {
                    MessageBox.Show("Favor preencher todos os campos corretamente");
                    txtNomeCliente.Clear();
                    txtCpf.Clear();
                    txtDatadeNascimento.Clear();
                    txtNomeCliente.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Método cadastrar clientes: " + ex.Message);
            }
        }


        private bool ValidacaoCadastroClientes(Clientes cadastro)
        {
            if (txtNomeCliente.Text.IsNotNull() && txtCpf.Text.IsNotNull() && txtDatadeNascimento.Text.IsNotNull())
            {
                return true;
            }
            return false;
        }



        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtPesquisaNome.Text.Equals(""))
                {

                    Clientes clientes = new Clientes();
                    clientes.nome = txtPesquisaNome.Text;
                    clientes.cpf = txtPesquisaCpf.Text;
                    MySqlDataReader reader = clientes.LocalizarClientes();

                    if (reader != null)
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();

                            //txtId.Text = reader["id"].ToString();
                            txtPesquisaCpf.Text = reader["cpf"].ToString();
                            txtResultadoNome.Text = reader["nome"].ToString();
                            txtResultadoCpf.Text = reader["cpf"].ToString();
                            //txtProdutosAdquiridos.Text = reader[""].ToString();
                            //txtValorASerPago.Text = reader[""].ToString();

                        }
                        else
                        {
                            MessageBox.Show("Cliente não encontrado aqui ");
                            txtPesquisaNome.Clear();
                            txtPesquisaCpf.Clear();
                            txtPesquisaCpf.Focus();
                            txtId.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cliente não encontrado porra");
                        txtPesquisaNome.Clear();
                        txtPesquisaCpf.Clear();
                        txtPesquisaCpf.Focus();
                        txtId.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Favor preecher o campo CPF para realizar a pesquisa");
                    txtPesquisaNome.Clear();
                    txtPesquisaCpf.Clear();
                    txtPesquisaCpf.Focus();
                    txtId.Text = "";
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Error ao encontrar Cliente: " + ex.Message);
            }



        }

        private void BtnDadosClientes_Click(object sender, EventArgs e)
        {
            DadosDosClientes dadosDosClientes = new DadosDosClientes();
            dadosDosClientes.ShowDialog();
        }

        private void Cliente_Forms_Load(object sender, EventArgs e)
        {

        }
    }
}