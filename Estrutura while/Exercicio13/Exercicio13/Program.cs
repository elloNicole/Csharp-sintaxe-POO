using System;

namespace Exercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int validPassword=2002, input;

            input = int.Parse(Console.ReadLine());

            while (validPassword != input)
            {
                Console.WriteLine("Senha Invalida");
                input = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Prmitido");
        }
    }
}