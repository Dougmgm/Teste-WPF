using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Windows;
using System.Xml.Linq;

namespace Teste
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        // Declaração da lista de Pessoas
        public ObservableCollection<Pessoa> Pessoas { get; set; } = new ObservableCollection<Pessoa>();
        // Declaração da lista de Produtos
        public ObservableCollection<Produto> Produtos { get; set; } = new ObservableCollection<Produto>();
        private int UltimoIdPessoa { get; set; }
        private int UltimoIdProduto { get; set; }

        public MainWindow()
        {

            InitializeComponent();

            // Define a origem dos dados do DataGridPessoa como a lista de Pessoas
            DataGridPessoa.ItemsSource = Pessoas;
            DataGridProduto.ItemsSource = Produtos;

            LerXmlPessoa("C:\\ListaPessoa.xml");
            LerXmlProduto("C:\\ListaProduto.xml");
        }

        #region Gerenciador de cadastros

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
                e.PessoaCadastrada.IdPessoa = UltimoIdPessoa + 1;
            }

            // Adiciona a pessoa cadastrada na lista de Pessoas
            UltimoIdPessoa++;
            Pessoas.Add(e.PessoaCadastrada);
        }

        private void CadastrarProduto_ProdutosCadastradosEvent(object sender, CadastrarProduto.ProdutosCadastradosEventArgs e)
        {
            if (Produtos.Count == 0)
            {
                // Se não houver pessoas cadastradas, o IdProduto é 1
                e.ProdutosCadastrados.IdProduto = 1;
            }
            else
            {
                // Caso contrário, o IdProduto é o último id cadastrado + 1
                //int ultimoId = Produtos.Max(p => p.IdProduto);
                e.ProdutosCadastrados.IdProduto = UltimoIdProduto + 1;
            }

            // Adiciona a pessoa cadastrada na lista de Produtos
            UltimoIdProduto++;
            Produtos.Add(e.ProdutosCadastrados);
        }

        #endregion

        #region Telas

        private void PessoaButton_Click(object sender, RoutedEventArgs e)
        {
            TelaPessoa.Visibility = Visibility.Visible;
            TelaProduto.Visibility = Visibility.Hidden;
            TelaPedido.Visibility = Visibility.Hidden;
            PesquisaPessoaTB.Text = "";
        }

        private void ProdutoButton_Click(object sender, RoutedEventArgs e)
        {
            TelaProduto.Visibility = Visibility.Visible;
            TelaPessoa.Visibility = Visibility.Hidden;
            TelaPedido.Visibility = Visibility.Hidden;
            PesquisaProdutoTB.Text = "";

        }

        private void PedidoButton_Click(object sender, RoutedEventArgs e)
        {
            TelaPedido.Visibility = Visibility.Visible;
            TelaPessoa.Visibility = Visibility.Hidden;
            TelaProduto.Visibility = Visibility.Hidden;
        }

        #endregion

        #region Botões

        #region Botões Pessoa

        private void IncluirPessoa_Click(object sender, RoutedEventArgs e)
        {
            AbrirPessoa();
        }

        private void BtnPesquisaPessoa_Click(object sender, RoutedEventArgs e)
        {
            var dadosGrid = Pessoas.Where(p => p.Nome.Contains(PesquisaPessoaTB.Text) || p.Cpf.Contains(PesquisaPessoaTB.Text)).ToList();

            if (dadosGrid.Count > 0)
            {
                DataGridPessoa.ItemsSource = dadosGrid;
            }
            else
            {
                MessageBox.Show("Pessoa não encontrado!");
            }
        }

        private void AbrirPessoa()
        {
            CadastroPessoa cadastroPessoa = new CadastroPessoa();
            cadastroPessoa.IdPessoaTB.Text = (UltimoIdPessoa + 1).ToString();
            cadastroPessoa.PessoaCadastradaEvent += CadastroPessoa_PessoaCadastradaEvent;
            cadastroPessoa.Show();
        }

        private void PedidoPessoa_Click(object sender, RoutedEventArgs e)
        {
            CadastrarPedido cadastrarPedido = new CadastrarPedido();
            cadastrarPedido.Show();
        }


        private void AlterarPessoa_Click(object sender, RoutedEventArgs e)
        {
            //TALVEZ ALTERAR POR BOTÃO DENTRO DO GRID
            CadastroPessoa cadastroPessoa = new CadastroPessoa();
            dynamic data = DataGridPessoa.SelectedItem;
            int indexId = data.IdPessoa;
            int indexList = Pessoas.IndexOf(Pessoas.Where(p => p.IdPessoa == indexId).FirstOrDefault());
            if(indexList != -1)
            {
                AbrirPessoa();
                cadastroPessoa.IdPessoaTB.Text = Pessoas[indexList].IdPessoa.ToString();
                cadastroPessoa.NomePessoaTB.Text = Pessoas[indexList].Nome;
                cadastroPessoa.CpfPessoaTB.Text = Pessoas[indexList].Cpf;
                cadastroPessoa.EnderecoPessoaTB.Text = Pessoas[indexList].Endereco;
            }
            this.SalvarPessoa.Visibility = Visibility.Visible;
        }

        private void SalvarPessoa_Click(object sender, RoutedEventArgs e)
        {
            this.SalvarPessoa.Visibility = Visibility.Collapsed;
        }

        private void PedidosPessoa_Click(object sender, RoutedEventArgs e)
        {
            //ARRUMAR VERIFICAÇÃO DA LISTA DE PRODUTOS CASO ESTEJA VAZIA
            CadastrarPedido cadastrarPedido = new CadastrarPedido();

            dynamic data = DataGridPessoa.SelectedItem;
            string result = data.Nome;
            cadastrarPedido.NomePessoaPedidoTB.Text = result.ToUpper();

            foreach(Produto produto in Produtos)
            {
                cadastrarPedido.ListaProdutosCB.Items.Add(produto.NomeProduto);
            }
            cadastrarPedido.ShowDialog();
        }

        private void ExcluirPessoa_Click(object sender, RoutedEventArgs e)
        {
            dynamic data = DataGridPessoa.SelectedItem;
            Pessoas.Remove(data);
        }

        #endregion

        #region Botões Produtos
        // BOTÕES PRODUTOS
        private void IncluirProduto_Click(object sender, RoutedEventArgs e)
        {
            CadastrarProduto cadastrarProduto = new CadastrarProduto();
            cadastrarProduto.IdProdutoTB.Text = (UltimoIdProduto + 1).ToString();

            // Registra o evento ProdutosCadastradosEvent da janela CadastrarProduto
            cadastrarProduto.ProdutosCadastradosEvent += CadastrarProduto_ProdutosCadastradosEvent;
            cadastrarProduto.Show();
        }

        private void BtnPesquisaProduto_Click(object sender, RoutedEventArgs e)
        {
            var dadosGrid = Produtos.Where(p => p.NomeProduto.Contains(PesquisaProdutoTB.Text) || p.Codigo.Contains(PesquisaProdutoTB.Text)).ToList();

            if (dadosGrid.Count > 0)
            {
                DataGridProduto.ItemsSource = dadosGrid;
            }
            else
            {
                MessageBox.Show("Produto não encontrado!");
            }
        }

        private void AlterarProduto_Click(object sender, RoutedEventArgs e)
        {
            this.SalvarProduto.Visibility = Visibility.Visible;
        }

        private void SalvarProduto_Click(object sender, RoutedEventArgs e)
        {
            this.SalvarProduto.Visibility = Visibility.Collapsed;
        }

        private void ExcluirProduto_Click(object sender, RoutedEventArgs e)
        {
            dynamic data = DataGridProduto.SelectedItem;
            Produtos.Remove(data);
        }


        #endregion

        #region Botões Pedidos

        // BOTÕES PEDIDOS
        private void IncluirPedido_Click(object sender, RoutedEventArgs e)
        {
            //PARA DEPOIS
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

        #endregion

        #region XML

        private void ExportarXmlPessoa(string fileName)
        {

            var pessoasXml = DataGridPessoa.ItemsSource as List<Pessoa>;

            if (Pessoas == null)
            {
                return;
            }

            var xml = new XElement("Pessoas",
                new XElement("UltimoIdPessoa", UltimoIdPessoa),
                from p in Pessoas
                select new XElement("Pessoa",
                    new XElement("IdPessoa", p.IdPessoa),
                    new XElement("Nome", p.Nome),
                    new XElement("Cpf", p.Cpf),
                    new XElement("Endereco", p.Endereco)
                )
            );
            xml.Save(fileName);
        }

        private void ExportarXmlProduto(string fileName)
        {

            var produtosXml = DataGridProduto.ItemsSource as List<Produto>;

            if (Produtos == null)
            {
                return;
            }

            var xml = new XElement("Produtos",
                new XElement("UltimoIdProduto", UltimoIdProduto),
                from p in Produtos
                select new XElement("Produto",
                    new XElement("IdProduto", p.IdProduto),
                    new XElement("NomeProduto", p.NomeProduto),
                    new XElement("Codigo", p.Codigo),
                    new XElement("Preco", p.Preco)
                )
            );
            xml.Save(fileName);
        }


        private void LerXmlPessoa(string fileName)
        {
            try
            {
                var xml = XElement.Load(fileName);

                UltimoIdPessoa = int.Parse(xml.Element("UltimoIdPessoa").Value);

                foreach (var element in xml.Elements("Pessoa"))
                {
                    var pessoa = new Pessoa
                    {
                        IdPessoa = int.Parse(element.Element("IdPessoa").Value),
                        Nome = element.Element("Nome").Value,
                        Cpf = element.Element("Cpf").Value,
                        Endereco = element.Element("Endereco").Value,
                    };
                    Pessoas.Add(pessoa);
                }
            }
            catch
            {
                return;
            }
        }

        private void LerXmlProduto(string fileName)
        {
            try
            {
                var xml = XElement.Load(fileName);

                UltimoIdProduto = int.Parse(xml.Element("UltimoIdProduto").Value);

                foreach (var element in xml.Elements("Produto"))
                {
                    var produto = new Produto
                    {
                        IdProduto = int.Parse(element.Element("IdProduto").Value),
                        NomeProduto = element.Element("NomeProduto").Value,
                        Codigo = element.Element("Codigo").Value,
                        Preco = double.Parse(element.Element("Preco").Value),
                    };
                    Produtos.Add(produto);
                }
            }
            catch
            {
                return;
            }
        }

        private void DataGridPessoa_LayoutUpdated(object sender, EventArgs e)
        {
            ExportarXmlPessoa("C:\\ListaPessoa.xml");
        }

        private void DataGridProduto_LayoutUpdated_1(object sender, EventArgs e)
        {
            ExportarXmlProduto("C:\\ListaProduto.xml");
        }

        #endregion

    }
}
