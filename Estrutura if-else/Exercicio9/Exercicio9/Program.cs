using System;
using System.Globalization;

namespace Exercicio9 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int code, quantity;
            double value=0, total=0;

            string[] data = Console.ReadLine().Split(' ');

            code = int.Parse(data[0]);
            quantity = int.Parse(data[1]);

            if (code == 1)
            { 
                value = 4.00;

            } else if(code == 2)
            {
                value = 4.50; 

            } else if(code == 3)
            {
                value = 5.00;            

            } else if( code == 4)
            {
                value = 2.00;

            } else if(code == 5)
            {
                value = 1.50;
            }

            total = value * quantity;
            Console.WriteLine($"TOTAL: $ {total.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}