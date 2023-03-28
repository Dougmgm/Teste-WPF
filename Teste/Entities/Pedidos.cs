using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    class Pedidos
    {
        public int IdPedido { get; set; }
        public Pessoa NomePessoa { get; set; }
        public Produtos Produto { get; set; }
        public DateTime DataVenda { get; set; }
        public TipoPagamento Tipo { get; set; }
        public StatusEnvio Status { get; set; }
    }
}
