using System;

namespace Exercicio8

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, hours;

            string[] numbers = Console.ReadLine().Split(' ');

            number1 = int.Parse(numbers[0]);
            number2 = int.Parse(numbers[1]);

            if (number1 > number2)
            {
                hours = (24 - number1) + number2;
            } else if (number1 < number2) 
            {
                hours = number2 - number1;
            } else //tambem é possivel deixar a condição do numero1 menor que numero2 por primeiro para fazer o calculo das 24h de duração
            {
                hours = 24;
            }

            Console.WriteLine($" O JOGO DUROU {hours} HORAS(S)");
        }
    }
}
