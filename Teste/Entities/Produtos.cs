using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    public class Produtos
    {
        public int IdProduto { get; set; }
        public string NomeProduto { get; set; }
        public int Codigo { get; set; }
        public double Preco { get; set; }

        public Produtos()
        {
        }

        public Produtos(int idProduto, string nomeProduto, int codigo, double preco)
        {
            IdProduto = idProduto;
            NomeProduto = nomeProduto;
            Codigo = codigo;
            Preco = preco;
        }
    }
}
