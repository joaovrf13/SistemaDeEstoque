using MySql.Data.MySqlClient;
using SistemaMelhorado.Cadastro_Produtos;
using SistemaMelhorado.Conexão_Banco;


namespace SistemaMelhorado.Cliente
{
    internal class Clientes
    {
        private string Nome { get; set; }
        private string Cpf { get; set; }  
        private DateTime DataDeNascimento { get; set; }
        private int QuantidadeComprada { get; set; }
        private  decimal ValorDeDivida { get; set; }


        public string nome
        {
            get { return Nome; }
            set { Nome = value; }
        }

        public string cpf
        {
            get { return Cpf; }
            set { Cpf = value; }
        }

        public DateTime datadenascimento
        {
            get { return DataDeNascimento; }
            set { DataDeNascimento = value; }
        }
        public decimal valordedivida
        {
            get { return ValorDeDivida; }
            set { ValorDeDivida = value; }
        }


        public decimal CalculoCliente()
        {
            return QuantidadeComprada;
        }

        public decimal ValorDivida(SomaDeDivida somaDeDivida, Clientes cliente, Produtos produto)
        {
            return somaDeDivida.CalculoDivida(cliente, produto);
        }

        public bool CadastrarCliente()
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(ConexaoBanco.BancoServidor1))
                {
                    conexao.Open();

                    // Verificar se o cliente já está cadastrado pelo CPF
                    string queryVerificar = @"SELECT COUNT(*) FROM clientes WHERE cpf = @Cpf";
                    using (MySqlCommand comandoVerificar = new MySqlCommand(queryVerificar, conexao))
                    {
                        comandoVerificar.Parameters.AddWithValue("@Cpf", Cpf ?? "");
                        int count = Convert.ToInt32(comandoVerificar.ExecuteScalar());

                        if (count > 0)
                        {
                            // Cliente já cadastrado, retorno false
                            MessageBox.Show("Cliente já cadastrado!");
                            return false;
                        }
                    }

                    // Inserir novo cliente
                    string query = @"INSERT INTO clientes (nome, cpf, datadenascimento)
                             VALUES (@Nome, @Cpf, @DataDeNascimento)";
                    using (MySqlCommand comando = new MySqlCommand(query, conexao))
                    {
                        comando.Parameters.AddWithValue("@Nome", Nome ?? "");
                        comando.Parameters.AddWithValue("@Cpf", Cpf);
                        comando.Parameters.AddWithValue("@DataDeNascimento", DataDeNascimento);

                        comando.ExecuteNonQuery();
                    }
                    return true;
                }
            }
            catch (Exception e)
            {
               
                Console.WriteLine($"Erro no método CadastrarCliente: {e.Message}");
                return false;
            }
        }



        public MySqlDataReader LocalizarClientes()
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection(ConexaoBanco.BancoServidor1);
                conexao.Open();

                string query = @"SELECT nome, cpf, datadenascimento
                                 FROM clientes WHERE cpf = @Cpf LIMIT 1";

                MySqlCommand comandoSql = new MySqlCommand(query, conexao);

                comandoSql.Parameters.AddWithValue("@Cpf", Cpf);
                comandoSql.Parameters.AddWithValue("@Nome", Nome);
                return comandoSql.ExecuteReader();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro no banco de dados - Método LocalizarClientes: {e.Message}");
                return null;
            }
        }
    }
}
