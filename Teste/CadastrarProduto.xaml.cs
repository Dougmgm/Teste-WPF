using System;
using System.Windows;

namespace Teste
{
    public partial class CadastrarProduto : Window
    {

        public event EventHandler<ProdutosCadastradosEventArgs> ProdutosCadastradosEvent;

        public class ProdutosCadastradosEventArgs : EventArgs
        {
            public Produto ProdutosCadastrados { get; set; }
        }

        public CadastrarProduto()
        {
            InitializeComponent();
        }

        private void CancelarProduto_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
        }

        private void IncluirProduto_Click(object sender, RoutedEventArgs e)
        {
            Produto produto = new Produto();

            produto.IdProduto = Convert.ToInt32(IdProdutoTB.Text);
            produto.NomeProduto = NomeProdutoTB.Text.ToUpper();
            produto.Codigo = CodigoProdutoTB.Text;
            produto.Preco = Convert.ToDouble(ValorProdutoTB.Text);

            ProdutosCadastradosEvent?.Invoke(this, new ProdutosCadastradosEventArgs { ProdutosCadastrados = produto });

            // fecha a janela de cadastro de pessoa
            this.Close(); 
        }
    }
}
