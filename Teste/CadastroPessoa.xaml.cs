using System;
using System.Collections.Generic;
using System.Windows;

namespace Teste
{ 
    public partial class CadastroPessoa : Window
    {
        public event EventHandler<PessoaCadastradaEventArgs> PessoaCadastradaEvent;

        public class PessoaCadastradaEventArgs : EventArgs
        {
            public Pessoa PessoaCadastrada { get; set; }
        }

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

            pessoa.IdPessoa = IdPessoaTB.Text;
            pessoa.Nome = NomePessoaTB.Text;
            pessoa.Cpf = CpfPessoaTB.Text;
            pessoa.Endereco = EnderecoPessoaTB.Text;

            PessoaCadastradaEvent?.Invoke(this, new PessoaCadastradaEventArgs { PessoaCadastrada = pessoa });

            this.Close(); // fecha a janela de cadastro de pessoa
        }


    }
}
