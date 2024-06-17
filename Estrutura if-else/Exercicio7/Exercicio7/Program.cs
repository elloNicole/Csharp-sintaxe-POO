using System;

namespace Exercicio7 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int number1, number2, greater, less;

            string[] numbers = Console.ReadLine().Split(' ');
            number1 = int.Parse(numbers[0]);
            number2 = int.Parse(numbers[1]);

            if (number1 > number2)
            {
                greater = number1;
                less = number2;
            }
            else
            {
                greater = number2;
                less = number1;
            }

            if (greater % less == 0)
            {
                Console.WriteLine("São Múltiplos");
            }
            else
            {
                Console.WriteLine("Não são Múltiplos");
            }

        }
    }
}
