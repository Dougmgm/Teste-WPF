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
            if (IdPessoaTB.Text != "" && CpfPessoaTB.Text != "")
            {
                if (Pessoa.ValidaCpf(CpfPessoaTB.Text))
                {
                    Pessoa pessoa = new Pessoa
                    {
                        IdPessoa = Convert.ToInt32(IdPessoaTB.Text),
                        Nome = NomePessoaTB.Text.ToUpper(),
                        Cpf = CpfPessoaTB.Text,
                        Endereco = EnderecoPessoaTB.Text
                    };

                    PessoaCadastradaEvent?.Invoke(this, new PessoaCadastradaEventArgs { PessoaCadastrada = pessoa });

                    // fecha a janela de cadastro de pessoa
                    this.Close();
                }
                else
                {
                    MessageBox.Show("CPF Inválido!");
                }
            }
            else
            {
                MessageBox.Show("Favor preencher todos os dados obrigatórios");
            }
        }

    }
}
