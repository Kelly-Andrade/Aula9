using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    internal class PessoaJuridica : Cliente
    {
        public string Cnpj { get; set; }
        public string NomeFantasia { get; set; }

        public PessoaJuridica(string nome, string endereco, string telefone, string cnpj, string nomeFantasia)
            : base(nome, endereco, telefone)
        {
            this.Cnpj = cnpj;
            this.NomeFantasia = nomeFantasia;
        }

        public override string ToString()
        {
            return ($"Nome: {Nome}\nEndereço: {Endereco}\nTelefone: {Telefone}\nCNPJ: {Cnpj}\nNome Fantasia: {NomeFantasia}");

        }

        //public override void Menu()
        //{
        //    Console.WriteLine("Insira o nome: ");
        //    string nome = Console.ReadLine();
        //    Console.WriteLine("Insira o endereço: ");
        //    string endereco = Console.ReadLine();
        //    Console.WriteLine("Insira o telefone: ");
        //    string telefone = Console.ReadLine();
        //    Console.WriteLine("Insira o CNPJ: ");
        //    string cnpj = Console.ReadLine();
        //    Console.WriteLine("Insira o nome fantasia: ");
        //    string nomefantasia 
        //}
    }
}
