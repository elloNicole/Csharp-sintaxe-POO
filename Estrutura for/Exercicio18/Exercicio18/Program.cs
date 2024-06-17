using System;
using System.Globalization;

/*Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste 
de 3 valores reais, cada um deles com uma casa decimal. Apresente a média ponderada para cada um destes 
conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem 
peso 5*/
namespace Exercicio18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            double n1, n2, n3, media;
            string[] numeros;

            N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                numeros = Console.ReadLine().Split(' ');
                n1 = double.Parse(numeros[0], CultureInfo.InvariantCulture);
                n2= double.Parse(numeros[1], CultureInfo.InvariantCulture);
                n3= double.Parse(numeros[2], CultureInfo.InvariantCulture);

                media = (n1*2 + n2*3 + n3*5)/10;
                Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));

            }
        }
    }
}
