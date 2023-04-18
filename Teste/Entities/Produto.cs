using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    public class Produto
    {
        public int IdProduto { get; set; }
        public string NomeProduto { get; set; }
        public string Codigo { get; set; }
        public double Preco { get; set; }

        public Produto()
        {
        }

        public Produto(int idProduto, string nomeProduto, string codigo, double preco)
        {
            IdProduto = idProduto;
            NomeProduto = nomeProduto;
            Codigo = codigo;
            Preco = preco;
        }
    }
}
