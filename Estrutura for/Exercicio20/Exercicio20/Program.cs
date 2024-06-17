using System;

namespace Exercicio20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int fatorial=1;
            int contador = N;

            for(int i = 0; i < N; i++)
            {
                if( contador > 0)
                {
                    fatorial = (fatorial * contador--);
                }
                else if (N==0)
                {
                    fatorial = 1;
                }
                else
                {
                    fatorial = 0;
                }
            }

            Console.WriteLine(fatorial);
        }
    }
}