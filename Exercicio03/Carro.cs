using System;

namespace Exercicio03
{
    internal class Carro : Veiculos
    {
        public override void Acelerar()
        {
            Console.WriteLine("Acelerando o carro...VROM VROM");
        }

        public override void Freiar()
        {
            Console.WriteLine("Freiando o carro...");
        }

        public string TrocarOleo()
        {
            return "O óleo do carro foi trocado";
        }

    }
}
