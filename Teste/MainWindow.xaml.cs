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
        // Declaração da lista de Pessoas
        public List<Pessoa> Pessoas { get; set; } = new List<Pessoa>();

        // Declaração da lista de Produtos
        public List<Produtos> Produtos { get; set; } = new List<Produtos>();

        public MainWindow()
        {

            InitializeComponent();

            // Define a origem dos dados do DataGridPessoa como a lista de Pessoas
            DataGridPessoa.ItemsSource = Pessoas;
            
        }

        // Evento disparado quando uma pessoa é cadastrada
        private void CadastroPessoa_PessoaCadastradaEvent(object sender, CadastroPessoa.PessoaCadastradaEventArgs e)
        {
            if (Pessoas.Count == 0)
            {
                // Se não houver pessoas cadastradas, o IdPessoa é 1
                e.PessoaCadastrada.IdPessoa = 1;
            }
            else
            {
                // Caso contrário, o IdPessoa é o último id cadastrado + 1
                int ultimoId = Pessoas.Max(p => p.IdPessoa);
                e.PessoaCadastrada.IdPessoa = ultimoId + 1;
            }

            // Adiciona a pessoa cadastrada na lista de Pessoas
            Pessoas.Add(e.PessoaCadastrada);

            // Atualiza o DataGridProduto para mostrar o novo produto cadastrado
            DataGridPessoa.Items.Refresh();
        }

        private void CadastrarProduto_ProdutosCadastradosEvent(object sender, CadastrarProduto.ProdutosCadastradosEventArgs e)
        {
            DataGridProduto.Items.Add(e.ProdutosCadastrados);
        }

        #region Telas

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

        #endregion

        #region Botões

        // Propriedade que retorna o número de pessoas cadastradas
        public int NumeroPessoasCadastradas => Pessoas.Count;

        // BOTÕES PESSOA
        private void IncluirPessoa_Click(object sender, RoutedEventArgs e)
        {
            CadastroPessoa cadastroPessoa = new CadastroPessoa();
            cadastroPessoa.IdPessoaTB.Text = (NumeroPessoasCadastradas + 1).ToString();
            cadastroPessoa.PessoaCadastradaEvent += CadastroPessoa_PessoaCadastradaEvent;
            cadastroPessoa.Show();
        }

        private void AlterarPessoa_Click(object sender, RoutedEventArgs e)
        {
            this.SalvarPessoa.Visibility = Visibility.Visible;
        }

        private void SalvarPessoa_Click(object sender, RoutedEventArgs e)
        {
            this.SalvarPessoa.Visibility = Visibility.Collapsed;
        }

        // BOTÕES PRODUTOS
        private void IncluirProduto_Click(object sender, RoutedEventArgs e)
        {
            CadastrarProduto cadastrarProduto = new CadastrarProduto();

            // Registra o evento ProdutosCadastradosEvent da janela CadastrarProduto
            cadastrarProduto.ProdutosCadastradosEvent += CadastrarProduto_ProdutosCadastradosEvent;

            cadastrarProduto.Show();

        }

        private void AlterarProduto_Click(object sender, RoutedEventArgs e)
        {
            this.SalvarProduto.Visibility = Visibility.Visible;
        }

        private void SalvarProduto_Click(object sender, RoutedEventArgs e)
        {
            this.SalvarProduto.Visibility = Visibility.Collapsed;
        }

        // BOTÕES PEDIDOS
        private void IncluirPedido_Click(object sender, RoutedEventArgs e)
        {
            CadastrarPedido cadastrarPedido = new CadastrarPedido();
            cadastrarPedido.Show();
        }

        private void AlterarPedido_Click(object sender, RoutedEventArgs e)
        {
            this.SalvarPedido.Visibility = Visibility.Visible;
        }

        private void SalvarPedido_Click(object sender, RoutedEventArgs e)
        {
            this.SalvarPedido.Visibility = Visibility.Collapsed;
        }

        #endregion
    }
}
