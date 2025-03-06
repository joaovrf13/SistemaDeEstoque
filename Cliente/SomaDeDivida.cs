using SistemaMelhorado.Cadastro_Produtos;


namespace SistemaMelhorado.Cliente
{
    internal class SomaDeDivida
    {
        public decimal CalculoDivida(Clientes cliente, Produtos produtos)
        {
            int quatidade = produtos.Quantidade;
            decimal preço = produtos.Preco;

            return quatidade * preço;
        }
    }
}
