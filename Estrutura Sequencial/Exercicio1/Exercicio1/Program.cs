using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor1 = int.Parse(Console.ReadLine());
            int valor2 = int.Parse(Console.ReadLine());

            int soma = valor1 + valor2;

            Console.WriteLine("SOMA = {0}", soma);
        }
    }
}