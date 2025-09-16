using MySql.Data.MySqlClient;
using SistemaMelhorado.Conexão_Banco;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaMelhorado.Cliente.DadosClientes
{
    public partial class DadosDosClientes : Form
    {
        public DadosDosClientes()
        {
            InitializeComponent();
            CarregarDadosClientes();
        }

        private void CarregarDadosClientes()
        {
            string query = "SELECT * FROM clientes"; // Insira o nome correto da tabela aqui
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
                            dataGridView1.DataSource = dt; // Exibe os dados no DataGridView
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados dos clientes: " + ex.Message);
            }
        }

        private void DadosClientes_Load(object sender, EventArgs e)
        {

        }
    }
}

