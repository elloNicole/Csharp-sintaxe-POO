using System;

namespace Exercicio23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;

            N=int.Parse(Console.ReadLine());    

            for (int i = 1; i <= N; i++)
            {
                Console.Write(i + " ");
                Console.Write(i*i + " ");
                Console.WriteLine(i*i*i + " ");

            }
        }
    }
}