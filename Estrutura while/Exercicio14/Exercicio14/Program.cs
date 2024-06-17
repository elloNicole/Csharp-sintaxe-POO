using System;

/*Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema 
cartesiano. Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo 
menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma) */

namespace Exercicio14 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            string[] vet;

            vet = Console.ReadLine().Split(' ');
            x= int.Parse(vet[0]);
            y = int.Parse(vet[1]);

            while ( x!= 0 && y!= 0){
                if (x> 0 &&  y> 0)
                {
                    Console.WriteLine("primeiro");
                } else if (x< 0 && y > 0)
                {
                    Console.WriteLine("segundo");
                } else if (x< 0 && y < 0)
                {
                    Console.WriteLine("terceiro");
                } else
                {
                    Console.WriteLine("quarto");
                }

                vet = Console.ReadLine().Split(' ');
                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]);

            }

        }
    }
}