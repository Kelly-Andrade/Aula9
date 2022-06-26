using System;

namespace Exercicio03
{
    //3 - Veículos
//  Criar um programa que representa os veículos do mundo real como uma classe abstrata.
//  Também escolha dois veículos para herdá-la, como por exemplo Bicicleta e Carro.
//  Os métodos da classe Veiculo são todos abstratos e devem corresponder a ação de acelerar e frear.
//  Estes métodos são implementados nas Carro e Bicicleta, por exemplo.
//  Acrescentar nas classes derivadas, métodos específicos tais como trocar óleo para classe carro,
//  ajustar a correia para classe bicicleta.
//  Na classe main instancie os veículos e utilize seus métodos.
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro carro1 = new Carro();
            carro1.Acelerar();
            carro1.Freiar();
            Console.WriteLine(carro1.TrocarOleo());

            Bicicleta bicicleta1 = new Bicicleta();
            bicicleta1.Acelerar();
            bicicleta1.Freiar();
            bicicleta1.AjustarCorreia();                      

        }
    }
}
