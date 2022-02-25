﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
    public class SubCelebridade
    {
        // Todos
        public string InfoPublica = "Tenho um instagram!";

        // herança
        protected string CorDoOlho = "Verde";

        //mesmo projeto (assembly)
        internal ulong NumeroCelular = 5511000000000;

        //herança ou mesmo projeto
        protected internal string JeitoDeFalar = "Uso muitas gírias";

        // mesma class ou herança ou mesmo projeto (c# >= 7.2)
        private protected string SegradoFamlia = "Bla bla";

        // private é o padrão
        bool UsaMuitoPhotoshop = true;

        public void MeusAcessos()
        {
            Console.WriteLine("SubCelebridade...");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegradoFamlia);
            Console.WriteLine(UsaMuitoPhotoshop);
        }

    }
}