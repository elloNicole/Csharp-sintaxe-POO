using System;
/*Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando 
essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo)*/
namespace Exercicio17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int N=0, dentro=0, fora=0, numero;
            N = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i  = 0; i < N; i++)
            {
                numero = int.Parse(Console.ReadLine());

                if(numero >= 10 && numero <= 20)
                {
                    dentro++;
                }
                else
                {
                    fora++;
                }
            }

            Console.WriteLine($"{dentro} in");
            Console.WriteLine($"{fora} out");
        }
    }
}