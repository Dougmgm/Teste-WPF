namespace Teste
{
    public class Pedidos
    {
        public string NomeProduto { get; set; }
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public double SubTotal { get; set; }

        public Pedidos(string nomeProduto, Produto produto, int quantidade)
        {
            NomeProduto = nomeProduto;
            Produto = produto;
            Quantidade = quantidade;
            SubTotal = quantidade * produto.Preco;
        }
    }
}
