using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    public class Pessoa
    {
        public int IdPessoa { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Endereco { get; set; }

        public Pessoa()
        {
        }

        public Pessoa(int idPessoa, string nome, string cpf, string endereco)
        {
            IdPessoa = idPessoa;
            Nome = nome;
            Cpf = cpf;
            Endereco = endereco;
        }
    }
}
