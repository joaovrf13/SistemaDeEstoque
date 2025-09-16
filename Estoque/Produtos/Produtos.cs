using MySql.Data.MySqlClient;
using SistemaMelhorado.Conexão_Banco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMelhorado.Cadastro_Produtos
{
    internal class Produtos
    {
        private int id;
        private string nome;
        private string categoria;
        private decimal custo;
        private decimal preco;
        private int quantidade;
        private string fornecedor;
        private DateTime dataDaCompra;
        private DateTime dataDoCadastro = DateTime.Now;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        public decimal Custo
        {
            get { return custo; }
            set { custo = value; }
        }

        public decimal Preco
        {
            get { return preco; }
            set { preco = value; }
        }

        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }

        public string Fornecedor
        {
            get { return fornecedor; }
            set { fornecedor = value; }
        }

        public DateTime DataDaCompra
        {
            get { return dataDaCompra; }
            set { dataDaCompra = value; }
        }

        public DateTime DataDoCadastro
        {
            get { return dataDoCadastro; }
            set { dataDoCadastro = value; }
        }

        public decimal CalculoProduto()
        {
            return Preco;
        }
        public bool CadastrarProdutos()
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(ConexaoBanco.BancoServidor1))
                {
                    conexao.Open();

                    string query = @"INSERT INTO produtos 
                             (nome, categoria, custo, preco, quantidade, fornecedor, dataDaCompra) 
                             VALUES 
                             (@Nome, @Categoria, @Custo, @Preco, @Quantidade, @Fornecedor, @Datadacompra)";

                   
                    using (MySqlCommand comando = new MySqlCommand(query, conexao))
                    {
                        comando.Parameters.AddWithValue("@Nome", Nome ?? ""); 
                        comando.Parameters.AddWithValue("@Categoria", Categoria ?? "");
                        comando.Parameters.AddWithValue("@Custo", Custo);
                        comando.Parameters.AddWithValue("@Preco", Preco);
                        comando.Parameters.AddWithValue("@Quantidade", Quantidade);
                        comando.Parameters.AddWithValue("@Fornecedor", Fornecedor ?? "");
                        comando.Parameters.AddWithValue("@Datadacompra", DataDaCompra);

                        
                        comando.ExecuteNonQuery();
                    }
                }
                return true; 
            }
            catch (Exception ex)
            {
                
                MessageBox.Show($"Erro no banco de dados (CadastrarProdutos): {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public MySqlDataReader LocalizarProdutos()
        {
            try
            {
                MySqlConnection MySqlConexaoBanco = new MySqlConnection(ConexaoBanco.BancoServidor1);
                MySqlConexaoBanco.Open();

                string query = "SELECT id, categoria, custo, preco, quantidade, fornecedor, datadacompra, datadocadastro " +
                                "FROM produtos WHERE nome = @Nome LIMIT 1";

                MySqlCommand ComandoSql = new MySqlCommand(query, MySqlConexaoBanco);
                ComandoSql.Parameters.AddWithValue("@Nome", Nome);

                MySqlDataReader reader = ComandoSql.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read(); 
                    return reader;
                }
                else
                {
                    MessageBox.Show("Produto não encontrado.");
                    return null;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao localizar produto: " + e.Message);
                return null;
            }
        }


        public bool AtualizarProdutos()
        {
            try
            {
                using (MySqlConnection MySqlConexaoBanco = new MySqlConnection(ConexaoBanco.BancoServidor1))
                {
                    MySqlConexaoBanco.Open();

                    string update = "UPDATE produtos SET nome = @Nome, custo = @Custo, preco = @Preco, quantidade = @Quantidade, fornecedor = @Fornecedor WHERE id = @Id";
                    using (MySqlCommand comandoSql = new MySqlCommand(update, MySqlConexaoBanco))
                    {
                        comandoSql.Parameters.AddWithValue("@Nome", Nome);
                        comandoSql.Parameters.AddWithValue("@Custo", Custo);
                        comandoSql.Parameters.AddWithValue("@Preco", Preco);
                        comandoSql.Parameters.AddWithValue("@Quantidade", Quantidade);
                        comandoSql.Parameters.AddWithValue("@Fornecedor", Fornecedor);
                        comandoSql.Parameters.AddWithValue("@Id", id);

                        // Verifica se a operação afetou alguma linha
                        int rowsAffected = comandoSql.ExecuteNonQuery();
                        return rowsAffected > 0; // Retorna true se uma linha foi atualizada
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco de dados - método AtualizarProdutos: " + ex.Message);
                return false;
            }
        }

        public bool DeletarProdutos(int id)
        {
            try
            {
                using (MySqlConnection MySqlConexaoBanco = new MySqlConnection(ConexaoBanco.BancoServidor1))
                {
                    MySqlConexaoBanco.Open();

                    string delete = "DELETE FROM produtos WHERE id = @Id";
                    using (MySqlCommand comandoSql = new MySqlCommand(delete, MySqlConexaoBanco))
                    {
                        comandoSql.Parameters.AddWithValue("@Id", id);

                        // Verifica se a operação afetou alguma linha
                        int rowsAffected = comandoSql.ExecuteNonQuery();
                        return rowsAffected > 0; // Retorna true se uma linha foi excluída
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco de dados - método DeletarProduto: " + ex.Message);
                return false;
            }
        }
    }
}
