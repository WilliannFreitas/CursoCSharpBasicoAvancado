using System;
using System.IO;

namespace CursoCSharp.API
{
    class Diretorios
    {
        public static void Executar()
        {
            var novoDir = @"~/PastCSharp".ParseHome();
            var novoDirDestino = @"~/PastCSharpDestino".ParseHome();
            var dirProjeto = @"D:\REPO\ProjetoCSharp\CursoCSharp";

            if (Directory.Exists(novoDir))
            {
                Directory.Delete(novoDir, true);
            }

            if (Directory.Exists(novoDir))
            {
                Directory.Delete(novoDirDestino, true);
            }

            Directory.CreateDirectory(novoDir);
            Console.WriteLine(Directory.GetCreationTime(novoDir));

            Console.WriteLine("==pastas==========");
            var pastas = Directory.GetDirectories(dirProjeto);
            foreach (var pasta in pastas)
            {
                Console.WriteLine(pasta);
            }

            Console.WriteLine("\n\n==ARQUIVOS==================");
            var arquivos = Directory.GetFiles(dirProjeto);
            foreach (var arquivo in arquivos)
            {
                Console.WriteLine(arquivo);
            }

            Console.WriteLine("\n\n==RAÍZ==================");
            Console.WriteLine(Directory.GetDirectoryRoot(novoDir));

            Directory.Move(novoDir, novoDirDestino);

        }
    }
}
