using System;
using System.Globalization;

namespace Exercicio25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario pessoa1, pessoa2;
            double media;

            pessoa1 = new Funcionario();
            pessoa2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            pessoa1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            pessoa1.Salario= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            pessoa2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            pessoa2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = (pessoa1.Salario + pessoa2.Salario)/2;

            Console.WriteLine($"Salário médio {media.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}