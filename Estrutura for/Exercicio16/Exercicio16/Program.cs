﻿using System;
/* Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o 
X, se for o caso. */
namespace Exercicio16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            num = int.Parse(Console.ReadLine());

            Console.WriteLine();

            if (num >= 0 && num <= 1000)
            {
                for (int i = 1; i <= num; i++)
                {
                    if (i % 2 == 1)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {
                Console.WriteLine("Esse número não está no intervalo de 1 a 1000");
            }
        }
    }
}