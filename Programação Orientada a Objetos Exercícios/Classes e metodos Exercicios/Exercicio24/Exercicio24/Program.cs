using Exercicio24;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Pessoa x, y;
            x = new Pessoa();
            y = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            x.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            x.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            y.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            y.Idade = int.Parse(Console.ReadLine());

            Console.Write("Pessoa mais velha: ");
            if ( x.Idade > y.Idade)
            {
                Console.Write(x.Nome);
            }
            else
            {
                Console.Write(y.Nome);
            }



        }
    }
}
