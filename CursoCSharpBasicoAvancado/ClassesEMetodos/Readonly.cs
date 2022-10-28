using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Readonly
    {
        public class Cliente
        {
            public string Nome;
            readonly DateTime Nascimento;
            public int ano;

            public Cliente(string nome, DateTime nascimento)
            {
                Nome = nome;
                Nascimento = nascimento;
                ano = nascimento.Year;
            }

            public string GetDataDeNascimento()
            {
                return String.Format("{0}/{1}/{2}", Nascimento.Day, Nascimento.Month, Nascimento.Year);
            }

        }
        public static void Executar()
        {
            {
                var novoCliente = new Cliente("Ana Silve", new DateTime(1987, 5, 22));

                Console.WriteLine(novoCliente.Nome);
                Console.WriteLine(novoCliente.GetDataDeNascimento());
            }
        }
    }
}
