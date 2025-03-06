using MySql.Data.MySqlClient;
using SistemaMelhorado.Conexão_Banco;
using System.Data;

namespace SistemaMelhorado.FormDados
{
    public partial class Dados : Form
    {
        public Dados()
        {
            InitializeComponent();
            CarregarDadosDoBanco();
        }

        private void CarregarDadosDoBanco()
        {


            string query = "SELECT * FROM produtos"; // Insira o nome correto da tabela aqui
            try
            {


                using (MySqlConnection conn = new MySqlConnection(ConexaoBanco.BancoServidor1))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dataGridViewDados.DataSource = dt; // Exibe os dados no DataGridView
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }
        }

        
    }
}
