using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    public class Pedidos
    {
        public int IdPedido { get; set; }
        public Pessoa NomePessoa { get; set; }
        public Produtos Produto { get; set; }
        public DateTime DataVenda { get; set; }
        public int Quantidade { get; set; }
        public double SubTotal { get; set; }
        public TipoPagamento Tipo { get; set; }
        public StatusEnvio Status { get; set; }

        public Pedidos()
        {
        }

        public Pedidos(int idPedido, Pessoa nomePessoa, Produtos produto, DateTime dataVenda, int quantidade, double subTotal, TipoPagamento tipo, StatusEnvio status)
        {
            IdPedido = idPedido;
            NomePessoa = nomePessoa;
            Produto = produto;
            DataVenda = dataVenda;
            Quantidade = quantidade;
            SubTotal = subTotal;
            Tipo = tipo;
            Status = status;
        }
    }
}
