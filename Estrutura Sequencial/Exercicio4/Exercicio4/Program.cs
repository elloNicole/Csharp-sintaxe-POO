using System;
using System.Globalization;
namespace Exercicio4 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programa que lê o número de um funcionário, num de horas trabalhadas, o valor que recebe por hora e calcula o salário desse funcionário.

            int number = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salary = hours * valuePerHour;

            Console.WriteLine($"Number = {number}");
            Console.WriteLine($"Salary = U$ {salary.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}