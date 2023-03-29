using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Teste
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Pessoa> pessoas;

        public MainWindow()
        {

            pessoas = new List<Pessoa>();

            pessoas.Add(new Pessoa());

            InitializeComponent();

            Pessoa teste = new Pessoa();

            teste.IdPessoa = "123";
            teste.Nome = "Teste da Silva";
            teste.Cpf = "000.123.456-98";
            teste.Endereco = "rua do teste testado, 659";

            DataGridPessoa.Items.Add(pessoas);

            Produtos teste2 = new Produtos();
            teste2.Codigo = 5;
            teste2.IdProduto = 123;
            teste2.NomeProduto = "Sapato";
            teste2.Valor = 1963.55;

            DataGridProduto.Items.Add(teste2);
        }

        private void PessoaButton_Click(object sender, RoutedEventArgs e)
        {
            TelaPessoa.Visibility = Visibility.Visible;
            TelaProduto.Visibility = Visibility.Hidden;
            TelaPedido.Visibility = Visibility.Hidden;
        }

        private void ProdutoButton_Click(object sender, RoutedEventArgs e)
        {
            TelaProduto.Visibility = Visibility.Visible;
            TelaPessoa.Visibility = Visibility.Hidden;
            TelaPedido.Visibility = Visibility.Hidden;

        }

        private void PedidoButton_Click(object sender, RoutedEventArgs e)
        {
            TelaPedido.Visibility = Visibility.Visible;
            TelaPessoa.Visibility = Visibility.Hidden;
            TelaProduto.Visibility = Visibility.Hidden;
        }

        private void IncluirPessoa_Click(object sender, RoutedEventArgs e)
        {
            CadastroPessoa cadastroPessoa = new CadastroPessoa();
            cadastroPessoa.Show();
        }

        private void IncluirProduto_Click(object sender, RoutedEventArgs e)
        {
            CadastrarProduto cadastrarProduto = new CadastrarProduto();
            cadastrarProduto.Show();
        }

        private void IncluirPedido_Click(object sender, RoutedEventArgs e)
        {
            CadastrarPedido cadastrarPedido = new CadastrarPedido();
            cadastrarPedido.Show();
        }

        // BOTÕES PESSOA
        private void AlterarPessoa_Click(object sender, RoutedEventArgs e)
        {
            this.SalvarPessoa.Visibility = Visibility.Visible;
        }

        private void SalvarPessoa_Click(object sender, RoutedEventArgs e)
        {
            this.SalvarPessoa.Visibility = Visibility.Collapsed;
        }

        // BOTÕES PRODUTOS

        private void AlterarProduto_Click(object sender, RoutedEventArgs e)
        {
            this.SalvarProduto.Visibility = Visibility.Visible;
        }

        private void SalvarProduto_Click(object sender, RoutedEventArgs e)
        {
            this.SalvarProduto.Visibility = Visibility.Collapsed;
        }

        // BOTÕES PEDIDOS
        private void AlterarPedido_Click(object sender, RoutedEventArgs e)
        {
            this.SalvarPedido.Visibility = Visibility.Visible;
        }

        private void SalvarPedido_Click(object sender, RoutedEventArgs e)
        {
            this.SalvarPedido.Visibility = Visibility.Collapsed;
        }
    }
}
