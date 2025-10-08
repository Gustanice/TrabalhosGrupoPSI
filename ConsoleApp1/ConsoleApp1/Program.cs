
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
                Console.WriteLine("De o "+ (i + 1)+ "º numero");
                vetor1[i] = int.Parse(Console.ReadLine());
            }
            for(int i = 1; i < vetor1.Length; i++)
            {
                if(vetor1[i] > vetor1[maiorNumero])
                {
                    maiorNumero = i;
                }
            }
        
            Console.WriteLine("ABCDEFGHIJKLMNOPQRSTUVWXYZ");
            Console.WriteLine("O maior numero é: " + vetor1[maiorNumero] + " e está na posição: " + (maiorNumero + 1));
        }

    }
}
