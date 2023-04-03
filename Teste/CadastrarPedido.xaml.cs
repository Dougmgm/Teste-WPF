using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Teste
{
    /// <summary>
    /// Lógica interna para CadastrarPedido.xaml
    /// </summary>
    public partial class CadastrarPedido : Window
    {
        public ObservableCollection<Pedidos> Pedidos { get; set; } = new ObservableCollection<Pedidos>();

        public CadastrarPedido()
        {
            InitializeComponent();
            DataGridPedido.ItemsSource = Pedidos;
        }

        private void SalvarPedido_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CancelarPedido_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
        }

        private void IncluirProdutoPedido_Click(object sender, RoutedEventArgs e)
        {
            // Cria um novo objeto Produtos correspondente ao produto selecionado
            Produtos produtoSelecionado = new Produtos
            {
                NomeProduto = ListaProdutosCB.Text,
                Preco = double.Parse(PrecoTB.Text)
            };

            // Cria um novo objeto Pedidos com o nome do produto, o objeto Produtos correspondente e a quantidade escolhida
            Pedidos pedidos = new Pedidos(produtoSelecionado.NomeProduto, produtoSelecionado, int.Parse(QuantidadeTB.Text));

            // Adiciona o novo objeto Pedidos à lista Pedidos
            Pedidos.Add(pedidos);

            // Calcula o valor total dos itens do pedido
            double valorTotal = Pedidos.Sum(p => p.SubTotal);

            ValorTotalTB.Text = "R$ " + valorTotal.ToString();
        }
    }
}
