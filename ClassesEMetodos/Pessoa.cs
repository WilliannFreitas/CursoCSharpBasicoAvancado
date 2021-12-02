using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Pessoa
    {
        public string Nome;
        public int Idade;

        public string Apresentar() 
        {
            return string.Format
                ($"Olá! Me chamo {Nome} e tenho {Idade}");
                
        }
        public void ApresentarNoConsole()
        {
            if (Nome == "" || Idade == 0)
            {
                Console.WriteLine("Nome e Idade não podem estar vazios!");
            }
            else
            {
                Console.WriteLine(Apresentar());
            }
        }
        public void Zerar() 
        {
            Nome = "ane";
            Idade = 18;
        }
    }
}
