using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

////5 - Cadastro de Clientes
//Um sistema de cadastro de clientes de uma empresa guarda informações sobre nomes, endereços e telefones.
//Além disso, caso o cliente seja uma pessoa física, seu número de CPF é armazenado e,
//caso o cliente seja uma pessoa jurídica, seu CNPJ e nome de fantasia da empresa devem ser guardados.
//Implemente o cadastro e a consulta de dados dos clientes no sistema.
//Não esqueça de utilizar os conceitos de polimorfismo e classes abstratas.
namespace Exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente;
            Console.WriteLine("Insira o nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Insira o endereço: ");
            string endereco = Console.ReadLine();
            Console.WriteLine("Insira o telefone: ");
            string telefone = Console.ReadLine();
            

            Console.WriteLine("1-Pessoa Física\n2-Pessoa Jurídica\nEscolha: ");
            string escolha = Console.ReadLine();
            if (escolha == "1")
            {
                Console.WriteLine("Insira o CPF: ");
                string cpf = Console.ReadLine();
                cliente = new PessoaFisica(nome, endereco, telefone, cpf);
                Console.WriteLine(cliente.ToString());

            }
            else
            {
                Console.WriteLine("Insira o CNPJ: ");
                string cnpj = Console.ReadLine();
                Console.WriteLine("Insira o nome fantasia: ");
                string nomefantasia = Console.ReadLine();
                cliente = new PessoaJuridica(nome, endereco, telefone, cnpj, nomefantasia);
                Console.WriteLine(cliente.ToString());
            }         

        }
       
    
    }
}
