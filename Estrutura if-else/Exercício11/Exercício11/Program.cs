using System;
using System.Globalization;

namespace Exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, n2;
            string[] valores = Console.ReadLine().Split(' ') ;

            n1  = double.Parse(valores[0], CultureInfo.InvariantCulture);
            n2 = double.Parse(valores[1], CultureInfo.InvariantCulture);

            if(n1>0 && n2>0)
            {
                Console.WriteLine("Q1");
            }else if(n1<0 && n2 > 0)
            {
                Console.WriteLine("Q2");
            } else if (n1<0 && n2 < 0)
            {
                Console.WriteLine("Q3");
            }
            else if (n1>0 && n2<0)
            {
                Console.WriteLine("Q4");
            }
            else
            {
                Console.WriteLine("Origem");
            }

        }
    }
}
