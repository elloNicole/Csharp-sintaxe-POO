using System;
using System.Collections.Generic;
using System.Globalization;
using ExercicioAbst.Entities;

namespace ExercicioAbst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int num = int.Parse(Console.ReadLine());

            for(int i = 1; i <= num; i++)
            {
                Console.Write($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualInc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                if (ch == 'i')
                {
                    Console.Write("Health expeditures: ");
                    double healthExpend = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Individual(name, anualInc, healthExpend));
                }
                else
                {
                    Console.Write("Health expeditures: ");
                    int numberEmp = int.Parse(Console.ReadLine());

                    list.Add(new Company(name, anualInc, numberEmp));
                }
            }
            Console.WriteLine();

            double sum = 0.0;
            Console.WriteLine("TAXES PAID:");
            foreach (TaxPayer payer in list)
            {
                double tax = payer.Tax();
                Console.WriteLine(payer.Name + ": $ " + payer.Tax().ToString("F2", CultureInfo.InvariantCulture));
                sum += tax;
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES : $ " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}