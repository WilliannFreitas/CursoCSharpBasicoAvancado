using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    class LendoDados
    {
        public static NumberStyles Culture { get; private set; }

        public static void Executar()
        {
            Console.Write("Qual é o seu nome? ");
            string nome = Console.ReadLine();

            Console.Write("Qual é  sua idade? ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Qual é o seu salário? ");
            double salario = double.Parse(Console.ReadLine(),
                CultureInfo.InvariantCulture);

            Console.WriteLine($"{nome} {idade} R${salario}");
                
        }
    }
}
