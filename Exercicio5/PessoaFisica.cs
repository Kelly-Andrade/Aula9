using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    internal class PessoaFisica : Cliente
    {
        public string Cpf { get; set;}

        public PessoaFisica(string nome, string endereco, string telefone, string cpf)
            : base (nome, endereco, telefone)
        {
            this.Cpf = cpf;
        }

        public override string ToString()
        {
            return ($"Nome: {Nome}\nEndereço: {Endereco}\nTelefone: {Telefone}\nCPF: {Cpf}");
            
        }

    }
}

//{
//    Console.WriteLine("Nome: " + Nome);
//    Console.WriteLine("Endereço: " + Endereco);
//    Console.WriteLine("Telefone: " + Telefone);
//    Console.WriteLine("CPF: " + Cpf);
//}

