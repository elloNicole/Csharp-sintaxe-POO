
using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double value;

            value=double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (value>0 && value <= 25)
            {
                Console.WriteLine("Intervalo [0,25]");

            }
            else if (value>25 && value <= 50)
            {
                Console.WriteLine("Intervalo [25,50]");
            }
            else if(value>50 && value <= 75)
            {
                Console.WriteLine("Intervalo [50,75]");
            }
            else if (value>75 && value<=100)
            {
                Console.WriteLine("Intervalo [75,100]");
            }
            else
            {
                Console.WriteLine("Fora do Intervalo");
            }

        }
    }
}