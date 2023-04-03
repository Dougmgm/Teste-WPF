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
using System.Windows.Shapes;
using static Teste.CadastroPessoa;

namespace Teste
{
    public partial class CadastrarProduto : Window
    {

        public event EventHandler<ProdutosCadastradosEventArgs> ProdutosCadastradosEvent;

        public class ProdutosCadastradosEventArgs : EventArgs
        {
            public Produtos ProdutosCadastrados { get; set; }
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
            Produtos produto = new Produtos();

            produto.IdProduto = Convert.ToInt32(IdProdutoTB.Text);
            produto.NomeProduto = NomeProdutoTB.Text;
            produto.Codigo = Convert.ToInt32(CodigoProdutoTB.Text);
            produto.Preco = Convert.ToDouble(ValorProdutoTB.Text);

            ProdutosCadastradosEvent?.Invoke(this, new ProdutosCadastradosEventArgs { ProdutosCadastrados = produto });

            // fecha a janela de cadastro de pessoa
            this.Close(); 
        }
    }
}
