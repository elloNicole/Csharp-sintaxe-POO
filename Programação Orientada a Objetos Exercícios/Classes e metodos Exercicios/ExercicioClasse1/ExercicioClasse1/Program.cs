using System;

namespace ExercicioClasse1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1, p2;
            p1 = new Pessoa();
            p2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa: ");

            Console.Write("Nome:");
            p1.Nome = Console.ReadLine();

            Console.Write("Idade:");
            p1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa: ");

            Console.Write("Nome:");
            p2.Nome = Console.ReadLine();

            Console.Write("Idade:");
            p2.Idade = int.Parse(Console.ReadLine());

            Console.Write("Pessoa mais velha: "); //nao quebra linha

            if (p1.Idade > p2.Idade)
            {
                Console.Write(p1.Nome);
            }
            else
            {
                Console.Write(p2.Nome);
            }

                

        }
    }
}