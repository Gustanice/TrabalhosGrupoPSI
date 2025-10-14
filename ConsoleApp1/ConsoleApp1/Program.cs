
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor1 = new int[10];
            int maiorNumero = 0;
            for (int i = 0; i < vetor1.Length; i++)
            {
                Console.WriteLine("De o " + (i + 1) + "º numero");
                vetor1[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 1; i < vetor1.Length; i++)
            {
                if (vetor1[i] > vetor1[maiorNumero])
                {
                    maiorNumero = i;
                }
            }
            Console.WriteLine("maximo {1}.", vetor1[maiorNumero]);
            Console.WriteLine("indice {1}.", maiorNumero);

            Console.WriteLine("Maior valor {0} e indice {1}.", vetor1[maiorNumero], maiorNumero);
            Console.WriteLine("********************");
            Console.WriteLine("Tecle enter para fechar ...");
            Console.WriteLine("Cardiaco");
        }


    }
}
