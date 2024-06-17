using System;
using System.Globalization;
/*Fazer um programa para ler um número N. Depois leia N pares de números e mostre a divisão do primeiro pelo 
segundo. Se o denominador for igual a zero, mostrar a mensagem "divisao impossivel"*/
namespace Exercicio19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, n1, n2;
            string[] pares;
            double divisao;

            N = int.Parse(Console.ReadLine());

            for(int i = 0; i < N; i++)
            {
                pares = Console.ReadLine().Split(' ');

                n1 = int.Parse(pares[0]);
                n2 = int.Parse(pares[1]);

                divisao = (double)n1 / n2;

                if(n2 == 0) 
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    Console.WriteLine(divisao.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}