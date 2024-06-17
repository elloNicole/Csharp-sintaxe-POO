using System;
using System.Globalization;

namespace Exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario, imposto = 0;

            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario>0 && salario <= 2000 )
            {
                imposto = 0;

            }
            else if (salario <= 3000)
            {
                imposto = (salario - 2000) * 0.08;

            }
            else if (salario <= 4500)
            {
                imposto = (salario - 3000) * 0.18 + 1000 * 0.8;
            } else
            {
                imposto = (salario - 4500) * 0.28 + 1500 * 0.18 + 1000*0.08; //paga o valor que ultrapassou o 4500 mais os 4500 dividido para a taxa dos valores que formam 4500
            }

            Console.WriteLine($"R$ {imposto.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}