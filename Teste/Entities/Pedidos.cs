using Teste;

public class Pedidos
{
    public string NomeProduto { get; set; }
    public Produtos Produto { get; set; }
    public int Quantidade { get; set; }
    public double SubTotal { get; set; }

    public Pedidos(string nomeProduto, Produtos produto, int quantidade)
    {
        NomeProduto = nomeProduto;
        Produto = produto;
        Quantidade = quantidade;
        SubTotal = quantidade * produto.Preco;
    }
}