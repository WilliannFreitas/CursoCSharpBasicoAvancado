﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle
{
    class EstruturaIfElse
    { 
        public static void Executar()
        {
            double nota = 7.0;

            if (nota >= 7.0) {
                Console.WriteLine("Aprovado!");
                Console.WriteLine("Não fes mais que a sua obrigação...");
            } else
            {
                Console.WriteLine("Recuperação");
            }
        }
        }
}
