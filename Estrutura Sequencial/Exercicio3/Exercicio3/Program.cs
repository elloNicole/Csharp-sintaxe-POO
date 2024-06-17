using System;

namespace Exercicio3 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "Esse programa lê quatro valores A, B, C e D e mostra a diference entre o produto de A e B polo produto de C e D");

            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());

            int diferenca = A * B - C * D;

            Console.WriteLine($"DIFERENCA = {diferenca}");
        }
    }
}