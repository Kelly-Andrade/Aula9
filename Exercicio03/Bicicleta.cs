using System;

namespace Exercicio03
{
    internal class Bicicleta : Veiculos
    {
        public override void Acelerar()
        {
            Console.WriteLine("Acelerando a bicicleta...RANDAN DAN DAN");
        }

        public override void Freiar()
        {
            Console.WriteLine("Freiando a bicicleta...");
        }

        public string AjustarCorreia()
        {
            return "A correia da bicicleta foi ajustada!";
        }
    }
}
