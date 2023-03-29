using System;
using System.Collections.Generic;
using System.Windows;

namespace Teste
{

    public class PessoaCadastradaEventArgs : EventArgs
    {
        public Pessoa Pessoa { get; set; }

        public event EventHandler<PessoaCadastradaEventArgs> PessoaCadastradaEvent;
    }

   

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
            Pessoa pessoa2 = new Pessoa();

            pessoa2.Nome = NomePessoaTB.Text;
            pessoa2.Cpf = CpfPessoaTB.Text;
            pessoa2.Endereco = EnderecoPessoaTB.Text;

            PessoaCadastradaEvent?.Invoke(this, new PessoaCadastradaEventArgs { Pessoa = pessoa2 });

            this.Close(); // fecha a janela de cadastro de pessoa
        }


    }
}
