using System.Collections.Generic;
using System.Windows;

namespace Teste
{
    public partial class CadastroPessoa : Window
    {
        public Pessoa Pessoa { get; set; }

        public CadastroPessoa()
        {
            InitializeComponent();
        }

        private void CancelarPessoa_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
        }

        private void SalvarPessoaButton_Click(object sender, RoutedEventArgs e)
        {
            Pessoa pessoa = new Pessoa();
          //  Pessoa pessoas = new List<Pessoa>();

            pessoa.IdPessoa = IdPessoaTB.Text;
            pessoa.Nome = NomePessoaTB.Text;
            pessoa.Cpf = CpfPessoaTB.Text;
            pessoa.Endereco = EnderecoPessoaTB.Text;

        }
    }
}
