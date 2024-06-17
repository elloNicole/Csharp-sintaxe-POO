using System;
/*Ler um número inteiro N e calcular todos os seus divisores*/
namespace Exercicio21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double divisor;
            int N;

            N= int.Parse(Console.ReadLine());

            for(int i = 1; i <= N; i++) {

                divisor = (double)N % i;

            if(divisor== 0)
                {
                    Console.WriteLine(i);
                }
            
            }
        }
    }
}