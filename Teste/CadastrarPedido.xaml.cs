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
            Pedidos pedidos = new Pedidos();
            Produtos produtoSelecionado = new Produtos();

            produtoSelecionado.NomeProduto = ListaProdutosCB.Text;
            produtoSelecionado.Preco = double.Parse(PrecoTB.Text);

            pedidos.Produto = produtoSelecionado;
            pedidos.Quantidade = int.Parse(QuantidadeTB.Text);
            pedidos.SubTotal = pedidos.Quantidade * produtoSelecionado.Preco;

            Pedidos.Add(pedidos);

            double valorTotal = Pedidos.Sum(p => p.SubTotal);

            ValorTotalTB.Text = "R$ " + valorTotal.ToString();
        }
    }
}
